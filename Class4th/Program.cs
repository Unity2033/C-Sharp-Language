namespace Program
{
    public interface IItem
    {
        void Use();
    }

    public interface IWaitTime
    {
        void Wait(float timer);
    }

    public class Player
    {
        public void OnTriggerEnter(IItem item)
        {
            item.Use();
        }
    }

    public class GameObject
    {
        private int guID;

        public int GUID
        {
            set { guID = value; }
            get { return guID; }
        }

        public GameObject Clone()
        {
            // 1. class를 생성합니다.
            GameObject clone = new GameObject();

            // 2. class 안에 있는 데이터를 넣어줍니다.
            clone.guID = guID;

            //3. class를 반환합니다.
            return clone;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사
            //GameObject gameObject1 = new GameObject();

            //GameObject gameObject2 = gameObject1;

            //gameObject2.GUID = 99;

            //Console.WriteLine("gameObject1의 GUID : " + gameObject1.GUID);
            //Console.WriteLine("gameObject2의 GUID : " + gameObject2.GUID);
            #endregion

            #region 깊은 복사
            //GameObject clone1 = new GameObject();

            //GameObject clone2 = clone1.Clone();

            //clone1.GUID = 456;
            //clone2.GUID = 111;

            //Console.WriteLine("clone1.GUID : " + clone1.GUID);
            //Console.WriteLine("clone2.GUID : " + clone2.GUID);
            #endregion

            #region 인터페이스
            Player player = new Player();

            // 인터페이스 참조 변수를 선언할 수 있지만,
            // 인스턴스를 생성할 수 없습니다.
            //IItem items = new IItem();

            player.OnTriggerEnter(new Magnet());
            player.OnTriggerEnter(new Missile());
            player.OnTriggerEnter(new Shield());
            #endregion

            #region 추상 클래스

            //Juggling juggling = new Juggling();

            //juggling.Information();
            //juggling.Skill();

            #endregion
        }
    }
}