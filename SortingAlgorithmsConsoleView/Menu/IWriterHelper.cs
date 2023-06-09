namespace SortingAlgorithmsConsoleView.Menu
{
    public interface IWriterHelper
    {
        public void WriteChoiseSortingMenu();

        public void WriteCoiseArrayMenu();

        public void WriteSortedArray(int[] array);

        public void WriteException(string message);
    }
}
