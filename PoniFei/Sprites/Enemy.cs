using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using PoniFei.Models;
using Microsoft.Xna.Framework.Input;
using PoniFei.Managers;

namespace PoniFei.Sprites
{
    public class Enemy : Hero
    {
        private float _timer;

        private KeyboardState _currentKey;

        private KeyboardState _previousKey;

        public Input Input { get; set; }

        public float ShootingTimer = 2f;

        public Enemy(Texture2D texture)
          : base(texture)
        {

        }

        public Enemy(Dictionary<string, Animation> animations) : base(animations)
        {
            Speed = 5f;
        }


        private bool _isOnGround = true;
        private bool _jumping = false;

        public virtual void Move()
        {
 
        }




        static public int qw2 = 0;
        protected virtual void SetAnimations()
        {

            if (XA == 2 && Position.Y >= 610)
            {
                _animationManager.Play(_animations["Shoot"]);
                qw2 = 3;
                Velocity.X = 0;
            }

            else if ((XA == 7 || XA == 4) && Position.Y >= 610)
            {
                _animationManager.Play(_animations["Blok"]);
                qw2 = 2;
                Velocity.X = 0;
            }


            else if (Velocity.X > 0 && Position.Y >= 610)
            {
                _animationManager.Play(_animations["WalkRight"]);
                qw2 = 22;
            }


            else if (Velocity.X < 0 && Position.Y >= 610)
            {
                _animationManager.Play(_animations["WalkLeft"]);
                qw2 = 22;
            }

            // else if (Velocity.Y > 0)
            //   _animationManager.Play(_animations["WalkDown"]);
            else if (Position.Y < 609 && Velocity.Y == -10f)
            {
                _animationManager.Play(_animations["Jumping"]);
                qw2 = 0;
            }


            else if (Position.Y >= 609 && Velocity.Y == 8f && qw2 == 0 || (XA == 4 && qw2 == 2) || (XA == 2 && qw2 == 3) || (qw2 == 22))
            {
                Velocity.Y = 0f;
                _animationManager.Play(_animations["JumpingEnd"]);
                qw2 = 0;
            }

            else if (XA == 5 && Position.Y >= 610)
            {
                qw2 = 1;
                timer1 = 0f;
                XA = -1;
            }

            else if (Position.Y >= 610 && qw2 == 1)
            {
                _animationManager.Play(_animations["Udar"]);

                if (timer1 >= timer2)
                {
                    _animationManager.Play(_animations["JumpingEnd"]);
                    qw2 = 0;
                }
            }

            else if (Health <= 0 && qw2 != 112)
            {
                _animationManager.Play(_animations["Dead"]);
                qw2 = 112;
            }

            else _animationManager.Stop();
        }
        private float timer1;
        private float timer2 = 0.85f;
        public static int XA;

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
                if (Velocity.X != 0)
            {
                Player.SoundSWa2 = 3;
            }
                timer1 += (float)gameTime.ElapsedGameTime.TotalSeconds;
            _timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_timer >= ShootingTimer)
            {
                Random rnd = new Random();
                XA = rnd.Next(0,7);


                if (XA == 0)//left0
                {
                    Velocity.X = -Speed;
                    _timer = 0f;
                }



                else if (XA == 1)//rrrr1
                {
                    Velocity.X = Speed;
                    _timer = 0f;
                }

                else if (XA == 2)//shot2
                {
                    Player.soundS = 1;
                    Shoot(-Speed * 5);
                    _timer = 1f;
                }

                else if(XA == 3)//jump3
                {
                    _timer = 0f;
                    XA = 1;
                    if (_isOnGround == true)
                    {
                        if (XA == 3)
                        {
                            Velocity.Y = -10f;
                            _jumping = true;
                            _isOnGround = true;
                        }
                    }
                    else if (_jumping == true)
                    {
                        Velocity.Y = 8f;
                    }
                    if (Position.Y <= 200)
                    {
                        _isOnGround = false;
                    }
                    if (Position.Y >= 610)
                    {
                        _jumping = false;
                        _isOnGround = true;
                    }

                    if (Position.Y < 610 && Position.Y > 200 && Velocity.Y == 0)
                    {
                        Velocity.Y = -10f;
                    }

                }

                else if (XA == 4)//blok4
                {
                    
                    _timer = 0f;
                }
                else if (XA == 7)//blok5
                {

                    _timer = 0f;
                }

                else if (XA == 5)//udar6
                {
                    Player.SoundSUdar = 1;
                    Velocity.X = 0;
                    Udar(-Speed * 2f);
                    _timer = 0.5f;
                }

            }


            if (Position.X >= 1650 && Velocity.X > 0)
            {
                Velocity = Vector2.Zero;
            }

            SetAnimations();

            _animationManager.Update(gameTime);

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if ((this.Velocity.X > 0 && this.IsTouchingLeft(sprite)) ||
                    (this.Velocity.X < 0 & this.IsTouchingRight(sprite)))
                    this.Velocity.X = 0;


            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player.qw == 1) || (this.IsTouchingRight(sprite) && Player.qw == 1)) && (Enemy.qw2 != 2))
                {

                    Player.pain = 1;
                }

            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player.qw == 3) || (this.IsTouchingRight(sprite) && Player.qw == 3)) && (Enemy.qw2 != 2))
                {
                    Player.pain = 1;
                }

            }




            if (IsDead2)
                return;

            _previousKey = _currentKey;
            _currentKey = Keyboard.GetState();

            var velocity = Vector2.Zero;
            _rotation = 0;


            Position += Velocity;


        }

        public bool IsDead2
        {
            get
            {
                return Health <= 0;
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (IsDead2)
                Player.pain = 4;

            base.Draw(gameTime, spriteBatch);
        }


        public override void OnCollide(Sprite sprite)
        {
            if (IsDead2)
                return;

            if (sprite is Bullet && ((Bullet)sprite).Parent is Player)
                Health--;

            if (sprite is Player)
                Health--;
        }
    }
}