#include <iostream>

#pragma region 이진 탐색 트리 (BST)
        // 임의의 키를 가진 원소를 삽입, 삭제, 검색하는데
        // 효율적인 트리입니다.
struct Node
{
    int data;
    Node * left;
    Node * right;
};

Node * Insert(Node * root, int data)
{
    // if root가 nullptr 이라면?
    if (root == nullptr)
    {
        root = new Node;
        root->data = data;
        root->left = nullptr;
        root->right = nullptr;
    }
    // else if root의 data보다 작다면?
    else if (data <= root->data)
    {
        root->left = Insert(root->left, data);
    }
    // else root의 data보다 크다면?
    else
    {
        root->right = Insert(root->right, data);
    }

     // 주솟값을 반환합니다.
     // 0x000001ec9846a0e0
     return root;
}

int FindMax(Node * root)
{
    if (root == nullptr)
    {
        std::cout << "현재 데이터가 존재하지 않습니다." << std::endl;
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
        std::cout << "현재 데이터가 존재하지 않습니다." << std::endl;
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
        std::cout << "현재 데이터가 존재하지 않습니다." << std::endl;
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

