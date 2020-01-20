using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PoniFei.Models;
using Microsoft.Xna.Framework.Input;
using PoniFei.Managers;


namespace PoniFei.Sprites
{
    public class Hero : Sprite, ICollidable
    {
        public int Health { get; set; }

        public Bullet Bullet { get; set; }

        public Udar Udarr { get; set; }

        public float Speed;

        public static int qwe = 0;

        public Hero(Texture2D texture) : base(texture)
        {
        }

        public Hero(Dictionary<string, Animation> animations) : base(animations)
        {

        }

        protected void Shoot(float speed)
        {
            var bullet = Bullet.Clone() as Bullet;
            bullet.Position = this.Position + new Vector2(250,150);
            bullet.Colour = this.Colour;
            bullet.Layer = 0.1f;
            bullet.LifeSpan = 6f;
            bullet.Velocity = new Vector2(speed, 0f);
            bullet.Parent = this;
            qwe = 1;

      
            Children.Add(bullet);
        }

        protected void Udar(float speed)
        {
            var udar = Udarr.Clone() as Udar;
            udar.Position = this.Position + new Vector2(50, 150);
            udar.Colour = this.Colour;
            udar.Layer = 0.1f;
            udar.LifeSpan = 0.2f;
            udar.Velocity = new Vector2(speed, 0f);
            udar.Parent = this;
            qwe = 2;
            Children.Add(udar);
        }

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {



        }

        public virtual void OnCollide(Sprite sprite)
        {
            throw new NotImplementedException();
        }
    }
}