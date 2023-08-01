#include <iostream>
#include <vector>

#pragma region 그래프
    // 정점과 간선으로 이루어진 자료구조입니다.

	// 정점(Vertex) : 노드를 의미하며, 각 노드에는 데이터가 저장됩니다.

    // 간선(Edge) : 링크라고 하며, 노드간의 관계를 나타냅니다.

    // 차수(degree) : 무방향 그래프에서 하나의 정점에 인접한 정점의 수 

    // 진출 차수(out-degree) : 방향 그래프에서 사용되며, 한 노드에서 외부로 향하는 간선의 수

    // 진입 차수(in-degree) : 방향 그래프에서 사용되며, 외부 노드에서 들어오는 간선의 수 
#pragma endregion


int main()
{
#pragma region 인접 행렬
    // 그래프의 연결 관계를 이차원 배열로 나타내는 방식입니다.  

   //   int buffer[4][4] = { 0, };
   //   
   //   int vertex = 0;
   //   int edge = 0;
   //   
   //   int x, y = 0;
   //   
   //   // 1. vertex와 edge 값을 입력합니다.
   //   std::cout << "vectex를 입력해주세요." << std::endl;
   //   std::cin >> vertex;
   //   
   //   std::cout << "edge를 입력해주세요." << std::endl;
   //   std::cin >> edge;
   //   
   //   std::cout << "-----------------------------" << std::endl;
   //   
   //   // 2. edge 만큼 반복하면서 x와 y값을 입력할 수 있도록 설정합니다.
   //   for (int i = 0; i < edge; i++)
   //   {
   //       std::cout << "x의 값을 입력해주세요." << std::endl;
   //       std::cin >> x;
   //   
   //       std::cout << "y의 값을 입력해주세요." << std::endl;
   //       std::cin >> y;
   //   
   //       std::cout << "-----------------------------" << std::endl;
   //   
   //       buffer[x][y] = 1;
   //       buffer[y][x] = 1;
   //   }
   //   
   //   std::cout << "-----------------------------" << std::endl;
   //   
   //   for (int i = 0; i < 4; i++)
   //   {
   //       for (int j = 0; j < 4; j++)
   //       {
   //           std::cout << buffer[i][j];
   //       }
   //   
   //       std::cout << std::endl;
   //   }
   //   


#pragma endregion

#pragma region 인접 리스트
    // 그래프의 연결 관계를 vector의 배열(vector<int> data[])로 나타내는 배열입니다.

    int node = 0;
    int edge = 0;

    int x = 0;
    int y = 0;

    // 1. node와 edge 값을 입력합니다.
    std::cout << "node를 입력해주세요." << std::endl;
    std::cin >> node;
   
    std::cout << "edge를 입력해주세요." << std::endl;
    std::cin >> edge;

    std::vector<int> data[4];

    for (int i = 0; i < edge; i++)
    {
        std::cout << "x의 값을 입력해주세요." << std::endl;
        std::cin >> x;
    
        std::cout << "y의 값을 입력해주세요." << std::endl;
        std::cin >> y;
    
        std::cout << "-----------------------------" << std::endl;

        data[x].push_back(y);
        data[y].push_back(x);
    }

#pragma endregion



	return 0;
}

