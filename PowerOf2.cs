namespace FunctionalProgramming
{
    public class PowerOf2
    {
        public static void PrintPowerOf2()
        {
            int N = 2;
            int result = 1;

            Console.Write("Enter a Power number: ");
            int power = Convert.ToInt32(Console.ReadLine());
            if (power >= 0 && power < 31)
            {
                for (int i = 0; i < power; i++)
                {
                    Console.Write((result = result * N) + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("enter a power between 0 and 31");
            }
        }
    }
}
   

