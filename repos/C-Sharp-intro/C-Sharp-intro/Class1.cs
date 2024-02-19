using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_intro
{
    internal class Class1
    {
        public string name = "HUNTER";
        public int health = 69;
        private int power = 70;

        public void setHealth(int x) { 
            health = x; 
        }

        public int getPower()
        {
            return power;
        }

        public void setPower(int x)
        {
            power = x;
        }
    }
}
