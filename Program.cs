using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void printAllNums()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void printOddNums()
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void printSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("New number: {0} | Sum: {1}", i, sum);
            }
            // Console.WriteLine(sum);
        }
        public static void printArrVals()
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9, 13 };
            foreach (int item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void findMax()
        {
            int[] arr = new int[] { -1, 3, -5, 7, 9, -13, 0 };
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            System.Console.WriteLine(max); // expect 9
        }
        public static void getAverage()
        {
            System.Console.WriteLine("HELLO");
            int[] arr = new int[] { 1, 3, 5, 7, 9, 13, 0 };
            int sum = 0;
            foreach (int numb in arr)
            {
                sum += numb;
            }
            System.Console.WriteLine(sum / arr.Length);
        }
        public static void arrOfOdds()
        {
            int[] odds = new int[256 / 2];
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    odds[(i-1)/2] = i;
                }
            }
            System.Console.WriteLine(odds);
        }
        public static void greaterThanY()
        {
            int[] arr = { 1, 3, 5, 7 };
            int y = 2;
            int numOfGreater = 0;

            foreach (int numb in arr)
            {
                if (numb > y)
                {
                    numOfGreater++;
                }
            }
            System.Console.WriteLine(numOfGreater);
        }
        public static void squareVals()
        {
            int[] arr = { 1, 3, -2, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                int item = arr[i];
                arr[i] = item * item;
            }
            System.Console.WriteLine(arr);
        }
        public static void noNegatives()
        {
            int[] arr = { 1, 5, 10, -2 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            System.Console.WriteLine(arr);
        }
        public static void minMaxAvg()
        {
            int[] arr = { 1, 5, 10, -3 };
            int min = arr[0]; int max = arr[0]; int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) { min = arr[i]; }
                if (arr[i] > max) { max = arr[i]; }
                sum += arr[i];
            }

            double avg = (double)sum / (double)arr.Length;

            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(avg);
        }
        public static void shiftArr()
        {
            int[] arr = new int[] { 1, 5, 10, 7, -2 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
            System.Console.WriteLine(arr);
        }
        public static void numToStr()
        {
            int[] arr = new int[] { 1, -5, 10, 7, -2 };
            object[] secondArr = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    secondArr[i] = "Dojo";
                }
                else
                {
                    secondArr[i] = arr[i];
                }
            }
            System.Console.WriteLine(secondArr);
            
        }
        public static void Main(string[] args)
        {
            // printAllNums();
            // printOddNums();
            // printSum();
            // printArrVals();
            // findMax();
            // getAverage();
            // arrOfOdds();
            // greaterThanY();
            // squareVals();
            // noNegatives();
            // minMaxAvg();
            // shiftArr();
            numToStr();
        }
    }
}