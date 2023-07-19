#pragma once
#include <iostream>

#define SIZE 5

int main()
{
#pragma region �ð� ���⵵
	// ��ǻ�� ���α׷��� �Է� ���� ���� ���� �ð���
	// ������踦 ��Ÿ���� ô���Դϴ�.

	// Big-O ǥ��� 
	// '�Է°��� ��ȭ�� ���� ������ ������ ��,
	// ���� Ƚ���� ���� �ð��� �󸶸�ŭ �ɸ��� �� ��Ÿ���� ô���Դϴ�.

	// �־��� ��츦 ����ϹǷ�, ���α׷��� ����Ǵ�
	// �������� �ҿ�Ǵ� �־��� �ð����� ����� �� �ֱ� �����Դϴ�.

	// O(1) ��� �ð� ���⵵
	/*
	// �Է°��� �����ϴ��� �ð��� �þ�� �ʴ� �ð� ���⵵�Դϴ�.

	// ex �迭�� �ε��� ����
	// int buffer[100];
	// buffer[50] = 10;
	// std::cout << buffer[50] << std::endl;
	*/

	// O(n) ���� �ð� ���⵵
	/*
	   �Է°��� �����Կ� ���� �ð� ���� ���� ������
	   �����ϴ� �ð� ���⵵�Դϴ�.

	   // �Է� 1
	   // �ð� -> 1��

	   // �Է� 100
	   // �ð� -> 100��

	   for(int i = 0; i < �Է°�(N); i++)
	   {

	   }
	*/

	// O(log n)	�α� �ð� ���⵵
	/*
	// �Է� �������� ũ�Ⱑ Ŀ������ ó�� �ð��� �α�(log) ��ŭ
	// ª������ �ð� ���⵵
	*/

	// O(n^2) 2�� �ð� ���⵵
	/*
	// �Է°��� �����Կ� ���� �ð��� n�� ��������
	// ������ �����ϴ� �ð� ���⵵�Դϴ�.

	// ex)
	// for(int i = 0; i < n; i++)
	// {
	//    for(int j = 0; j < n; j++)
	//    {
	//
	//    }
	// }
	*/

	// O(2n) ���� �޼��� �ð� ���⵵
	// ex) ��� �Լ� (�Ǻ���ġ ����)
#pragma endregion

#pragma region ��ǰ ����
	// ���� ������ �� ���Ҹ� �˻��Ͽ� �����ϴ� �˰����Դϴ�.

	// �ð� ���⵵ O(n^2)

	//	int sortBuffer[SIZE] = { 7,4,5,1,3 };
	//	
	//	for (int i = 0; i < SIZE; i++)
	//	{
	//		for (int j = 0; j < (SIZE - i) - 1; j++)
	//		{
	//			if (sortBuffer[j] > sortBuffer[j + 1])
	//			{
	//				std::swap(sortBuffer[j], sortBuffer[j + 1]);
	//			}
	//		}
	//	}
	//	
	//	for (int i = 0; i < SIZE; i++)
	//	{
	//		std::cout << sortBuffer[i] << " ";
	//	}

#pragma endregion

#pragma region ���� ����
	// ���ĵ��� ���� �����͵鿡 ���� ����
	// ���� �����͸� ã�Ƽ� ���� �տ� �ִ� �����Ϳ� ��ȯ�ϴ�
	// �˰����Դϴ�.

	// �ð� ���⵵ O(n^2)

	int selectBuffer[SIZE] = { 6,2,11,4,3 };

	for (int i = 0; i < SIZE; i++)
	{
		// �ּڰ� 
		int min = selectBuffer[i];

		// select ����
		int select = i;

		for (int j = i + 1; j < SIZE; j++)
		{
			if (min > selectBuffer[j])
			{
				min = selectBuffer[j];
				select = j;
			}
		}

		std::swap(selectBuffer[i], selectBuffer[select]);
	}

	for (auto& element : selectBuffer)
	{
		std::cout << element << " ";
	}


#pragma endregion

}


