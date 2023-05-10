//Задание 4. Наименьший элемент в последовательности

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите длину последовательности:");

            string? enteringString = Console.ReadLine();
            int parceSequence;
            int compareValue = int.MaxValue;
            int currentNumber;

            if (enteringString != null)
            {
                parceSequence = int.Parse(enteringString);
                Console.WriteLine("Введите числа последовательности:");
                for (int i = 0; i < parceSequence; i++)
                {
                    enteringString = Console.ReadLine();
                    if(enteringString != null)
                    {
                        currentNumber = int.Parse(enteringString);
                        if (compareValue > currentNumber)
                        {
                            compareValue = currentNumber;
                        }
                    }

                }
                Console.WriteLine($"Наименьшее число из введённых: {compareValue}");
            }
        }
    }
}