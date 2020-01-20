using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Models;
using Microsoft.Xna.Framework.Input;
using PoniFei.Managers;
using Microsoft.Xna.Framework.Audio;
using PoniFei.States;
using Microsoft.Xna.Framework.Content;
using PoniFei.Sprites;
using PoniFei.Controls;



namespace PoniFei.Sprites
{
    public class Player2 : Hero
    {

        private KeyboardState _currentKey;

        private KeyboardState _previousKey;

        private float _shootTimer = 0;

        private float _shootTimer2 = 0;


        public Input Input { get; set; }

        // public Score Score { get; set; }

        public Player2(Texture2D texture)
          : base(texture)
        {

        }

        public Player2(Dictionary<string, Animation> animations) : base(animations)
        {
            Speed = 5f;
        }



        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            timer1 += (float)gameTime.ElapsedGameTime.TotalSeconds;

            Move();

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


                if (((this.IsTouchingLeft(sprite) && Player.qw == 1) || (this.IsTouchingRight(sprite) && Player.qw == 1)) && ((Player2.qw != 2) && (Player2.qw != 9) && (Player2.qw != 999) && (Player2.qw != 721) && (Player2.qw != 112)))
                {

                    Bullet.AddExplosion();
                    Player.pain = 1;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player.qw == 3) || (this.IsTouchingRight(sprite) && Player.qw == 3)) && ((Player2.qw != 1) && (Player2.qw != 2) && (Player2.qw != 9) && (Player2.qw != 999) && (Player2.qw != 712) && (Player2.qw != 112)))
                {

                    Bullet.AddExplosion();
                    Player.pain = 1;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player.qw == 1) || (this.IsTouchingRight(sprite) && Player.qw == 1)) && Player2.qw == 721)
                {

                    Player.pain = 2;
                }

            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player.qw == 3) || (this.IsTouchingRight(sprite) && Player.qw == 3)) && Player2.qw == 712)
                {

                    Player.pain = 2;
                }

            }




            if (IsDead2)
                return;

            _previousKey = _currentKey;
            _currentKey = Keyboard.GetState();

            var velocity = Vector2.Zero;
            _rotation = 0;



            _shootTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_currentKey.IsKeyDown(Input.Shoot) && _shootTimer > 1f && Position.Y >= 610) //safdsafrwqarfdwerfyyyyyyyyyyyyy
            {
                Player.soundS = 1;
                Player2.Reload = 1;
                Shoot(-Speed * 5);
                _shootTimer = -5f;
                qw = 0;
            }

            _shootTimer2 += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (_currentKey.IsKeyDown(Input.Udar) && _shootTimer2 > 1f && Position.Y >= 610) //udarudaurudauruudaur
            {
                Player.SoundSUdar = 1;
                Udar(-Speed * 4f);
                _shootTimer2 = 0f;
                qw = 0;
            }

            Position += Velocity;
            Velocity = Vector2.Zero;

        }

        public static int Reload = 0;

        private bool _isOnGround = true;
        private bool _jumping = false;

        public virtual void Move()
        {
            //  else if (Keyboard.GetState().IsKeyDown(Input.Down))
            //   Velocity.Y = Speed;
            if (_isOnGround == true)
            {
                if (Keyboard.GetState().IsKeyDown(Input.Up))
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

            if (Keyboard.GetState().IsKeyDown(Input.Left)) ////////////////////MV
                Velocity.X = -Speed;

            else if (Keyboard.GetState().IsKeyDown(Input.Right))
                Velocity.X = Speed;

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && Hero2State.player2 == 1 && Mana2.mana > 3 && Mana2.manakd2 == 0)
                Velocity.X = -Speed * 5;

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && Hero2State.player2 == 2 && Mana2.mana > 3 && Mana2.manakd2 == 0)
                Velocity.X = +100;


            if (Position.X >= 1650 && Velocity.X > 0)
            {
                Velocity = Vector2.Zero;
            }



        }


        private float timer1;
        private float timer2 = 0.85f;
        private float timer3 = 3.6f;
        public static int qw = 0;
        public static int SoundSWa2 = 0;
        public static int SoundSWa = 0;
        public static int SoundSUdar = 0;
        public static int SoundSUdar2 = 0;

        protected virtual void SetAnimations()
        {

            if (Velocity.X < +10)
            {
                Player.SoundSWa = 1112;
            }

            if (Keyboard.GetState().IsKeyDown(Input.Shoot) && Position.Y >= 610)
            {
                qw = 3;
                timer1 = 0f;
            }


            if (Position.Y >= 610 && qw == 3)
            {
                _animationManager.Play(_animations["Shoot"]);
                qw = 3;
                Velocity.X = 0;
                if (timer1 >= timer2)
                {
                    _animationManager.Play(_animations["JumpingEnd"]);
                    qw = 0;
                }
            }

            if (Position.Y >= 610 && qw == 1)
            {
                _animationManager.Play(_animations["Udar"]);

                if (timer1 >= timer2)
                {
                    _animationManager.Play(_animations["JumpingEnd"]);
                    qw = 0;
                }
            }

            else if (Keyboard.GetState().IsKeyDown(Input.Blok) && Position.Y >= 610)
            {
                _animationManager.Play(_animations["Blok"]);
                qw = 2;
                Velocity.X = 0;

            }


            else if (Velocity.X < 0 && Position.Y >= 610 && Velocity.X > -10)
            {
                _animationManager.Play(_animations["WalkLeft"]);
                qw = 22;
                Player.SoundSWa = 3;
            }


            else if (Velocity.X > 0 && Position.Y >= 610)
            {
                _animationManager.Play(_animations["WalkRight"]);
                qw = 22;
                Player.SoundSWa = 3;
            }

            else if (Velocity.X < -10 && Hero2State.player2 == 1)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 999;
                Player.SoundSWa = 313;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && Hero2State.player2 == 4 && Mana2.mana > 3 && Mana2.manakd2 == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 721;
                Player.SoundSWa = 721;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && Hero2State.player2 == 3 && Mana2.mana > 3 && Mana2.manakd2 == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 712;
                Player.SoundSWa = 712;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && Hero2State.player2 == 2 && Mana2.mana > 3 && Mana2.manakd2 == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 112;
                Player.SoundSWa = 112;
            }

            // else if (Velocity.Y > 0)
            //   _animationManager.Play(_animations["WalkDown"]);
            else if (Position.Y < 609 && Velocity.Y == -10f)
            {
                _animationManager.Play(_animations["Jumping"]);
                qw = 9;
            }


            else if ((Position.Y >= 609 && Velocity.Y == 8f && qw == 9) || (Keyboard.GetState().IsKeyUp(Input.Blok) && qw == 2) || (qw == 22) || (qw == 999) || (qw == 721) || (qw == 112) || (qw == 712))
            {
                Velocity.Y = 0f;
                _animationManager.Play(_animations["JumpingEnd"]);
                qw = 0;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.Udar) && Position.Y >= 610)
            {
                qw = 1;
                timer1 = 0f;
            }



            else if (Keyboard.GetState().IsKeyDown(Input.Suicide) && Position.Y >= 610)
            {
                Player.soundS2 = 2;
                qw = 666;
                timer1 = 0f;
            }

            else if (Position.Y >= 610 && qw == 666)
            {
                _animationManager.Play(_animations["Suicide"]);
                qw = 666;
                Velocity.X = 0;
                if (timer1 >= timer3)
                {
                    _animationManager.Play(_animations["Dead"]);
                    qw = 6666;
                    Health = 0;
                }
            }

            else if (Health <= 0 && qw != 112)
            {
                _animationManager.Play(_animations["Dead"]);
                qw = 112;
            }

            else _animationManager.Stop();
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