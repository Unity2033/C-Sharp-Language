#pragma once
#include <iostream>

// 1. ��� �����
struct NODE
{
	int data;
	NODE* next;
};

void AddNode(NODE* target, int data)
{
	// 1. NODE ����
	NODE* newNode = new NODE;

	// 2. ���ο� ����� data ���� �����մϴ�.
	newNode->data = data;

	// 3. ���ο� ����� next �����Ϳ� ���� ����� ���� �ּҸ� �����մϴ�.
	newNode->next = target->next;

	// 4. ���� ����� ���� �ּҿ� ���ο� ����� �ּҸ� �����մϴ�. 
	target->next = newNode;
}

void ShowNode(NODE* targetPtr)
{
	NODE* currentPtr = targetPtr;

	while (currentPtr != nullptr)
	{
		currentPtr = currentPtr->next;

		if (currentPtr != nullptr)
		{
			std::cout << currentPtr->data << std::endl;
		}
	}
}

void RemoveNode(NODE* target)
{
	// 1. ������ ����� �����͸� ������ ����
	NODE* deletePtr = target->next;

	// 2. target ����� Next�� �����Ǵ� ����� ���� �ּҷ� ����Ű�� �մϴ�.
	target->next = deletePtr->next;

	// 3. �ش� ��带 �����մϴ�.
	delete deletePtr;
}


void ReleaseNode(NODE* target)
{
	NODE* curPtr = target;

	while (curPtr != nullptr)
	{
		NODE* nextPtr = curPtr->next;

		delete curPtr;

		curPtr = nextPtr;
	}
}

int main()
{
	// ���� ���� ����Ʈ
	/*

	//           [dummy ���]
	NODE * dummy = new NODE;

	//           [node1 ���]
	NODE * node1 = new NODE;

	//           [node1 ���]
	NODE * node2 = new NODE;

	// 1. dummy�� next ������ <- node1�� ���� �ּ�
	dummy->next = node1;

	// 2. node1�� data ���� 10���� �ʱ�ȭ
	node1->data = 10;

	// 3. node1�� next ������ <- node2�� ���� �ּ�
	node1->next = node2;

	// 4. node2�� data ���� 20���� �ʱ�ȭ
	node2->data = 20;

	// 5. node2�� next �����ʹ� nullptr�� �����մϴ�.
	node2->next = nullptr;

	ShowNode(dummy);

	delete 	  dummy;
	delete 	  node1;
	delete 	  node2;
	*/

	// ���� ���� ����Ʈ (�Լ�)
	NODE* dummy = new NODE;

	dummy->next = nullptr;

	AddNode(dummy, 10);
	AddNode(dummy, 20);
	AddNode(dummy, 30);

	RemoveNode(dummy->next);
	// dummy->next

	ShowNode(dummy);

	ReleaseNode(dummy);
}

