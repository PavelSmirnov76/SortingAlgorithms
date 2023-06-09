namespace SortingAlgorithmsConsoleView.Menu
{
    public enum SortOptions
    {
        Bubble = 1,
        Quick = 2
    }
    public class Menu
    {
        private readonly IWriterHelper menuWriterHelper;
        private readonly IChoiseHelper choiseHelper;


        public Menu(IWriterHelper menuWriterHelper, IChoiseHelper choiseHelper)
        {
            this.choiseHelper = choiseHelper;
            this.menuWriterHelper = menuWriterHelper;
        }
        public void OpenMenu()
        {

            try
            {
                menuWriterHelper.WriteCoiseArrayMenu();
                var array = choiseHelper.ChoiseArray();

                menuWriterHelper.WriteChoiseSortingMenu();
                var sortingAlgorithm = choiseHelper.ChoiseSorting();

                var sortedArray = sortingAlgorithm.Sort(array);
                menuWriterHelper.WriteSortedArray(sortedArray);
            }
            catch (Exception ex)
            {
                menuWriterHelper.WriteException(ex.Message);
            }
        }   
    }
}
