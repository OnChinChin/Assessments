using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    abstract class Character : GameObject
    {
        protected int AT = 0;
        protected int HP = 0;
        protected int DF = 0;

        public Character(int at, int hp, int df) : base()
        {
            this.AT = at;
            this.HP = hp;
            this.DF = df;
        }

        public bool IsAlive()
        {
            return HP > 0; 
        }
       
    }
}
