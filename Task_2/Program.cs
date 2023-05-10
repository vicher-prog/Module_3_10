//Задание 2. Программа подсчёта суммы карт в игре «21»

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardsNumber;
            
            string? enteredString;
            
            int summ = 0;
            
            Console.WriteLine("Приветствую! Поиграем?\nУкажите сколько карт у вас на руках:");
            
            enteredString = Console.ReadLine();
            
            Console.WriteLine("Введите номиналы карт (возможные варианты 7, 8, 9, 10, Q, J, K, T):");
           
            if (enteredString != null)
            {
                cardsNumber = int.Parse(enteredString);
                for (int i = cardsNumber; i > 0; i--)
                {
                    Console.WriteLine($"Введите номинал {cardsNumber - i + 1} карты:");
                    enteredString = Console.ReadLine();

                    switch (enteredString)
                    {
                        case "7":
                            summ += 7;
                            break;
                        case "8":
                            summ += 8;
                            break;
                        case "9":
                            summ += 9;
                            break;
                        case "10":
                            summ += 10;
                            break;
                        case "J":
                            summ += 10;
                            break;
                        case "Q":
                            summ += 10;
                            break;
                        case "K":
                            summ += 10;
                            break;
                        case "T":
                            summ += 10;
                            break;
                        default:
                            Console.WriteLine("Введёной вами карты нет!");
                            i++;
                            break;
                    }
                }
                Console.WriteLine($"Сумма ваших карт:{summ}");
            }
        }
    }
}