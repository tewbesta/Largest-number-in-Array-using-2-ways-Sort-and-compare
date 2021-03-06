﻿using System;

namespace ArrayUtils
{
    class ArayUtils
    {
        public static int method(int[] array)
        {
            int i = 0;
            int newvalue=0;
            while (i < array.Length)
            {if(array[i]>newvalue)
                newvalue = array[i];
                i++;
            }
            return newvalue;
        }
        // Another simpler approach using Sort
        public static int method2(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to compare?");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the {0} number", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The array holds ");
            for (int i = 0; i < n; i++)
            {
            Console.Write(" {0}, ",x[i]); 
            }
            Console.WriteLine(". The maximum number is {0}.", method(x));
            Console.WriteLine("The maximum number using method 2 is {0}", method2(x));
        }

    }
}
