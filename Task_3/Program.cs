//Задание 3. Проверка простого числа

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int parceNumber;
            int cachedValue;
            bool comparisonResult = false;
            Console.WriteLine("Введите целое число для проверки:");
            string? enteredString = Console.ReadLine();

            
            if (enteredString != null)
            {
                parceNumber = int.Parse(enteredString);
                cachedValue = parceNumber;
                parceNumber--;

                while (parceNumber > 1)
                {

                    if (cachedValue % parceNumber == 0)
                    {
                        comparisonResult = true;
                        break;
                    }
                    parceNumber--;
                }
                if (cachedValue != 1)
                {
                    if (comparisonResult)
                    {
                        Console.WriteLine($"Число {cachedValue} не может являться простым числом.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {cachedValue} - простое число.");
                    }
                }
                else
                {
                    Console.WriteLine($"Число 1 не является ни простым, ни составным числом, так как у него только один делитель.");
                }
            }
        }
    }
}