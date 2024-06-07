namespace Class8th__Polymorphism_
{
    internal class Barracks
    {
        private int count = 0;

        public void Create()
        {
            while(count < 5)
            {
                int select = Convert.ToInt32(Console.ReadLine());

                Unit unit = null;

                switch(select)
                {
                    case 0 : unit = new Marine();
                        break;
                    case 1 : unit = new Firebet();
                        break;
                    case 2 : unit = new Ghost();
                        break;
                    default : continue;
                }

                count++;

                Console.WriteLine("count의 값 : " + count);

                unit.Show();
            }
        }

    }
}
