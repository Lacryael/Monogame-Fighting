using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using PoniFei.Models;
using PoniFei.Sprites;
using PoniFei.States;
using PoniFei.Controls;
using PoniFei.Managers;
using Microsoft.Xna.Framework.Audio;


namespace PoniFei.Controls
{
    class Mana2 : Component
    {
        #region Fields

        public Vector2 Velocity;
        public float Speed;
        private Texture2D _texture;
        #endregion
        #region Properties

        public Vector2 Position { get; set; }

        public Color PenColour { get; set; }
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }
        #endregion

        #region Methods




        public Mana2(Texture2D texture)
        {
            _texture = texture;

            PenColour = Color.NavajoWhite;
            Speed = 2f;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var colour = Color.White;

            spriteBatch.Draw(_texture, Rectangle, colour);
        }


        private float timer1;
        public static int mana = 300;
        public static int manakd2;

        public override void Update(GameTime gameTime)
        {
            timer1 += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (mana < 300 && mana >= 0 && (Player2.qw != 999 && Player2.qw != 112 && Player2.qw != 721 && Player2.qw != 712))
            {
                Velocity.X = -1;
                mana++;
                manakd2 = 1;
            }

            if (mana == 300)
            {
                manakd2 = 0;
            }

            if (mana > 300 && (Player2.qw != 999 && Player2.qw != 112 && Player2.qw != 721 && Player2.qw != 712))
            {
                mana--;
            }

            if (mana < 0 && (Player2.qw != 999 && Player2.qw != 112 && Player2.qw != 721 && Player2.qw != 712))
            {
                mana = 0;
            }

            if ((Player2.qw == 999 || Player2.qw == 112 || Player2.qw == 721 || Player2.qw == 712) && mana > 3)
            {
                mana = mana - 2;
                Velocity.X = +2;
            }


            var velocity = Vector2.Zero;
            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        #endregion
    }
}