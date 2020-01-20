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
    class HpBack : Component
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




        public HpBack(Texture2D texture)
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


       
        public override void Update(GameTime gameTime)
        {

            
        }

        #endregion
    }
}