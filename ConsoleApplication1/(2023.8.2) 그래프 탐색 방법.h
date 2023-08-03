#pragma once
#include <iostream>
#include <vector>
#include <queue>

std::vector<int> bfsGraph[6];
std::vector<int> dfsGraph[6];

bool bfsCheck[6];
bool dfsCheck[6];

#pragma region BFS (너비 우선 탐색)
// 시작 노드를 방문한 후 시작 노드에 있는
// 인접한 모든 노드들을 탐색하는 방법입니다.
std::queue<int> queue;

void BFS(int start)
{
    // 1. Queue에 데이터를 삽입합니다.
    queue.push(start);

    // 2. 시작 노드의 방문을 체크합니다.
    bfsCheck[start] = true;

    // 3. Queue가 비어있지 않다면 반복합니다.
    while (queue.empty() == false)
    {
        // 4. Queue에 front값을 임시 변수에 저장합니다.
        int temp = queue.front();

        // 5. Queue에 데이터를 뺍니다.
        queue.pop();

        // 6. 임시 변수에 저장된 값을 출력합니다.
        std::cout << temp << " ";

        // 7. 해당 원소와 연결된, 아직 방문하지 않은 원소들을 Queue에 넣어줍니다.
        for (int i = 0; i < bfsGraph[temp].size(); i++)
        {
            int v = bfsGraph[temp][i];

            if (bfsCheck[v] == false)
            {
                queue.push(v);
                bfsCheck[v] = true;
            }
        }
    }
}


// 더 이상 방문하지 않은 노드가 없을 때까지 방문하지
// 않은 모든 노드에 대해서도 BFS를 적용합니다.

#pragma endregion



#pragma region DFS (깊이 우선 탐색)
     // 시작점부터 다음 경로로 넘어가기 전에
     // 해당 경로를 완벽하게 탐색하는 넘어가는 방법입니다. 

void DFS(int start)
{
    // 1. 시작 노드의 방문을 체크합니다.
    dfsCheck[start] = true;

    // 2. 노드의 값을 출력합니다.
    std::cout << start << " ";

    // 3. 반복문으로 이용해서 인접한 노드의 사이즈만큼 탐색합니다.

    for (int i = 0; i < dfsGraph[start].size(); i++)
    {
        int v = dfsGraph[start][i];

        // 방문하지 않은 노드가 있다면?
        if (dfsCheck[v] == false)
        {
            // 재귀함수를 호출합니다.
            DFS(v);
        }
    }
}

#pragma endregion




int main()
{
#pragma region BFS

    // bfsGraph[0]의 노드
    // bfsGraph[0].push_back(1);
    // bfsGraph[0].push_back(2);
    // 
    // // bfsGraph[1]의 노드
    // bfsGraph[1].push_back(0);
    // bfsGraph[1].push_back(3);
    // 
    // // bfsGraph[2]의 노드
    // bfsGraph[2].push_back(0);
    // bfsGraph[2].push_back(4);
    // bfsGraph[2].push_back(5);
    // 
    // // bfsGraph[3]의 노드
    // bfsGraph[3].push_back(1);
    // 
    // // bfsGraph[4]의 노드
    // bfsGraph[4].push_back(2);
    // 
    // // bfsGraph[5]의 노드
    // bfsGraph[5].push_back(2);
    // 
    // BFS(0);

#pragma endregion

#pragma region DFS

    // dfsGraph[0]의 노드
    dfsGraph[0].push_back(1);
    dfsGraph[0].push_back(2);
    dfsGraph[0].push_back(3);

    // dfsGraph[1]의 노드
    dfsGraph[1].push_back(0);
    dfsGraph[1].push_back(4);

    // dfsGraph[2]의 노드 
    dfsGraph[2].push_back(0);

    // dfsGraph[3]의 노드 
    dfsGraph[3].push_back(0);
    dfsGraph[3].push_back(5);

    // dfsGraph[4]의 노드
    dfsGraph[4].push_back(1);

    // dfsGraph[5]의 노드
    dfsGraph[5].push_back(3);

    DFS(0);
#pragma endregion




    return 0;
}

