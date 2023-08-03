#pragma once
#include <iostream>
#include <vector>
#include <queue>

std::vector<int> bfsGraph[6];
std::vector<int> dfsGraph[6];

bool bfsCheck[6];
bool dfsCheck[6];

#pragma region BFS (�ʺ� �켱 Ž��)
// ���� ��带 �湮�� �� ���� ��忡 �ִ�
// ������ ��� ������ Ž���ϴ� ����Դϴ�.
std::queue<int> queue;

void BFS(int start)
{
    // 1. Queue�� �����͸� �����մϴ�.
    queue.push(start);

    // 2. ���� ����� �湮�� üũ�մϴ�.
    bfsCheck[start] = true;

    // 3. Queue�� ������� �ʴٸ� �ݺ��մϴ�.
    while (queue.empty() == false)
    {
        // 4. Queue�� front���� �ӽ� ������ �����մϴ�.
        int temp = queue.front();

        // 5. Queue�� �����͸� ���ϴ�.
        queue.pop();

        // 6. �ӽ� ������ ����� ���� ����մϴ�.
        std::cout << temp << " ";

        // 7. �ش� ���ҿ� �����, ���� �湮���� ���� ���ҵ��� Queue�� �־��ݴϴ�.
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


// �� �̻� �湮���� ���� ��尡 ���� ������ �湮����
// ���� ��� ��忡 ���ؼ��� BFS�� �����մϴ�.

#pragma endregion



#pragma region DFS (���� �켱 Ž��)
     // ���������� ���� ��η� �Ѿ�� ����
     // �ش� ��θ� �Ϻ��ϰ� Ž���ϴ� �Ѿ�� ����Դϴ�. 

void DFS(int start)
{
    // 1. ���� ����� �湮�� üũ�մϴ�.
    dfsCheck[start] = true;

    // 2. ����� ���� ����մϴ�.
    std::cout << start << " ";

    // 3. �ݺ������� �̿��ؼ� ������ ����� �����ŭ Ž���մϴ�.

    for (int i = 0; i < dfsGraph[start].size(); i++)
    {
        int v = dfsGraph[start][i];

        // �湮���� ���� ��尡 �ִٸ�?
        if (dfsCheck[v] == false)
        {
            // ����Լ��� ȣ���մϴ�.
            DFS(v);
        }
    }
}

#pragma endregion




int main()
{
#pragma region BFS

    // bfsGraph[0]�� ���
    // bfsGraph[0].push_back(1);
    // bfsGraph[0].push_back(2);
    // 
    // // bfsGraph[1]�� ���
    // bfsGraph[1].push_back(0);
    // bfsGraph[1].push_back(3);
    // 
    // // bfsGraph[2]�� ���
    // bfsGraph[2].push_back(0);
    // bfsGraph[2].push_back(4);
    // bfsGraph[2].push_back(5);
    // 
    // // bfsGraph[3]�� ���
    // bfsGraph[3].push_back(1);
    // 
    // // bfsGraph[4]�� ���
    // bfsGraph[4].push_back(2);
    // 
    // // bfsGraph[5]�� ���
    // bfsGraph[5].push_back(2);
    // 
    // BFS(0);

#pragma endregion

#pragma region DFS

    // dfsGraph[0]�� ���
    dfsGraph[0].push_back(1);
    dfsGraph[0].push_back(2);
    dfsGraph[0].push_back(3);

    // dfsGraph[1]�� ���
    dfsGraph[1].push_back(0);
    dfsGraph[1].push_back(4);

    // dfsGraph[2]�� ��� 
    dfsGraph[2].push_back(0);

    // dfsGraph[3]�� ��� 
    dfsGraph[3].push_back(0);
    dfsGraph[3].push_back(5);

    // dfsGraph[4]�� ���
    dfsGraph[4].push_back(1);

    // dfsGraph[5]�� ���
    dfsGraph[5].push_back(3);

    DFS(0);
#pragma endregion




    return 0;
}

