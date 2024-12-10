#include <iostream>

using namespace std;

template <typename T>
class SingleLinkedList
{
private:
    int size;

    struct Node
    {
        T data;
        Node * next;
    };

    Node * head;
public:
    SingleLinkedList()
    {
        size = 0;
        head = nullptr;
    }

    void PushFront(T data)
    {
        Node * newNode = new Node;

        if (head == nullptr)
        {
            head = newNode;

            head->data = data;
            head->next = nullptr;
        }
        else
        {
            newNode->data = data;
            newNode->next = head;

            head = newNode;
        }

        size++;

    }

    void PopFront()
    {
        if (head == nullptr)
        {
            cout << "Single Linked List is Empty" << endl;
        }
        else
        {
            Node * deleteNode = head;

            head = deleteNode->next;

            delete deleteNode;

            size--;
        }

    }

    void PushBack(T data)
    {
        Node * newNode = new Node;

        if (head == nullptr)
        {
            head = newNode;

            head->data = data;
            head->next = nullptr;
        }
        else
        {
            Node * currentNode = head;

            while (currentNode->next != nullptr)
            {
                currentNode = currentNode->next;
            }

            currentNode->next = newNode;

            newNode->data = data;
            newNode->next = nullptr;
        }

        size++;
    }

    void Show()
    {
        Node * currentNode = head;

        while (currentNode != nullptr)
        {
            cout << currentNode->data << " ";

            currentNode = currentNode->next;
        }
    }

    ~SingleLinkedList()
    {
        while (head != nullptr)
        {
            PopFront();
        }

    }
};

int main()
{
    SingleLinkedList<int> singleLinkedList;

    singleLinkedList.PushFront(10);
    singleLinkedList.PushFront(5);
    singleLinkedList.PushFront(1);

    singleLinkedList.PushBack(20);

    singleLinkedList.PopFront();

    singleLinkedList.Show();
}
