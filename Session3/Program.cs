namespace Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            // 1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //bool isTheConversionOccur = false;

            //do
            //{
            //    Console.Write("Enter the number: ");
            //    isTheConversionOccur = int.TryParse(Console.ReadLine(), out int number);

            //    if (isTheConversionOccur)
            //    {
            //        if (number % 3 == 0 && number % 4 == 0)
            //        {
            //            Console.WriteLine("Yes");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("Cannot convert the input to a number.");
            //    }

            //}
            //while (!isTheConversionOccur);

            #endregion

            #region

            // 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            bool isTheConversionOccur = false;

            do
            {
                Console.Write("Enter the number: ");
                isTheConversionOccur = int.TryParse(Console.ReadLine(), out int number);

                if (isTheConversionOccur)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else
                    {
                        Console.WriteLine("Positive");
                    }
                }

                else
                {
                    Console.WriteLine("Cannot convert the input to a number.");
                }

            }
            while (!isTheConversionOccur);

            #endregion
        }
    }
}
