using Moq;
using SortingAlgorithms;
using SortingAlgorithmsConsoleView.Menu;

namespace SortingAlgorithmsConsoleViewTests
{
    public class MenuTests
    {
        public class WriterHelperTest : IWriterHelper
        {
            public string WriteChoiseSortingMenuState = "";
            public string WriteCoiseArrayMenuState = "";
            public string WriteExceptionState = "";
            public int[] WriteSortedArrayState;
            public void WriteChoiseSortingMenu()
            {
                WriteChoiseSortingMenuState = "call";
            }

            public void WriteCoiseArrayMenu()
            {
                WriteCoiseArrayMenuState = "call";
            }

            public void WriteException(string message)
            {
                WriteExceptionState = message;
            }

            public void WriteSortedArray(int[] array)
            {
                WriteSortedArrayState = array;
            }
        }

        [Fact]
        public void OpenMenu_array_1_5_3_Sorting_Quick_Return_1_3_5()
        {
            var expected = new int[] { 1, 3, 5 };

            //Мокаем ввод
            var mockChoiseHelper = new Mock<IChoiseHelper>();
            mockChoiseHelper.Setup(x => x.ChoiseArray()).Returns(new int[] { 1, 5, 3 });
            mockChoiseHelper.Setup(x => x.ChoiseSorting()).Returns(new QuickSorting());
            var writerHelperTest = new WriterHelperTest();

            //Создаем меню
            var menu = new Menu(writerHelperTest, mockChoiseHelper.Object);
            menu.OpenMenu();

            //проверяем отсортировался ли массив.
            Assert.Equal(expected, writerHelperTest.WriteSortedArrayState);

        }

        [Fact]
        public void OpenMenu_array_1_5_3_Sorting_bubble_Return_1_3_5()
        {
            var expected = new int[] { 1, 3, 5 };

            //Мокаем ввод
            var mockChoiseHelper = new Mock<IChoiseHelper>();
            mockChoiseHelper.Setup(x => x.ChoiseArray()).Returns(new int[] { 1, 5, 3 });
            mockChoiseHelper.Setup(x => x.ChoiseSorting()).Returns(new BubbleSorting());
            var writerHelperTest = new WriterHelperTest();

            //Создаем меню
            var menu = new Menu(writerHelperTest, mockChoiseHelper.Object);
            menu.OpenMenu();

            //проверяем отсортировался ли массив.
            Assert.Equal(expected, writerHelperTest.WriteSortedArrayState);

        }
    }
}