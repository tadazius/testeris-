using System;
using Xplicity.Academy.EntranceExam.Tasks;
using Xunit;

namespace Xplicity.Academy.EntranceExam.Tests
{
    [Trait("Entrance Exam", "Tasks")]
    public class TaskTests
    {
        [Theory]
        [InlineData("5 16 10", "3 9 21, 0 4 0", "2 2 18")]
        [InlineData("1000 0 0", "200 0 0, 200 0 0, 200 0 0, 200 0 0, 200 0 1", "-1")]
        public void ItReturns_ExpectedBalance_AfterPurchase(string initialBalance, string prices, string expectedBalance)
        {
            //Prepare:

            var task1 = new Task1();

            var priceList = prices.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //Act:

            var balance = task1.Purchase(initialBalance, priceList);

            //Assert:

            Assert.Equal(expectedBalance, balance);
        }

        [Theory]
        [InlineData(10, 20, 30, 1000)]
        [InlineData(100, 101, 10, 0)]
        [InlineData(15, 25, 40, 750)]
        public void ItReturns_Expected_MaxAmount(int alpha, int beta, int x, int expectedAmount)
        {
            //Prepare:

            var task2 = new Task2();

            //Act:

            var actualAmount = task2.MaxWaterAmount(alpha, beta, x);

            //Assert:

            Assert.Equal(expectedAmount, actualAmount);
        }

        [Theory]
        [InlineData(1, "My elbow was below")]
        [InlineData(2, "My elbow was below, below another elbow")]
        public void ItReturns_ExpectedNumberOfAnagrams(int expected, string text)
        {
            //Prepare:

            var task3 = new Task3();

            //Act:

            var actual = task3.GetNumberOfAnagrams(text);

            //Assert:

            Assert.Equal(expected, actual);
        }
    }
}