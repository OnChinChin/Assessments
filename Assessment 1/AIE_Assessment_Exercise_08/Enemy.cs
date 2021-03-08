using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Enemy : Character
    {
        public Enemy() : base(20,20,10)
        {

        }
        
        public Enemy(int at, int hp, int df) : base(at, hp, df)
        {
            
        }
        public override void Draw()
        {
            if (HP > 10)
                Console.Write("O");
            else
                Console.Write("o");
        }
    }
}
