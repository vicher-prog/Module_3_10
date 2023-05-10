//Задание 1. Приложение по определению чётного или нечётного числа

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder;
            Console.WriteLine("Введите целое число:");
            string? enteredString = Console.ReadLine();

            if (enteredString != null)
            {
                remainder = int.Parse(enteredString) % 2;
                if (remainder == 0)
                {
                    Console.WriteLine("Вы ввели чётное число.");
                }
                else
                {
                    Console.WriteLine("Вы ввели нечётное число.");
                }
            }
        }
    }
}
