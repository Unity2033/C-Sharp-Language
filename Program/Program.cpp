#include <iostream>

using namespace std;

template <typename T>
class Stack
{
private:
    int highset;
    int capacity;

    T * container;
public:
    Stack()
    {
        highset = -1;
        capacity = 0;

        container = nullptr;
    }

};

int main()
{

    return 0;
}
