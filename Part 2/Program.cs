using System;

/// Week 5		Homework 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  October 4th 2020

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = GenerateArray(10);
            Reverse(numbers);
            PrintArray(numbers);

        }

        //generate array of int type
        static int[] GenerateArray(int length)
        {
            //generate array of given length
            int[] tempArray = new int[length];

            Console.WriteLine("Enter {0} numbers.", length);
            
            //generate array based on given length
            for (int i = 0; i < length; i++)
            {
                tempArray[i] = Int32.Parse(Console.ReadLine());
            }

            return tempArray;

        }

        //reverse array of int type
        static void Reverse(int[] array)
        {
            //temp holding variables
            int temp, a, b;

            for (int i = 0; i < array.Length / 2; i++)
            {
                //set to temp variables, accounting for 0 index
                a = array[i];
                b = array[array.Length - i - 1];

                //make the swap
                temp = a;
                a = b;
                b = temp;

                //set indexes to corresponding numbers, accounting for 0 index
                array[i] = a;
                array[array.Length - i - 1] = b;

            }

        }

        //print array of int type
        static void PrintArray(int[] array)
        {

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

        }

    }
}
