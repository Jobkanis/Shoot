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
    class DrawVisitor
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        MainGameFactory mainGameFactory;
        ContentManager content;

        Sprites sprites;

        public DrawVisitor(GraphicsDeviceManager graphics, SpriteBatch spriteBatch, ContentManager content, MainGameFactory mainGameFactory)
        {
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.mainGameFactory = mainGameFactory;
            this.content = content;
            this.sprites = new Sprites(graphics, spriteBatch, content, mainGameFactory);
        }
        public void startDraw()
        {
            spriteBatch.Begin();
        }

        public void EndDraw()
        {

            spriteBatch.End();
        }


        // Draw guis

        public void drawMouse(Position mousePosition)
        {
            Position pos = mousePosition;
            Size size = new Size(4, 4);
            spriteBatch.Draw(sprites.emptyPixel, new Rectangle(pos.x, pos.y, size.x, size.y), Color.Black);
        }
        // Draw objects

        public void drawMainCharacter(MainCharacter obj)
        {
            Position pos = obj.position;
            Size size = obj.size;
            spriteBatch.Draw(sprites.emptyPixel, new Rectangle(pos.x, pos.y, size.x, size.y), obj.color);
        }

        public void drawBullet(Bullet obj)
        {
            Position pos = obj.position;
            Size size = obj.size;
            spriteBatch.Draw(sprites.emptyPixel, new Rectangle(pos.x, pos.y, size.x, size.y), obj.color);
        }

        public void drawTarget(Target obj)
        {
            Position pos = obj.position;
            Size size = obj.size;
            spriteBatch.Draw(sprites.emptyPixel, new Rectangle(pos.x, pos.y, size.x, size.y), obj.color);
        }
    }
}