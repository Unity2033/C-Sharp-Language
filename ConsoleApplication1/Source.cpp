#include <iostream>

#define SIZE 10

int quickArray[SIZE] = { 4,1,2,3,9,7,8,6,10,5 };

//                �迭	     	  0         9
void QuickSort(int data [], int start, int end)
{
	// ���Ұ� 1�� ���� ���
	if (start >= end)
	{
		return;
	}

	int pivot = start;
	int left = start + 1;
	int right = end;

	while (left <= right)
	{
		// left�� end���� �۰ų� ���ٸ� �ݺ�
		// ���ʿ� �ִ� left������ pivot�� ���մϴ�.
		while (left <= end && quickArray[left] < quickArray[pivot])
		{
			left++;
		}

		// right�� start���� ũ�ٸ�
		// �����ʿ� �ִ� right ������ pivot�� ���մϴ�.
		while (right > start && quickArray[right] > quickArray[pivot])
		{
			right--;
		}

		// if ���ʰ� ������ �������� ��
		if(left > right)
		{ 
			std::swap(quickArray[pivot], quickArray[right]);
		}
		else // else right�� left�� ���� ��ȯ�մϴ�.
		{
			std::swap(quickArray[left], quickArray[right]);
		}
	}

	QuickSort(quickArray, start, right - 1);
	QuickSort(quickArray, right + 1, end);
}


struct Node
{
	int key;
	int value;

	Node * next;
};

struct Bucket
{
	Node * head;
	int count;
};

class HashTable
{
private :
	Bucket bucket[5];

public :
	HashTable()
	{
		for (int i = 0; i < 5; i++)
		{
			bucket[i].count = 0;
			bucket[i].head = nullptr;
		}
	}

	Node * CreateNode(int key, int value)
	{
		// 1. ���ο� ��带 �����մϴ�.
		Node * newNode = new Node;

		// 2. ���ο� ����� key���� �����մϴ�.
		newNode->key = key;

		// 3. ���ο� ����� value ���� �����մϴ�.
		newNode->value = value;

	    // 4. ���ο� ����� next�� ���� �ʱ�ȭ�մϴ�.
		newNode->next = nullptr;

		// 5. ���ο� ����� �ּ� ���� ��ȯ�մϴ�.
		return newNode;
	}

	int HashFunction(int key)
	{
		return key % 5;
	}

	void Insert(int key, int value)
	{
		 // �ؽ� ���� �޴� ����
		 int hashIndex = HashFunction(key);

		 // ���ο� ��带 �����մϴ�.
		 Node* newNode = CreateNode(key, value);

		 // ��尡 1�� �� �������� ������
		 if (bucket[hashIndex].count == 0)
		 {

		 }
		 // ��尡 1�� �� �����ϸ�
		 else
		 {

		 }
	}

	void Remove(int key)
	{

	}

	void Search(int key)
	{

	}
};

int main()
{
#pragma region �� ���� 
	// �������� ȹ���� ���� �ش� �������� �������� �迭�� ������ 
	// �� �ʿ��� ���������� ���� �׸���� ��ġ�ϰ� �ٸ� �ʿ��� ���������� ū �׸���� ��ġ�Ѵ�.
	//	QuickSort(quickArray, 0, SIZE - 1);
	//	
	//	
	//	for (int i = 0; i < SIZE; i++)
	//	{
	//		std::cout << quickArray[i] << " ";
	//	}
	// �������� ���� �迭�� ���� ��������� �� ������ ȣ���Ͽ�,
	// ��� �迭�� �⺻ �迭(��Ұ� �ϳ����� �迭)�� �� ������ �ݺ��ϴ� �˰����Դϴ�.


#pragma endregion

#pragma region �ؽ� ���̺�
	  // (Key, Value)�� �����͸� �����ϴ� �ڷᱸ�� �� �ϳ���
	  // ������ �����͸� �˻��� �� �ִ� �ڷᱸ���Դϴ�.

	  // �ؽ� ���̺��� ��� �ð� ���⵵�� O(1)�Դϴ�.

	  // �ؽ� �浹�� �ذ��ϴ� ���
	  
	  // ü�̴� ���
	  // �� �ؽ� ��Ŷ�� ���Ḯ��Ʈ�� �����ϴ� ����Դϴ�.

	  



	  // �ؽ� �浹 �߻� �� ������ �ؽ� ���� �ش��ϴ� �����͵���
	  // ���Ḯ��Ʈ�� �����Ͽ� �����մϴ�. 

	  // ���� �ּҹ� 
	  /*
	  // �浹 �߻� �� �� ���Ͽ� �����͸� �����ϴ� ����Դϴ�.
	  
	  // �� ��Ŷ�� ��� ������ ���� ���� ���� ����� �޶����ϴ�.

	  // ���� Ž�� : �浹 �߻� �� �տ��� ���� ���ʴ�� �� ��Ŷ��
	  // ã�� ���� �����ϴ� ����Դϴ�.

	  // ���� Ž�� : �浹 �߻� �� 2^, 2^3��ŭ ������ �� ��Ŷ�� ã��
	  // ���� �����ϴ� ����Դϴ�.

	  // ���� �ؽ� : �ؽ� ���� �ѹ� �� �ؽ� �Լ��� �־� �ٸ� �ؽð���
	  // �����ϴ� ����Դϴ�.
	  */

#pragma endregion



	return 0;
}

