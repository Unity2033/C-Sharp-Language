using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6th
{
    #region 단일 책임 원칙
    // 하나의 객체는 반드시 하나의 동작만을 수행해야 합니다.

    public class Monster
    {
        private string name;
        private int attack;
        private int health;
    
        public Monster(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Patrol()
        {
            Console.WriteLine("순찰하는 중...");
        }

        // Monster의 정보를 보내주는 함수
        public string Representation()
        {
            return "name : " + name + " attack : " + attack + " health : " + health;
        }    
    }

    public class Information
    {
        public void MonsterInfo(Monster monster)
        {
            Console.WriteLine(monster.Representation());
        }
    }
    #endregion
}
