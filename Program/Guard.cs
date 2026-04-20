using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Guard : Soldier
    {
        public Guard()
        {
            health = 100;
            defense = 1;
        }

        public override void Attack()
        {
            Console.WriteLine("Guard Attack\n");
        }
    }
}
