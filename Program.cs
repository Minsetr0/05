float dollars = 56.4f;
float rubs = 1045.0f;
float euros = 10.0f;
string endCycle = "exit";
float dolToRub = 70.07f;
float dolToEur = 0.92f;
float rubToDol = 0.014f;
float rubToEur = 0.013f;
float eurToDol = 1.09f;
float eurToRub = 76.46f;
float amountOfExchange;
Console.WriteLine("Здравствуйте. Хотите начать работу с конвертером валют? Для согласия напишите 'да'");
string isWorking = Console.ReadLine();

if (isWorking == "да")
{
    while (isWorking != endCycle)
    {
        Console.WriteLine("Добро пожаловать в конвертер валют!\n\nЧто вы хотите обменять?\nДоллары: в рубли - 1, в евро - 2\nРубли: в доллары - 3, в евро - 4\nЕвро: в доллары - 5 в рубли - 6");
        Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
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

            case "2":
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

            case "3":
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

            case "4":
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

            case "5":
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

            case "6":
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
        endCycle = Console.ReadLine();
        Console.Clear();
    }
}
else 
{
    Console.WriteLine("Обязательно заходите в программу в следующий раз.");
}