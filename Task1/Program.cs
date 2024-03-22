using Task1;

//использование методов библиотеки 

Console.WriteLine("Введите информацию о клиенте (имя, возраст, количество банковских продуктов, сумма средств на счете):");
string clientName = Console.ReadLine();
int age = Convert.ToInt32(Console.ReadLine());
int numberOfServicesUsed = Convert.ToInt32(Console.ReadLine());
double deposit = Convert.ToDouble(Console.ReadLine());
bool isOfferAvailable =  BankingSystem.IsOfferAvailable(age, numberOfServicesUsed, deposit);
BankingSystem.DisplayInfoAboutOfferAvailability(clientName, isOfferAvailable);

Console.WriteLine();

Console.WriteLine("Введите информацию о имени клиента, размере вклада, продолжительности вклада в годах и процентной ставке:");
string anotherClientName = Console.ReadLine();
double anotherDeposit = Convert.ToDouble(Console.ReadLine());
int duration = Convert.ToInt32(Console.ReadLine());
double interestRate =  Convert.ToDouble(Console.ReadLine());
double totalDeposit = BankingSystem.CalculateTotalDeposit(anotherDeposit, duration, interestRate);
BankingSystem.DisplayInfoAboutDeposit(anotherClientName, totalDeposit);

Console.WriteLine();

Console.WriteLine("Введите сумму денег:");
int amountOfMoney = Convert.ToInt32(Console.ReadLine());
int numberOfBanknotes = BankingSystem.CalculateNumberOfBanknotes(amountOfMoney);
BankingSystem.DisplayAtmInfo(numberOfBanknotes);