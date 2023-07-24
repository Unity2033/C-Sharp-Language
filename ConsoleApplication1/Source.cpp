#include <iostream>

#define SIZE 5

int main()
{
#pragma region ���� ����
	// �� ��° �ڷ���� �����Ͽ� �� ��(����)��
	// �ڷ��� ���Ͽ� ������ ��ġ�� ������ ��
	// �ڷḦ �ڷ� �ű�� ������ �ڸ��� �ڷḦ �����Ͽ� 
	// �����ϴ� �˰����Դϴ�.

	// �ð� ���⵵ O(n^2) 

	int array[SIZE] = { 5, 8, 6, 1, 2 };
	int temp = 0;
	int j = 0;

	for (int i = 1; i < SIZE; i++)
	{
		temp = array[i];

		// j�� -1���� �������ϴ�.
		// j�� 0            -1 >= 0
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

