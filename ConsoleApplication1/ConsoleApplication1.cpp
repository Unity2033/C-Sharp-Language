#include <iostream>

struct NODE
{
	int data;
	NODE * next;
	NODE * prev;
};

template <typename T>
class DoubleLinkedList
{
private :
	NODE * head;
	NODE * tail;
public :

	DoubleLinkedList()
	{
		head = nullptr;
		tail = nullptr;
	}

	void Push_Front(T data)
	{
		NODE * newNode = new NODE;

		newNode->data = data;

		newNode->next = nullptr;

		newNode->prev = nullptr;

		if (head == nullptr)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			newNode->next = head;

			head->prev = newNode;

			head = newNode;
		}
	}

	void Push_Back(T data)
	{
		NODE* newNode = new NODE;

		newNode->data = data;

		newNode->next = nullptr;

		newNode->prev = nullptr;

		if (head == nullptr)
		{
			head = newNode;
			tail = newNode;
		}
		else
		{
			newNode->prev = tail;

			tail->next = newNode;

			tail = newNode;
		}

	}

	void Pop_Front()
	{
		if (head == nullptr)
		{
			return;
		}
		else
		{
			NODE* removePtr = head;

			head = head->next;

			head->prev = nullptr;

			delete removePtr;
		}
	}

	void Pop_Back()
	{
		if (head == nullptr)
		{
			return;
		}
		else
		{
			NODE* removePtr = tail;

			tail = tail->prev;

			tail->next = nullptr;

			delete removePtr;
		}
	}

	~DoubleLinkedList()
	{

	}
};

int main()
{
	DoubleLinkedList<int> list;

	list.Push_Front(10);



}


