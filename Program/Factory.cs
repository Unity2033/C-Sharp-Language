using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Factory<T> where T : new()
{
    private int count;
    private T [ ] objects;

    public Factory(int size = 5)
    {
        objects = new T[size];
    }

    public T Instantiate()
    {
        if (count >= objects.Length)
        {
            Console.WriteLine("No more can be created");

            return default;
        }

        T clone = new();

        objects[count] = clone;

        return objects[count++];
        
    }
}

