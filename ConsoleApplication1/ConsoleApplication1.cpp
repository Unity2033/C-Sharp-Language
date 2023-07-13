#include <iostream>

struct NODE
{
	int data;
	NODE* next;
};

class LinkedList
{
private :
	NODE * head;
	NODE * tail;

	int size;
public :

	LinkedList()
	{
		head = nullptr;
		tail = nullptr;

		size = 0;
	}

	void Push_Front(int data)
	{
		// 1. 새로운 노드를 생성합니다.
		NODE* newNode = new NODE;

		// 2. 새로운 노드의 data 값을 저장합니다. <- 매개변수로
		newNode->data = data;

		// 3. 새로운 노드 next 값은 NULL로 저장합니다.
		newNode->next = nullptr;



	}

	void Push_Back(int data)
	{			
		// 1. 새로운 노드를 생성합니다.
		NODE* newNode = new NODE;

		// 2. 새로운 노드의 data 값을 저장합니다. <- 매개변수로
		newNode->data = data;

		// 3. 새로운 노드 next 값은 NULL로 저장합니다.
		newNode->next = nullptr;

	}

	void Insert(NODE* prevNode, int data)
	{

	}

	void Pop_Back()
	{

	}

	void Pop_Front()
	{

	}

	int Size()
	{
		return size;
	}

	~LinkedList()
	{

	}
};

int main()
{
	LinkedList list;

	list.Push_Back(10);
	
}


