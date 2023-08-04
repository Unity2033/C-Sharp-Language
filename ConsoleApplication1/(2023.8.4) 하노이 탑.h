#pragma once
#include <iostream>

#pragma region �ϳ����� ž
// ��Ģ
// 1. ū ������ �Ʒ�, ���� ������ ���� ���� �ؼ�
// ������ 3���� ��� ���̿� �ű�� ���Դϴ�.

// 2. ������ 1���� 1������ �ű� �� �ְ�, ��� ������
// ũ�Ⱑ �ٸ���, ū ������ ���� ���� ���� ������ 
// �ȵǴ� ��Ģ�� �ֽ��ϴ�.

// 3. �ּ����� �̵����� ��ǥ ������� �Űܾ� �մϴ�.

void Hanoi(int n, char A, char B, char C)
{
    if (n <= 1)
    {
        std::cout << A << "->" << C << std::endl;
        return;
    }
    else
    {
        Hanoi(n - 1, A, C, B);
        std::cout << A << "->" << C << std::endl;
        Hanoi(n - 1, B, A, C);
    }
}

#pragma endregion

class A
{
public:
    void Print()
    {
        std::cout << "A class" << std::endl;
    }

    virtual A* GetThis()
    {
        return this;
    }
};

class B : public A
{
public:
    void Print()
    {
        std::cout << "B Class" << std::endl;
    }

    virtual B* GetThis()
    {
        return this;
    }
};


int main()
{
#pragma region �ϳ����� ž
    // int data = 0;

    // std::cin >> data;

    // Hanoi(data, 'A', 'B', 'C');
#pragma endregion

#pragma region ���� ��ȯ��

    A aClass;
    B bClass;

    A& ref = bClass;

    bClass.GetThis()->Print();
    ref.GetThis()->Print();

    std::cout << typeid(bClass.GetThis()).name() << std::endl;
    std::cout << typeid(ref.GetThis()).name() << std::endl;

#pragma endregion



    return 0;
}

