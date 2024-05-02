using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        private static void Question1()
        {
            Console.WriteLine($"{"Number"} {"Square",8} {"cubes",6}");
            Console.WriteLine("----------------------");

            int i = 10;
            int squares, cubes;

            while (i >= 1)
            {
                squares = i * i;
                cubes = i * i * i;
                Console.WriteLine($"{i,4} {squares,8} {cubes,8}");
                i--;
            }

        }

        private static void Question2()
        {
            Console.WriteLine("Enter initial value of Fahrenheit:  ");
            double initial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter final value of Fahrenheit:  ");
            double final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter increment value of Fahrenheit:  ");
            double increment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($" {"Fahrenheit",2}  {"Celsius",9} ");
            Console.WriteLine("-----------------------");

            double fahrenheit = initial;

            while (fahrenheit <= final)
            {
                double celsius = ((fahrenheit - 32) * 5) / 9;
                Console.WriteLine($" {fahrenheit,7:F2} {celsius,12:F2}");
                fahrenheit += increment;
            }

        }

        private static void Question3()
        {
            Console.WriteLine($"{"Year",5}\t{"Balance",2}");

            decimal moneyAvailable = 1000m;
            const decimal interestRate = 0.08m;
            int i = 1;

            while (i <= 10)
            {
                moneyAvailable += moneyAvailable * interestRate;
                Console.WriteLine($"{i,3}\t{moneyAvailable:c}");
                i++;
            }

        }

        private static void Question4()
        {
            int numberValidGrades = 0;
            decimal sumGrades = 0;
            bool continueEnteringGrades = true;

            while (continueEnteringGrades)
            {
                Console.WriteLine("Enter grade: ");
                decimal grade = Convert.ToDecimal(Console.ReadLine());

                if (grade == 999)
                {
                    continueEnteringGrades = false;
                }
                else if (grade >= 0 && grade <= 100)
                {
                    sumGrades += grade;
                    numberValidGrades++;
                }
                else if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid grade");
                }
            }

            if (numberValidGrades > 0)
            {
                decimal average = sumGrades / numberValidGrades;

                Console.WriteLine($"Sum of valid grades: {sumGrades:F2}");
                Console.WriteLine($"Total valid grades: {numberValidGrades:F2}");
                Console.WriteLine($"Average of valid grades: {average:F2}");
            }

        }

        private static void Question5()
        {
            char startChar, stopChar;

            Console.Write("Enter the start character: ");
            startChar = Convert.ToChar(Console.ReadLine());

            do
            {
                Console.Write("Enter the stop character: ");
                stopChar = Convert.ToChar(Console.ReadLine());

                if (startChar >= stopChar)
                {
                    Console.WriteLine("The stop character must occur later in the alphabet than the start character.");
                }

            } while (startChar >= stopChar);

            Console.WriteLine("\nLetter\tDecimal\tOctal\tHex");

            for (char currentChar = startChar; currentChar <= stopChar; currentChar++)
            {
                int decimalValue = currentChar;
                string octalValue = Convert.ToString(decimalValue, 8);
                string hexValue = Convert.ToString(decimalValue, 16);

                Console.WriteLine($"{currentChar,6}\t{decimalValue,7}\t{octalValue,5}\t{hexValue,3}");
            }

        }


        private static void Question6()
        {
            double x = 1;
            double increment = 0.5;

            Console.WriteLine($"{"x",2}\t{"2x²",4}\t-x\t-6{"y",6}");

            while (x <= 5)
            {
                double power = (Math.Pow(x, 2));
                double y = 2 * power - x - 6;
                double doublePower = 2 * power;

                Console.WriteLine($"{x,4:F1}\t{doublePower,4:F1}\t{-x,4:F1}\t-6{y,8:F1}");

                x += increment;
            }

        }

        private static void Question7()
        {
            Console.Write("Enter a positive integer number: ");
            long number = Convert.ToInt64(Console.ReadLine());
            long reversedNumber = 0;

            do
            {
                long digit = number % 10;
                reversedNumber = reversedNumber *10 + digit;
                number /= 10;

            } while (number != 0);
            Console.WriteLine($"The reversed number is : {reversedNumber}");

        }





    }
}
