using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15th
{
    internal class AdjacencyList
    {
        // 그래프의 사이즈
        int size;

        // 그래프의 인접 리스트
        private List<int> [ ] adjacencyList;

        // 방문한 노드를 추적하기 위한 배열
        bool [] visited;

        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;

            visited = new bool[vertexSize];

            adjacencyList = new List<int>[vertexSize];

            for(int i = 0; i < vertexSize; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void InsertEdge(int vertex, int edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void Display()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write("adjacencyList[" + i + "] : ");

                for (int j = 0; j < adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + "->");
                }

                Console.WriteLine(" "); // <-
            }
        }

        public void BFS(int root)
        {
            // Queue 컬렉션을 선언합니다.
            Queue<int> queue = new Queue<int>();

            // Queue에 root 노드를 넣어줍니다.
            queue.Enqueue(root);

            // visited[root] true 설정
            visited[root] = true;

            // 1. Queue가 비어있을 때 까지 반복합니다.
            while (queue.Count != 0)
            {
                // 2. Queue에서 데이터를 뽑습니다.
                int index = queue.Dequeue();

                // 3. Queue에서 뽑은 데이터를 출력합니다.
                Console.Write(index + " ");

                // 4.반복문을 이용해서 자기와 인접한 노드를 Queue에 넣습니다.
                for (int i = 0; i < adjacencyList[index].Count; i++)
                {
                    if (visited[adjacencyList[index][i]] == false)
                    {
                        visited[adjacencyList[index][i]] = true;

                        queue.Enqueue(adjacencyList[index][i]);
                    }
                }
            }
        }

        public void DFS(int root)
        {
            // 현재 노드를 방문한 것으로 표시합니다.
            visited[root] = true;

            // 현재 노드를 출력합니다.
            Console.Write(root + " ");

            // 현재 노드와 연결된 방문하지 않은 노드를 재귀적으로 탐색합니다.
            foreach (int index in adjacencyList[root])
            {
                if (visited[index] == false)
                {
                    DFS(index);
                }
            }
        }
    }
}
