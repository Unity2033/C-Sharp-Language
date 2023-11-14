using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Missile : IItem
    {
        public void Use()
        {
            Console.WriteLine("Use Missile");
        }
    }

}
