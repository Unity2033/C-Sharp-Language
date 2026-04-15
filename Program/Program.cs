public class Puzzle
{
    public string word;

    public Puzzle()
    {
        word = "apple"; 
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
    }

    public void Enter(ref int health)
    {
        health--;
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        #region 매개 변수 한정자
        // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

        int life = 5;

        Puzzle puzzle = new Puzzle();

        puzzle.Enter(ref life);

        Random random = new Random();

        int index = random.Next(0, puzzle.word.Length);

        puzzle.Render(in index);

        #endregion


    }
}

