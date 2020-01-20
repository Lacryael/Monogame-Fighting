using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PoniFei.Controls;
using PoniFei.States;
using PoniFei.Models;
using PoniFei.Sprites;
using Microsoft.Xna.Framework.Audio;



namespace PoniFei.States
{
    public class StartState : State
    {
        SoundEffect daze;
        private List<Component> _components;
        SoundEffect nya1S;
        SoundEffect nya2S;
        public StartState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {





            var buttonTexture = _content.Load<Texture2D>("Controls/Button3q");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font2");
            var back = _content.Load<Texture2D>("StartState/TestBack");

            var bg = new Background(back)
            {
                Position = new Vector2(0, 0),
            };

            var startGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(755, 900),
                Text = "Начать игру",
            };

            startGameButton.Click += StartGameButton_Click;



            _components = new List<Component>()
      {
                        bg,
        startGameButton,
      };

        }

        public override void LoadContent()
        {
            // _backgroundTexture = _content.Load<Texture2D>("StartState/TestBack");
            nya1S = _content.Load<SoundEffect>("Audio/nya1");
            nya2S = _content.Load<SoundEffect>("Audio/nya2");
            daze = _content.Load<SoundEffect>("Audio/daze");
        }




        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
         //   spriteBatch.Draw(_backgroundTexture, new Vector2(0, 0), Color.White);
            spriteBatch.End();

            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();


        }

        public int Nya;

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));

            Random rnd = new Random();
            Nya = rnd.Next(0, 2);
            if (Nya == 0)
            {
                SoundEffectInstance soundEffectInstance = nya1S.CreateInstance();
                SoundEffect.MasterVolume = 0.5f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
            }
            if(Nya == 1)
            {
                SoundEffectInstance soundEffectInstance = nya2S.CreateInstance();
                SoundEffect.MasterVolume = 0.5f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
            }

        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        private float DazeT = 0;

        public override void Update(GameTime gameTime)
        {
            DazeT += (float)gameTime.ElapsedGameTime.TotalSeconds;
            foreach (var component in _components)
                component.Update(gameTime);


            if(DazeT < 0.01f)
            {
                SoundEffectInstance soundEffectInstance = daze.CreateInstance();
                SoundEffect.MasterVolume = 1f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
            }

        }
    }
}