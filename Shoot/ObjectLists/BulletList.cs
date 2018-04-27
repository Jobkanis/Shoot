using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot{
    class BulletList: MonoList<Bullet>
    {
        public BulletList(MainGameFactory mainGameFactory): base(mainGameFactory)
        {
            
        }

        public override void Draw()
        { 
            foreach (Bullet bullet in elements)
            {
                bullet.Draw();
            }
        }

        public override void Update(float gameTime)
        {
            foreach (Bullet bullet in elements)
            {
                bullet.Update(gameTime);

                if (bullet.position.x >= 1000 || bullet.position.y <= -50 || bullet.size.y >= 700 || bullet.size.y <= -50)
                {
                    bullet.remove = true;
                }
            }

            foreach (Bullet bullet in elements.ToList())
            {
                if (bullet.remove)
                { 
                    this.elements.Remove(bullet);
                }
            }
        }
    }
}
