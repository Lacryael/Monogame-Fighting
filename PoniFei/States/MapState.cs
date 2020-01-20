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
    public class MapState : State
    {
        public static int map;
        private List<Component> _components;

        SoundEffect nya1S;
        SoundEffect nya2S;
        public int Nya;




        public MapState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
              : base(game, graphicsDevice, content)
        {
            var BackgroundTexture = _content.Load<Texture2D>("Background/Background3");
            var buttonTexture2 = _content.Load<Texture2D>("Controls/BackButton1");
            var buttonFont2 = _content.Load<SpriteFont>("Fonts/Font2");
            var buttonFont1 = _content.Load<SpriteFont>("Fonts/Font");
            var buttonTexture3 = _content.Load<Texture2D>("Controls/RamTree");
            var buttonTexture4 = _content.Load<Texture2D>("Controls/ForestRam");
            var buttonTexture5 = _content.Load<Texture2D>("Controls/RamCity");
            var buttonTexture6 = _content.Load<Texture2D>("Controls/RamTrain");
            var buttonTexture7 = _content.Load<Texture2D>("Controls/RamCrip");
            var buttonTexture8 = _content.Load<Texture2D>("Controls/RamRoom");
            var buttonTexture9 = _content.Load<Texture2D>("Controls/RamNight");
            var buttonTexture10 = _content.Load<Texture2D>("Controls/RamDesert");
            var buttonTexture11 = _content.Load<Texture2D>("Controls/RamNCity");
            var buttonTexture12 = _content.Load<Texture2D>("Controls/RamSnow");
            var buttonTexture13 = _content.Load<Texture2D>("Controls/RamWinter");
            var buttonTexture14 = _content.Load<Texture2D>("Controls/RamPark");
            var buttonTexture15 = _content.Load<Texture2D>("Controls/RamOffice");
            var buttonTexture16 = _content.Load<Texture2D>("Controls/RamVilage");
            var buttonTexture17 = _content.Load<Texture2D>("Controls/RamPlanet");
            var buttonTexture18 = _content.Load<Texture2D>("Controls/RamChina");
            var buttonTexture19 = _content.Load<Texture2D>("Controls/FortRam");
            var buttonTexture20 = _content.Load<Texture2D>("Controls/RamGiga");

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

            var pinkiButton = new Button(buttonTexture3, buttonFont2)
            {
                Position = new Vector2(300, 200),
                Text = "",
            };

            pinkiButton.Click += PinkiButton_Click;

            var rainbowButton = new Button(buttonTexture4, buttonFont2)
            {
                Position = new Vector2(535, 200),
                Text = "",
            };

            rainbowButton.Click += RainbowButton_Click;

            var map3 = new Button(buttonTexture5, buttonFont2)
            {
                Position = new Vector2(770, 200),
                Text = "",
            };

            map3.Click += Map3_Click;


            var map4 = new Button(buttonTexture6, buttonFont2)
            {
                Position = new Vector2(1005, 200),
                Text = "",
            };

            map4.Click += Map4_Click;

            var map5 = new Button(buttonTexture7, buttonFont2)
            {
                Position = new Vector2(1240, 200),
                Text = "",
            };

            map5.Click += Map5_Click;


            var map6 = new Button(buttonTexture8, buttonFont2)
            {
                Position = new Vector2(1475, 200),
                Text = "",
            };

            map6.Click += Map6_Click;

            var map7 = new Button(buttonTexture9, buttonFont2)
            {
                Position = new Vector2(300, 450),
                Text = "",
            };

            map7.Click += Map7_Click;

            var map8 = new Button(buttonTexture10, buttonFont2)
            {
                Position = new Vector2(535, 450),
                Text = "",
            };

            map8.Click += Map8_Click;


            var map9 = new Button(buttonTexture11, buttonFont2)
            {
                Position = new Vector2(770, 450),
                Text = "",
            };

            map9.Click += Map9_Click;

            var map10 = new Button(buttonTexture12, buttonFont2)
            {
                Position = new Vector2(1005, 450),
                Text = "",
            };

            map10.Click += Map10_Click;

            var map11 = new Button(buttonTexture13, buttonFont2)
            {
                Position = new Vector2(1240, 450),
                Text = "",
            };

            map11.Click += Map11_Click;

            var map12 = new Button(buttonTexture14, buttonFont2)
            {
                Position = new Vector2(1475, 450),
                Text = "",
            };

            map12.Click += Map12_Click;

            var map13 = new Button(buttonTexture15, buttonFont2)
            {
                Position = new Vector2(300, 700),
                Text = "",
            };

            map13.Click += Map13_Click;

            var map14 = new Button(buttonTexture16, buttonFont2)
            {
                Position = new Vector2(535, 700),
                Text = "",
            };

            map14.Click += Map14_Click;

            var map15 = new Button(buttonTexture17, buttonFont2)
            {
                Position = new Vector2(770, 700),
                Text = "",
            };

            map15.Click += Map15_Click;

            var map16 = new Button(buttonTexture18, buttonFont2)
            {
                Position = new Vector2(1005, 700),
                Text = "",
            };

            map16.Click += Map16_Click;

            var map17 = new Button(buttonTexture19, buttonFont2)
            {
                Position = new Vector2(1240, 700),
                Text = "",
            };

            map17.Click += Map17_Click;

            var map18 = new Button(buttonTexture20, buttonFont2)
            {
                Position = new Vector2(1475, 700),
                Text = "",
            };

            map18.Click += Map18_Click;

            _components = new List<Component>()
      {
                bg,
        backButton,
        pinkiButton,
        rainbowButton,
        map3,
        map4,
        map5,
        map6,
        map7,
        map8,
        map9,
        map10,
        map11,
        map12,
        map13,
        map14,
        map15,
        map16,
        map17,
        map18,


      };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new Hero2State(_game, _graphicsDevice, _content));


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
            map = 2;


            if(MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

            map = 1;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map3_Click(object sender, EventArgs e)
        {

            map = 3;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map4_Click(object sender, EventArgs e)
        {

            map = 4;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map5_Click(object sender, EventArgs e)
        {

            map = 5;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map6_Click(object sender, EventArgs e)
        {

            map = 6;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map7_Click(object sender, EventArgs e)
        {

            map = 7;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map8_Click(object sender, EventArgs e)
        {

            map = 8;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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

        private void Map9_Click(object sender, EventArgs e)
        {

            map = 9;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map10_Click(object sender, EventArgs e)
        {

            map = 10;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map11_Click(object sender, EventArgs e)
        {

            map = 11;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map12_Click(object sender, EventArgs e)
        {

            map = 12;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map13_Click(object sender, EventArgs e)
        {

            map = 13;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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



        private void Map14_Click(object sender, EventArgs e)
        {

            map = 14;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map15_Click(object sender, EventArgs e)
        {

            map = 15;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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



        private void Map16_Click(object sender, EventArgs e)
        {

            map = 16;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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


        private void Map17_Click(object sender, EventArgs e)
        {

            map = 17;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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



        private void Map18_Click(object sender, EventArgs e)
        {

            map = 18;
            if (MenuState.rejim == 1)
            {
                _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            }

            if (MenuState.rejim == 2)
            {
                _game.ChangeState(new PvpState(_game, _graphicsDevice, _content));
            }

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