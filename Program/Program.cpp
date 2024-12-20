#include <iostream>

#define SIZE 8

using namespace std;

template <typename T>
class Heap
{
private:
	int index;

	T container[SIZE];
public:
	Heap()
	{
		index = 0;

		for (int i = 0; i < SIZE; i++)
		{
			container[i] = NULL;
		}
	}

	void Insert(T data)
	{
		if (index + 1 >= SIZE)
		{
			cout << "Heap Overflow" << endl;
		}						    
		else
		{
			container[++index] = data;

			int child = index;
			int parent = child / 2;

			while (child > 1)
			{
				if (container[parent] < container[child])
				{
					std::swap(container[parent], container[child]);
				}

				child = parent;
				parent = child / 2;
			}
		}
	}

	const T & Remove()
	{
		if (index <= 0)
		{
			cout << "Heap is Empty" << endl;

			exit(0);
		}
		
		T result = container[1];

		container[1] = container[index];

		container[index--] = NULL;
	}

	void Show()
	{
		for (int i = 1; i <= index; i++)
		{
			cout << container[i] << " ";
		}
	}
};

int main()
{
	Heap<int> heap;

	heap.Insert(12);
	heap.Insert(10);
	heap.Insert(22);
	heap.Insert(30);

	heap.Show();

	return 0;
}
