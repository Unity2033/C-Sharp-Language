#pragma once
#include <iostream>

#define SIZE 10

int quickArray[SIZE] = { 4,1,2,3,9,7,8,6,10,5 };

//                배열	     	  0         9
void QuickSort(int data[], int start, int end)
{
	// 원소가 1개 있을 경우
	if (start >= end)
	{
		return;
	}

	int pivot = start;
	int left = start + 1;
	int right = end;

	while (left <= right)
	{
		// left가 end보다 작거나 같다면 반복
		// 왼쪽에 있는 left변수를 pivot과 비교합니다.
		while (left <= end && quickArray[left] < quickArray[pivot])
		{
			left++;
		}

		// right가 start보다 크다면
		// 오른쪽에 있는 right 변수를 pivot과 비교합니다.
		while (right > start && quickArray[right] > quickArray[pivot])
		{
			right--;
		}

		// if 왼쪽과 오른쪽 엇갈렸을 때
		if (left > right)
		{
			std::swap(quickArray[pivot], quickArray[right]);
		}
		else // else right와 left의 값을 교환합니다.
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

	Node* next;
};

struct Bucket
{
	Node* head;
	int count;
};

class HashTable
{
private:
	Bucket bucket[5];

public:
	HashTable()
	{
		for (int i = 0; i < 5; i++)
		{
			bucket[i].count = 0;
			bucket[i].head = nullptr;
		}
	}

	Node* CreateNode(int key, int value)
	{
		// 1. 새로운 노드를 생성합니다.
		Node* newNode = new Node;

		// 2. 새로운 노드의 key값을 저장합니다.
		newNode->key = key;

		// 3. 새로운 노드의 value 값을 저장합니다.
		newNode->value = value;

		// 4. 새로운 노드의 next의 값을 초기화합니다.
		newNode->next = nullptr;

		// 5. 새로운 노드의 주소 값을 반환합니다.
		return newNode;
	}

	int HashFunction(int key)
	{
		return key % 5;
	}

	void Insert(int key, int value)
	{
		// 해시 함수를 통해서 값을 받는 임시 변수
		int hashIndex = HashFunction(key);

		// 새로운 노드를 생성합니다.
		Node* newNode = CreateNode(key, value);

		// 노드가 1개 라도 존재하지 않으면
		if (bucket[hashIndex].count == 0)
		{
			// 1. bucket[hashIndex]의 head 포인터에 새로운 노드의 주솟값을 저장합니다.
			bucket[hashIndex].head = newNode;

			// 2. bucket[hashIndex]의 count 변수의 값을 증가합니다.
			bucket[hashIndex].count++;
		}
		// 노드가 1개 라도 존재하면
		else
		{
			// 1. newNode의 next에 bucket[hashIndex]의 head의 값을 넣어줍니다.
			newNode->next = bucket[hashIndex].head;

			// 2. bucket[hashIndex].head를 방금 새로 생성한 node의 주소를 가리키도록 설정합니다.
			bucket[hashIndex].head = newNode;

			// 3. bucket[hashIndex]의 count 변수의 값을 증가합니다.
			bucket[hashIndex].count++;
		}
	}

	void Remove(int key)
	{
		// 해시 함수를 통해서 값을 받는 임시 변수
		int hashIndex = HashFunction(key);

		// Node를 탐색할 수 있는 순회용 포인터 변수 선언 <- 각 bucket의 head값을 저장합니다.
		Node* currentNode = bucket[hashIndex].head;

		Node* traceNode = nullptr;

		// currentNode가 nullptr이라는 함수를 종료합니다.
		if (currentNode == nullptr)
		{
			printf("현재 노드가 존재하지 않습니다.");
			return;
		}

		// currentNode를 이용해서 내가 찾고하는 key값을 찾으면 됩니다.
		while (currentNode != nullptr)
		{
			if (currentNode->key == key)
			{
				// 내가 삭제하고자 하는 key가 head에 있는 노드라면...
				if (currentNode == bucket[hashIndex].head)
				{
					bucket[hashIndex].head = currentNode->next;
				}
				else
				{
					traceNode->next = currentNode->next;
				}

				// 각 bucket의 카운트을 감소시킵니다.
				bucket[hashIndex].count--;

				// 해당하는 메모리를 해제합니다.
				delete currentNode;

				return;
			}

			traceNode = currentNode;
			currentNode = currentNode->next;
		}



	}

	void Search(int key)
	{
		// 해시 함수를 통해서 값을 받는 임시 변수
		int hashIndex = HashFunction(key);

		// Node를 탐색할 수 있는 순회용 포인터 변수 선언 <- 각 bucket의 head값을 저장합니다.
		Node* currentNode = bucket[hashIndex].head;

		// currentNode가 nullptr이라는 함수를 종료합니다.
		if (currentNode == nullptr)
		{
			printf("현재 노드가 존재하지 않습니다.");
			return;
		}

		// currentNode를 이용해서 내가 찾고하는 key값을 찾으면 됩니다.
		while (currentNode != nullptr)
		{
			// 해당하는 KEY값이 있다면 함수를 종료합니다.
			// 해당하는 KEY값과 VALUE값을 출력합니다.
			if (currentNode->key == key)
			{
				std::cout << "KEY : " << currentNode->key << " VALUE : " << currentNode->value << std::endl;
				return;
			}

			// 해당하는 KEY가 없다면 다음 NODE의 주소를 저장합니다.
			currentNode = currentNode->next;
		}

		std::cout << "찾고자 하는 KEY가 존재하지 않습니다." << std::endl;
	}

	void Show()
	{

	}
};

int main()
{
#pragma region 퀵 정렬 
	// 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고 
	// 한 쪽에는 기준점보다 작은 항목들이 위치하고 다른 쪽에는 기준점보다 큰 항목들이 위치한다.
	//	QuickSort(quickArray, 0, SIZE - 1);
	//	
	//	
	//	for (int i = 0; i < SIZE; i++)
	//	{
	//		std::cout << quickArray[i] << " ";
	//	}
	// 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여,
	// 모든 배열이 기본 배열(요소가 하나뿐인 배열)이 될 때까지 반복하는 알고리즘입니다.


#pragma endregion

#pragma region 해시 테이블
	  // (Key, Value)로 데이터를 저장하는 자료구조 중 하나로
	  // 빠르게 데이터를 검색할 수 있는 자료구조입니다.

	  // 해시 테이블의 평균 시간 복잡도는 O(1)입니다.

	  // 해시 충돌을 해결하는 방법

	  // 체이닝 기법
	  // 각 해시 버킷을 연결리스트로 구성하는 방식입니다.
	HashTable hashTable;

	hashTable.Insert(5, 555);
	hashTable.Insert(10, 111);

	hashTable.Remove(10);

	hashTable.Search(10);



	// 해시 충돌 발생 시 동일한 해시 값에 해당하는 데이터들을
	// 연결리스트로 연결하여 저장합니다. 

	// 개방 주소법 
	/*
	// 충돌 발생 시 빈 버켓에 데이터를 저장하는 방식입니다.

	// 빈 버킷을 어떻게 결정할 지에 따라 구현 방식이 달라집니다.

	// 선형 탐사 : 충돌 발생 시 앞에서 부터 차례대로 빈 버킷을
	// 찾아 값을 저장하는 방식입니다.

	// 이차 탐사 : 충돌 발생 시 2^, 2^3만큼 떨어진 빈 버킷을 찾아
	// 값을 저장하는 방식입니다.

	// 이중 해싱 : 해시 값을 한번 더 해시 함수에 넣어 다른 해시값을
	// 도출하는 방식입니다.
	*/

#pragma endregion



	return 0;
}

