#pragma once
#include <iostream>

#pragma region 하노이의 탑
// 규칙
// 1. 큰 원반이 아래, 작은 원반이 위로 가게 해서
// 원반을 3개의 기둥 사이에 옮기는 것입니다.

// 2. 원반은 1번에 1개씩만 옮길 수 있고, 모든 원반은
// 크기가 다르며, 큰 원반이 작은 원반 위로 가서는 
// 안되는 규칙이 있습니다.

// 3. 최소한의 이동으로 목표 기둥으로 옮겨야 합니다.

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
#pragma region 하노이의 탑
    // int data = 0;

    // std::cin >> data;

    // Hanoi(data, 'A', 'B', 'C');
#pragma endregion

#pragma region 공변 반환값

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

