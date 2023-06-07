using SortingAlgorithmsConsoleView.Menu;
using SortingAlgorithmsConsoleView.Services.ReaderService;
using SortingAlgorithmsConsoleView.Services.PrinterService;

namespace SortingAlgoritmsConsoleView {
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu(new MenuWriterHelper(new ConsolePrinterService()), new ConsoleReaderService());

            menu.OpenMenu();
        }
    }
}