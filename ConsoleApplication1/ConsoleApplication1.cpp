#include <iostream>
#include <vector>

template <typename T>
class VECTOR
{
private :
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
		if (size => capacity)
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
		// capacity에 새로운 size값을 설정한다.
		capacity = size;

		// 새로운 포인터 변수를 생성해서 새롭게 만들어진
		// 메모리 공간을 가리키도록 설정합니다.
		T * tempArray = new T[size];

		// 새로운 메모리 공간의 값을 초기화합니다.
		for (int i = 0; i < size; i++)
		{
			tempArray[i] = NULL;
		}

		// 기존 배열에 있는 값을 복사해서 새로운 배열에 넣어줍니다.
		for (int i = 0; i < this->size; i++)
		{
			tempArray[i] = array[i];
		}
		
		// array에 메모리 주소를 해제합니다.
		delete array;
		
		// array에 새로 할당한 메모리의 주소를 저장합니다.
		array = tempArray;

	}

	int Size()
	{
		return size;
	}

	T & operator [ ] (const int & value)
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


