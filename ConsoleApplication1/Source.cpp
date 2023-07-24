#include <iostream>

#define SIZE 5

int main()
{
#pragma region 삽입 정렬
	// 두 번째 자료부터 시작하여 그 앞(왼쪽)의
	// 자료들과 비교하여 삽입할 위치를 지정한 후
	// 자료를 뒤로 옮기고 지정한 자리에 자료를 삽입하여 
	// 정렬하는 알고리즘입니다.

	// 시간 복잡도 O(n^2) 

	int array[SIZE] = { 5, 8, 6, 1, 2 };
	int temp = 0;
	int j = 0;

	for (int i = 1; i < SIZE; i++)
	{
		temp = array[i];

		// j가 -1까지 떨어집니다.
		// j가 0            -1 >= 0
		for ( j = i - 1; j >= 0; j--)
		{
			if (array[j] > temp)
			{
				array[j + 1] = array[j];
			}
		}

		array[j + 1] = temp;
	}

	for (const int & element : array)
	{
		std::cout << element << std::endl;
	}
#pragma endregion


	return 0;
}

