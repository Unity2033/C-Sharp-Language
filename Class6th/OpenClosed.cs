using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6th
{
    #region 개방 폐쇄 원칙
    // 객체의 확장은 열려있어야 하며, 객체의 수정에는 닫혀있어야 합니다.
    
    public abstract class Unit
    {
        protected int health;
        protected int defense;

        public abstract void Move();
    }

    public class Marine : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Marine Move...");
        }
    }

    public class Firebet : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Firebet Move...");
        }
    }

    public class Ghost : Unit
    {
        public override void Move()
        {
            Console.WriteLine("Ghost Move...");
        }
    }

    public class UnitManager
    {
        public void Commend(Unit unit)
        {
            unit.Move();
        }
    }


    #endregion
}
