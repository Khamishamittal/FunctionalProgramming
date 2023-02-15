namespace FunctionalProgramming
{
    public class LargestNumbers
    {
        public static void FindTheLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three Number");
            Console.WriteLine("Input the Ist Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1 number is greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3 number is greatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2 number is greatest among three");
            }
            else
            {
                Console.WriteLine("The 3 number is greatest among three");

            }
        }
    }
}


