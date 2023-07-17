#pragma once
#include <iostream>

template <typename T>
struct NODE
{
	T data;
	NODE<T>* next;
	NODE<T>* prev;
};

template <typename T>
class DoubleLinkedList
{
private:
	NODE<T>* head;
	NODE<T>* tail;
public:

	DoubleLinkedList()
	{
		head = nullptr;
		tail = nullptr;
	}

	void Push_Front(T data)
	{
		NODE<T>* newNode = new NODE<T>;

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
		NODE<T>* newNode = new NODE<T>;

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
			NODE<T>* removePtr = head;

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
			NODE<T>* removePtr = tail;

			tail = tail->prev;

			tail->next = nullptr;

			delete removePtr;
		}
	}

	~DoubleLinkedList()
	{
		while (head != nullptr)
		{
			NODE<T>* removeNode = head;
			head = head->next;
			// head->prev = nullptr;

			delete removeNode;
		}
	}
};

int main()
{
	DoubleLinkedList<int> list;

	list.Push_Front(10);
}
