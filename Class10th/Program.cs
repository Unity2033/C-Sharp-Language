namespace Class10th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 등차 수열
            //int firstTerm = 0;       // 첫항
            //int commonDifferent = 0; // 공차

            //int size = 0;

            //// Console.ReadLine() : string 타입으로만 값을 반환합니다.
            ////string name = Console.ReadLine();
            //// Console.WriteLine("name의 변수의 값 : " + name);

            //// Int32.Parse : int 타입으로 값을 반환합니다.
            //Console.Write("첫 항의 값 입력 : ");
            //firstTerm = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" ");

            //Console.Write("공차의 값 입력 : ");
            //commonDifferent = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" ");

            //Console.Write("n의 값 입력 : ");
            //size = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" ");

            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(firstTerm + commonDifferent * i);
            //}

            #endregion

            #region 등비 수열
            //int firstTerm; // 첫항
            //int different; // 공비

            //int n;

            //Console.Write("첫 항의 값 입력 : ");
            //firstTerm = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" ");

            //Console.Write("공차의 값 입력 : ");
            //different = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(" ");

            //Console.Write("n의 값 입력 : ");
            //n = Int32.Parse(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(firstTerm);

            //    firstTerm *= different;
            //}
            #endregion

            #region 무명 형식
            // 이름이 존재하지 않는 객체 또는 변수를 의미합니다.

            // var data = new { Name = "Data", Value = 10 };

            // 무명 형식의 경우 값을 읽기만 할 수 있습니다.
            // data.Name = 200;

            // Console.WriteLine("data.Name : " + data.Name + " data.Value : " + data.Value);
            #endregion
        }
    }
}