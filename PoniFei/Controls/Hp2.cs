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
    class Hp2 : Component
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




        public Hp2(Texture2D texture)
        {
            _texture = texture;

            PenColour = Color.NavajoWhite;
            Speed = 4f;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var colour = Color.White;

            spriteBatch.Draw(_texture, Rectangle, colour);
        }


        private float timer1;
        public int hpp1 = 100;
        public int hpp12;
        public int hpp123;

        int rezi2 = 0;
        int rezi3 = 0;
        public override void Update(GameTime gameTime)
        {
            if (Player.pain == 2)
            {
                rezi3++;
                if (rezi3 == 2)
                {
                    rezi3 = 0;
                    hpp1--; 
                }
            }

            if (Player.pain == 2 && (hpp1 < 60 && hpp1 >= 30))
            {
                rezi2++;
                if (rezi2 == 2)
                {
                    rezi2 = 0;
                    Velocity.X = -Speed;
                }

            }

            if (Player.pain == 2 && hpp1 < 30|| Player.qw == 6666)
            {
                Velocity.X = -1000f;
            }


            var velocity = Vector2.Zero;
            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        #endregion
    }
}