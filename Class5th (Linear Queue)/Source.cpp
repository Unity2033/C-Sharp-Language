#include <iostream>

#define SIZE 5

using namespace std;

template <typename T>
class LinearQueue
{
private:
	int size;
	int rear;
	int front;

	T container[SIZE];
public:
	LinearQueue()
	{
		size = 0;
		rear = 0;
		front = 0;

		for (int i = 0; i < SIZE; i++)
		{
			container[i] = NULL;
		}
	}

	void Push(T data)
	{
		if (rear >= SIZE)
		{
			cout << "Linear Queue Overflow" << endl;
		}
		else
		{
			container[rear++] = data;

			size++;
		}
	}

	void Pop()
	{
		if (Empty())
		{
			cout << "Linear Queue is Empty" << endl;
		}
		else
		{
			container[front++] = NULL;

			size--;
		}
	}

	bool Empty()
	{
		if (front == rear)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	const int& Size()
	{
		return size;
	}

	const T& Front()
	{
		if (Empty())
		{
			cout << "No Data Exists" << endl;

			exit(1);
		}
		else
		{
			return container[front];
		}
	}

	const T& Back()
	{
		if (Empty())
		{
			cout << "No Data Exists" << endl;

			exit(1);
		}
		else
		{
			return container[rear - 1];
		}
	}

};

int main()
{
	LinearQueue<int> linearQueue;

	linearQueue.Push(10);
	linearQueue.Push(20);
	linearQueue.Push(30);
	linearQueue.Push(40);
	linearQueue.Push(50);

	cout << "Linear Queue의 크기 : " << linearQueue.Size() << endl;

	while (linearQueue.Empty() == false)
	{
		cout << linearQueue.Front() << " ";

		linearQueue.Pop();
	}

	linearQueue.Push(99);

	return 0;
}
