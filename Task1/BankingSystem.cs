using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class BankingSystem
    {
        public static bool IsOfferAvailable(int age, int numberOfServicesUsed, double deposit)
        {
            if (age <= 0) throw new ArgumentException("Argument value is invalid");
            if (numberOfServicesUsed < 0) throw new ArgumentException("Argument value is invalid");
            if (deposit < 0) throw new ArgumentException("Argument value is invalid");
            if (age >= 60 || deposit > 1000000 || (numberOfServicesUsed >= 3 && deposit > 400000)) return true;
            return false;
        }
        public static void DisplayInfoAboutOfferAvailability(string clientName, bool isOfferAvailable)
        {
            if (isOfferAvailable) Console.WriteLine($"Клиент {clientName} может воспользоваться акционным предложением.");
            else Console.WriteLine($"Клиент {clientName} не может воспользоваться акционным предложением.");
        }

        public static double CalculateTotalDeposit(double deposit, int duration, double interestRate)
        {
            if (deposit < 0) throw new ArgumentException("Argument value is invalid");
            if (duration < 0) throw new ArgumentException("Argument value is invalid");
            if (interestRate < 0) throw new ArgumentException("Argument value is invalid");
            interestRate = interestRate / 100;
            for (int i = 0; i < duration; i++)
            {
                deposit += deposit * interestRate;
            }

            return deposit;
        }
        public static void DisplayInfoAboutDeposit(string clientName, double deposit)
        {
            Console.WriteLine($"Размер банковского вклада клиента {clientName} равен {deposit}.");
        }

        public static int CalculateNumberOfBanknotes(int amountOfMoney)
        {
            if (amountOfMoney < 100) throw new ArgumentException("Argument value is invalid");
            int thousand = 0;
            int fiveHundred = 0;
            int oneHundred = 0;

            while (amountOfMoney >= 1000)
            {
                thousand++;
                amountOfMoney -= 1000;
            }
            while (amountOfMoney >= 500)
            {
                fiveHundred++;
                amountOfMoney -= 500;
            }
            while (amountOfMoney >= 100)
            {
                oneHundred++;
                amountOfMoney -= 100;
            }

            return thousand+fiveHundred+oneHundred;
        }
        public static void DisplayAtmInfo(int numberOfBanknotes)
        {
            Console.WriteLine($"Банкоматом будет произведена выдача {numberOfBanknotes} купюр.");
        }

    }

}
