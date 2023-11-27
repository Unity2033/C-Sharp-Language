namespace Class13th
{
    internal class Program
    {
        static void MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);

                Merge(array, start, middle, end);
            }
        }

        static void Merge(int[] array, int start, int middle, int end)
        {
            int[] leftArray = new int[middle - start + 1];
            int[] rightArray = new int[end - middle];

            int index = start;
            int left = 0;
            int right = 0;

            for (left = 0; index <= middle; left++)
            {
                leftArray[left] = array[index++];
            }

            for (right = 0; index <= end; right++)
            {
                rightArray[right] = array[index++];
            }

            index = start;

            left = 0;
            right = 0;

            while (left < leftArray.Length && right < rightArray.Length)
            {
                if (leftArray[left] < rightArray[right])
                {
                    array[index] = leftArray[left++];
                }
                else
                {
                    array[index] = rightArray[right++];
                }

                index++;
            }

            while (left < leftArray.Length)
            {
                array[index++] = leftArray[left++];
            }

            while (right < rightArray.Length)
            {
                array[index++] = rightArray[right++];
            }
        }

        static void Main(string[] args)
        {
            #region 병합 정렬
            // 하나의 리스트를 두 개의 균등한 크기로 분할하고
            // 분할된 부분 리스트를 정렬한 다음, 두 개의 정렬된 부분 
            // 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법입니다.

            // 분할 : 입력 배열을 같은 크기의 2개의 부분 배열로 분할합니다.

            // 정복 : 부분 배열을 정렬하며, 부분 배열의 크기가 충분히 작지 않으면
            // 순환 호출을 이용하여 다시 분할 정복을 실행합니다.

            // 결합 : 정렬된 부분 배열들을 하나의 배열에 병합합니다.

            /*
            int [] array = new int[] { 11, 5, 3, 12, 4, 6, 1, 2 };

            MergeSort(array, 0, array.Length - 1);

            foreach(var element in array)
            {
                Console.Write(element + " ");
            }
            */

            #endregion
        }
    }
}