using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    class Bullet : MonoObject
    {
        public Bullet(MainGameFactory mainGameFactory, Position position) : base(mainGameFactory, position, new Size(10, 3))
        {
        }

        public override void Draw()
        {
            this.drawVisitor.drawBullet(this);
        }

        public override void Update(float gameTime)
        {
            base.Update(gameTime);
        }
    }
}
