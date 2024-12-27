#include <iostream>

#define SIZE 10

using namespace std;

template <typename T>
class AdjacencyMatrix
{
private:
	int size; // 정점의 개수
	T vertex[SIZE];	// 정점의 집합
	int matrix[SIZE][SIZE];	// 인접 행렬

public:
	AdjacencyMatrix()
	{
		size = 0;

		for (int i = 0; i < SIZE; i++)
		{
			vertex[i] = NULL;

			for (int j = 0; j < SIZE; j++)
			{
				matrix[i][j] = NULL;
			}
		}
	}

	void Insert(T data)
	{
		if (size >= SIZE)
		{
			cout << "Adjacency Matrix Overflow" << endl;
		}
		else
		{
			vertex[size++] = data;
		}
	}

	void Connect(int i, int j)
	{
		if (size <= 0)
		{
			cout << "Adjancency Matrix is Empty" << endl;
		}
		else if (i >= size || j >= size)
		{
			cout << "Index Out of Range" << endl;
		}
		else
		{
			matrix[i][j] = 1;
			matrix[j][i] = 1;
		}

	}

	void Show()
	{
		if (size <= 0)
		{
			cout << "Adjacency Matrix is Empty" << endl;
		}
		else
		{
			cout << "  ";

			for (int i = 0; i < size; i++)
			{
				cout << vertex[i] << " ";
			}

			cout << endl;

			for (int i = 0; i < size; i++)
			{
				cout << vertex[i] << " ";

				for (int j = 0; j < size; j++)
				{
					cout << matrix[i][j] << " ";
				}

				cout << endl;
			}
		}
	}
};

int main()
{
	AdjacencyMatrix<char> adjacencyMatrix;

	adjacencyMatrix.Insert('A');
	adjacencyMatrix.Insert('B');
	adjacencyMatrix.Insert('C');
	adjacencyMatrix.Insert('D');

	adjacencyMatrix.Connect(0, 1);
	adjacencyMatrix.Connect(0, 2);
	adjacencyMatrix.Connect(1, 3);

	adjacencyMatrix.Show();

	return 0;
}
