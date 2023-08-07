#include <iostream>

#pragma region ���� ���� ����Ʈ
    // �ܼ� ���� ����Ʈ���� ������ ��尡
    // ����Ʈ�� ù ��° ��带 ����Ű�� ����Ʈ ������
    // �������� ���� ����Ʈ�Դϴ�.

struct Node
{
    int data;
    Node * next;
};

class CircleLinkedList
{
private :
    int count;

public:
    CircleLinkedList(int m_count = 1)
    { 
        count = m_count;
    };

    Node * Push_Front(Node* head, int data)
    {
        // 1. ���ο� ��带 �����մϴ�.
        Node * newNode = new Node;

        // 2. ���ο� ����� data ���� �����մϴ�.
        newNode->data = data;

        // 3. if(���࿡ head�� nullptr�̶��?)
        if (head == nullptr)
        {
            // head �����ʹ� ���ο� ����� �ּҸ� �����մϴ�.
            head = newNode;

            // ���ο� ����� next�� �ڱ� �ڽ��� �����Ѿ� �մϴ�.
            newNode->next = head;
        }
        else
        {
            // ���ο� ����� next�� head->next�� ����Ű�� �մϴ�.
            newNode->next = head->next;

            // head�� next�� ���ο� ��带 ����Ű�� �մϴ�.
            head->next = newNode;
        }

        return head;
    }

    Node * Push_Back(Node* head, int data)
    {
        // 1. ���ο� ��带 �����մϴ�.
        Node * newNode = new Node;

        // 2. ���ο� ����� data ���� �����մϴ�.
        newNode->data = data;

        // 3. if(���࿡ head�� nullptr�̶��?)
        if (head == nullptr)
        {
            // head �����ʹ� ���ο� ����� �ּҸ� �����մϴ�.
            head = newNode;

            // ���ο� ����� next�� �ڱ� �ڽ��� �����Ѿ� �մϴ�.
            newNode->next = head;
        }
        else      
        {
            // ���ο� ����� next�� head�� next ������ �����մϴ�.
            newNode->next = head->next;

            // head ����� next�� ���ο� ����� �ּҸ� ����ŵ�ϴ�.
            head->next = newNode;

            // head �����Ϳ� ���ο� ����� �ּҸ� �����մϴ�.
            head = newNode;
        }

        return head;
    }

    void Information(Node * head)
    {
        if (head == nullptr)
        {
            return;
        }

        Node* currentNode = head->next;  

        while (currentNode != head)
        {
            std::cout << currentNode->data << std::endl;
            currentNode = currentNode->next;
        }

        std::cout << currentNode->data << std::endl;
    }
};
#pragma endregion


int main()
{
    CircleLinkedList circleLinkedList;
   
    Node * head = nullptr;

    head = circleLinkedList.Push_Front(head, 20);
    head = circleLinkedList.Push_Front(head, 10);

    head = circleLinkedList.Push_Back(head, 30);

    circleLinkedList.Information(head);

    
	return 0;
}

