using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    class MainCharacter : MonoObject
    {
        public MainCharacter(MainGameFactory mainGameFactory, Position position) : base(mainGameFactory, position, new Size(50, 50))
        {
        }

        public override void Draw()
        {
            this.drawVisitor.drawMainCharacter(this);
        }

        public override void Update(float gameTime)
        {
            base.Update(gameTime);
        }
    }
}
