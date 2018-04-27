using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Shoot
{
    class ControlAdapter
    {
        ControlInformation previousInformation;
        MainGameFactory mainGameFactory;
        public ControlAdapter(MainGameFactory mainGameFactory)
        {
            this.mainGameFactory = mainGameFactory;
            getInformation();   
        }

        public ControlInformation getInformation()
        {
            MouseState current_mouse = Mouse.GetState();
            Position mousePosition = new Position(current_mouse.X, current_mouse.Y);
            Boolean holdLeft = current_mouse.LeftButton == ButtonState.Pressed;

            Boolean clickedLeft = false;
            if (this.previousInformation != null && holdLeft == true && !previousInformation.leftMouseButtonDown)
            {
                clickedLeft = true;
            }

            ControlInformation newInfo = new ControlInformation(mousePosition, holdLeft, clickedLeft);
            this.previousInformation = newInfo;
            return newInfo;

        }
    }
}
