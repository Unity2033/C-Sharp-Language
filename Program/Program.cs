namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 추상 클래스
            // 공통적인 기능을 제공하며, 구체적인 동작은 하위 클래스에서
            // 정의할 수 있도록 만들어 놓은 클래스입니다.

            Soldier soldier = null;

            int createCount = 0;

            int select = 0;

            while (createCount < 5)
            {
                Console.Write("Select a soldier : ");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1 : soldier = new Knight();
                        break;

                    case 2 : soldier = new Archer();
                        break;

                    case 3 : soldier = new Guard();
                        break;
                    default :
                        continue;
                }

                createCount++;

                soldier.Attack();
            }

            #endregion

        }
    }
}

