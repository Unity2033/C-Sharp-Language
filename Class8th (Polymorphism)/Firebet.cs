namespace Class8th__Polymorphism_
{
    internal class Firebet : Unit
    {
        public Firebet()
        {
            health  = 50;
            attack  = 7;
            defense = 1;
        }

        new public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }

        override public void Show()
        {
            Console.WriteLine("health 변수의 값 : " + health);
            Console.WriteLine("attack 변수의 값 : " + attack);
            Console.WriteLine("defense 변수의 값 : " + defense);
        }
    }
}
