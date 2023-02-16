

namespace FunctionalProgramming
{
    public class Harmonic
    {
        public static void PrintHarmonic()
            {
                Console.Write("Enter a harmonic number: ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N != 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        Console.Write("1/" + i + " ");
                    }

                }
                else
                {
                    Console.WriteLine("Enter a valid number ");
                }
            }
        }
    }



