public class Circle
{
    public int x;
    public int y;
    public float radius;

    public Circle()
    {
        Console.WriteLine("Created Circle");
    }
}

internal class Program
{
    static void Collide(Circle origin, Circle other)
    {
        float deltaX = origin.x - other.x;
        float deltaY = origin.y - other.y;

        float radius = (origin.radius + other.radius) * (origin.radius + other.radius);

        if (deltaX * deltaX + deltaY * deltaX <= radius)
        {
            Console.WriteLine("Collision occurred");
        }
        else
        {
            Console.WriteLine("No collision detected");
        }
    }

    static void Main(string[] args)
    {
        #region 박싱
        // 값 타입을 참조 타입으로 변환하여 관리되는 힙 영역에 새로운 객체를
        // 만들고 복사하는 과정입니다.

        // int count = 3;
        // 
        // object clone = count;
        // 
        // Console.WriteLine("count : " + count);
        // Console.WriteLine("clone : " + clone);

        #endregion

        #region 언박싱
        // 관리되는 힙 영역에 박싱되어 있는 객체에서 값을 꺼내
        // 값 타입으로 복사하는 과정입니다.

        // long experience = 2000;
        // 
        // object address = experience;
        // 
        // long data = (long)address;
        // 
        // Console.WriteLine("experience : " + experience);
        // Console.WriteLine("address : " + address);
        // Console.WriteLine("data : " + data);
        #endregion

        #region 가비지 컬렉터
        // 메모리 관리를 담당하는 시스템이며, 메모리에서 더 이상 사용되지
        // 않는 객체를 탐색하여 메모리를 회수하는 기법입니다.

        Circle circle = new Circle();

        circle.x = 5;
        circle.y = 5;
        circle.radius = 1.0f;

        Circle quadrant = new Circle();

        quadrant.x = 1;
        quadrant.y = 2;
        circle.radius = 1.0f;

        Collide(circle, quadrant);


        // Mark : Root Space로 부터 그래프 순회를 통해 연결된 객체들을
        //        찾아 각각 어떤 객체를 참조하고 있는 지 찾아냅니다.

        // Sweep : 참조하고 있지 않은 객체를 Unreachable 객체들을 관리
        //         되는 힙 영역에서 제거합니다.

        // Compact : Sweep 이후에 분산된 객체들을 관리되는 힙 영역의 시작 
        //           주소로 모아 메모리가 할당된 부분과 그렇지 않은 부분을 
        //           압축합니다.
        #endregion
    }
}

