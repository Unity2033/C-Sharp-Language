using System.Collections;

namespace Class9th
{
    public class Rifle : IEnumerator
    {
        private int index;
        private int[] bullet;

        public Rifle()
        {
            index = -1;
            bullet = new int[5];
        }

        // Current : 읽기 전용 프로퍼티로 현재 위치의 데이터를 object 타입으로 반환합니다.
        public object Current
        {
            get { return bullet[index]; }
        }

        // MoveNext() : 다음 위치로 이동하는데 다음 위치에 데이터가 있다면 true,
        //              없다면 false를 반환하는 함수입니다.
        public bool MoveNext()
        {
            index++;

            if (index < bullet.Length)
            {
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        // Reset() : 인덱스를 초기 상태로 이동시킵니다.
        // 컬렉션의 인덱스를 -1로 설정합니다.
        public void Reset()
        {
            index = -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 예외 처리
            //try
            //{
            //    int [] array = new int[3];

            //    array[3] = 555;  

            //    Console.WriteLine("프로그램 시작");
            //}
            //catch(Exception error)
            //{
            //    Console.WriteLine(error.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("프로그램 종료");
            //}
            #endregion

            #region 열거자

            //Rifle rifle = new Rifle();

            //while(rifle.MoveNext())
            //{
            //    Console.WriteLine(rifle.Current);
            //}

            #endregion
        }
    }
}