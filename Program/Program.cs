using System.Collections;
using System.Xml.Linq;

namespace Program
{
    public class GameObject
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name;  }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션

            // ArrayList
            /*
            ArrayList arrayList = new ArrayList();

            arrayList.Add(10);
            arrayList.Add("String");
            arrayList.Add(57.5f);
            arrayList.Add('A');

            foreach(object element in arrayList)
            {
                Console.WriteLine(element);
            }

            //  0       1         2      3
            // [10] ["String"] [57.5f] ['A'] 

            arrayList.Remove(10);

            Console.WriteLine(" ");
            Console.WriteLine("arrayList Count : " + arrayList.Count);
            Console.WriteLine(" ");

            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            */

            // List
            /*
            List<int> list = new List<int>();

            list.Capacity = 10;

            // [10] [20] [30] [40] [50] [] [] [] [] []
            list.Add(35);
            list.Add(77);
            list.Add(1);
            list.Add(39);
            list.Add(15);

            list.Remove(45);
            list.RemoveAt(4);

            // list.Reverse(); // 리스트 안에 있는 원소를 반전하는 함수
            // list.Sort();    // 리스트 안에 있는 원소를 정렬하는 함수    

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
          
            List<string> games = new List<string>();

            games.Capacity = 5;

            games.Add("마구마구");
            games.Add("피파온라인 4");
            games.Add("메이플스토리");
            games.Add("서든어택");
            games.Add("바람의나라");

            Random random = new Random();

            while(games.Count != 0)
            {
                int rand = random.Next(0, games.Count);

                Console.WriteLine(games[rand]);

                games.RemoveAt(rand);
            }
            */

            // LinkedList
            /*
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddLast(100);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            */

            // Stack
            /*
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            stack.Pop();                                       // Pop : 가장 위에 있는 데이터를 삭제합니다.
            Console.WriteLine("stack Peek : " + stack.Peek()); // Peek : 가장 위에 있는 데이터를 반환합니다.

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            */

            // Queue
            Queue<GameObject> queue = new Queue<GameObject>();

            string[] objectName = new string [4] { "Cube", "Sphere", "Cylinder", "Capsule"};

            queue.Enqueue(new GameObject()); // [] 
            queue.Enqueue(new GameObject()); // [] []
            queue.Enqueue(new GameObject()); // [] [] []
            queue.Enqueue(new GameObject()); // [] [] [] []

            int queueSize = queue.Count;

            for(int i = 0; i < queueSize; i++)
            {
                GameObject gameObject = queue.Dequeue();

                gameObject.Name = objectName[i];

                Console.WriteLine(gameObject.Name);
            }

            // Random 클래스
            /*
            Random random = new Random();

            int rand = random.Next(0, 10);

            Console.WriteLine("rand : " + rand);
            */
            #endregion
        }
    }
}