#pragma once
#include <iostream>
#include <vector>

template <typename T>
class VECTOR
{
private:
	int capacity = 0;
	int size = 0;

	T* array;

public:
	VECTOR()
	{
		capacity = 1;
		array = new T[capacity];
	}

	void Push_Back(T data)
	{
		if (size >= capacity)
		{
			capacity = capacity * 2;

			Resize(capacity);
		}

		array[size++] = data;
	}

	void Pop_Back()
	{
		if (size <= 0)
		{
			return;
		}

		array[--size] = NULL;
	}

	void Resize(int size)
	{
		// capacity�� ���ο� size���� �����Ѵ�.
		capacity = size;

		// ���ο� ������ ������ �����ؼ� ���Ӱ� �������
		// �޸� ������ ����Ű���� �����մϴ�.
		T* tempArray = new T[size];

		// ���ο� �޸� ������ ���� �ʱ�ȭ�մϴ�.
		for (int i = 0; i < size; i++)
		{
			tempArray[i] = NULL;
		}

		// ���� �迭�� �ִ� ���� �����ؼ� ���ο� �迭�� �־��ݴϴ�.
		for (int i = 0; i < this->size; i++)
		{
			tempArray[i] = array[i];
		}

		// array�� �޸� �ּҸ� �����մϴ�.
		delete array;

		// array�� ���� �Ҵ��� �޸��� �ּҸ� �����մϴ�.
		array = tempArray;

	}

	int Size()
	{
		return size;
	}

	T& operator [ ] (const int& value)
	{
		return array[value];
	}

	~VECTOR()
	{
		delete array;
	}
};

int main()
{

}


