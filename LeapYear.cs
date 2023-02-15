 namespace LogicalProgramming
    {
        public class LeapYear
        {
            public static void CheckLeapYear()
            {
                Console.WriteLine("Enter a 4 digit year to check for leap year");

                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }

        }
    }
    

