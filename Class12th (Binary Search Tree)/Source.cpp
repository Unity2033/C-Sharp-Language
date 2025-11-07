#include <iostream>

using namespace std;

template <typename T>
class Set
{
private:
	struct Node
	{
		T data;

		Node* left = nullptr;
		Node* right = nullptr;

		Node(T data)
		{
			this->data = data;
		}
	};

	Node* root;
public:
	Set()
	{
		root = nullptr;
	}

	void insert(T data)
	{
		Node* newNode = new Node(data);

		if (root == nullptr)
		{
			root = newNode;
		}
		else
		{
			Node* currentNode = root;

			while (currentNode != nullptr)
			{
				if (currentNode->data == data)
				{
					delete newNode;

					return;
				}
				else if (currentNode->data > data)
				{
					if (currentNode->left == nullptr)
					{
						currentNode->left = newNode;

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
						currentNode->right = newNode;

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

	void release(Node* root)
	{
		if (root != nullptr)
		{
			release(root->left);

			release(root->right);

			delete root;
		}
	}

	void erase(T data)
	{
		Node* currentNode = root;
		Node* parentNode = nullptr;

		while (currentNode != nullptr && currentNode->data != data)
		{
			parentNode = currentNode;

			if (currentNode->data > data)
			{
				currentNode = currentNode->left;
			}
			else
			{
				currentNode = currentNode->right;
			}
		}

		if (currentNode == nullptr)
		{
			cout << "the data does not exist" << endl;
		}
		else if (currentNode->left == nullptr && currentNode->right == nullptr)
		{
			if (parentNode != nullptr)
			{
				if (parentNode->left == currentNode)
				{
					parentNode->left = nullptr;
				}
				else
				{
					parentNode->right = nullptr;
				}
			}
			else
			{
				root = nullptr;
			}
		}
		else if (currentNode->left == nullptr || currentNode->right == nullptr)
		{
			if (currentNode == root)
			{
				if (currentNode->left != nullptr)
				{
					root = currentNode->left;
				}
				else
				{
					root = currentNode->right;
				}
			}
			else
			{
				Node* childNode = nullptr;

				if (currentNode->left != nullptr)
				{
					childNode = currentNode->left;
				}
				else
				{
					childNode = currentNode->right;
				}

				if (parentNode->left == currentNode)
				{
					parentNode->left = childNode;
				}
				else
				{
					parentNode->right = childNode;
				}
			}
		}
		else
		{
			Node* childNode = currentNode->right;
			Node* traceNode = currentNode;

			while (childNode->left != nullptr)
			{
				traceNode = childNode;

				childNode = childNode->left;
			}

			currentNode->data = childNode->data;

			if (traceNode == currentNode)
			{
				traceNode->right = childNode->right;
			}
			else
			{
				traceNode->left = childNode->right;
			}

			delete childNode;

			return;
		}

		delete currentNode;
	}

	void inorder(Node* root, ostream& ostream) const
	{
		if (root != nullptr)
		{
			inorder(root->left, ostream);

			ostream << root->data << " ";

			inorder(root->right, ostream);
		}
	}

	friend ostream& operator << (ostream& ostream, const Set<T>& set)
	{
		set.inorder(set.root, ostream);

		return ostream;
	}

	~Set()
	{
		release(root);
	}
};

int main()
{
	Set<int> set;

	set.insert(10);
	set.insert(17);
	set.insert(15);
	set.insert(20);
	set.insert(16);

	set.erase(17);

	cout << set << endl;

	return 0;
}