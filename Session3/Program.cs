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

            //bool isTheConversionOccur = false;

            //do
            //{
            //    Console.Write("Enter the number: ");
            //    isTheConversionOccur = int.TryParse(Console.ReadLine(), out int number);

            //    if (isTheConversionOccur)
            //    {
            //        if (number < 0)
            //        {
            //            Console.WriteLine("Negative");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Positive");
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

            // 3. Write a program that takes 3 integers from the user then prints the max element and the min element.

            //int[] numbers = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    bool parsed = false;
            //    do
            //    {
            //        Console.Write($"Enter integer number {i + 1}: ");
            //        parsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //        if (!parsed)
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    } 
            //    while (!parsed);
            //}

            //int min = numbers[0];
            //int max = numbers[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (numbers[i] < min) min = numbers[i];
            //    if (numbers[i] > max) max = numbers[i];
            //}

            //Console.WriteLine($"Min: {min}, Max: {max}");

            #endregion

            #region

            // 4. Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("it is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("it's an odd number.");
            //}

            #endregion

            #region

            // 5. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //char[] Vowel_chars = { 'a', 'e', 'i', 'u', 'o' };
            //bool isVowel = false;

            //Console.Write("Enter a single char: ");
            //char.TryParse(Console.ReadLine(), out char character);

            //for(int i = 0; i < Vowel_chars.Length; i++)
            //{
            //    if(character == Vowel_chars[i])
            //    {
            //        Console.WriteLine("it is a Vowel Char.");
            //        isVowel = true;
            //    }
            //}
            //if(!isVowel)
            //{
            //    Console.WriteLine("it is a consonant char.");
            //}

            #endregion

            #region

            // 6. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a number to print between 1 and your number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for(int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region

            // 7. Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for(int i = 1; i <= 12; i++ )
            //{
            //    Console.Write($"{i*num}  ");
            //}
            #endregion

            #region

            // 8. Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a number to print even nums between 1 and your number: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            #endregion

            #region

            // 9. Write a program that takes two integers then prints the power.

            //Console.Write("Enter (First: num) :  ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.Write("Enter (Second : to power) : ");
            //int.TryParse(Console.ReadLine(), out int power);

            //Console.WriteLine($"the answer: {Math.Pow(num, power)} ");
            #endregion

            #region

            // 10. Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] Marks = new int[5];

            //for(int i = 0; i <5; i++)
            //{
            //    bool parsed = false;
            //    do
            //    {
            //        Console.Write($"Enter the subject{i} degree: ");
            //        parsed = int.TryParse(Console.ReadLine(), out Marks[i]);
            //        if(!parsed)
            //            Console.WriteLine("your input is invalid!");
            //    }
            //    while (!parsed);
            //}

            //// for the total mark
            //double Total = 0;

            //for(int j =0; j< Marks.Length;j++)
            //{
            //     Total += Marks[j];
            //}
            //Console.WriteLine($"The total is: {Total}");

            //// Average 
            //double average = Total / 5;
            //Console.WriteLine($"The average is: {average}");

            //// percantage
            //double percentage = (Total / 500) * 100;
            //Console.WriteLine($"The percantage is: {percentage}");

            #endregion

            #region

            // 11. Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter month number: ");
            //bool parsed = int.TryParse(Console.ReadLine(), out int month);

            //if (parsed)
            //{
            //    switch (month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("Days in Month: 31");
            //            break;

            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("Days in Month: 30");
            //            break;

            //        case 2:
            //            Console.WriteLine("Days in Month: 28");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid month number.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            #endregion

            #region

            // 12. Write a program to create a Simple Calculator.

            //Console.Write("Enter first number: ");
            //double.TryParse(Console.ReadLine(), out double num1);

            //Console.Write("Enter second number: ");
            //double.TryParse(Console.ReadLine(), out double num2);

            //Console.Write("Enter operator (+, -, *, /): ");
            //char.TryParse(Console.ReadLine(), out char operation);

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine($"Result = {num1 + num2}");
            //        break;

            //    case '-':
            //        Console.WriteLine($"Result = {num1 - num2}");
            //        break;

            //    case '*':
            //        Console.WriteLine($"Result = {num1 * num2}");
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //            Console.WriteLine($"Result = {num1 / num2}");
            //        else
            //            Console.WriteLine("Cannot divide by zero.");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operation.");
            //        break;
            //}
            #endregion

            #region

            // 13. Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            #region
        }
    }
}
