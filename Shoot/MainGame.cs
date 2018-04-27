using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    class MainGame: MonoObject
    {

        MainCharacter mainCharacter;
        BulletList bulletList;
        TargetList targetList;
        ControlInformation currentControlInformation;

        public MainGame(MainGameFactory mainGameFactory)
            : base(mainGameFactory)
        {
            this.mainCharacter = this.mainGameFactory.getMainCharacter(new Position(350, 200));
            this.currentControlInformation = this.controlAdapter.getInformation();
            this.bulletList = this.mainGameFactory.getBulletList();
            this.targetList = this.mainGameFactory.getTargetList();
            instantiateLevel();
        }

        public void instantiateLevel()
        {
            targetList.Add(this.mainGameFactory.getTarget(new Position(100, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(200, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(300, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(400, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(500, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(600, 100)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(700, 100)));

            targetList.Add(this.mainGameFactory.getTarget(new Position(700, 200)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(100, 200)));

            targetList.Add(this.mainGameFactory.getTarget(new Position(100, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(200, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(300, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(400, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(500, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(600, 300)));
            targetList.Add(this.mainGameFactory.getTarget(new Position(700, 300)));
        }

        // draw

        public override void Draw()
        {
            this.drawVisitor.startDraw();

            //draw logic
            this.bulletList.Draw();
            this.targetList.Draw();
            this.mainCharacter.Draw();

            // gui logic
            this.drawVisitor.drawMouse(this.currentControlInformation.mousePosition.copy());


            this.drawVisitor.EndDraw();
        }


// update


        public void CheckCollisions()
        {
            this.targetList.handleBulletHits(bulletList);
        }

        public void handleActions(float gameTime)
        {
            this.currentControlInformation = this.controlAdapter.getInformation();

            if (this.currentControlInformation.leftMouseButtonClick)
            {
                this.bulletList.Add(this.mainGameFactory.getBullet(this.mainCharacter, this.currentControlInformation.mousePosition.copy()));
            }
        }

        public override void Update(float gameTime)
        {
            this.handleActions(gameTime);

            //Update Logic
            this.bulletList.Update(gameTime);
            this.targetList.Update(gameTime);

            this.CheckCollisions();
        }
    }
}
