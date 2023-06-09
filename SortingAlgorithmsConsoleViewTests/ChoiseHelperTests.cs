using Moq;
using SortingAlgorithms;
using SortingAlgorithmsConsoleView.Menu;
using SortingAlgorithmsConsoleView.Services.ReaderService;
using static SortingAlgorithmsConsoleViewTests.MenuTests;

namespace SortingAlgorithmsConsoleViewTests
{
    public class ChoiseHelperTests
    {
        [Fact]
        public void ChoiseArray_string_1_5_3_Return_1_5_3()
        {
            var expected = new int[] { 1, 5, 3 };

            var mockReaderService = new Mock<IReaderService>();
            mockReaderService.Setup(x => x.ReadLine()).Returns("1 5 3");
            var choiseHelper = new ChoiseHelper(mockReaderService.Object);

            var actual = choiseHelper.ChoiseArray();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ChoiseArray_string_1_a_3_Return_throwException()
        {
            var expected = new int[] { 1, 5, 3 };

            var mockReaderService = new Mock<IReaderService>();
            mockReaderService.Setup(x => x.ReadLine()).Returns("1 a 3");
            var choiseHelper = new ChoiseHelper(mockReaderService.Object);

            Assert.Throws<FormatException>(() =>
            {
                var actual = choiseHelper.ChoiseArray();
            });

        }

        [Fact]
        public void ChoiseSorting_string_1_Return_BubbleSorting()
        {
            var expected = "BubbleSorting";

            var mockReaderService = new Mock<IReaderService>();
            mockReaderService.Setup(x => x.ReadLine()).Returns("1");
            var choiseHelper = new ChoiseHelper(mockReaderService.Object);

            var actual = choiseHelper.ChoiseSorting();

            Assert.Equal(expected, actual.GetType().Name);

        }

        [Fact]
        public void ChoiseSorting_string_2_Return_QuickSorting()
        {
            var expected = "QuickSorting";

            var mockReaderService = new Mock<IReaderService>();
            mockReaderService.Setup(x => x.ReadLine()).Returns("2");
            var choiseHelper = new ChoiseHelper(mockReaderService.Object);

            var actual = choiseHelper.ChoiseSorting();

            Assert.Equal(expected, actual.GetType().Name);

        }

        [Fact]
        public void ChoiseSorting_string_3_Return_ThrowArgumentOutOfRangeException()
        {
            var mockReaderService = new Mock<IReaderService>();
            mockReaderService.Setup(x => x.ReadLine()).Returns("3");
            var choiseHelper = new ChoiseHelper(mockReaderService.Object);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var actual = choiseHelper.ChoiseSorting();

            });
        }
    }
}
