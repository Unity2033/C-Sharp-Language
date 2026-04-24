using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Obstacle
{
    private int x;
    private int y;
    
    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;

        Console.SetCursorPosition(this.x, this.y);
    }

    public void Render()
    {
        Console.WriteLine("▣");
    }
}

