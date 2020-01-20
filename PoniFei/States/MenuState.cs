using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Controls;
using Microsoft.Xna.Framework.Audio;


namespace PoniFei.States
{
    public class MenuState : State
    {
        SoundEffect nya1S;
        SoundEffect nya2S;
        public int Nya;

        private List<Component> _components;
        public static int rejim;

        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {
            var BackgroundTexture = _content.Load<Texture2D>("Background/Background");
            var buttonTexture = _content.Load<Texture2D>("Controls/Button2q");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");

            var bg = new Background(BackgroundTexture)
            {
                Position = new Vector2(0, 0),
            };

            var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610,200),
                Text = "Один Игрок",
            };
            newGameButton.Click += NewGameButton_Click;

            var newSurvButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610, 350),
                Text = "Игрок против Игрока",
            };

            newSurvButton.Click += NewSurvButton_Click;


            var recordGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610,500),
                Text = "Управление",
            };

            recordGameButton.Click += RecordGameButton_Click;

            var quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610,650),
                Text = "Выход",
            };

            quitGameButton.Click += QuitGameButton_Click;

            _components = new List<Component>()
      {
                bg,
        newGameButton,
        newSurvButton,
        recordGameButton,
        quitGameButton,
      };
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

        private void RecordGameButton_Click(object sender, EventArgs e)
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

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new HeroState(_game, _graphicsDevice, _content));
            rejim = 1;

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

        private void NewSurvButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new HeroState(_game, _graphicsDevice, _content));
            rejim = 2;

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

        public override void PostUpdate(GameTime gameTime)
        {
            // remove sprites if they're not needed
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }
    }
}