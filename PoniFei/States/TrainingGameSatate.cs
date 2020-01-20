using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Models;
using PoniFei.Sprites;
using Microsoft.Xna.Framework.Input;
using PoniFei.States;
using PoniFei.Controls;
using PoniFei.Managers;
using Microsoft.Xna.Framework.Audio;


namespace PoniFei.States
{
    public class TraningGameState : State
    {
        private EnemyManager _enemyManager;

        private SpriteFont _font;

        private List<Player> _players;

        private List<Enemy> _enemys;

        // private ScoreManager _scoreManager;

        public int PlayerCount;

        private List<Sprite> _sprites;

        private List<Component> _components;

        private List<Component> _components2;

        private List<Component> _components3;

        private List<Component> _components4;

        private List<Component> _components5;



        public TraningGameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {
            _content.RootDirectory = "Content";

 
            var BackgroundTexture = _content.Load<Texture2D>("Background/MapTree");
            var bg = new Background(BackgroundTexture)
            {
                Position = new Vector2(0, 0),
            };


            var BackgroundTexture2 = _content.Load<Texture2D>("Background/MapForest");
            var bg2 = new Background(BackgroundTexture2)
            {
                Position = new Vector2(0, 0),
            };


            var BackgroundTexture3 = _content.Load<Texture2D>("Background/MapCity");
            var bg3 = new Background(BackgroundTexture3)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture4 = _content.Load<Texture2D>("Background/MapTrain");
            var bg4 = new Background(BackgroundTexture4)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture5 = _content.Load<Texture2D>("Background/MapCrip");
            var bg5 = new Background(BackgroundTexture5)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture6 = _content.Load<Texture2D>("Background/MapRoom");
            var bg6 = new Background(BackgroundTexture6)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture7 = _content.Load<Texture2D>("Background/MapNight");
            var bg7 = new Background(BackgroundTexture7)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture8 = _content.Load<Texture2D>("Background/MapDesert");
            var bg8 = new Background(BackgroundTexture8)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture9 = _content.Load<Texture2D>("Background/MapNCity");
            var bg9 = new Background(BackgroundTexture9)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture10 = _content.Load<Texture2D>("Background/MapSnow");
            var bg10 = new Background(BackgroundTexture10)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture11 = _content.Load<Texture2D>("Background/MapWinter");
            var bg11 = new Background(BackgroundTexture11)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture12 = _content.Load<Texture2D>("Background/MapPark");
            var bg12 = new Background(BackgroundTexture12)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture13 = _content.Load<Texture2D>("Background/MapOffice");
            var bg13 = new Background(BackgroundTexture13)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture14= _content.Load<Texture2D>("Background/MapVilage");
            var bg14 = new Background(BackgroundTexture14)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture15 = _content.Load<Texture2D>("Background/MapPlanet");
            var bg15 = new Background(BackgroundTexture15)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture16 = _content.Load<Texture2D>("Background/MapChina");
            var bg16 = new Background(BackgroundTexture16)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture17 = _content.Load<Texture2D>("Background/MapFort");
            var bg17 = new Background(BackgroundTexture17)
            {
                Position = new Vector2(0, 0),
            };

            var BackgroundTexture18 = _content.Load<Texture2D>("Background/MapGiga");
            var bg18 = new Background(BackgroundTexture18)
            {
                Position = new Vector2(0, 0),
            };

            ///////////////////////////////////////////////////////
            var HpBack = _content.Load<Texture2D>("Controls/HpBack");
            var HpBack1 = new HpBack(HpBack)
            {
                Position = new Vector2(255, 65),
            };

            var HpGreen = _content.Load<Texture2D>("Controls/HpGreen");
            var HpGreen1 = new Hp(HpGreen)
            {
                Position = new Vector2(255, 65),
            };

            var HpOrange = _content.Load<Texture2D>("Controls/HpOrange");
            var HpOrange1 = new Hp2(HpOrange)
            {
                Position = new Vector2(255, 65),
            };

            var HpRed = _content.Load<Texture2D>("Controls/HpRed");
            var HpRed1 = new Hp3(HpRed)
            {
                Position = new Vector2(255, 65),
            };

            var Mana = _content.Load<Texture2D>("Controls/Mana");
            var Mana1 = new Mana1(Mana)
            {
                Position = new Vector2(370, 130),
            };
            ////////////////////////////////////////////////////////////////

             ///////////////////////////////////////////////////////
            var HpBack0 = _content.Load<Texture2D>("Controls/HpBack");
            var HpBack01 = new HpBack(HpBack0)
            {
                Position = new Vector2(1233, 65),
            };

            var HpGreen0 = _content.Load<Texture2D>("Controls/HpGreen2");
            var HpGreen01 = new Hp01(HpGreen0)
            {
                Position = new Vector2(1234, 65),
            };

            var HpOrange0 = _content.Load<Texture2D>("Controls/HpOrange2");
            var HpOrange01 = new Hp02(HpOrange0)
            {
                Position = new Vector2(1400, 65),
            };

            var HpRed0 = _content.Load<Texture2D>("Controls/HpRed2");
            var HpRed01 = new Hp03(HpRed0)
            {
                Position = new Vector2(1538, 65),
            };

            ////////////////////////////////////////////////////////////////

            var Hp = _content.Load<Texture2D>("Controls/Hp");
            var Hp1 = new Background(Hp)
            {
                Position = new Vector2(10, 10),
            };

            var Hp0 = _content.Load<Texture2D>("Controls/Hp2");
            var Hp2 = new Background(Hp0)
            {
                Position = new Vector2(1200, 10),
            };


            if (MapState.map == 1)
            {
                _components = new List<Component>()
      {
                bg,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 2)
            {
                _components = new List<Component>()
      {
                bg2,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 3)
            {
                _components = new List<Component>()
      {
                bg3,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 4)
            {
                _components = new List<Component>()
      {
                bg4,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map ==5)
            {
                _components = new List<Component>()
      {
                bg5,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 6)
            {
                _components = new List<Component>()
      {
                bg6,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }


            if (MapState.map == 7)
            {
                _components = new List<Component>()
      {
                bg7,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 8)
            {
                _components = new List<Component>()
      {
                bg8,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }


            if (MapState.map == 9)
            {
                _components = new List<Component>()
      {
                bg9,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 10)
            {
                _components = new List<Component>()
      {
                bg10,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 11)
            {
                _components = new List<Component>()
      {
                bg11,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }


            if (MapState.map == 12)
            {
                _components = new List<Component>()
      {
                bg12,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 13)
            {
                _components = new List<Component>()
      {
                bg13,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 14)
            {
                _components = new List<Component>()
      {
                bg14,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 15)
            {
                _components = new List<Component>()
      {
                bg15,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 16)
            {
                _components = new List<Component>()
      {
                bg16,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 17)
            {
                _components = new List<Component>()
      {
                bg17,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            if (MapState.map == 18)
            {
                _components = new List<Component>()
      {
                bg18,
                HpBack1,
                HpRed1,
                HpOrange1,
                HpGreen1,
                Mana1,
                Hp1,
                HpBack01,
                HpRed01,
                HpOrange01,
                HpGreen01,
                Hp2
      };
            }

            var buttonTexture = _content.Load<Texture2D>("Controls/Button3q");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");


            var returnButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(750, 380),
                Text = "Продолжить",
            };
            returnButton.Click += ReturnButton_Click;

            var restartButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(750, 480),
                Text = "Начать заново",
            };

            restartButton.Click += RestartButton_Click;


            var MenuButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(750, 580),
                Text = "В Меню",
            };

            MenuButton.Click += MenuButton_Click;


            var pausee = _content.Load<Texture2D>("Controls/pause");
            var pause = new Background(pausee)
            {
                Position = new Vector2(480, 100),
            };


            var pauseeW = _content.Load<Texture2D>("Controls/pauseW");
            var pauseW = new Background(pauseeW)
            {
                Position = new Vector2(480, 100),
            };


            var pauseeL = _content.Load<Texture2D>("Controls/pauseL");
            var pauseL = new Background(pauseeL)
            {
                Position = new Vector2(480, 100),
            };


            _components2 = new List<Component>()
      {
                pause,
                returnButton,
                restartButton,
                MenuButton,
      };

            _components4 = new List<Component>()
      {
                pauseW,

                restartButton,
                MenuButton,
      };

            _components3 = new List<Component>()
      {
                pauseL,

                restartButton,
                MenuButton,
      };






            var PinkiRT1 = _content.Load<Texture2D>("Controls/PinkiRam1");
            var PinkiR1 = new Background(PinkiRT1)
            {
                Position = new Vector2(60, 34),
            };

            var PinkiRT2 = _content.Load<Texture2D>("Controls/PinkiRam2");
            var PinkiR2 = new Background(PinkiRT2)
            {
                Position = new Vector2(1690, 34),
            };

            var RainbowRT1 = _content.Load<Texture2D>("Controls/RainbowRam");
            var RainbowR1 = new Background(RainbowRT1)
            {
                Position = new Vector2(60, 34),
            };

            var RainbowRT2 = _content.Load<Texture2D>("Controls/RainbowRam2");
            var RainbowR2 = new Background(RainbowRT2)
            {
                Position = new Vector2(1690, 34),
            };

            var AppleRT1 = _content.Load<Texture2D>("Controls/AppleRam");
            var AppleR1 = new Background(AppleRT1)
            {
                Position = new Vector2(60, 34),
            };

            var AppleRT2 = _content.Load<Texture2D>("Controls/AppleRam2");
            var AppleR2 = new Background(AppleRT2)
            {
                Position = new Vector2(1690, 34),
            };

            var RarRT1 = _content.Load<Texture2D>("Controls/RarRam");
            var RarR1 = new Background(RarRT1)
            {
                Position = new Vector2(60, 34),
            };

            var RarRT2 = _content.Load<Texture2D>("Controls/RarRam2");
            var RarR2 = new Background(RarRT2)
            {
                Position = new Vector2(1690, 34),
            };


            if (HeroState.player1 == 1 && Hero2State.player2 == 1)
            {
                _components5 = new List<Component>()
                   {
                       RainbowR2,
                       RainbowR1,

                   };
            }

            else if (HeroState.player1 == 1 && Hero2State.player2 == 2)
            {
                _components5 = new List<Component>()
                   {
                       PinkiR2,
                       RainbowR1,
                   };
            }

            else if (HeroState.player1 == 2 && Hero2State.player2 == 1)
            {
                _components5 = new List<Component>()
                   {
                    RainbowR2,
                       PinkiR1,

                   };
            }

            else if (HeroState.player1 == 2 && Hero2State.player2 == 2)
            {
                _components5 = new List<Component>()
                   {
                       PinkiR2,
                       PinkiR1,

                   };
            }

            else if (HeroState.player1 == 3 && Hero2State.player2 == 2)
            {
                _components5 = new List<Component>()
                   {
                       PinkiR2,
                       AppleR1,

                   };
            }

            else if (HeroState.player1 == 3 && Hero2State.player2 == 1)
            {
                _components5 = new List<Component>()
                   {
                       RainbowR2,
                       AppleR1,

                   };
            }

            else if (HeroState.player1 == 3 && Hero2State.player2 == 3)
            {
                _components5 = new List<Component>()
                   {
                       AppleR2,
                       AppleR1,

                   };
            }

            else if (HeroState.player1 == 1 && Hero2State.player2 == 3)
            {
                _components5 = new List<Component>()
                   {
                       AppleR2,
                       RainbowR1,

                   };
            }

            else if (HeroState.player1 == 2 && Hero2State.player2 == 3)
            {
                _components5 = new List<Component>()
                   {
                       AppleR2,
                       PinkiR1,

                   };
            }






            else if (HeroState.player1 == 4 && Hero2State.player2 == 2)
            {
                _components5 = new List<Component>()
                   {
                       PinkiR2,
                       RarR1,

                   };
            }

            else if (HeroState.player1 == 4 && Hero2State.player2 == 1)
            {
                _components5 = new List<Component>()
                   {
                       RainbowR2,
                       RarR1,

                   };
            }

            else if (HeroState.player1 == 4 && Hero2State.player2 == 3)
            {
                _components5 = new List<Component>()
                   {
                       AppleR2,
                       RarR1,

                   };
            }


            else if (HeroState.player1 == 4 && Hero2State.player2 == 4)
            {
                _components5 = new List<Component>()
                   {
                       RarR2,
                       RarR1,

                   };
            }

            else if (HeroState.player1 == 1 && Hero2State.player2 == 4)
            {
                _components5 = new List<Component>()
                   {
                       RarR2,
                       RainbowR1,

                   };
            }

            else if (HeroState.player1 == 2 && Hero2State.player2 == 4)
            {
                _components5 = new List<Component>()
                   {
                       RarR2,
                       PinkiR1,

                   };
            }

            else if (HeroState.player1 == 3 && Hero2State.player2 == 4)
            {
                _components5 = new List<Component>()
                   {
                       RarR2,
                       AppleR1,

                   };
            }



        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            _game.IsMouseVisible = false;
            a = 0;

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
        private void RestartButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new TraningGameState(_game, _graphicsDevice, _content));
            Player.pain = 0;
            Mana1.mana = 300;
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
        private void MenuButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
            Player.pain = 0;
            Mana1.mana = 300;
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


        SoundEffect pain1S;
        SoundEffect pain2S;
        SoundEffect pain3S;

        SoundEffect walk1S;
        SoundEffect walk2S;
        SoundEffect walk3S;
        SoundEffect walk4S;
        SoundEffect walk5S;

        SoundEffect udarS;
        SoundEffect shootS;
        SoundEffect suicideS;

        SoundEffect nya1S;
        SoundEffect nya2S;

        SoundEffect polet1S;
        SoundEffect polet2S;
        SoundEffect polet3S;
        SoundEffect polet4S;

        SoundEffect winS;

        SoundEffect blinkS;
        public int Nya;



        public override void LoadContent()
        {

            nya1S = _content.Load<SoundEffect>("Audio/nya1");
            nya2S = _content.Load<SoundEffect>("Audio/nya2");
            //  var bulletTexture = _content.Load<Texture2D>("Bullet2");
            // var bulletPrefab = new Bullet(bulletTexture);

            //  var bulletPrefab = new Bullet(new Dictionary<string, Animation>()
            _font = _content.Load<SpriteFont>("Fonts/Font2");

            shootS = _content.Load<SoundEffect>("Audio/shoot");
            suicideS = _content.Load<SoundEffect>("Audio/suicide");

            walk1S = _content.Load<SoundEffect>("Audio/shag1");
            walk2S = _content.Load<SoundEffect>("Audio/shag2");
            walk3S = _content.Load<SoundEffect>("Audio/shag3");
            walk4S = _content.Load<SoundEffect>("Audio/shag4");
            walk5S = _content.Load<SoundEffect>("Audio/shag5");

            udarS = _content.Load<SoundEffect>("Audio/udar");

            pain1S = _content.Load<SoundEffect>("Audio/pain1");
            pain2S = _content.Load<SoundEffect>("Audio/pain2");
            pain3S = _content.Load<SoundEffect>("Audio/pain3");

            polet1S = _content.Load<SoundEffect>("Audio/polet1");
            polet2S = _content.Load<SoundEffect>("Audio/polet2");
            polet3S = _content.Load<SoundEffect>("Audio/polet3");
            polet4S = _content.Load<SoundEffect>("Audio/polet4");

            winS = _content.Load<SoundEffect>("Audio/tuturu");

            blinkS = _content.Load<SoundEffect>("Audio/blink");





            var udarTexture = _content.Load<Texture2D>("Udar");
            var udarPrefab = new Udar(udarTexture)


            {
                Explosion = new Explosion(new Dictionary<string, Models.Animation>()
            {
              { "Explode", new Models.Animation(_content.Load<Texture2D>("Explosion"), 3) { FrameSpeed = 0.1f, } }
            })
                {
                    Layer = 0.5f,
                }
            };

            {

                var bulletPrefab = new Bullet(new Dictionary<string, Animation>()
                    {
                    { "Bullet", new Animation(_content.Load<Texture2D>("Bullet"), 4) { FrameSpeed = 0.1f, } }

                })
                {
                    Layer = 0.5f,
                };


                var rainbow = new Player(new Dictionary<string, Animation>()
              {
                           { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/JumpingEndR"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/WalkingRight"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/WalkingRightBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/JumpingR"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/BlokR"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/UdarR"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/ShootR"), 1) },
                           { "Suicide", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/Suicide"), 4) { FrameSpeed = 1f, }},
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/Dead"), 1) },
                           { "ULTA", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/ULTA"), 6) },

                })
                {
                    Position = new Vector2(10, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Input = new Input()
                    {
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        Shoot = Keys.Q,
                        Udar = Keys.E,
                        Blok = Keys.S,
                        Suicide = Keys.C,
                        ULTA = Keys.R
                    },
                    Health = 100,
                };

                var pinki = new Player(new Dictionary<string, Animation>()
              {
                                               { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Pinki/JumpingEndR"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Pinki/WalkingRight"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Pinki/WalkingRightBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Pinki/JumpingR"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Pinki/BlokR"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Pinki/UdarR"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Pinki/ShootR"), 1) },
                           { "Suicide", new Animation(_content.Load<Texture2D>("Heroes/Pinki/Suicide"), 4) { FrameSpeed = 1f, }},
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Pinki/Dead"), 1) },
                           { "ULTA", new Animation(_content.Load<Texture2D>("Heroes/Pinki/ULTA"), 1) },
                })
                {
                    Position = new Vector2(10, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Input = new Input()
                    {
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        Shoot = Keys.Q,
                        Udar = Keys.E,
                        Blok = Keys.S,
                        Suicide = Keys.C,
                        ULTA = Keys.R,
                    },
                    Health = 100,
                };

                var apple = new Player(new Dictionary<string, Animation>()
              {
                    { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Apple/JumpingEndR"), 1) },
                          { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Apple/WalkingRight"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Apple/WalkingRightBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Apple/JumpingR"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Apple/BlokR"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Apple/UdarR"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Apple/ShootR"), 1) },
                           { "Suicide", new Animation(_content.Load<Texture2D>("Heroes/Apple/Suicide"), 4) { FrameSpeed = 1f, }},
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Apple/Dead"), 1) },
                           { "ULTA", new Animation(_content.Load<Texture2D>("Heroes/Apple/ULTA"), 1) },
                })
                {
                    Position = new Vector2(10, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Input = new Input()
                    {
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        Shoot = Keys.Q,
                        Udar = Keys.E,
                        Blok = Keys.S,
                        Suicide = Keys.C,
                        ULTA = Keys.R,
                    },
                    Health = 100,
                };

                var rar = new Player(new Dictionary<string, Animation>()
              {
                    { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Rar/JumpingEndR"), 1) },
                          { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Rar/WalkingRight"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Rar/WalkingRightBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Rar/JumpingR"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Rar/BlokR"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Rar/UdarR"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Rar/ShootR"), 1) },
                           { "Suicide", new Animation(_content.Load<Texture2D>("Heroes/Rar/Suicide"), 4) { FrameSpeed = 1f, }},
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Rar/Dead"), 1) },
                           { "ULTA", new Animation(_content.Load<Texture2D>("Heroes/Rar/ULTA"), 1) },
                })
                {
                    Position = new Vector2(10, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Input = new Input()
                    {
                        Up = Keys.W,
                        Left = Keys.A,
                        Right = Keys.D,
                        Shoot = Keys.Q,
                        Udar = Keys.E,
                        Blok = Keys.S,
                        Suicide = Keys.C,
                        ULTA = Keys.R,
                    },
                    Health = 100,
                };

                var rainbow2 = new Enemy(new Dictionary<string, Animation>()
                     {
                                               { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/JumpingEndL"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/WalkingLeft"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/WalkingLeftBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/JumpingL"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/BlokL"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/UdarL"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/ShootL"), 1) },
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Rainbow/Dead"), 1) },
                     })
                {
                    Position = new Vector2(1600, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Health = 100,

                };
                var pinki2 = new Enemy(new Dictionary<string, Animation>()
                     {
                                               { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Pinki/JumpingEndL"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Pinki/WalkingLeft"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Pinki/WalkingLeftBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Pinki/JumpingL"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Pinki/BlokL"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Pinki/UdarL"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Pinki/ShootL"), 1) },
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Pinki/Dead"), 1) },
                     })
                {
                    Position = new Vector2(1600, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Health = 100,

                };

                var apple2 = new Enemy(new Dictionary<string, Animation>()
                     {
                           { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Apple/JumpingEndL"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Apple/WalkingLeft"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Apple/WalkingLeftBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Apple/JumpingL"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Apple/BlokL"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Apple/UdarL"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Apple/ShootL"), 1) },
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Apple/Dead"), 1) },
                     })
                {
                    Position = new Vector2(1600, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Health = 100,

                };

                var rar2 = new Enemy(new Dictionary<string, Animation>()
                     {
                           { "JumpingEnd", new Animation(_content.Load<Texture2D>("Heroes/Rar/JumpingEndL"), 1) },
                           { "WalkRight", new Animation(_content.Load<Texture2D>("Heroes/Rar/WalkingLeft"), 6) },
                           { "WalkLeft", new Animation(_content.Load<Texture2D>("Heroes/Rar/WalkingLeftBack"), 6) },
                           { "Jumping", new Animation(_content.Load<Texture2D>("Heroes/Rar/JumpingL"), 1) },
                           { "Blok", new Animation(_content.Load<Texture2D>("Heroes/Rar/BlokL"), 1) },
                           { "Udar", new Animation(_content.Load<Texture2D>("Heroes/Rar/UdarL"), 9) },
                           { "Shoot", new Animation(_content.Load<Texture2D>("Heroes/Rar/ShootL"), 1) },
                           { "Dead", new Animation(_content.Load<Texture2D>("Heroes/Rar/Dead"), 1) },
                     })
                {
                    Position = new Vector2(1600, 610),
                    Bullet = bulletPrefab,
                    Udarr = udarPrefab,
                    Health = 100,

                };


                if (HeroState.player1 == 1 && Hero2State.player2 == 1)
                {
                    _sprites = new List<Sprite>()
                   {
                       rainbow2,
                       rainbow,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                else if (HeroState.player1 == 1 && Hero2State.player2 == 2)
                {
                    _sprites = new List<Sprite>()
                   {
                       pinki2,
                       rainbow,
                   };
                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                else if (HeroState.player1 == 2 && Hero2State.player2 == 1)
                {
                    _sprites = new List<Sprite>()
                   {
                    rainbow2,
                       pinki,

                   };
                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                else if (HeroState.player1 == 2 && Hero2State.player2 == 2)
                {
                    _sprites = new List<Sprite>()
                   {
                       pinki2,
                       pinki,

                   };
                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 1 && Hero2State.player2 == 3)
                {
                    _sprites = new List<Sprite>()
                   {
                       apple2,
                       rainbow,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 2 && Hero2State.player2 == 3)
                {
                    _sprites = new List<Sprite>()
                   {
                       apple2,
                       pinki,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 3 && Hero2State.player2 == 3)
                {
                    _sprites = new List<Sprite>()
                   {
                       apple2,
                       apple,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }


                if (HeroState.player1 == 3 && Hero2State.player2 == 1)
                {
                    _sprites = new List<Sprite>()
                   {
                       rainbow2,
                       apple,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 3 && Hero2State.player2 == 2)
                {
                    _sprites = new List<Sprite>()
                   {
                       pinki2,
                       apple,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }





                if (HeroState.player1 == 1 && Hero2State.player2 == 4)
                {
                    _sprites = new List<Sprite>()
                   {
                       rar2,
                       rainbow,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 2 && Hero2State.player2 == 4)
                {
                    _sprites = new List<Sprite>()
                   {
                       rar2,
                       pinki,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 3 && Hero2State.player2 == 4)
                {
                    _sprites = new List<Sprite>()
                   {
                       rar2,
                       apple,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 4 && Hero2State.player2 == 4)
                {
                    _sprites = new List<Sprite>()
                   {
                       rar2,
                       rar,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }


                if (HeroState.player1 == 4 && Hero2State.player2 == 1)
                {
                    _sprites = new List<Sprite>()
                   {
                       rainbow2,
                       rar,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 4 && Hero2State.player2 == 2)
                {
                    _sprites = new List<Sprite>()
                   {
                       pinki2,
                       rar,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                if (HeroState.player1 == 4 && Hero2State.player2 == 3)
                {
                    _sprites = new List<Sprite>()
                   {
                       apple2,
                       rar,

                   };

                    _enemys = _sprites.Where(c2 => c2 is Enemy).Select(c2 => (Enemy)c2).ToList();
                    _players = _sprites.Where(c => c is Player).Select(c => (Player)c).ToList();
                }

                _enemyManager = new EnemyManager(_content)
                {
                    Bullet = bulletPrefab,

                };


            }
        }


        public override void PostUpdate(GameTime gameTime)
        {
            var collidableSprites = _sprites.Where(c => c is ICollidable);

            foreach (var spriteA in collidableSprites)
            {
                foreach (var spriteB in collidableSprites)
                {
                    // Don't do anything if they're the same sprite!
                    if (spriteA == spriteB)
                        continue;

                    if (!spriteA.CollisionArea.Intersects(spriteB.CollisionArea))
                        continue;

                    if (spriteA.Intersects(spriteB))
                       ((ICollidable)spriteA).OnCollide(spriteB);
                }
            }

            // Add the children sprites to the list of sprites (ie bullets)
            int spriteCount = _sprites.Count;
            for (int i = 0; i < spriteCount; i++)
            {
                var sprite = _sprites[i];
                foreach (var child in sprite.Children)
                    _sprites.Add(child);

                sprite.Children = new List<Sprite>();
            }

            for (int i = 0; i < _sprites.Count; i++)
            {
                if (_sprites[i].IsRemoved)
                {
                    _sprites.RemoveAt(i);
                    i--;
                }
            }

            // If all the players are dead, we save the scores, and return to the highscore state
          // if (_players.All(c => c.IsDead))
          // {
          //     foreach (var player in _players)
          //         _scoreManager.Add(player.Score);
          //
          //     ScoreManager.Save(_scoreManager);
          //
          //     _game.ChangeState(new HighscoresState(_game, _content));
          // }
        }



        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {



            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();

            spriteBatch.Begin(SpriteSortMode.FrontToBack);

            foreach (var sprite in _sprites)
                sprite.Draw(gameTime, spriteBatch);

            spriteBatch.End();


                if (timerReload < 0f && Player.Reload == 2)
                {
                    spriteBatch.Begin();
                        spriteBatch.DrawString(_font, "Перезарядка: " + Math.Round(timerReload,1), new Vector2(500f, 200), Color.White);
                    spriteBatch.End();

                }

            if (Player.pain == 4)
            {
                spriteBatch.Begin();

                foreach (var component in _components4)
                    component.Draw(gameTime, spriteBatch);

                spriteBatch.End();

            }

            if (Player.pain == 3)
            {
                spriteBatch.Begin();

                foreach (var component in _components3)
                    component.Draw(gameTime, spriteBatch);

                spriteBatch.End();

            }



            spriteBatch.Begin();

            foreach (var component in _components5)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                spriteBatch.Begin();

                foreach (var component in _components2)
                    component.Draw(gameTime, spriteBatch);

                spriteBatch.End();

            }
            

            if (a > 0)
            {
                a = 2;
                spriteBatch.Begin();

                foreach (var component in _components2)
                    component.Draw(gameTime, spriteBatch);

                spriteBatch.End();
            }

            spriteBatch.Begin();

            foreach (var player in _players)
            {
                spriteBatch.DrawString(_font, player.Health + " / 100", new Vector2(275f, 75f), Color.Black);

            }
            spriteBatch.End();

            spriteBatch.Begin();

            foreach (var enemy in _enemys)
            {
                spriteBatch.DrawString(_font, enemy.Health + " / 100", new Vector2(1560f, 75), Color.Black);

            }
            spriteBatch.End();

        }
        public int rezi = 0;
        public int rezi2 = 0;
        public int PainS1 = 0;
        public int PainS2 = 0;

        public int a = 0;
        public int b = 0;
        public int soundhelp = 0;
        public int soundhelp2 = 0;
        public int soundhelp3 = 0;
        public int soundhelp4 = 0;
        private float timerReload;
        private float timerSound;
        public int SHG = 0;
        public int SHG2 = 0;
        public int SHG3 = 0;

        public override void Update(GameTime gameTime)
        {
            
            _game.IsMouseVisible = false;

            timerReload += (float)gameTime.ElapsedGameTime.TotalSeconds;
            timerSound += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (Player.SoundSWa == 112) //Blink
            {
                soundhelp4++;
                if (soundhelp4 == 1)
                {
                    SoundEffectInstance soundEffectInstance = blinkS.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;

                }

            }
            else
                soundhelp4 = 0;


            if (Player.soundS == 1) //Shoot SOUND
            {
                SoundEffectInstance soundEffectInstance = shootS.CreateInstance();
                SoundEffect.MasterVolume = 0.3f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();

                Player.soundS = 0;
            }

            if (Player.soundS == 2) //Suicide SOUND
            {
                timerSound = 0;
                Player.soundS = 22;
            }

            if (Player.soundS == 22 && Keyboard.GetState().IsKeyUp(Keys.C)) //Suicide SOUND
            {
                SoundEffectInstance soundEffectInstance = suicideS.CreateInstance();
                SoundEffect.MasterVolume = 1f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();
                Player.soundS = 0;
            }

            if (Player.SoundSWa == 3) //Walk SOUND
            {
                Player.SoundSWa = 33;
                soundhelp++;

                Random rnd = new Random();
                SHG = rnd.Next(0, 5);
            }

            if (Player.SoundSWa == 33 && soundhelp == 18) //Walk SOUND
            {
                Random rnd2 = new Random();
                SHG2 = rnd2.Next(0, 5);

                if (SHG == 0)
                {
                    SoundEffectInstance soundEffectInstance = walk1S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 1)
                {
                    SoundEffectInstance soundEffectInstance = walk2S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 2)
                {
                    SoundEffectInstance soundEffectInstance = walk3S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 3)
                {
                    SoundEffectInstance soundEffectInstance = walk4S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 4)
                {
                    SoundEffectInstance soundEffectInstance = walk5S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }

            }


            if (Player.SoundSWa2 == 3) //Walk SOUND ENEMY
            {
                Player.SoundSWa2 = 33;
                soundhelp2++;

                Random rnd2 = new Random();
                SHG2 = rnd2.Next(0, 5);
            }

            if (Player.SoundSWa2 == 33 && soundhelp2 == 18) //Walk SOUND ENEMY
            {
                Random rnd2 = new Random();
                SHG2 = rnd2.Next(0, 5);

                if (SHG2 == 0)
                {
                    SoundEffectInstance soundEffectInstance = walk1S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa2 = 0;
                    soundhelp2 = 0;
                }
                if (SHG2 == 1)
                {
                    SoundEffectInstance soundEffectInstance = walk2S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa2 = 0;
                    soundhelp2 = 0;
                }
                if (SHG2 == 2)
                {
                    SoundEffectInstance soundEffectInstance = walk3S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa2 = 0;
                    soundhelp2 = 0;
                }
                if (SHG2 == 3)
                {
                    SoundEffectInstance soundEffectInstance = walk4S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa2 = 0;
                    soundhelp2 = 0;
                }
                if (SHG2 == 4)
                {
                    SoundEffectInstance soundEffectInstance = walk5S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa2 = 0;
                    soundhelp2 = 0;
                }

            }



            if (Player.pain == 4) //Win
            {

                soundhelp++;
                if (soundhelp== 20)
                {
                    SoundEffectInstance soundEffectInstance = winS.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;

                }

            }



            if (Player.SoundSUdar == 1) //Udar SOUND
            {
                SoundEffectInstance soundEffectInstance = udarS.CreateInstance();
                SoundEffect.MasterVolume = 0.3f;
                soundEffectInstance.IsLooped = false;
                soundEffectInstance.Play();

                Player.SoundSUdar = 0;
            }


            if (Player.SoundSWa == 313) //POLET SOUND
            {
                Player.SoundSWa = 3133;
                soundhelp++;

                Random rnd = new Random();
                SHG = rnd.Next(0, 4);
            }

            if (Player.SoundSWa == 3133 && soundhelp == 18) //POLET2 SOUND
            {
                Random rnd2 = new Random();
                SHG2 = rnd2.Next(0, 4);

                if (SHG == 0)
                {
                    SoundEffectInstance soundEffectInstance = polet1S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 1)
                {
                    SoundEffectInstance soundEffectInstance = polet2S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 2)
                {
                    SoundEffectInstance soundEffectInstance = polet3S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }
                if (SHG == 3)
                {
                    SoundEffectInstance soundEffectInstance = polet4S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    Player.SoundSWa = 0;
                    soundhelp = 0;
                }

            }


            if (PainS1==1   || PainS2 ==1) //SPain
            {
                soundhelp3++;

                if (soundhelp3 == 10)
                {
                    SoundEffectInstance soundEffectInstance = pain1S.CreateInstance();
                    soundEffectInstance.IsLooped = false;
                    SoundEffect.MasterVolume = 0.2f;
                    soundEffectInstance.Play();
                    soundhelp3 = 0;
                    PainS1 = 0;
                    PainS2 = 0;
                }

            }







            if (Player.Reload == 1)
            {
                timerReload = -6f;
                Player.Reload = 2;
            }

            if (timerReload >= 0f)
            {
                Player.Reload = 0;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                a++;
            }

            if (Player.pain == 1)
            {
                rezi++;

                if(rezi == 2)
                {
                    foreach (var enemy in _enemys)
                    {
                        PainS1 = 1;
                        enemy.Health--;
                        Player.pain = 0;
                        rezi = 0;
                    }
                }

            }


            if (Player.pain == 2)
            {
                rezi2++;
                if (rezi2 == 2)
                {
                    foreach (var player in _players)
                    {
                        PainS2 = 1;
                        player.Health--;
                        Player.pain = 0;
                        rezi2 = 0;
                    }
                }

            }


            if (a > 0)
            {
                _game.IsMouseVisible = true;
                foreach (var component in _components2)
                    component.Update(gameTime);
            }
            else if (Player.pain == 3)
            {
                _game.IsMouseVisible = true;
                foreach (var component in _components3)
                    component.Update(gameTime);
                Player.pain = 0;

            }

            else if (Player.pain == 4)
            {
                _game.IsMouseVisible = true;
                foreach (var component in _components4)
                    component.Update(gameTime);
                Player.pain = 0;

            }
            else
            {
                foreach (var sprite in _sprites)
                    sprite.Update(gameTime);
                _enemyManager.Update(gameTime);

                foreach (var sprite in _sprites)
                    sprite.Update(gameTime, _sprites);

                foreach (var component in _components)
                    component.Update(gameTime);

                if (_enemyManager.CanAdd && _sprites.Where(c => c is Enemy).Count() < _enemyManager.MaxEnemies)
                {
                    _sprites.Add(_enemyManager.GetEnemy());
                }
            }

        }
    }
}
