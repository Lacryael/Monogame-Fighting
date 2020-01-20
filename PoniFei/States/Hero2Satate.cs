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
    public class Hero2State : State
    {
        public static int player2;
        private List<Component> _components;
        private List<Component> _components2;
        SoundEffect nya1S;
        SoundEffect nya2S;
        public int Nya;





        public Hero2State(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {
            var PayButtonTexture = _content.Load<Texture2D>("Controls/Button3q");
            var BackgroundTexture = _content.Load<Texture2D>("Background/Background2");
            var buttonTexture2 = _content.Load<Texture2D>("Controls/BackButton1");
            var buttonFont2 = _content.Load<SpriteFont>("Fonts/Font2");
            var buttonFont1 = _content.Load<SpriteFont>("Fonts/Font");
            var buttonTexture3 = _content.Load<Texture2D>("Controls/PinkiRam2");
            var buttonTexture4 = _content.Load<Texture2D>("Controls/RainbowRam");

            var bg = new Background(BackgroundTexture)
            {
                Position = new Vector2(0, 0),
            };

            var pausee = _content.Load<Texture2D>("Controls/Ploti");
            var pause = new Background(pausee)
            {
                Position = new Vector2(480, 100),
            };

            var PayButton = new Button(PayButtonTexture, buttonFont1)
            {
                Position = new Vector2(750, 666),
                Text = "Ок",
            };

            _components2 = new List<Component>()
      {
                pause,
                PayButton,
      };

            PayButton.Click += PayButton_Click;

            var backButton = new Button(buttonTexture2, buttonFont2)
            {
                Position = new Vector2(50, 1000),
                Text = "",
            };

            backButton.Click += BackButton_Click;

            var rainbowButton = new Button(buttonTexture4, buttonFont2)
            {
                Position = new Vector2(400, 250),
                Text = "",
            };

            rainbowButton.Click += RainbowButton_Click;


            var pinkiButton = new Button(buttonTexture3, buttonFont2)
            {
                Position = new Vector2(650, 250),
                Text = "",
            };

            pinkiButton.Click += PinkiButton_Click;


            var buttonTexture5 = _content.Load<Texture2D>("Controls/AppleRam");
            var appleButton = new Button(buttonTexture5, buttonFont2)
            {
                Position = new Vector2(400, 500),
                Text = "",
            };

            appleButton.Click += AppleButton_Click;


            var buttonTexture6 = _content.Load<Texture2D>("Controls/RarRam2");
            var rarButton = new Button(buttonTexture6, buttonFont2)
            {
                Position = new Vector2(650, 500),
                Text = "",
            };

            rarButton.Click += RarButton_Click;


            var buttonTexture7 = _content.Load<Texture2D>("Controls/FloRam");
            var floButton = new Button(buttonTexture7, buttonFont2)
            {
                Position = new Vector2(650, 750),
                Text = "",
            };

            floButton.Click += FloButton_Click;


            var buttonTexture8 = _content.Load<Texture2D>("Controls/IskRam");
            var iskButton = new Button(buttonTexture8, buttonFont2)
            {
                Position = new Vector2(400, 750),
                Text = "",
            };
            iskButton.Click += FloButton_Click;



            var buttonTexture9 = _content.Load<Texture2D>("Controls/BlumRam");
            var blumButton = new Button(buttonTexture9, buttonFont2)
            {
                Position = new Vector2(1100, 250),
                Text = "",
            };
            blumButton.Click += FloButton_Click;


            var buttonTexture10 = _content.Load<Texture2D>("Controls/StlRam");
            var stlButton = new Button(buttonTexture10, buttonFont2)
            {
                Position = new Vector2(1350, 250),
                Text = "",
            };
            stlButton.Click += FloButton_Click;


            var buttonTexture11 = _content.Load<Texture2D>("Controls/MuzRam");
            var muzButton = new Button(buttonTexture11, buttonFont2)
            {
                Position = new Vector2(1100, 500),
                Text = "",
            };
            muzButton.Click += FloButton_Click;


            var buttonTexture12 = _content.Load<Texture2D>("Controls/TekRam");
            var tekButton = new Button(buttonTexture12, buttonFont2)
            {
                Position = new Vector2(1350, 500),
                Text = "",
            };
            tekButton.Click += FloButton_Click;


            var buttonTexture13 = _content.Load<Texture2D>("Controls/FloraRam");
            var floraButton = new Button(buttonTexture13, buttonFont2)
            {
                Position = new Vector2(1100, 750),
                Text = "",
            };
            floraButton.Click += FloButton_Click;


            var buttonTexture14 = _content.Load<Texture2D>("Controls/LelRam");
            var lelButton = new Button(buttonTexture14, buttonFont2)
            {
                Position = new Vector2(1350, 750),
                Text = "",
            };
            lelButton.Click += FloButton_Click;



            _components = new List<Component>()
      {
                bg,
        backButton,
        pinkiButton,
        rainbowButton,
        appleButton,
        rarButton,
        floButton,
        iskButton,
        blumButton,
        stlButton,
        muzButton,
        tekButton,
        floraButton,
        lelButton,

      };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new HeroState(_game, _graphicsDevice, _content));


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

        private void RainbowButton_Click(object sender, EventArgs e)
        {
            player2 = 1;
            _game.ChangeState(new MapState(_game, _graphicsDevice, _content));

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

        private void PinkiButton_Click(object sender, EventArgs e)
        {
            player2 = 2;
            _game.ChangeState(new MapState(_game, _graphicsDevice, _content));

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

        private void AppleButton_Click(object sender, EventArgs e)
        {
            player2 = 3;
            _game.ChangeState(new MapState(_game, _graphicsDevice, _content));

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

        private void RarButton_Click(object sender, EventArgs e)
        {
            player2 = 4;
            _game.ChangeState(new MapState(_game, _graphicsDevice, _content));

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

        public int pay = 0;
        private void FloButton_Click(object sender, EventArgs e)
        {
            pay = 1;
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

        private void PayButton_Click(object sender, EventArgs e)
        {
            pay = 0;
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

            if (pay == 1)
            {
                pay = 1;
                spriteBatch.Begin();

                foreach (var component in _components2)
                    component.Draw(gameTime, spriteBatch);

                spriteBatch.End();
            }
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);

            if (pay == 1)
            {
                _game.IsMouseVisible = true;
                foreach (var component in _components2)
                    component.Update(gameTime);
            }
        }
    }
}