namespace Program
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            #region BFS (너비 우선 탐색)

            AdjacencyList adjacencyList = new AdjacencyList(7);

            adjacencyList.InsertEdge(0, 1);
            adjacencyList.InsertEdge(0, 2);
            adjacencyList.InsertEdge(1, 3);
            adjacencyList.InsertEdge(1, 4);
            adjacencyList.InsertEdge(2, 5);
            adjacencyList.InsertEdge(2, 6);

            adjacencyList.BFS(0);

            #endregion

        }
    }
}