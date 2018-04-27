using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot{

    class TargetList: MonoList<Target>
    {
        public TargetList(MainGameFactory mainGameFactory): base(mainGameFactory)
        {
        }

        public void handleBulletHits(BulletList bulletList)
        {
            foreach (Target target in elements)
            {
                target.handleBulletHits(bulletList);
            }
        }


        public override void Draw()
        {
            foreach (Target target in elements)
            {
                target.Draw();
            }
        }

        public override void Update(float gameTime)
        {
            foreach (Target target in elements)
            {
                target.Update(gameTime);

            }

            foreach (Target target in elements.ToList())
            {
                if (target.remove)
                { 
                    this.elements.Remove(target);
                }
            }
        }
    }
}
