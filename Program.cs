const string UsdToRubCommand = "1";
const string UsdToEurCommand = "2";
const string RubToUsdCommand = "3";
const string RubToEurCommand = "4";
const string EurToUsdCommand = "5";
const string EurToRubCommand = "6";

float dollars = 56.4f;
float rubs = 1045.0f;
float euros = 10.0f;
string comandExit = "exit";
float dolToRub = 70.07f;
float dolToEur = 0.92f;
float rubToDol = 0.014f;
float rubToEur = 0.013f;
float eurToDol = 1.09f;
float eurToRub = 76.46f;
float amountOfExchange;
Console.WriteLine("Здравствуйте. Хотите начать работу с конвертером валют? Для согласия напишите 'да'");
string answer = Console.ReadLine();
string entryCondition = "да";

if (answer == entryCondition)
{
    while (answer != comandExit)
    {
        Console.WriteLine("Добро пожаловать в конвертер валют!\n\nЧто вы хотите обменять?\nДоллары: в рубли - 1, в евро - 2\nРубли: в доллары - 3, в евро - 4\nЕвро: в доллары - 5 в рубли - 6");
        Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case UsdToRubCommand:
                Console.WriteLine("Сколько долларов вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (dollars >= amountOfExchange)
                {
                    rubs += amountOfExchange * dolToRub;
                    dollars -= amountOfExchange;
                }
                else
                {
                    Console.WriteLine("Недостаточно данной валюты на балансе.");
                }

                break;

            case UsdToEurCommand:
                Console.WriteLine("Сколько долларов вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (dollars >= amountOfExchange)
                {
                    euros += amountOfExchange * dolToEur;
                    dollars -= amountOfExchange;

                }
                else
                {
                    Console.WriteLine("Недостаточно данной валюты на балансе.");
                }

                break;

            case RubToUsdCommand:
                Console.WriteLine("Сколько рублей вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (rubs >= amountOfExchange)
                {
                    dollars += amountOfExchange * rubToDol;
                    rubs -= amountOfExchange;
                }
                else
                {
                    Console.WriteLine("Недостаточно данной валюты на балансе.");
                }

                break;

            case RubToEurCommand:
                Console.WriteLine("Сколько рублей вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (rubs >= amountOfExchange)
                {
                    euros += amountOfExchange * rubToEur;
                    rubs -= amountOfExchange;
                }
                else
                {
                    Console.WriteLine("Недостаточно данной валюты на балансе.");
                }

                break;

            case EurToUsdCommand:
                Console.WriteLine("Сколько евро вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (euros >= amountOfExchange)
                {
                    dollars += amountOfExchange * eurToDol;
                    euros -= amountOfExchange;
                }
                else
                {
                    Console.WriteLine("Недостаточно данной валюты на балансе.");
                }

                break;

            case EurToRubCommand:
                Console.WriteLine("Сколько евро вы хотите обменять?");
                amountOfExchange = Convert.ToSingle(Console.ReadLine());

                if (euros >= amountOfExchange)
                {
                    rubs += amountOfExchange * eurToRub;
                    euros -= amountOfExchange;
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

        Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");
        Console.WriteLine("Спасибо. Если желаете выйти из программы, напишите 'да', в противном случае пишите что угодно");
        comandExit = Console.ReadLine();
        Console.Clear();
    }
}
else
{
    Console.WriteLine("Обязательно заходите в программу в следующий раз.");
}
