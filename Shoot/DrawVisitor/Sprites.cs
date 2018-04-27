using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace Shoot
{
    class Sprites
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        MainGameFactory mainGameFactory;
        ContentManager content;

        public Sprites(GraphicsDeviceManager graphics, SpriteBatch spriteBatch, ContentManager content, MainGameFactory mainGameFactory)
        {
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.mainGameFactory = mainGameFactory;
            this.content = content;
            this.ReloadSprites();
        }

        public Texture2D emptyPixel;

        public void ReloadSprites()
        {
            this.emptyPixel = this.content.Load<Texture2D>("EmptyPixel");
        }
    }
}
