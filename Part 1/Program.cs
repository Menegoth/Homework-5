using System;

/// Week 5		Homework 1
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  October 4th 2020

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare arrays
            int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copy = new int[original.Length];

            CopyArray(original, copy);

            //print both arrays
            Console.WriteLine("Original:");
            PrintArray(original);

            Console.WriteLine("Copy:");
            PrintArray(copy);

        }

        //function that copies two arrays of the same length
        static void CopyArray(int[] original, int[] copy)
        {

            if (original.Length != copy.Length)
            {
                Console.WriteLine("These two arrays have different lengths");
                return;
            }

            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }

        }

        //printarray function
        static void PrintArray(int[] array)
        {

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

        }

    }
}
