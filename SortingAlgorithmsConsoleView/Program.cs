using SortingAlgorithmsConsoleView.Menu;
using SortingAlgorithmsConsoleView.Services.ReaderService;
using SortingAlgorithmsConsoleView.Services.PrinterService;

namespace SortingAlgoritmsConsoleView 
{
    internal class Program
    {
        static void Main()
        {
             var menu = new Menu(new MenuWriterHelper(new ConsolePrinterService()), new ChoiseHelper(new ConsoleReaderService()));
            do
            {
                menu.OpenMenu();
            }
            while (true);
        }
    }
}