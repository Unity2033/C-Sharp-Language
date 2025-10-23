#include <iostream>

using namespace std;

template <typename T>
class Stack
{
private:
    int highset;
    int capacity;

    T* container;
public:
    Stack()
    {
        highset = -1;
        capacity = 0;

        container = nullptr;
    }

    void resize(int newSize)
    {
        capacity = newSize;

        T* temporary = new T[capacity];

        for (int i = 0; i < capacity; i++)
        {
            temporary[i] = NULL;
        }

        for (int i = 0; i < highset + 1; i++)
        {
            temporary[i] = container[i];
        }

        delete[] container;

        container = temporary;
    }

    void push(T data)
    {
        if (capacity <= 0)
        {
            resize(1);
        }
        else if (highset + 1 >= capacity)
        {
            resize(capacity * 2);
        }

        container[++highset] = data;
    }

    void pop()
    {
        if (empty())
        {
            cout << "stack is empty" << endl;
        }
        else
        {
            container[highset--] = NULL;
        }

    }

    const bool& empty()
    {
        return  highset <= -1;
    }

    const int& size()
    {
        return highset + 1;
    }

    const T& top()
    {
        return container[highset];
    }

    ~Stack()
    {
        if (container != nullptr)
        {
            delete[] container;
        }
    }

};

int main()
{
    Stack<int> stack;

    stack.push(10);
    stack.push(20);
    stack.push(30);
    stack.push(40);
    stack.push(50);

    while (stack.empty() == false)
    {
        cout << stack.top() << endl;

        stack.pop();
    }

    cout << "Stack Size : " << stack.size() << endl;

    return 0;
}
