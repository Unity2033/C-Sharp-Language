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

};

int main()
{
    Graph<int> graph;

    return 0;
}
