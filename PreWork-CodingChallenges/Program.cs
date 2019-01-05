using System;

namespace PreWork_CodingChallenges
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++) //iterate a counter 5 times
            {
                //ask the user for numbers and put them in the array
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Please enter a number between 1-10: ");
                string answer = Console.ReadLine();
                int result = Int32.Parse(answer);
                numbers[i] = result;
            }
            // Display user array - numbers;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            // ask the user for a number to calculate
            Console.WriteLine("Please choose a number listed above: ");
            string value = Console.ReadLine();
            int target = Int32.Parse(value);
            Console.WriteLine($"your score is {MaxArrayResult(numbers, target)}!!!! ");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please provide a year to check if it is a Gregorian Leap Year!");
            string year = Console.ReadLine();
            int gyear = Int32.Parse(year);
            LeapYearCalc(gyear);
            Console.WriteLine($"{LeapYearCalc(gyear)}");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            int[] numbers2 = new int[3];
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < numbers2.Length; i++) //iterate a counter 5 times
            {
                //ask the user for numbers and put them in the array
                Console.WriteLine("Please enter a number between 1-10: ");
                string answer2 = Console.ReadLine();
                int result2 = Int32.Parse(answer2);
                numbers2[i] = result2;

            }
            Console.WriteLine($"{PerfectArrayCalc(numbers2)}");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How many rows do you need? 1-3");
            string arrayValue1 = Console.ReadLine();
            int rows = Int32.Parse(arrayValue1);
            Console.WriteLine("How many columns? 3-5");
            string arrayValue2 = Console.ReadLine();
            int columns = Int32.Parse(arrayValue2);
            // int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }; //mocked values
            int[,] myArray = new int[rows, columns];
            //int sum = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Please provide a number for your array: ");
                    string arrayValue3 = Console.ReadLine();
                    int twoDArray = Int32.Parse(arrayValue3);
                    myArray[i, j] = twoDArray;
                }

            }

            int[] results = ArraySumTool(myArray);
            Console.WriteLine(string.Join(',', results));
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.ReadLine();


        }
        

        static int MaxArrayResult(int[] numbers, int target)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (target == numbers[i])
                {
                    counter++;
                }
            }
            int score = counter * target;
            return score;
        }
        static bool LeapYearCalc(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;

            }
            return false;
        }
        static bool PerfectArrayCalc(int[] numbers2)
        {
            int prod = 1;
            foreach (int value in numbers2)
            {
                prod *= value;
            }
            int sum = 0;
            foreach (int value in numbers2)
            {
                sum += value;
            }

            if (prod == sum)
            {
                return true;
            }
            return false;
        }
        static int[] ArraySumTool(int[,] myArray)
        {
            int[] sumValues = new int[myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i, j];
                }
                sumValues[i] = sum;
            }
            return sumValues;
        }
    }

}
