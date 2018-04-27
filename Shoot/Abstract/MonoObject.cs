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
    abstract class MonoObject : Drawable, Updateable
    {
        public MainGameFactory mainGameFactory;
        public MainGame mainGame;
        public DrawVisitor drawVisitor;
        public ControlAdapter controlAdapter;
        public Position position = new Position();
        public Size size = new Size();

        public Boolean remove = false;
        public Color color = Color.Black;

        public MonoObject(MainGameFactory mainGameFactory)
        {
            this.mainGameFactory = mainGameFactory;
            this.drawVisitor = mainGameFactory.getDrawVisitor();
            this.mainGame = mainGameFactory.getMainGame();
            this.controlAdapter = mainGameFactory.getControlAdapter();
        }

        public MonoObject(MainGameFactory mainGameFactory, Position position, Size size)
        {
            this.mainGameFactory = mainGameFactory;
            this.drawVisitor = mainGameFactory.getDrawVisitor();
            this.mainGame = mainGameFactory.getMainGame();
            this.size = size;
            this.position = position;
        }

        public Position getMiddle()
        {
            return new Position(this.position.x + this.size.x / 2, this.position.y + this.size.y / 2);
        }

        public abstract void Draw();

        float pastX = 0;
        float pastY = 0;

        public int speed = 0;
        public Position direction = new Position();
     
        public void giveForce(Position direction, int speed)
        {
            this.direction = direction;
            this.speed = speed;
        }
        public void setLooks(Color color)
        {
            this.color = color;
        }


        public Boolean intersect(MonoObject that)
        {
            Rectangle thatRec = new Rectangle(that.position.x, that.position.y, that.size.x, that.size.y);
            Rectangle thisRec = new Rectangle(this.position.x, this.position.y, this.size.x, this.size.y);
    
            return thisRec.Intersects(thatRec);
        }

        public virtual void Update(float gameTime)
        {
            // force
            if (this.speed > 0)
            {
                double length = Math.Sqrt(this.direction.getFloatX() * this.direction.getFloatX() + this.direction.getFloatY() * this.direction.getFloatY());
           
                this.pastX += (float)((this.direction.getFloatX() / length) * this.speed);
                this.pastY += (float)((this.direction.getFloatY() / length) * this.speed);           

                int addX = (int) pastX;
                int addY = (int) pastY;
                pastX -= addX;
                pastY -= addY;

                this.position.x += addX;
                this.position.y += addY;
            }
        }
    }
}
 