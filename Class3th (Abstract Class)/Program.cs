internal class Program
{
    static void Main(string[] args)
    {
        #region 추상 클래스
        // 공통적인 기능을 제공하며, 구체적인 동작은 하위 클래스에서
        // 정의할 수 있도록 만들어 놓은 클래스입니다.

        Barracks barracks = new Barracks();

        int select = 0;

        Console.Write("Please select an option : ");

        while (true)
        {
            select = int.Parse(Console.ReadLine());

            if (select < 4)
            {
                Console.Write("Select a soldier : ");

                barracks.Create(select);
            }
            else if (select == 4)
            {
                barracks.Battle();

                Console.WriteLine("The Battle is over");

                break;
            }
            else
            {
                Console.Write("Please select an option : ");
            }
        }

        #endregion
    }
}

