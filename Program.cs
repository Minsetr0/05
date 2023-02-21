const string UsdToRubCommand = "1";
const string UsdToEurCommand = "2";
const string RubToUsdCommand = "3";
const string RubToEurCommand = "4";
const string EurToUsdCommand = "5";
const string EurToRubCommand = "6";
const float UsdToRub = 70.07f;
const float UsdToEur = 0.92f;
const float RubToUsd = 0.014f;
const float RubToEur = 0.013f;
const float EurToUsd = 1.09f;
const float EurToRub = 76.46f;

float USD = 56.4f;
float RUB = 1045.0f;
float EUR = 10.0f;
string comandExit = "";
float amountOfExchange;
string answer = "exit";
while (answer != comandExit)
{
    Console.WriteLine($"Добро пожаловать в конвертер валют!\n\nЧто вы хотите обменять?\nДоллары: в рубли - {UsdToRubCommand}, в евро - {UsdToEurCommand}" +
        $"\nРубли: в доллары - {RubToUsdCommand}, в евро - {RubToEurCommand}\nЕвро: в доллары - {EurToUsdCommand} в рубли - {EurToRubCommand}");
    Console.WriteLine($"Ваш баланс: рубли - {RUB}; доллары - {USD}; евро - {EUR}");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case UsdToRubCommand:
            Console.WriteLine("Сколько долларов вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (USD >= amountOfExchange)
            {
                RUB += amountOfExchange * UsdToRub;
                USD -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }

            break;

         case UsdToEurCommand:
            Console.WriteLine("Сколько долларов вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (USD >= amountOfExchange)
            {
                EUR += amountOfExchange * UsdToEur;
                USD -= amountOfExchange;

            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }

            break;

          case RubToUsdCommand:
            Console.WriteLine("Сколько рублей вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (RUB >= amountOfExchange)
            {
                USD += amountOfExchange * RubToUsd;
                RUB -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }
    
            break;

        case RubToEurCommand:
            Console.WriteLine("Сколько рублей вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (RUB >= amountOfExchange)
            {
                EUR += amountOfExchange * RubToEur;
                RUB -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }

            break;

        case EurToUsdCommand:
            Console.WriteLine("Сколько евро вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (EUR >= amountOfExchange)
            {
                USD += amountOfExchange * EurToUsd;
                EUR -= amountOfExchange;
            }
            else
            {
                Console.WriteLine("Недостаточно данной валюты на балансе.");
            }

            break;

        case EurToRubCommand:
            Console.WriteLine("Сколько евро вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (EUR >= amountOfExchange)
            {
                RUB += amountOfExchange * EurToRub;
                EUR -= amountOfExchange;
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

    Console.WriteLine($"Ваш баланс: рубли - {RUB}; доллары - {USD}; евро - {EUR}");
    Console.WriteLine("Спасибо. Если желаете выйти из программы, напишите " + answer + ", в противном случае пишите что угодно");
    comandExit = Console.ReadLine();
    Console.Clear();
}