using System;

namespace ITExpertsERa_BatchMay2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Welcome To the ITEXpertsERa");
            //Console.WriteLine("This is our May 2022 batch");
            //Console.WriteLine("This is our May 2022 batch.............");

            //Console.Write("This is same line code");
            //Console.Write("This is same line code");
            //Console.Write("This is same line code");
            //Console.Write("This is same line code");

            ////////////////////////////////////////////////////////////////////////
            ///

            //Console.WriteLine();
            //Console.WriteLine("============================Programming Started Now==============================");

            //int number1 = 10; 
            //int number2 = 20;

            //int result = number1 + number2;

            //Console.WriteLine(result);

            //// Take Inputs from User.  string variable = "abc1";

            //Console.WriteLine("Please Enter your First Number");

            //int num1 = Convert.ToInt32(Console.ReadLine()); // String needs to be converted everytime we want different datatype.

            //Console.WriteLine("Please enter your second number");

            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int sumResult = num1 + num2;
            //int diffResult = num1 - num2;
            //int mulResult = num1 * num2;
            //int divResult = num1 / num2;

            //Console.WriteLine("Sum of the num 1 and num 2 is " + sumResult);
            //Console.WriteLine("Subtraction of the num 1 and num 2 is " + diffResult);
            //Console.WriteLine("Multiplications of the num 1 and num 2 is " + mulResult);
            //Console.WriteLine("Divide of the num 1 and num 2 is " + divResult);


            //// DataType

            //Console.WriteLine("======================DataType Starts From Here========================");

            //int variable1 = 20;
            //string variäble2 = "This is  dotnet class";
            //bool variable3 = true;
            //DateTime variable4 = DateTime.Now;
            //decimal variable5 = 10.50M;

            //byte variable6 = 255;
            //sbyte variable7 = 40;

            //Console.WriteLine("===================New Question Starts Here for If condition==================");

            //Console.WriteLine("Please Enter Your Marks ?");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //if (marks > 80)
            //{
            //    Console.WriteLine("Congratulations, You are the topper of the college");
            //}
            //else if (marks > 60 && marks < 80) // for multiple condition use &&
            //{
            //    Console.WriteLine("You have got Second Rank");
            //}
            //else if (marks >= 40 && marks <= 60)
            //{
            //    Console.WriteLine("You have got Third Rank");
            //}
            //else
            //{
            //    Console.WriteLine("You are Failed in your examination");
            //}


            //int result = BiggestNumber(90, 70, 30);

            //Console.WriteLine(result);

            Console.WriteLine("New Changes");

            Console.WriteLine(1 % 4);

            Console.Read();
        }

        public static int BiggestNumber(int a, int b, int c)
        {

            //if (a > b && a > c)
            //{
            //    return a; 
            //}
            //else if (b > a && b > c)
            //{
            //    return b;
            //}
            //else
            //{
            //    return c;
            //}

            return (a > b && a > c) ? a : (b > c) ? b : c;
        }
    }
}
