namespace Class10th__Collection_
{
    public class Vector<T>
    {
        private T[] array;

        public Vector()
        {
            array = new T[5];
        }

        public T Array
        {
            get { return array[0]; }
            set { array[0] = value; }
        }

    }

    internal class Program
    {
        public static void Debug<T>(T data)
        {
            Console.WriteLine("data 변수의 값 : " + data);
        }

        static void Main(string[] args)
        {
            #region 일반화 프로그래밍
            // 특정 데이터 타입에 의존하지 않고, 모든 타입을 멤버 변수의 타입으로
            // 설정할 수 있는 프로그래밍 기법입니다.

            // Debug('A');
            // Debug(10);
            // Debug(20.5f);
            // Debug(57.85);
            // Debug("Hello World");

            // Vector<int> vector = new Vector<int>();
            // 
            // vector.Array = 20;
            // 
            // Console.WriteLine("vector의 [0] index 값 : " + vector.Array);

            #endregion

            #region 컬렉션
            // 많은 데이터 요소를 효율적으로 관리하기 위한 자료 구조입니다.

            #region List
            // List<int> list = new List<int>();
            // 
            // list.Capacity = 5;
            // 
            // list.Add(10); // [10] [  ] [  ] [  ] [  ]
            // list.Add(20); // [10] [20] [  ] [  ] [  ]
            // list.Add(30); // [10] [20] [30] [  ] [  ]
            // 
            // list.Remove(30); // [10] [20] [ ] [  ] [  ]
            // 
            // for (int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine("list [" + i + "]의 값 : " + list[i]);
            // }
            // 
            // Console.WriteLine("list의 Count 값 : " + list.Count);
            // Console.WriteLine("list의 Capacity 값 : " + list.Capacity);
            #endregion

            #region Linked List

            // LinkedList<int> linkedList = new LinkedList<int>();
            // 
            // linkedList.AddFirst(10); // [10]
            // linkedList.AddFirst(5);  // [5]->[10]
            // linkedList.AddLast(99);  // [5]->[10]->[99]
            // 
            // linkedList.Remove(10);
            // 
            // foreach(int element in linkedList)
            // {
            //     Console.WriteLine(element);
            // }
            // 
            // Console.WriteLine("linked List의 Count 값 : " + linkedList.Count);

            #endregion

            #region Stack

            // Stack<int> stack = new Stack<int>();
            // 
            // stack.Push(10); // [10]
            // stack.Push(20); // [20] [10]
            // stack.Push(30); // [30] [20] [10]
            // stack.Push(40); // [40] [30] [20] [10]
            // stack.Push(50); // [50] [40] [30] [20] [10]
            // 
            // // stack.Pop();    // [40] [30] [20] [10]
            // 
            // Console.WriteLine("Stack의 Count 값 : " + stack.Count());
            // 
            // int count = stack.Count();
            // 
            // for(int i = 0; i < count; i++)
            // {
            //     Console.WriteLine("Stack의 Peek 값 : " + stack.Peek());
            //     stack.Pop();
            // }

            #endregion

            #region Queue

            // Queue<int> queue = new Queue<int>();
            // 
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);
            // queue.Enqueue(40);
            // queue.Enqueue(50);
            // 
            // queue.Dequeue();
            // 
            // Console.WriteLine("queue의 count 값 : " + queue.Count);
            // 
            // foreach (int element in queue)
            // {
            //     Console.WriteLine("element의 값 : " + element);
            // }

            #endregion

            #region Dictionary
            // Dictionary<string, int> dictionary = new Dictionary<string, int>();
            // 
            // dictionary.Add("Sword" , 10000);
            // dictionary.Add("Gloves", 7500);
            // dictionary.Add("Shoes" , 2500);
            // dictionary.Add("Armor" , 7500);
            // 
            // if(dictionary.ContainsKey("Sword"))
            // {
            //     Console.WriteLine("KEY 값이 존재합니다.");
            // }
            // else
            // {
            //     Console.WriteLine("KEY 값이 존재하지 않습니다.");
            // }
            // 
            // 
            // foreach (KeyValuePair<string, int> item in dictionary)
            // {
            //     Console.WriteLine("item의 Key 값 : " + item.Key);
            //     Console.WriteLine("item의 Value 값 : " + item.Value);
            // }

            // dictionary는 Key 값의 중복을 허용하지 않습니다.
            // dictionary.Add("Shoes", 2500);
            #endregion

            #endregion
        }
    }
}
