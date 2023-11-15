namespace Program
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
            Marine marine = new Marine();
            Firebet firebet = new Firebet();
            Ghost ghost = new Ghost();

            UnitManager unitManager = new UnitManager();

            unitManager.Commend(marine);
            unitManager.Commend(firebet);
            unitManager.Commend(ghost);

            #endregion
        }
    }
}