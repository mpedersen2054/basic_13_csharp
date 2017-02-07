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
            Console.WriteLine("hello there");
        }
        public static void Main(string[] args)
        {
            // printAllNums();
            // printOddNums();
            // printSum();
            printArrVals();
        }
    }
}