// Задание 5. Игра «Угадай число»
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное целое число диапазона:");
            string? enteredString = Console.ReadLine();
            int specifiedNumber = 0;

            if (enteredString != null)
            {
                int maxValue = int.Parse(enteredString);
                Random rnd = new Random();

                if (enteredString != null)
                {
                    specifiedNumber = rnd.Next(0, maxValue + 1);
                }
                Console.WriteLine("Загадано число, попробуйте его угадать.");
                while (true)
                {
                    string? numberString = Console.ReadLine();

                    if (numberString != null && numberString != "")
                    {
                        int number = int.Parse(numberString);
                        if (number > specifiedNumber)
                        {
                            Console.WriteLine($"Введённое число больше загаданного");
                        }
                        else if (number < specifiedNumber)
                        {
                            Console.WriteLine($"Введённое число меньше загаданного");
                        }
                        else
                        {
                            Console.WriteLine($"Вы угадали загаданное число!");
                            break;
                        }
                    }
                    else break;

                }
            }
        }
    }
}
