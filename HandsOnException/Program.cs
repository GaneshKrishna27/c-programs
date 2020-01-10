﻿using System;

namespace HandsOnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);

                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[3]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + "" + e.Source + "" + e.StackTrace);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message + "" + e.Source + "" + e.StackTrace);
            }            Console.ReadLine();
        }
    }
}
