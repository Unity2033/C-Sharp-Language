namespace Class8th__Polymorphism_
{
    internal class Unit
    {
        protected int health;
        protected int attack;
        protected int defense;

        public Unit()
        {
            Console.WriteLine("Create Unit");
        }

        public void Skill()
        {
            Console.WriteLine("Unit Skill");
        }

        virtual public void Show()
        {
            Console.WriteLine("Unit Information");

            // 가상 함수의 경우 가상 함수 테이블을 사용하여
            // 호출되는 함수를 실행 시간에 결정하며, 정적으로
            // 선언된 함수는 가상 함수로 선언할 수 없습니다.
        }
    }
}
