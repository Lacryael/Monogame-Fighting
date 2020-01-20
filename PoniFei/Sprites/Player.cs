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
    public class Player : Hero
    {

        private KeyboardState _currentKey;

        private KeyboardState _previousKey;

        private float _shootTimer = 0;

        private float _shootTimer2 = 0;

        public bool IsDead
        {
            get
            {
                return Health <= 0;
            }
        }

        public Input Input { get; set; }

       // public Score Score { get; set; }

        public Player(Texture2D texture)
          : base(texture)
        {
            
        }

        public Player(Dictionary<string, Animation> animations) : base(animations)
        {
            Speed = 5f;
        }



        public static int pain;
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


                if (((this.IsTouchingLeft(sprite) && Enemy.qw2 == 1) || (this.IsTouchingRight(sprite) && Enemy.qw2 == 1)) && ((Player.qw != 2) && (Player.qw != 9) && (Player.qw != 999) && (Player.qw != 721) && (Player.qw != 112)) )
                {

                    Bullet.AddExplosion();
                    pain = 2;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Enemy.qw2 == 3) || (this.IsTouchingRight(sprite) && Enemy.qw2 == 3)) && ((Player.qw != 1) && (Player.qw != 2) && (Player.qw != 9) && (Player.qw != 999) && (Player.qw != 712) && (Player.qw != 112)) )
                {

                    Bullet.AddExplosion();
                    pain = 2;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Enemy.qw2 == 1) || (this.IsTouchingRight(sprite) && Enemy.qw2 == 1)) && Player.qw == 721)
                {

                    Player.pain = 1;
                }

            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Enemy.qw2 == 3) || (this.IsTouchingRight(sprite) && Enemy.qw2 == 3)) && Player.qw == 712)
                {

                    Player.pain = 1;
                }

            }









            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////22222222



            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;


                if (((this.IsTouchingLeft(sprite) && Player2.qw == 1) || (this.IsTouchingRight(sprite) && Player2.qw == 1)) && ((Player.qw != 2) && (Player.qw != 9) && (Player.qw != 999) && (Player.qw != 721) && (Player.qw != 112)))
                {

                    Bullet.AddExplosion();
                    Player.pain = 2;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player2.qw == 3) || (this.IsTouchingRight(sprite) && Player2.qw == 3)) && ((Player.qw != 1) && (Player.qw != 2) && (Player.qw != 9) && (Player.qw != 999) && (Player.qw != 712) && (Player.qw != 112)))
                {

                    Bullet.AddExplosion();
                    Player.pain = 2;
                }
            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player2.qw == 1) || (this.IsTouchingRight(sprite) && Player2.qw == 1)) && Player.qw == 721)
                {

                    Player.pain = 1;
                }

            }

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (((this.IsTouchingLeft(sprite) && Player2.qw == 3) || (this.IsTouchingRight(sprite) && Player2.qw == 3)) && Player.qw == 712)
                {

                    Player.pain = 1;
                }

            }









            if (IsDead)
                return;

            _previousKey = _currentKey;
            _currentKey = Keyboard.GetState();

            var velocity = Vector2.Zero;
            _rotation = 0;



            _shootTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_currentKey.IsKeyDown(Input.Shoot) && _shootTimer > 1f && Position.Y >= 610) //safdsafrwqarfdwerfyyyyyyyyyyyyy
            {
                soundS = 1;
                Reload = 1;
                Shoot(Speed * 5);
                _shootTimer = -5f;
                qw = 0;
            }

            _shootTimer2 += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (_currentKey.IsKeyDown(Input.Udar) && _shootTimer2 > 1f && Position.Y >= 610) //udarudaurudauruudaur
            {
                SoundSUdar = 1;
                Udar(Speed * 0.6f);
                _shootTimer2 = 0f;
                qw = 0;
            }

            Position += Velocity;
            Velocity = Vector2.Zero;

        }

        public static int soundS = 0;

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

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && HeroState.player1 == 1 && Mana1.mana > 3 && Mana1.manakd == 0)
                Velocity.X = Speed*5;

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && HeroState.player1 == 2 && Mana1.mana > 3 && Mana1.manakd == 0)
                Velocity.X = -100;


            if (Position.X <= -30 && (Keyboard.GetState().IsKeyDown(Input.Left) || Keyboard.GetState().IsKeyDown(Input.ULTA)))
            {
                Velocity.X = 0;
            }

            if (Position.X >= 1650 && (Keyboard.GetState().IsKeyDown(Input.Right) || Keyboard.GetState().IsKeyDown(Input.ULTA)))
            {
                Velocity.X = 0;
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
        public static int soundS2 = 0;

        protected virtual void SetAnimations()
        {

            if (Velocity.X < -10)
            {
                SoundSWa = 1112;
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

            
            else if (Velocity.X > 0 && Position.Y >= 610 && Velocity.X < 10)
            {
                _animationManager.Play(_animations["WalkRight"]);
                qw = 22;
                SoundSWa = 3;
            }


            else if (Velocity.X < 0 && Position.Y >= 610)
            {
                _animationManager.Play(_animations["WalkLeft"]);
                qw = 22;
                SoundSWa = 3;
            }

            else if (Velocity.X > 10 && HeroState.player1 == 1)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 999;
                SoundSWa = 313;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && HeroState.player1 == 4 && Mana1.mana > 3 && Mana1.manakd == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 721;
                SoundSWa = 721;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && HeroState.player1 == 3 && Mana1.mana > 3 && Mana1.manakd == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 712;
                SoundSWa = 712;
            }

            else if (Keyboard.GetState().IsKeyDown(Input.ULTA) && HeroState.player1 == 2 && Mana1.mana > 3 && Mana1.manakd == 0)
            {
                _animationManager.Play(_animations["ULTA"]);
                qw = 112;
                SoundSWa = 112;
            }

            // else if (Velocity.Y > 0)
            //   _animationManager.Play(_animations["WalkDown"]);
            else if (Position.Y < 609 && Velocity.Y == -10f)
            {
                _animationManager.Play(_animations["Jumping"]);
                qw = 9;
            }


            else if ((Position.Y >= 609 && Velocity.Y == 8f && qw == 9 )|| (Keyboard.GetState().IsKeyUp(Input.Blok) && qw == 2) || (qw == 22) || (qw == 999) || (qw == 721) || (qw == 112) || (qw == 712))
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
                soundS = 2;
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


        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (IsDead)
                pain = 3;

            base.Draw(gameTime, spriteBatch);
        }

        public override void OnCollide(Sprite sprite)
        {
            if (IsDead)
                return;

            if (sprite is Bullet && ((Bullet)sprite).Parent is Enemy)
                Health--;

            if (sprite is Enemy)
                Health--;
        }


    }
}