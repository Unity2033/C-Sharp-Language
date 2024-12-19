#include <iostream>

using namespace std;

struct Node
{
	int data;
	Node * left;
	Node * right;
};

Node * CreateNode(int data, Node * left, Node * right)
{
	Node * newNode = new Node();

	newNode->data = data;

	newNode->left = left;

	newNode->right = right;

	return newNode;

}

void Postorder(Node * root)
{
	if (root != nullptr)
	{
		Postorder(root->left);
		Postorder(root->right);
		cout << root->data << " ";
	}
}

int main()
{
	Node* node7 = CreateNode(7, nullptr, nullptr);
	Node* node6 = CreateNode(6, nullptr, nullptr);
	Node* node5 = CreateNode(5, nullptr, nullptr);
	Node* node4 = CreateNode(4, nullptr, nullptr);
	Node* node3 = CreateNode(3, node6, node7);
	Node* node2 = CreateNode(2, node4, node5);
	Node* node1 = CreateNode(1, node2, node3);

	Postorder(node1);

	return 0;
}
