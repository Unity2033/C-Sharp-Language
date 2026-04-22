using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Clock : ISelectable, IActivatable
{
    public void Activate()
    {
        Console.WriteLine("Current Time : " + DateTime.Now.ToString("HH:mm:ss"));
    }

    public void Select()
    {
        Console.WriteLine("The Clock is running");
    }
}

