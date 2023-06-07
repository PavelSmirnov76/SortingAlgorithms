using SortingAlgorithmsConsoleView.Services.PrinterService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public class MenuWriterHelper
    {
        private readonly IPrinterService printerService;

        public MenuWriterHelper(IPrinterService printerService)
        {
            this.printerService = printerService;
        }

        public void WriteChoiseSortingMenu()
        {
            printerService.Print("Выберете вариант сортировки.");
            printerService.Print("1 Сортировка пузырьком.");
            printerService.Print("2 Быстрая сортировка.");
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
