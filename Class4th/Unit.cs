using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class Unit
    {
        int health;
        int attack;
        int defense;

        public virtual void Information()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("attack : " + attack);
            Console.WriteLine("defense : " + defense);
        }

        public abstract void Skill();
    }
}
