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
		// 1. ���ο� ��带 �����մϴ�.
		NODE* newNode = new NODE;

		// 2. ���ο� ����� data ���� �����մϴ�. <- �Ű�������
		newNode->data = data;

		// 3. ���ο� ��� next ���� NULL�� �����մϴ�.
		newNode->next = nullptr;



	}

	void Push_Back(int data)
	{			
		// 1. ���ο� ��带 �����մϴ�.
		NODE* newNode = new NODE;

		// 2. ���ο� ����� data ���� �����մϴ�. <- �Ű�������
		newNode->data = data;

		// 3. ���ο� ��� next ���� NULL�� �����մϴ�.
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


