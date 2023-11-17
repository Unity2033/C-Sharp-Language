namespace Class6th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 10, 100);
            //spider.Patrol();
            //Information infomation = new Information();
            //infomation.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            //Marine marine = new Marine();
            //Firebet firebet = new Firebet();
            //Ghost ghost = new Ghost();

            //UnitManager unitManager = new UnitManager();

            //unitManager.Commend(marine);
            //unitManager.Commend(firebet);
            //unitManager.Commend(ghost);

            #endregion

            #region ISP 5대 원칙
            //Wraith wraith = new Wraith();

            //wraith.Attack();
            //wraith.Move();
            //wraith.Skill();

            //BattleCruiser battleCruiser = new BattleCruiser();

            //battleCruiser.Attack();
            //battleCruiser.Move();
            //battleCruiser.Skill();

            //Valkyrie valkyrie = new Valkyrie();

            //valkyrie.Attack();
            //valkyrie.Move();

            //DropShip dropShip = new DropShip();

            //dropShip.Move();
            //dropShip.Skill();
            #endregion

            #region DIP 5대 원칙

            //Character character = new Character(100, new Knife());

            //character.ChangeWeapon(new Axe());
            //character.ChangeWeapon(new Rifle());

            #endregion

            #region LSP 5대 원칙

            // Drone drone = new Drone();

            #endregion
        }
    }
}