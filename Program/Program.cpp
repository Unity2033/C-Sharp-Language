#include <iostream>

using namespace std;

template <typename T>
class BinarySearchTree
{
private:
	struct Node
	{
		T data;

		Node* left;
		Node* right;
	};

	Node * root;
public:
	BinarySearchTree()
	{
		root = nullptr;
	}

	bool Find(T data)
	{
		Node * currentNode = root;

		if (currentNode == nullptr)
		{
			return false;
		}
		else
		{
			while (currentNode != nullptr)
			{
				if (currentNode->data == data)
				{
					return true;
				}
				else
				{
					if (currentNode->data > data)
					{
						currentNode = currentNode->left;
					}
					else
					{
						currentNode = currentNode->right;
					}
				}
			}

			return false;
		}
	}

	void Insert(T data)
	{
		if (root == nullptr)
		{
			root = CreateNode(data);
		}
		else
		{
			Node * currentNode = root;

			while (currentNode != nullptr)
			{
				if (currentNode->data == data)
				{
					return;
				}
				else if (currentNode->data > data)
				{
					if (currentNode->left == nullptr)
					{
						currentNode->left = CreateNode(data);
						break;
					}
					else
					{
						currentNode = currentNode->left;
					}
				}
				else
				{
					if (currentNode->right == nullptr)
					{
						currentNode->right = CreateNode(data);

						break;
					}
					else
					{
						currentNode = currentNode->right;
					}
				}
			}

		}

	}

	void Inorder(Node * root)
	{
		if (root != nullptr)
		{
			Inorder(root->left);
			cout << root->data << " ";
			Inorder(root->right);
		}
	}

	void Destroy(Node * root)
	{
		if (root != nullptr)
		{
			Destroy(root->left);

			Destroy(root->right);

			delete root;
		}
	}

	Node * Root()
	{
		return root;
	}

	Node * CreateNode(T data)
	{
		Node * newNode = new Node;

		newNode->data = data;

		newNode->left = nullptr;

		newNode->right = nullptr;

		return newNode;
	}

	~BinarySearchTree()
	{
		Destroy(root);
	}
};


int main()
{
	BinarySearchTree<int> binarySearchTree;

	binarySearchTree.Insert(10);
	binarySearchTree.Insert(15);
	binarySearchTree.Insert(6);
	binarySearchTree.Insert(7);

	cout << binarySearchTree.Find(15) << endl;

	binarySearchTree.Inorder(binarySearchTree.Root());

	return 0;
}
