#include <iostream>

using namespace std;

template <typename T>
class Graph 
{
private:
    int size;     // 정점의 개수
    int count;    // 인접 행렬의 크기
    int capacity; // 최대 용량

    T * vertex;   // 정점의 집합
    int ** matrix; // 인접 행렬
public:
    Graph()
    {
        size = 0;
        count = 0;
        capacity = 0;

        vertex = nullptr;
        matrix = nullptr;
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

        T * container = new T[capacity];

        for (int i = 0; i < capacity; i++)
        {
            container[i] = NULL;
        }

        for (int i = 0; i < size; i++)
        {
            container[i] = vertex[i];
        }

        delete [ ] vertex;

        vertex = container;
    }

};

int main()
{
    Graph<char> graph;

    graph.push('A');
    graph.push('B');
    graph.push('C');


    return 0;
}
