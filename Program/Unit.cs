using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Unit
    {
        protected int health;
        protected int defense;

        public abstract void Attack(); 
    }
}
