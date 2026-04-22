using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Frame : ISelectable
{
    public void Select()
    {
        Console.WriteLine("examine the frame...");
    }
}
