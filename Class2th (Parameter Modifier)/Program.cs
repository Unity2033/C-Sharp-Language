public class Puzzle
{
    public string word;

    public void Initialize(params string[] list)
    {
        Random random = new Random();

        int index = random.Next(0, list.Length);

        word = list[index];
    }

    public void Validate(char input, int index, out bool state)
    {
        if (word[index] == input)
        {
            state = true;
        }
        else
        {
            state = false;
        }

        Console.WriteLine();
    }

    public void Render(in int index)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (i == index)
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word[i] + " ");
            }
        }

        Console.WriteLine();
    }

    public void Decrease(ref int health)
    {
        health--;

        Console.WriteLine("Health : " + health);

        Console.WriteLine();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        #region 매개 변수 한정자
        // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

        Puzzle puzzle = new Puzzle();
        Random random = new Random();

        int life = 5;

        bool state = false;

        puzzle.Initialize("apple", "banana", "orange");

        int index = random.Next(0, puzzle.word.Length);

        while (life > 0)
        {
            puzzle.Render(in index);

            Console.Write("Enter the correct answer : ");

            char answer = Console.ReadKey().KeyChar;

            Console.WriteLine();

            puzzle.Validate(answer, index, out state);

            if (state == true)
            {
                break;
            }
            else
            {
                puzzle.Decrease(ref life);
            }
        }

        if (life <= 0)
        {
            Console.WriteLine("D e f e a t");
        }
        else
        {
            Console.WriteLine("V i c t o r y");
        }

        #endregion
    }
}

