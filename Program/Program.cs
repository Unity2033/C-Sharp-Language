namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 일반화
            // 데이터 형식에 의존하지 않고, 하나의 값이 여러 다른 데이터
            // 형식을 가질 수 있는 기술에 중점을 두어 재사용성을 높일 수
            // 있는 기능입니다.

            Factory<Obstacle> factory = new Factory<Obstacle>();

            for(int i = 0; i < 5; i++)
            {
                Obstacle obstacle = factory.Instantiate();

                obstacle.Translate(i, i);
            }

            #endregion

        }
    }
}

