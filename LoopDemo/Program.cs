using System;
using System.Collections.Generic;

namespace LoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a for loop that prints the number from 50 through 1 to the console. (Start with fifty and count down).
            //for (int i = 50; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // Write a while loop that prints only the even numbers from 2 through 50 to the console.
            //int n = 2;
            //while (n < 52)
            //{
            //    if (n % 2 == 0)
            //    {
            //        Console.WriteLine(n);
            //        n++;
            //    }
            //    else
            //    {
            //        n++;
            //    }
            //}

            // Write a for loop that prints each letter individually in the word "Hello world!" to the console.
            //string str = "Hello world!";
            //foreach (char c in str)
            //{
            //    Console.Write(c);
            //}

            // Write any type of loop that adds the numbers 1 through 20 to a List<int> collection.
            //int sum = 0;
            //List<string> listNum = new List<string>();

            //for (int i = 1; i < 21; i++)
            //{
            //    sum += i;
            //    string strSum = Convert.ToString(sum);
            //    listNum.Add(strSum);
            //}

            //foreach (var stringnum in listNum)
            //{
            //    Console.WriteLine($"{stringnum}");
            //}

            // Write a loop inside of a loop another loop that prints the numbers 1-9 to the console. (Copy the below code to your application and iterate through it).
            var numbers = new int[][]
            {
                new int [] {1,2,3},
                new int [] {4,5,6},
                new int [] {7,8,9},
                new int [] {10, 11, 12, 13},
            };

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var k = 0; k < numbers[i].Length; k++)
                {
                    Console.WriteLine(numbers[i][k]);
                }
                
            }
        }
    }
}
