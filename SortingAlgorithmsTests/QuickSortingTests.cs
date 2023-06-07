namespace SortingAlgorithmsTests
{
    public class QuickSortingTests
    {
        [Fact]
        public void Sort_Array1_6_3_2_SortedArray_1_2_3_6()
        {
            // Arrange
            var array = new int[] { 1, 6, 3, 2 };
            var expected = new int[] { 1, 2, 3, 6 };
            //act
            var actual = new QuickSorting().Sort(array);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sort_Array1_6_negative3_2_SortedArray_negative3_1_2_6()
        {
            // Arrange
            var array = new int[] { 1, 6, -3, 2 };
            var expected = new int[] { -3, 1, 2, 6 };
            //act
            var actual = new QuickSorting().Sort(array);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sort_ArrayEmpty_ArrayEmpty()
        {
            // Arrange
            var array = Array.Empty<int>();
            var expected = Array.Empty<int>();
            //act
            var actual = new QuickSorting().Sort(array);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
