using SortingAlgorithmsConsoleView.Services.PrinterService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public class MenuWriterHelper : IWriterHelper
    {
        private readonly IPrinterService printerService;

        public MenuWriterHelper(IPrinterService printerService)
        {
            this.printerService = printerService;
        }

        public void WriteChoiseSortingMenu()
        {
            printerService.Print("Выберете вариант сортировки. \n" +
                                 "1 Сортировка пузырьком. \n" +
                                 "2 Быстрая сортировка."
                                 );
        }

        public void WriteCoiseArrayMenu()
        {
            printerService.Print("Введите массив (целые числа через пробел).");

        }

        public void WriteSortedArray(int[] array)
        {
            printerService.Print("Отсортированный массив");

            foreach (var number in array)
            {
                printerService.Print(number.ToString());
            }
        }

        public void WriteException(string message)
        {
            printerService.Print(message);
        }
    }
}
