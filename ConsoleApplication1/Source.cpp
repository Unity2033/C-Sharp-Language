#include <iostream>

#pragma region ���� Ž�� Ʈ�� (BST)
        // ������ Ű�� ���� ���Ҹ� ����, ����, �˻��ϴµ�
        // ȿ������ Ʈ���Դϴ�.
struct Node
{
    int data;
    Node * left;
    Node * right;
};

Node * Insert(Node * root, int data)
{
    // if root�� nullptr �̶��?
    if (root == nullptr)
    {
        root = new Node;
        root->data = data;
        root->left = nullptr;
        root->right = nullptr;
    }
    // else if root�� data���� �۴ٸ�?
    else if (data <= root->data)
    {
        root->left = Insert(root->left, data);
    }
    // else root�� data���� ũ�ٸ�?
    else
    {
        root->right = Insert(root->right, data);
    }

     // �ּڰ��� ��ȯ�մϴ�.
     // 0x000001ec9846a0e0
     return root;
}

int FindMax(Node * root)
{
    if (root == nullptr)
    {
        std::cout << "���� �����Ͱ� �������� �ʽ��ϴ�." << std::endl;
        return 0xcccccccc;
    }

    if (root->right == nullptr)
    {
        return root->data;
    }
    else
    {
        return FindMax(root->right);
    }
}

int FindMin(Node* root)
{
    if (root == nullptr)
    {
        std::cout << "���� �����Ͱ� �������� �ʽ��ϴ�." << std::endl;
        return 0xcccccccc;
    }

    if (root->left == nullptr)
    {
        return root->data;
    }
    else
    {
        return FindMin(root->left);
    }
}

Node * DeleteNode(Node* root, int key)
{
    if (root == nullptr)
    {
        std::cout << "���� �����Ͱ� �������� �ʽ��ϴ�." << std::endl;
        return root;
    }

    if (key < root->data)
    {
        root->left = DeleteNode(root->left, key);
    }
    else if (key > root->data)
    {
        root->right = DeleteNode(root->right, key);
    }

}


#pragma endregion


int main()
{
    Node * root = nullptr;
   
    root = Insert(root, 10); // 0x000001ec9846a080
    root = Insert(root, 5);  // 0x000001ec9846a080

    std::cout << FindMax(root) << std::endl;
    std::cout << FindMin(root) << std::endl;


	return 0;
}

