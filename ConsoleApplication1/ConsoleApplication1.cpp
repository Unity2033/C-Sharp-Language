#include <iostream>
#include <queue>


#define SIZE 5

template <typename T>
class LinearQueue
{
private :
	int front;
	int rear;
	int size;

	T array[SIZE];

public :
	LinearQueue()
	{
		front = 0;
		rear = 0;
		size = 0;
	}

	void Push(T data)
	{
		if (IsFull() == true)
		{
			std::cout << "Queue의 사이즈가 가득 찼습니다." << std::endl;
		}
		
		array[rear++] = data;

		size++;
	}

	void Pop()
	{
		if (Empty() == true)
		{
			std::cout << "Queue가 비어있습니다." << std::endl;
			exit(1);
		}

		array[front++] = NULL;

		size--;
	}

	int & Size()
	{
		return size;
	}

	T & Front()
	{
		return array[front];
	}

	T & Back()
	{
		return array[rear-1];
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
		if (SIZE <= rear)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
};

int main()
{
#pragma region 선형 큐
	// 배열의 공간에 들어간 데이터가 고정되어
	// 데이터를 빼내더라도 초기화하지 않으면
	// 원래 데이터가 있던 배열의 자리에 더 이상
	// 다른 것이 들어갈 수 없는 형태의 Queue입니다.

	LinearQueue<int> linearQueue;

	linearQueue.Push(10);
	linearQueue.Push(20);
	linearQueue.Push(30);
	linearQueue.Push(40);
	linearQueue.Push(50);

	linearQueue.Pop();
	linearQueue.Pop();	
	linearQueue.Pop();
	linearQueue.Pop();
	linearQueue.Pop();

	linearQueue.Push(9999);

	std::cout << linearQueue.Size() << std::endl;
	std::cout << linearQueue.Front() << std::endl;
	std::cout << linearQueue.Back() << std::endl;


#pragma endregion


}


