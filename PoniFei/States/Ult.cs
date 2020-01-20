using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Controls;
using PoniFei.States;
using Microsoft.Xna.Framework.Audio;

namespace PoniFei.States
{
    public class Ult : State
    {
        public static int player2;
        private List<Component> _components;

        SoundEffect nya1S;
        SoundEffect nya2S;
        public int Nya;




        public Ult(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
              : base(game, graphicsDevice, content)
        {
            var BackgroundTexture = _content.Load<Texture2D>("Background/BackgroundULT");
            var buttonTexture2 = _content.Load<Texture2D>("Controls/BackButton1");
            var buttonTexture6 = _content.Load<Texture2D>("Controls/Button2q");
            var buttonFont2 = _content.Load<SpriteFont>("Fonts/Font2");
            var buttonFont1 = _content.Load<SpriteFont>("Fonts/Font");


            var bg = new Background(BackgroundTexture)
            {
                Position = new Vector2(0, 0),
            };

            var backButton = new Button(buttonTexture2, buttonFont2)
            {
                Position = new Vector2(50, 1000),
                Text = "",
            };

            backButton.Click += BackButton_Click;






            _components = new List<Component>()
      {
                bg,
        backButton,

      };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new UpravState(_game, _graphicsDevice, _content));

            Random rnd = new Random();
            Nya = rnd.Next(0, 2);
            if (Nya == 0)
            {
                SoundEffectInstance soundEffectInstance = nya1S.CreateInstance();
                SoundEffect.MasterVolume = 0.5f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
            }
            if (Nya == 1)
            {
                SoundEffectInstance soundEffectInstance = nya2S.CreateInstance();
                SoundEffect.MasterVolume = 0.5f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
            }
        }

     





        public override void LoadContent()
        {
            nya1S = _content.Load<SoundEffect>("Audio/nya1");
            nya2S = _content.Load<SoundEffect>("Audio/nya2");
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
    }
}