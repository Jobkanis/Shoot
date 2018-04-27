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
    class MainGameFactory
    {
        public Game1 baseGame;
        public DrawVisitor drawVisitor;
        public MainGame mainGame;

        public MainGameFactory(Game1 baseGame)
        {
            this.baseGame = baseGame;
            initializeControlAdapter();
        }

        // drawvisitor


        public ContentManager content;
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public void initializeDrawVisitor(GraphicsDeviceManager graphics, SpriteBatch spriteBatch, ContentManager content)
        {
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.content = content;

            this.drawVisitor = new DrawVisitor(graphics, spriteBatch, content, this);
        }


        public DrawVisitor getDrawVisitor()
        {
            return this.drawVisitor;
        }

        // controlAdapter

        public ControlAdapter controlAdapter;

        public void initializeControlAdapter()
        {
            this.controlAdapter = new ControlAdapter(this);
        }

        public ControlAdapter getControlAdapter()
        {
            return this.controlAdapter;
        }



        // maingame

        public void initialiseMainGame()
        {
            this.mainGame = new MainGame(this);
        }

        public MainGame getMainGame()
        {
            return this.mainGame;
        }

        // Object Facotory


//MainCharacter
        public MainCharacter getMainCharacter(Position position) {
            MainCharacter mainCharacter = new MainCharacter(this, position);
            mainCharacter.setLooks(Color.Yellow);
            return mainCharacter;
        }

 // bullet
        public BulletList getBulletList()
        {
            return new BulletList(this);
        }

        public Bullet getBullet(MainCharacter mainCharacter, Position mousePos)
        {
            Position startPos = mainCharacter.getMiddle().copy();
            Position newPos = new Position(mousePos.x - startPos.x, mousePos.y - startPos.y);
            Bullet bullet = new Bullet(this, startPos);
            bullet.giveForce(newPos, 10);
            bullet.setLooks(Color.Black);
            return bullet;
        }

// target
        public TargetList getTargetList()
        {
            return new TargetList(this);
        }

        public Target getTarget(Position position)
        {
            Target target = new Target(this, position);
            target.setLooks(Color.Red);
            return target;
        }

    }
}
