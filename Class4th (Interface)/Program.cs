internal class Program
{
    static void Main(string[] args)
    {
        #region 인터페이스
        // 객체가 외부에 제공해야 하는 기능을 정의하고,
        // 구현은 포함하지 않은 참조 타입입니다.

        ISelectable[] selectables = { new Frame(), new Clock(), new Switch() };

        int select = 0;

        while (true)
        {
            Console.WriteLine("0 : Frame, 1 : Clock, 2 : Switch\n");

            Console.Write("Please select an option : ");

            if (int.TryParse(Console.ReadLine(), out select) == false)
            {
                Console.WriteLine("\nInvalid Input...\n");

                continue;
            }

            Console.WriteLine();

            if (select >= 0 && select < selectables.Length)
            {
                selectables[select].Select();

                if (selectables[select] is IActivatable activatable)
                {
                    Console.WriteLine("\nThis item can be Used\n");

                    Console.WriteLine("0 : Use, 1 : do not use \n");

                    Console.Write("Please select an option : ");

                    if (int.TryParse(Console.ReadLine(), out select) == false)
                    {
                        Console.WriteLine("\nInvalid Input...\n");

                        continue;
                    }

                    if (select >= 0 && select < 1)
                    {
                        Console.WriteLine();

                        activatable.Activate();
                    }
                    else
                    {
                        Console.WriteLine();

                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Exception");
            }

            Console.WriteLine();
        }

        #endregion
    }
}

