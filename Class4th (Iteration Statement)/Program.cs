namespace Class4th__Iteration_Statement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 반복문
            // 프로그램 내에서 특정한 작업을 반복적으로 수행하는
            // 명령문입니다.

            #region 증감 연산자
            // 피연산자를 하나씩 증가시키거나 감소시킬 때 사용하는
            // 연산자입니다.

            // int x = 0;
            // int result = 0;
            // 
            // result = ++x;
            // 
            // Console.WriteLine("전위 증가한 result 변수의 값 : " + result); 
            // 
            // result = --x;
            // 
            // Console.WriteLine("전위 감소한 result 변수의 값 : " + result);

            // 전위 증감 연산자는 변수의 값을 증감시킨 후에 연산을
            // 수행하고, 후위 증감 연산자는 연산을 수행한 다음
            // 변수의 값을 증감시킵니다.

            // int attack = 10; 
            // int damage = 0; 

            // damage = attack++;

            // Console.WriteLine("후위 증가한 damage 변수의 값 : " + damage);

            // damage = attack--;

            // Console.WriteLine("후위 감소한 damage 변수의 값 : " + damage);

            // 후위 증감 연산자의 경우 변화되는 값을 나중에 가지고
            // 오기 때문에 추가적인 메모리가 필요합니다.
            #endregion

            #region for문
            // 초기식을 연산하여 조건식의 결과에 따라 특정한
            // 횟수만큼 반복하는 반복문입니다.

            //  for(int i = 0; i < 5; i++)
            //  {
            //      Console.WriteLine("for Statement");
            //  }

            // for(int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for문의 경우 조건이 끝나는 형태와 반대로 초기식을
            // 연산하게 되면 조건이 일치하지 않아 계속 반복적으로
            // 실행되는 문제가 발생할 수 있습니다.

            #endregion

            #region 2중 for문    
            // for(int i = 0; i < 3; i++)
            // {
            //     for(int j = 0; j < 3; j++)
            //     {
            //         Console.WriteLine("In For Statement");
            //     }
            // 
            //     Console.WriteLine("Out For Statement");
            // }
            #endregion

            #region 구구단     
            // for(int i = 1; i <= 9; i++)
            // {
            //     for(int j = 1; j <= 9; j++)
            //     {
            //         Console.WriteLine(i + " x " + j + " = " + i * j);
            //     }
            // 
            //     Console.WriteLine("");
            // }
            #endregion

            #region while문
            // 특정 조건을 만족할 때까지 계속해서 주어진 명령문을
            // 실행하는 반복문입니다.

            // int count = 5;
            // 
            // while(count > 0)
            // {
            //     Console.WriteLine("count 변수의 값 : " + count);
            // 
            //     count--;
            // }

            // while문의 경우 위에서 아래로 실행되며, 아래에 있는
            // 명령문의 실행이 다 끝나면 다시 위에 있는 명령문으로
            // 돌아가서 반복하는 구조입니다.
            #endregion

            #region do-while문
            // 조건과 상관없이 한 번의 작업을 수행한 다음
            // 조건에 따라 명령문을 실행하는 반복문입니다.

            // int data = 0;
            // 
            // do
            // {
            //     Console.WriteLine("Connect");
            // }
            // while (data == 1);

            #endregion

            #region continue문
            // 해당하는 조건문만 실행하지 않고, 반복문은 이어서
            // 실행하는 제어문입니다.

            // for(int i = 1; i <= 5; i++)
            // {
            //     if(i == 3)
            //     {
            //         continue;
            //     }
            // 
            //     Console.Write(i + " ");
            // }

            #endregion

            #region Star Wars
            // for(int i = 0; i < 5; i++)
            // {
            //     for(int j = 0; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            // 
            //     Console.WriteLine("");
            // }
            #endregion

            #region 단락 평가 (Short-Circuit Evaluation)
            // 첫 번째 값만으로 결과가 확실할 때 두 번째 값은 확인하지
            // 않고, 실행하는 방법입니다.

            // int z = 0;
            // 
            // if(10 != 10 && ++z == z)
            // {
            //     Console.WriteLine("Short-Circuit");
            // }
            // 
            // Console.WriteLine("z 변수의 값 : " + z);

            #endregion

            #region 자료형 변환
            // 서로 다른 자료형을 가지고 있는 변수끼리 연산이
            // 이루어질 때 기존에 지정했던 자료형을 다른 자료형으로
            // 변환하는 과정입니다.

            #region 암묵적 형변환
            // 서로 다른 자료형으로 연산이 이루어질 때 자료형의
            // 크기가 큰 자료형으로 변환되는 과정입니다.

            // int integer = 10;
            // float z = 6.5f;
            // 
            // Console.WriteLine("integer 변수와 z 변수를 + 연산한 결과 : " + (integer + z));

            // 표현 범위가 작은 데이터에 표현 범위가 큰 데이터를
            // 저장하게 되면 암묵적으로 데이터 손실이 발생할 수 있습니다.

            // float fat = 5.75f;
            // int weight = fat;

            // 정수형에서 실수형으로 암묵적 형변환은 가능하지만, 실수형에서 정수형으로
            // 암묵적 자료형 변환은 불가능합니다.

            #endregion

            #region 명시적 형변환
            // 연산이 이루어지기 전에 사용자가 직접 자료형을 변환하는 과정입니다.

            // int health = 10;
            // int armor = 3;
            // 
            // float rate = (float)health / armor;
            // 
            // Console.WriteLine("rate 변수의 값 : " + rate);

            // 정수형 변수끼리 연산을 수행하게 되면 정수의 결과 값만 가질 수 있습니다.
            #endregion

            #endregion

            #endregion
        }
    }
}
