namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션
            // 데이터를 저장하고, 추가하고, 삭제하며 순회하는 기능까지 포함한
            // 데이터 관리 구조입니다.

            #region List

            // List<int> list = new List<int>();
            // 
            // list.Capacity = 10;
            // 
            // list.Add(10);
            // list.Add(20);
            // list.Add(30);
            // list.Add(40);
            // list.Add(50);
            // 
            // list.Remove(10);
            // 
            // list.RemoveAt(list.Count - 1);
            // 
            // list.Insert(1, 25);
            // 
            // if(list.Contains(20))
            // {
            //     Console.WriteLine("I found the data");
            // }
            // else
            // {
            //     Console.WriteLine("I didn't find thd data");
            // }
            // 
            // for(int i = 0; i < list.Count; i++)
            // {
            //     Console.WriteLine("List [" + i + "] = " + list[i]);
            // }
            // 
            // Console.WriteLine("List Capacity : " + list.Capacity);

            #endregion

            #region Queue

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            if (queue.Contains(19))
            {
                Console.WriteLine("I found the data");
            }
            else
            {
                Console.WriteLine("I didn't find thd data");
            }

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();

                Console.WriteLine(x);
            }

            #endregion

            #region Stack

            // Stack<int> stack = new Stack<int>();
            // 
            // stack.Push(10);
            // stack.Push(20);
            // stack.Push(30);
            // stack.Push(40);
            // stack.Push(50);
            // 
            // int size = stack.Count;
            // 
            // for(int i = 0; i < size; i++)
            // {
            //     Console.WriteLine(stack.Peek());
            // 
            //     stack.Pop();
            // }

            #endregion

            #endregion

        }
    }
}

