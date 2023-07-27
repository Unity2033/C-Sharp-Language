#include <iostream>

#define SIZE1 5
#define SIZE2 10

int quickArray[10] = { 4,1,2,3,9,7,8,6,10,5 };

void QuickSort(int data[], int start, int end)
{



}

int main()
{
#pragma region 계수 정렬
	// 데이터의 값을 직접 비교하지 않고, 단순하게 각 숫자가
	// 몇 개 있는지 갯수를 세어 저장한 다음 정렬하는 알고리즘입니다.

	//	int array[SIZE1] = { 0, };
	//	
	//	int item[SIZE2] = { 1,5,3,4,4,3,1,2,5,1 };
	//	
	//	for (int i = 0; i < SIZE2; i++)
	//	{
	//		array[item[i] - 1] += 1;
	//	}
	//	
	//	for (int i = 0; i < SIZE1; i++)
	//	{
	//		std::cout << array[i] << std::endl;
	//	}

#pragma endregion

#pragma region 퀵 정렬 
	// 기준점을 획득한 다음 해당 기준점을 기준으로 배열을 나누고 
	// 한 쪽에는 기준점보다 작은 항목들이 위치하고 다른 쪽에는 기준점보다 큰 항목들이 위치한다.

	// 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여,
	// 모든 배열이 기본 배열(요소가 하나뿐인 배열)이 될 때까지 반복하는 알고리즘입니다.


#pragma endregion
	return 0;
}

