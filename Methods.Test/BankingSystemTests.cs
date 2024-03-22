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

        [TestCase(700, 3)]
        [TestCase(3800, 7)]
        [TestCase(500, 1)]
        [TestCase(2000, 2)]
        public void CalculateNumberOfBanknotesTest(int amountOfMoney, int expected)
        {
            int actual = BankingSystem.CalculateNumberOfBanknotes(amountOfMoney);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 500)]
        [TestCase(-30, 1, 500)]
        public void IsOfferAvailableTest_WhenAgeZeroOrNegative_ShouldThrowArgumentException(int age, int numberOfServicesUsed, double deposit)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.IsOfferAvailable(age, numberOfServicesUsed, deposit));
        }
        [TestCase(0, -2, 500)]
        public void IsOfferAvailableTest_WhenNumberOfServicesUsedNegative_ShouldThrowArgumentException(int age, int numberOfServicesUsed, double deposit)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.IsOfferAvailable(age, numberOfServicesUsed, deposit));
        }
        [TestCase(40, 3, -500)]
        public void IsOfferAvailableTest_WhenDepositNegative_ShouldThrowArgumentException(int age, int numberOfServicesUsed, double deposit)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.IsOfferAvailable(age, numberOfServicesUsed, deposit));
        }

        [TestCase(-100, 3, 10)]
        public void CalculateTotalDepositTest_WhenDepositNegative_ShouldThrowArgumentException(double deposit, int duration, double interestRate)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.CalculateTotalDeposit(deposit, duration, interestRate));
        }
        [TestCase(100, -3, 10)]
        public void CalculateTotalDepositTest_WhenDurationNegative_ShouldThrowArgumentException(double deposit, int duration, double interestRate)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.CalculateTotalDeposit(deposit, duration, interestRate));
        }
        [TestCase(100, 3, -10)]
        public void CalculateTotalDepositTest_WhenInterestRateNegative_ShouldThrowArgumentException(double deposit, int duration, double interestRate)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.CalculateTotalDeposit(deposit, duration, interestRate));
        }

        [TestCase(25)]
        public void CalculateNumberOfBanknotesTest_WhenAmountOfMoneyLessThanHundred_ShouldThrowArgumentException(int amountOfMoney)
        {
            Assert.Throws<ArgumentException>(() => BankingSystem.CalculateNumberOfBanknotes(amountOfMoney));
        }
    }
}