using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Magnet : IItem, IWaitTime
    {
        public void Use()
        {
            Console.WriteLine("Use Magnet");
        }

        public void Wait(float timer)
        {
            Console.WriteLine("wait Time : " + timer);

        }
    }
}
