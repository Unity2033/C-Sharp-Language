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

    void resize()
    {
        int ** newMatrix = new int * [size];

        for (int i = 0; i < size; i++)
        {
            newMatrix[i] = new int[size] {0};
        }

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                newMatrix[i][j] = matrix[i][j];
            }
        }

        for (int i = 0; i < count; i++)
        {
            delete [ ] matrix[i];
        }

        delete [ ] matrix;

        matrix = newMatrix;

        count = size;
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

    void edge(int i, int j)
    {
        if (size <= 0)
        {
            cout << "adjacency matrix is empty" << endl;
        }
        else if (i >= size || j >= size)
        {
            cout << "index out of range" << endl;
        }                                        
        else
        {
            if (matrix == nullptr)
            {
                count = size;

                matrix = new int * [size];

                for (int i = 0; i < size; i++)
                {
                    matrix[i] = new int[size];

                    for (int j = 0; j < size; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            else if (count < size)
            {
                resize();
            }
        }

        matrix[i][j] = 1;
        matrix[j][i] = 1;
    }

    ~Graph()
    {
        for (int i = 0; i < count; i++)
        {
            delete [ ] matrix[i];
        }

        delete [ ] matrix;

        delete [ ] vertex;
    }

};

int main()
{
    Graph<char> graph;

    graph.push('A');
    graph.push('B');
    graph.push('C');

    graph.edge(0, 1);
    graph.edge(1, 2);
   
    graph.push('D');

    graph.edge(0, 3);

    return 0;
}
