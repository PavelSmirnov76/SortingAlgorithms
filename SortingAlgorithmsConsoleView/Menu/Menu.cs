using SortingAlgorithms;
using SortingAlgorithmsConsoleView.Services.ReaderService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public enum SortOptions
    {
        Bubble = 1,
        Quick = 2
    }
    public class Menu
    {
        private readonly MenuWriterHelper menuWriterHelper;
        private readonly IReaderService readerService;


        public Menu(MenuWriterHelper menuWriterHelper, IReaderService readerService )
        {
            this.readerService = readerService;
            this.menuWriterHelper = menuWriterHelper;
        }
        public void OpenMenu()
        {
            do
            {
                try
                {
                    menuWriterHelper.WriteCoiseArrayMenu();
                    var array = ChoiseArray();

                    menuWriterHelper.WriteChoiseSortingMenu();
                    var sortingAlgorithm = ChoiseSorting();

                    var sortedArray = sortingAlgorithm.Sort(array);
                    menuWriterHelper.WriteSortedArray(sortedArray);
                }
                catch (Exception ex)
                {
                    menuWriterHelper.WriteException(ex.Message);
                }
            }
            while (true);
        }

        private ISortingAlgorithm ChoiseSorting()
        {
            ISortingAlgorithm sortingAlgorithm = new BubbleSorting();

            switch (int.Parse(readerService.ReadLine()))
            {
                case (int)SortOptions.Bubble:
                    {
                        sortingAlgorithm = new BubbleSorting();
                        break;
                    }
                case (int)SortOptions.Quick:
                    {
                        sortingAlgorithm = new QuickSorting();
                        break;
                    }
                default:
                    {
                        throw new Exception("Выбран не верный пункт меню");
                    }
            }

            return sortingAlgorithm;
        }

        private int[] ChoiseArray()
        {
            return readerService.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
