#include <iostream>

#define SIZE 5

using namespace std;

template <typename T>
class Queue
{
private:
    int rear;
    int front;

    T container[SIZE];

public:
    Queue()
    {
        rear = 0;
        front = 0;

        for (int i = 0; i < SIZE; i++)
        {
            container[i] = NULL;
        }             
    }

};

int main()
{
    Queue<int> queue;


    return 0;
}
