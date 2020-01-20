using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PoniFei.States;
using PoniFei.Models;
using PoniFei.Sprites;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Audio;


namespace PoniFei
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SoundEffect daze;

        public static Random Random;
        public static int ScreenWidth = 1920;
        public static int ScreenHeight = 1080;

        private State _currentState;

        private State _nextState;


        public void ChangeState(State state)
        {
            _nextState = state;

        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);    
            Content.RootDirectory = "Content";


          //  cursor = new Cursor(this, 2);
          //  cursor.BorderColor = Color.White;
          //  Components.Add(cursor);
        }


        protected override void Initialize()
        {
            Random = new Random();

            GraphicsAdapter adapter = graphics.GraphicsDevice.Adapter;
            graphics.PreferredBackBufferWidth = adapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = adapter.CurrentDisplayMode.Height;
         graphics.IsFullScreen = true;
            graphics.ApplyChanges();

           IsMouseVisible = true;



            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            daze = Content.Load<SoundEffect>("Audio/daze");
            _currentState = new StartState(this, graphics.GraphicsDevice, Content);
            _currentState.LoadContent();
        }


        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {


            if (_nextState != null)
            {
                _currentState = _nextState;
                _currentState.LoadContent();

                _nextState = null;

            }

            _currentState.Update(gameTime);

            _currentState.PostUpdate(gameTime);


                base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.DimGray);

            _currentState.Draw(gameTime, spriteBatch);


            base.Draw(gameTime);
        }
    }
}