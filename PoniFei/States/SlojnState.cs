using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Controls;

namespace PoniFei.States
{
    public class SlojnState : State
    {
        private List<Component> _components;


        public SlojnState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button2q");
            var buttonTexture2 = _content.Load<Texture2D>("Controls/BackButton1");
            var buttonFont = _content.Load<SpriteFont>("Fonts/Font");
            var buttonFont2 = _content.Load<SpriteFont>("Fonts/Font2");

            var BackgroundTexture = _content.Load<Texture2D>("Background/Background");
            var bg = new Background(BackgroundTexture)
            {
                Position = new Vector2(0, 0),
            };

            var trainingButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610, 250),
                Text = "Training",
            };
            trainingButton.Click += TrainingButton_Click;

            var pvscButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610, 400),
                Text = "Player vs COM",
            };




            var pvspButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(610, 550),
                Text = "Player vs Player",
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
        trainingButton,
        pvscButton,
        pvspButton,
        backButton,
      };
        }

        public override void LoadContent()
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);

            spriteBatch.End();
        }


        private void TrainingButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new HeroState(_game, _graphicsDevice, _content));
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MenuState(_game, _graphicsDevice, _content));
        }
    }
}