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
    class Target : MonoObject
    {
        public Target(MainGameFactory mainGameFactory, Position position) : base(mainGameFactory, position, new Size(50, 50))
        {

        }

        public void handleBulletHits(BulletList bulletList)
        {
            foreach(Bullet bullet in bulletList.getList())
            {
                if (bullet.intersect(this))
                {
                    bullet.remove = true;
                    this.color = Color.Green;
                }
            }
        }

        public override void Draw()
        {
            this.drawVisitor.drawTarget(this);
        }

        public override void Update(float gameTime)
        {
            base.Update(gameTime);
        }

    }
}
