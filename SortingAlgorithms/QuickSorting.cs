namespace SortingAlgorithms
{
    public class QuickSorting : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        private static int[] Sort(int[] array, int first, int last)
        {
            if(first >= last)
            {
                return array;
            }

            var pivot = Partition(array, first, last);
            Sort(array, first, pivot - 1);
            Sort(array, pivot + 1, last);

            return array;     
        }

        private static int Partition(int[] array, int first, int last)
        {
            var pivot = first - 1;

            for(int i = first; i < last; i++)
            {
                if(array[i] < array[last])
                {
                    pivot++;
                    (array[i], array[pivot]) = (array[pivot], array[i]);
                }               
            }

            pivot++;
            (array[last], array[pivot]) = (array[pivot], array[last]);

            return pivot;
        }
    }
}
