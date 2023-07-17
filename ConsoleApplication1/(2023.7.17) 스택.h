#pragma once
#include <iostream>
#include <stack>

#define SIZE 5

template <typename T>
class STACK
{
private:
	int top;
	T buffer[SIZE];

public:
	STACK()
	{
		top = -1;
	}

	void Push(T data)
	{
		if (IsFull())
		{
			std::cout << "STACK�� �����Ͱ� �� á���ϴ�." << std::endl;
		}
		else
		{
			buffer[++top] = data;
		}
	}

	T Pop()
	{
		if (Empty())
		{
			std::cout << "STACK�� �����Ͱ� ����ֽ��ϴ�." << std::endl;
			exit(1);
		}
		else
		{
			return buffer[top--];
		}
	}

	T Top()
	{
		if (Empty())
		{
			return 0;
		}
		else
		{
			return buffer[top];
		}
	}

	bool Empty()
	{
		// ����ִٸ� true�� ��ȯ�մϴ�.
		if (top <= -1)
		{
			return true;
		}
		else// ������� �ʴٸ� false�� ��ȯ�մϴ�.
		{
			return false;
		}
	}

	bool IsFull()
	{
		// ������ �� �� ������ true
		if (SIZE - 1 <= top)
		{
			return true;
		}
		else// �����Ͱ� �� �� ���� ������ false
		{
			return false;
		}
	}

	~STACK() { }
};

int main()
{
	STACK<char> intStack;

	intStack.Push('A');
	intStack.Push('B');
	intStack.Push('C');
	intStack.Push('D');

	while (intStack.Empty() == false)
	{
		std::cout << intStack.Top() << std::endl;
		intStack.Pop();
	}

	// intStack.Pop();
}