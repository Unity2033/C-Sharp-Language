#pragma once
#include <iostream>

#define SIZE 4

template <typename T>
class CircleQueue
{
private:
	int front;
	int rear;
	T buffer[SIZE] = { 0, };
public:
	CircleQueue()
	{
		front = SIZE - 1;
		rear = SIZE - 1;
	}

	void Push(T data)
	{
		if (IsFull() == true)
		{
			std::cout << "Queue�� ���� á���ϴ�." << std::endl;
		}
		else
		{
			rear = (rear + 1) % SIZE;
			buffer[rear] = data;
		}
	}

	void Pop()
	{
		if (Empty() == true)
		{
			std::cout << "Queue�� ����ֽ��ϴ�." << std::endl;
		}
		else
		{
			front = (front + 1) % SIZE;
			buffer[front] = NULL;
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

	bool IsFull()
	{
		if (front == (rear + 1) % SIZE)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	T& Front()
	{
		return buffer[(front + 1) % SIZE];
	}

	T& Back()
	{
		return buffer[rear];
	}
};

int main()
{
#pragma region ���� ť
	// ���������δ� ���� ������ ������ ������, 
	// ť�� �������� ������ ������ ť�Դϴ�.

	CircleQueue<int> circleQueue;

	circleQueue.Push(10);
	circleQueue.Push(20);
	circleQueue.Push(30);

	// circleQueue.Push(40);

	circleQueue.Pop();
	circleQueue.Pop();
	circleQueue.Pop();

	circleQueue.Push(999);

	std::cout << circleQueue.Front() << std::endl;
	std::cout << circleQueue.Back() << std::endl;
#pragma endregion
}


