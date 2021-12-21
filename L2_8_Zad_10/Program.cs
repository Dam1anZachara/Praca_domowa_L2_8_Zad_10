using System;

namespace L2_8_Zad_10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("***Program znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb całkowitych dodatnich***");
                Console.WriteLine("\r\n-Aby wyjść z programu naciśnij klawisz \"Esc\" po wykonaniu obliczeń.");
                Console.WriteLine("\r\n-Aby wykonać kolejne oblieczenia naciśnij dowolny klawisz z wyłączeniem \"Esc\".");

                Console.Write("\r\nPodaj pierwszą liczbę całkowitą dodatnią: ");
                bool firstNumberIsUint = uint.TryParse(Console.ReadLine(), out uint firstNumber);

                Console.Write("\r\nPodaj drugą liczbę całkowitą dodatnią: ");
                bool secondNumberIsUint = uint.TryParse(Console.ReadLine(), out uint secondNumber);

                uint multipleOfFirstNumber = 0;
                uint multipleOfSecondNumber = 1;

                uint counterOne = 1;
                uint counterTwo = 1;

                if (firstNumberIsUint && secondNumberIsUint)
                {
                    while (multipleOfFirstNumber != multipleOfSecondNumber)
                    {
                        multipleOfFirstNumber = firstNumber * counterOne;
                        multipleOfSecondNumber = secondNumber * counterTwo;

                        if (multipleOfFirstNumber > multipleOfSecondNumber)
                        {
                            counterTwo++;
                        }
                        else if (multipleOfFirstNumber < multipleOfSecondNumber)
                        {
                            counterOne++;
                        }
                        else
                        {
                            Console.WriteLine($"\r\nNajmniejsza wspólna wielokrotność liczby {firstNumber} i {secondNumber} wynosi: {multipleOfFirstNumber}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\r\nBłędnie wpisane liczby");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
