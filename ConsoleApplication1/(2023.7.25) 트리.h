#pragma once
#include <iostream>

#pragma region Ʈ�� (TREE)
// �׷����� �������� ������ ������
// �̿��Ͽ� �������� ��ġ ���¸� �߻�ȭ�� �ڷᱸ���Դϴ�.

struct Node
{
    int data;
    Node* left;
    Node* right;
};

#pragma endregion

Node* CreateNode(int data, Node* leftChild, Node* rightChild)
{
    // ���ο� ��带 �����մϴ�.
    Node* newNode = new Node;

    // ����� data ���� �����մϴ�.
    newNode->data = data;

    // ����� leftChild ���� �����մϴ�.
    newNode->left = leftChild;

    // ����� rightChild ���� �����մϴ�.
    newNode->right = rightChild;

    // ����� �ּڰ��� ��ȯ�մϴ�.
    return newNode;
}

// ���� ��ȸ
void Preorder(Node* root)
{
    if (root != nullptr)
    {
        std::cout << root->data << " ";
        Preorder(root->left);
        Preorder(root->right);
    }
}

// ���� ��ȸ
void Inorder(Node* root)
{
    if (root != nullptr)
    {
        Inorder(root->left);
        std::cout << root->data << " ";
        Inorder(root->right);
    }
}

// ���� ��ȸ
void Postorder(Node* root)
{
    if (root != nullptr)
    {
        Postorder(root->left);
        Postorder(root->right);
        std::cout << root->data << " ";
    }
}

int main()
{
    // Ʈ���� ��ȸ
    Node* node7 = CreateNode(7, nullptr, nullptr);
    Node* node6 = CreateNode(6, nullptr, nullptr);
    Node* node5 = CreateNode(5, nullptr, nullptr);
    Node* node4 = CreateNode(4, nullptr, nullptr);
    Node* node3 = CreateNode(3, node6, node7);
    Node* node2 = CreateNode(2, node4, node5);
    Node* node1 = CreateNode(1, node2, node3);

    // Preorder(node1);

    // Inorder(node1);

    // Postorder(node1);

    return 0;
}