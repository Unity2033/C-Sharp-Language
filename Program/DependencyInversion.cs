using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    #region 의존관계 역전 원칙
    // 상위 계층이 하위 계층에 의존하는 전통적인 관계를
    // 반전시킴으로써 상위 계층이 하위 계층의 구현으로부터
    // 독립될 수 있도록 설계하는 원칙입니다.

    public class Character
    {
        private int health;
        private Weapon weapon;

        public Character(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
        }

        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            WeaponInfo();
        }

        public void WeaponInfo()
        {
            Console.WriteLine("name : " + weapon.Name);
            Console.WriteLine("attack : " + weapon.Attack);
        }

    }


    public abstract class Weapon
    {
        protected int attack;
        protected string name;

        public Weapon(int attack, string name)
        {
            this.attack = attack;
            this.name = name;
        }

        public int Attack
        {
            get { return attack; }
        }

        public string Name
        {
            get { return name; }
        }


        public abstract void Action();
    }

    public class Axe : Weapon
    {
        public Axe() : base(10, "Axe")
        {

        }
    
        public override void Action()
        {
            Console.WriteLine("Axe Action");
        }
    }

    public class Knife : Weapon
    {
        public Knife() : base(5, "Knife")
        {

        }

        public override void Action()
        {
            Console.WriteLine("Knife Action");
        }
    }

    public class Rifle : Weapon
    {
        public Rifle() : base(25, "Rifle")
        {

        }

        public override void Action()
        {
            Console.WriteLine("Rifle Action");
        }
    }
    #endregion
}
