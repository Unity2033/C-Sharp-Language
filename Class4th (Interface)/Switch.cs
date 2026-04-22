using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Switch : ISelectable, IActivatable
{
    private bool power;

    public void Activate()
    {
        power = !power;

        if(power)
        {
            Console.WriteLine("The Room Light is on");
        }
        else
        {
            Console.WriteLine("The Room Light is off");
        }
    }

    public void Select()
    {
        Console.WriteLine("Select the Switch...");
    }
}

