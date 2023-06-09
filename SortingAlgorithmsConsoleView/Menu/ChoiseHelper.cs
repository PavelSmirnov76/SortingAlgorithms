using SortingAlgorithms;
using SortingAlgorithmsConsoleView.Services.ReaderService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public class ChoiseHelper : IChoiseHelper
    {
        private readonly IReaderService readerService;

        public ChoiseHelper(IReaderService readerService)
        {
            this.readerService = readerService;
        }

        public ISortingAlgorithm ChoiseSorting()
        {
            ISortingAlgorithm sortingAlgorithm;

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

        public int[] ChoiseArray()
        {
            return readerService.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
