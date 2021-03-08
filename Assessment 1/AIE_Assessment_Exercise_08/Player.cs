using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Player : Character
    {

        public Player() : base(100,20,30)
        {

        }
        public override void Draw()
        {
            Console.Write("X");
        }

    }
}
