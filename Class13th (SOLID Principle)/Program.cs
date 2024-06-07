namespace Class13th__SOLID_Principle_
{
    public abstract class Weapon
    {
        public abstract void Attack();
    }

    public class Knife : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("knife Attack");
        }
    }

    public class Rifle : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("Rifle Attack");
        }
    }

    class Controller
    {
        public void Move(int x, int y)
        {
            Console.WriteLine(x + " 값만큼 이동");
            Console.WriteLine(y + " 값만큼 이동");
        }

        public void Attack()
        {
            Console.WriteLine("공격");
        }
    }

    class Character
    {
        private int x;
        private int y;

        private Controller controller;

        public Character(int x, int y)
        {
            this.x = x;
            this.y = y;

            controller = new Controller();
        }

        public void Select(Weapon weapon)
        {
            weapon.Attack();
        }

        public void Move(int x, int y)
        {
            controller.Move(x, y);
        }
    }

    public abstract class Unit
    {
        public abstract void Move();
    }

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Marine Move");
        }
    }

    public class Firebet : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Firebet Move");
        }
    }

    public class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Ghost Move");
        }
    }

    public class CreateManager
    {
        public void Create(Unit unit)
        {
            unit.Move();
        }
    }

    public interface IAttack
    {
        public void Attack();
    }

    public interface ITechnique
    {
        public void Skill();
    }

    class Wraith : IAttack, ITechnique
    {
        public void Attack()
        {
            Console.WriteLine("Wraith Attack");
        }

        public void Skill()
        {
            Console.WriteLine("Clocking");
        }
    }

    class Dropship : ITechnique
    {
        public void Skill()
        {
            Console.WriteLine("Drop");
        }
    }

    class Valkyrie : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Valkyrie Attack");
        }
    }

    class BattleCruiser : IAttack, ITechnique
    {
        public void Attack()
        {
            Console.WriteLine("BattleCruiser Attack");
        }

        public void Skill()
        {
            Console.WriteLine("Yamato");
        }
    }

    public class Zerg
    {
        protected int health;
        protected int attack;
    }

    public class AirUnit : Zerg
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    public class GroundUnit : Zerg
    {
        public void Ground()
        {
            Console.WriteLine("Ground");
        }
    }

    public class Juggling : GroundUnit
    {
        public Juggling()
        {
            Ground();
        }
    }

    public class Mutalisk : AirUnit
    {
        public Mutalisk()
        {
            Fly();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            // 객체는 단 하나의 책임만 가져야한다는 원칙입니다.

            // Character character = new Character(10,10);

            // character.Move(25, 25);

            // 하나의 클래스는 하나의 기능 담당하여 하나의 책임을
            // 수행하는데 집중되어야 합니다.
            #endregion

            #region 개방 폐쇄 원칙
            // 소프트웨어 개체는 확장에 대해 열려 있어야 하며,
            // 수정에 대해서는 닫혀 있어야 합니다.

            // CreateManager createManager = new CreateManager();
            // 
            // createManager.Create(new Marine());
            // createManager.Create(new Firebet());
            // createManager.Create(new Ghost());

            #endregion

            #region 리스코프 치환 원칙
            // 상위 클래스와 하위 클래스가 있을 때 상위 클래스를
            // 호출하는 동작에서 하위 클래스가 상위 클래스를 완벽하게
            // 대처할 수 있어야 한다는 원칙입니다.

            // Juggling juggling = new Juggling();

            // Mutalisk mutalisk = new Mutalisk();

            #endregion

            #region 인터페이스 분리 원칙
            // 클라이언트가 자신이 이용하지 않는 함수에 의존하지 
            // 않아야 한다는 원칙입니다.

            // Wraith wraith = new Wraith();
            // Dropship dropShip = new Dropship();
            // Valkyrie valkyrie = new Valkyrie();
            // BattleCruiser battleCruiser = new BattleCruiser();
            // 
            // wraith.Skill();
            // wraith.Attack();
            // 
            // dropShip.Skill();
            // 
            // valkyrie.Attack();
            // 
            // battleCruiser.Attack();
            // battleCruiser.Skill();

            #endregion

            #region 의존 역전 원칙
            // 상위 계층이 하위 계층에 의존하는 전통적인 의존 관계를
            // 역전시킴으로써 상위 계층이 하위 계층의 구현으로부터 독립
            // 될 수 있도록 설계하는 원칙입니다.

            // Character character = new Character(5, 5);

            // character.Select(new Rifle());
            // character.Select(new Knife());
            #endregion
        }
    }
}
