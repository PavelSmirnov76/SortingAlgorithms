namespace SortingAlgorithms
{
    public class BubbleSorting : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]); 
                    }
                }
            }

            return array;
        }
    }
}