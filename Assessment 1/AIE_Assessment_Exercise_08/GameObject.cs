using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    abstract class GameObject
    {
        protected int xPos = 0;
        protected int yPos = 0;

        public GameObject()
        {

        }


        public abstract void Draw();
        

    }
}
