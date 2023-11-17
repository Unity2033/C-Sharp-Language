using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6th
{
    #region 인터페이스 분리 원칙
    // 클라이언트가 자신이 사용하지 않는 함수에 의존하지 않아야 하며,
    // 인터페이스를 구체적이고 작은 단위로 분리하여 사용하는 원칙입니다.

    public interface IMoveable
    {
        public void Move();
    }

    public interface IAttackable
    {
        public void Attack();
    }

    public interface ISkillable
    {
        public void Skill();
    }

    public class Wraith : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("Wraith Attack");
        }

        public void Move()
        {
            Console.WriteLine("Wraith Move");
        }

        public void Skill()
        {
            Console.WriteLine("Cloaking");
        }
    }

    public class BattleCruiser : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("BattleCruiser Attack");
        }

        public void Move()
        {
            Console.WriteLine("BattleCruiser Move");
        }

        public void Skill()
        {
            Console.WriteLine("Yamato");
        }
    }

    public class Valkyrie : IMoveable, IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Valkyrie Attack");
        }

        public void Move()
        {
            Console.WriteLine("Valkyrie Move");
        }
    }

    public class DropShip : IMoveable, ISkillable
    {
        public void Move()
        {
            Console.WriteLine("DropShip Move");
        }

        public void Skill()
        {
            Console.WriteLine("Load");
        }
    }

    #endregion
}
