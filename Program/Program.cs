namespace Program
{ 
    internal class Program
    {   
        public int Fibonacci(int n, int [] memoization)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }


            return Fibonacci(n - 1, memoization) + Fibonacci(n - 2, memoization);
        }

        static void Main(string[] args)
        {
            #region 동적 계획법
            // 특정 범위까지의 값을 구하기 위해서 그것과
            // 다른 범위까지의 값을 이용하여 효율적으로 값을
            // 구하는 알고리즘입니다.

            // 메모이제이션
            // 프로그램이 동일한 계산을 반복해야 할 때, 이전에
            // 계산한 값을 메모리에 저장함으로써 동일한 계산을
            // 반복 수행하는 작업을 제거하여 프로그램의 실행 속도 향상시키는 기술입니다.

            Program program = new Program();

            int count = Convert.ToInt32(Console.ReadLine());

            int [] memoization = new int[count];

            int result = program.Fibonacci(count, memoization);

            Console.WriteLine("Fibonacci의 값 : " + result);

            #endregion
        }
    }
}