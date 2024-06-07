namespace Class6th__Function_
{
    internal class Program
    {
        #region 매개 변수 한정자

        static void Swap(ref int x, ref int y)
        {
            int temp = y;

            y = x;

            x = temp;
        }

        static void Damage(out int health)
        {
            health = 100;
        }

        static void Printf(in int value)
        {
            Console.WriteLine("Value의 값 : " + value);
        }

        static void Function(params int[] ints)
        {
            foreach (int element in ints)
            {
                Console.WriteLine("element의 값 : " + element);
            }
        }

        static void Position(int x = 10, int y = 10)
        {
            // 기본 매개 변수를 사용할 때 오른쪽에서 부터 기본 매개변수를 설정해주어야 합니다.
            Console.WriteLine("x 좌표의 값 : " + x);
            Console.WriteLine("y 좌표의 값 : " + y);
        }

        #endregion 

        static void Start(int count)
        {
            if (count <= 0)
            {
                return;
            }
            else
            {
                Start(count - 1);
            }

            Console.WriteLine("Start");

            // 재귀 함수의 경우 특정한 시점에서 함수를 반환해야 하며,
            // 재귀적으로 호출한 함수는 스택 프레임에 의해 마지막에 호출된
            // 함수부터 차례대로 스택 영역에서 해제됩니다.
        }

        static int Process(int count)
        {
            if (count <= 0)
            {
                return 0;
            }
            else
            {
                return Process(count - 1) + 1;
            }
        }

        static void Information(object[] item)
        {
            foreach (object element in item)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            #region 인수
            // 함수가 호출될 때 매개 변수에 실제로 전달되는 값입니다.

            #region ref 키워드
            // int a = 10;
            // int b = 20;
            // 
            // Console.WriteLine("a 변수의 값 : " + a);
            // Console.WriteLine("b 변수의 값 : " + b);
            // 
            // Swap(ref a, ref b);
            // 
            // Console.WriteLine("a 변수의 값 : " + a);
            // Console.WriteLine("b 변수의 값 : " + b);
            #endregion

            #region out 키워드

            // int health;

            // Damage(out health);

            // Console.WriteLine("health 변수의 값 : " + health);

            #endregion

            #region in 키워드

            // int data = 300;

            // Printf(data);

            #endregion

            #region foreach문

            // int [ ] list = new int[5] { 1, 2, 3, 4, 5 };

            // foreach(int element in list)
            // {
            //     Console.WriteLine(element);
            // }

            #endregion

            #region params 키워드

            // Function(10, 20, 30);

            // Function(45, 99, 1250, 9999);

            #endregion

            #region 기본 매개 변수

            // Position();

            // // 기본 매개 변수에 값을 넣을 때 왼쪽에 있는 매개 변수부터 값이 들어갑니다.

            // Position(0);

            #endregion

            // 인수의 경우 함수에 있는 매개변수의 수에 따라 전달할 수 있는
            // 인수의 수가 결정되며, 값을 전달하는 인수와 값을 전달받는
            // 매개변수의 자료형이 서로 일치해야 합니다.

            #endregion

            #region 재귀 함수
            // 어떤 함수에서 자신을 다시 호출하여 작업을 수행하는 함수입니다.

            // Start(3);

            // Console.WriteLine("Process 함수가 반환하는 값 : " + Process(3));

            // 재귀 함수는 함수를 계속 호출하기 때문에 스택 영역에 메모리가
            // 계속 쌓이게 되므로 스택 오버플로우가 일어 나게 됩니다.
            #endregion

            #region 박싱과 언박싱
            // 박싱은 값 형식을 참조 형식으로 변환하는 과정을 의미하며,
            // 언박싱은 참조 형식을 값 형식으로 변환하는 과정입니다.

            // int attack = 10;
            // 
            // object box = attack;
            // 
            // Console.WriteLine("box의 값 : " + box);
            // 
            // int result = (int)box;
            // 
            // Console.WriteLine("result 값 : " + result);

            // object [ ] dataList = new object[3];
            // 
            // dataList[0] = 10;       // Attack
            // dataList[1] = "Marine"; // Name
            // dataList[2] = 55.5f;    // Health
            // 
            // Information(dataList);

            #endregion
        }
    }
}
