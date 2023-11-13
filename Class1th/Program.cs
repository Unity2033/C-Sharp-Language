namespace Class1th
{
    // 접근 지정자 class 클래스 이름
    // public, protected, private
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine() : 문자열을 출력하는 함수

            #region 자료형
            //byte stream = 1;
            //bool boolean = false;
            //char character = 'A';
            //short data = 100;
            //int integer = 200;
            //long longData = 300;

            //float [] buffer = new float[3];

            //buffer[0] = 1.15f;
            //buffer[1] = 1.25f;
            //buffer[2] = 1.35f;

            //double pi = 3.14;
            //decimal decimalData = 0.1m;

            //Console.WriteLine("stream : " + stream);
            //Console.WriteLine("boolean : " + boolean);
            #endregion

            #region 박싱(BOXING)
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.
            //int data = 5;

            //object obj = data;
            //Console.WriteLine("data의 값 : " + data);
            //Console.WriteLine("obj의 값 : " + obj);

            #endregion

            #region 언박싱(UnBoxing)
            // 참조 타입의 데이터를 값 타입으로 변환하는 과정입니다.

            //int count = 10;

            //object obj1 = count;

            //int result = (int)obj1;

            #endregion
        }
    }
}