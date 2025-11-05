#include <iostream>

using namespace std;

template<typename T>
class Graph
{
private:
    struct Node
    {
        T data;
        Node * next;

        Node(T data, Node* link = nullptr)
        {
            this->data = data;
            next = link;
        }
    };

    int size; // 정점의 개수
    int count; // 인접 리스트의 크기
    int capacity; // 최대 용량

    T * vertex; // 정점의 집합
    Node ** list; // 인접 리스트

public:
    Graph()
    {
        size = 0;
        count = 0;
        capacity = 0;

        list = nullptr;
        vertex = nullptr;
    }

    void push(T data)
    {
        if (capacity <= 0)
        {
            resize(1);
        }
        else if (size >= capacity)
        {
            resize(capacity * 2);
        }

        vertex[size++] = data;
    }

    void resize(int newSize)
    {
        capacity = newSize;

        T* container = new T[capacity];

        for (int i = 0; i < capacity; i++)
        {
            container[i] = NULL;
        }

        for (int i = 0; i < size; i++)
        {
            container[i] = vertex[i];
        }

        delete[] vertex;

        vertex = container;
    }

    void edge(int i, int j)
    {
        if (size <= 0)
        {
            cout << "adjacency list is empty" << endl;
        }
        else if (i >= size || j >= size)
        {
            cout << "index out of range" << endl;
        }
        else
        {
            if (list == nullptr)
            {
                list = new Node * [size];

                for (int i = 0; i < size; i++)
                {
                    list[i] = nullptr;
                }

                count = size;
            }

            list[i] = new Node(vertex[j], list[i]);
            list[j] = new Node(vertex[i], list[j]);
        }

    }
};

int main()
{
    Graph<char> graph;

    graph.push('A');
    graph.push('B');
    graph.push('C');
    graph.push('D');

    graph.edge(1, 2);
    graph.edge(1, 3);

    graph.push('E');

    graph.edge(2, 4);

    return 0;
}
