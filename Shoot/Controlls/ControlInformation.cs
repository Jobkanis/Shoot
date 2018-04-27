using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    class ControlInformation
    {
        public Position mousePosition;
        public Boolean leftMouseButtonDown;
        public Boolean leftMouseButtonClick;
        public ControlInformation(Position mousePosition, Boolean leftMouseButtonDown, Boolean leftMouseButtonClick)
        {
            this.mousePosition = mousePosition;
            this.leftMouseButtonDown = leftMouseButtonDown;
            this.leftMouseButtonClick = leftMouseButtonClick;
        }
    }
}
