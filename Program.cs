const string Answer = "exit";
const string ConvertUsdToRubCommand = "1";
const string ConvertUsdToEurCommand = "2";
const string ConvertRubToUsdCommand = "3";
const string ConvertRubToEurCommand = "4";
const string ConvertEurToUsdCommand = "5";
const string ConvertEurToRubCommand = "6";
const float UsdToRub = 70.07f;
const float UsdToEur = 0.92f;
const float RubToUsd = 0.014f;
const float RubToEur = 0.013f;
const float EurToUsd = 1.09f;
const float EurToRub = 76.46f;

float balanceUSD = 56.4f;
float balanceRUB = 1045.0f;
float balanceEUR = 10.0f;
string commandExit = "";
float amountOfExchange;

while (Answer != commandExit)
{
    Console.WriteLine($"Добро пожаловать в конвертер валют!\n\nЧто вы хотите обменять?\nДоллары: в рубли - {ConvertUsdToRubCommand}, в евро - {ConvertUsdToEurCommand}" +
        $"\nРубли: в доллары - {ConvertRubToUsdCommand}, в евро - {ConvertRubToEurCommand}\nЕвро: в доллары - {ConvertEurToUsdCommand} в рубли - {ConvertEurToRubCommand}");
    Console.WriteLine($"Ваш баланс: рубли - {balanceRUB}; доллары - {balanceUSD}; евро - {balanceEUR}");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case ConvertUsdToRubCommand:
            Console.WriteLine("Сколько долларов вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceUSD >= amountOfExchange)
            {
                balanceRUB += amountOfExchange * UsdToRub;
                balanceUSD -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

         case ConvertUsdToEurCommand:
            Console.WriteLine("Сколько долларов вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceUSD >= amountOfExchange)
            {
                balanceEUR += amountOfExchange * UsdToEur;
                balanceUSD -= amountOfExchange;

            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

          case ConvertRubToUsdCommand:
            Console.WriteLine("Сколько рублей вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceRUB >= amountOfExchange)
            {
                balanceUSD += amountOfExchange * RubToUsd;
                    balanceRUB -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

        case ConvertRubToEurCommand:
            Console.WriteLine("Сколько рублей вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceRUB >= amountOfExchange)
            {
                balanceEUR += amountOfExchange * RubToEur;
                balanceRUB -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

        case ConvertEurToUsdCommand:
            Console.WriteLine("Сколько евро вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceEUR >= amountOfExchange)
            {
                balanceUSD += amountOfExchange * EurToUsd;
                balanceEUR -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

        case ConvertEurToRubCommand:
            Console.WriteLine("Сколько евро вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (balanceEUR >= amountOfExchange)
            {
                balanceRUB += amountOfExchange * EurToRub;
                balanceEUR -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
            break;

         default:
            Console.WriteLine("Я вас не понял.");
            break;
    }

    Console.WriteLine($"Ваш баланс: рубли - {balanceRUB}; доллары - {balanceUSD}; евро - {balanceEUR}");
    Console.WriteLine("Спасибо. Если желаете выйти из программы, напишите " + Answer + ", в противном случае пишите что угодно");
    commandExit = Console.ReadLine();
    Console.Clear();
}