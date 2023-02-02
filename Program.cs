float dollars = 56.4f;
float rubs = 1045.0f;
float euros = 10.0f;
string endCycle = "exit";
string isWorking = null;
float dollarToRub = 70.07f;
float dollarToEuro = 0.92f;
float rubToDollar = 0.014f;
float rubToEuro = 0.013f;
float euroToDollar = 1.09f;
float euroToRub = 76.46f;
float amountOfExchange;

while (isWorking != endCycle)
{
    Console.SetCursorPosition(50, 20);
    Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");

    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Добро пожаловать в конвертер валют!\n\nЧто вы хотите обменять?\nДоллары: в рубли - 1, в евро - 2\nРубли: в доллары - 3, в евро - 4\nЕвро: в доллары - 5 в рубли - 6");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.WriteLine("Сколько долларов вы хотите обменять?");
            amountOfExchange = Convert.ToSingle(Console.ReadLine());

            if (dollars >= amountOfExchange)
            {
                rubs += amountOfExchange * dollarToRub;
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
                euros += amountOfExchange * dollarToEuro;
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
                dollars += amountOfExchange * rubToDollar;
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
                euros += amountOfExchange * rubToEuro;
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
                dollars += amountOfExchange * euroToDollar;
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
                rubs += amountOfExchange * euroToRub;
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

    Console.SetCursorPosition(50, 20);
    Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");
    Console.SetCursorPosition(50, 20);
    Console.WriteLine($"Ваш баланс: рубли - {rubs}; доллары - {dollars}; евро - {euros}");
    Console.WriteLine("Спасибо. Если желаете выйти из программы, напишите exit, а если продолжить - напишите что угодно.");
    isWorking = Console.ReadLine();
    Console.Clear();
}