namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱
            // 값 타입을 참조 타입으로 변환하여 관리되는 힙 영역에 새로운 객체를
            // 만들고 복사하는 과정입니다.

            // int count = 3;
            // 
            // object clone = count;
            // 
            // Console.WriteLine("count : " + count);
            // Console.WriteLine("clone : " + clone);

            #endregion

            #region 언박싱
            // 관리되는 힙 영역에 박싱되어 있는 객체에서 값을 꺼내
            // 값 타입으로 복사하는 과정입니다.

            // long experience = 2000;
            // 
            // object address = experience;
            // 
            // long data = (long)address;
            // 
            // Console.WriteLine("experience : " + experience);
            // Console.WriteLine("address : " + address);
            // Console.WriteLine("data : " + data);
            #endregion
        }
    }
}
