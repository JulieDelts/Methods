using Task1;

namespace Methods.Test
{
    public class BankingSystemTests
    {
        [TestCase(62, 2, 50000, true)]
        [TestCase(35, 3, 400500, true)]
        [TestCase(40, 1, 10000010, true)]
        [TestCase(59, 1, 50000, false)]
        [TestCase(29, 3, 50000, false)]
        [TestCase(50, 1, 400000, false)]
        public void IsOfferAvailableTest(int age, int numberOfServicesUsed, double deposit, bool expected)
        {
            bool actual = BankingSystem.IsOfferAvailable(age, numberOfServicesUsed, deposit);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1000, 2, 5, 1102.5)]
        [TestCase(5000, 10, 0, 5000)]
        [TestCase(20000, 0, 10, 20000)]
        [TestCase(0, 5, 10, 0)]
        public void CalculateTotalDepositTest(double deposit, int duration, double interestRate, double expected)
        {
            double actual = BankingSystem.CalculateTotalDeposit(deposit, duration, interestRate);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(700, 3)]
        [TestCase(3800, 7)]
        [TestCase(500, 1)]
        [TestCase(2000, 2)]
        public void CalculateNumberOfBanknotesTest(int amountOfMoney, int expected)
        {
            int actual = BankingSystem.CalculateNumberOfBanknotes(amountOfMoney);
            Assert.AreEqual(expected, actual);
        }
    }
}