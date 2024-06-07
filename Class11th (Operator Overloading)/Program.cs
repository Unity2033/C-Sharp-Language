namespace Class11th__Operator_Overloading_
{
    public class Point2D
    {
        private float x;
        private float y;

        public float X
        {
            set { x = value; }
            get { return x; }
        }

        public float Y
        {
            set { y = value; }
            get { return y; }
        }
    }

    public class Position
    {
        public void Update()
        {
            Console.WriteLine("60 FPS");
        }
    }

    public class Vector2 : Position
    {
        private int x;
        private int y;

        public Vector2()
        {
            base.Update();
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        static public Vector2 operator +(Vector2 left, Vector2 right)
        {
            Vector2 clone = new Vector2();

            clone.x = left.x + right.x;
            clone.y = left.y + right.y;

            return clone;
        }

        static public Vector2 operator -(Vector2 left, Vector2 right)
        {
            Vector2 clone = new Vector2();

            clone.x = left.x - right.x;
            clone.y = left.y - right.y;

            return clone;
        }

        static public Vector2 operator *(Vector2 left, Vector2 right)
        {
            Vector2 clone = new Vector2();

            clone.x = left.x * right.x;
            clone.y = left.y * right.y;

            return clone;
        }

        static public Vector2 operator /(Vector2 left, Vector2 right)
        {
            Vector2 clone = new Vector2();

            clone.x = left.x / right.x;
            clone.y = left.y / right.y;

            return clone;
        }
    }

    internal class Program
    {
        static void View(int health)
        {
            for (int i = 0; i < health; i++)
            {
                Console.Write("♥");
            }

            Console.WriteLine();
        }

        static bool Judgment(List<string> container, string arrow)
        {
            if (container[container.Count - 1] == arrow)
            {
                container.RemoveAt(container.Count - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            #region Rhythm Game

            //  int count = 4;
            //  int health = 5;
            // 
            //  List<string> container = new List<string>();
            // 
            //  Random random = new Random();
            // 
            //  for (int i = 0; i < count; i++)
            //  {
            //      int rand = random.Next(0, 4);
            // 
            //      switch (rand)
            //      {
            //          case 0 : container.Add("↑"); 
            //              break;
            //          case 1 : container.Add("←");
            //              break;
            //          case 2 : container.Add("→");
            //              break;
            //          case 3 : container.Add("↓");
            //              break;
            //      }
            //  }
            // 
            //  ConsoleKeyInfo key;
            // 
            //  while (health > 0)
            //  {
            //      View(health);
            // 
            //      foreach (string arrow in container)
            //      {
            //          Console.Write(arrow + " ");
            //      }
            // 
            //      key = Console.ReadKey(true);
            // 
            //      switch (key.Key)
            //      {
            //          case ConsoleKey.UpArrow :
            //              if (Judgment(container, "↑") == false)
            //              {
            //                  health--;
            //              }
            //       
            //              break;
            // 
            //          case ConsoleKey.LeftArrow :
            //              if (Judgment(container, "←") == false) 
            //              {
            //                  health--;
            //              }
            // 
            //              break;
            // 
            //          case ConsoleKey.RightArrow:
            //              if (Judgment(container, "→") == false)
            //              {
            //                  health--;
            //              }
            //              break;
            // 
            //          case ConsoleKey.DownArrow:
            //              if (Judgment(container, "↓") == false)
            //              {
            //                  health--;
            //              }
            //              break;
            //      }
            // 
            //      Console.Clear();
            // 
            //      if (container.Count <= 0)
            //      {
            //          break;
            //      }
            //  }
            // 
            //  if(health <= 0)
            //  {
            //      Console.WriteLine("Defeat");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Victory");
            //  }

            #endregion

            #region 두 점 사이의 거리

            // Point2D point1 = new Point2D();
            // 
            // point1.X = 0;
            // point1.Y = 0;
            // 
            // Point2D point2 = new Point2D();
            // 
            // point2.X = 5;
            // point2.Y = 3;
            // 
            // float x = point1.X - point2.X; 
            // float y = point1.Y - point2.Y;
            // 
            // double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            // 
            // if(distance > 2.5f)
            // {
            //     Console.WriteLine("공격 범위를 벗어났습니다.");
            // }
            // else
            // {
            //     Console.WriteLine("공격 범위입니다.");
            // }

            #endregion

            #region 연산자 오버로딩

            // Vector2 vector1 = new Vector2();
            // Vector2 vector2 = new Vector2();
            // 
            // vector1.X = 5;
            // vector1.Y = 10;
            // 
            // vector2.X = 7;
            // vector2.Y = 6;
            // 
            // Vector2 vector3 = vector1 + vector2;
            // 
            // Console.WriteLine("vector3의 X 값 : " + vector3.X);
            // Console.WriteLine("vector3의 Y 값 : " + vector3.Y);

            #endregion
        }
    }
}
