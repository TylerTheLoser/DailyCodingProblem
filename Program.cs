using System;
using System.Collections.Generic;

//Daily Coding Problem 1.1
/*
 * Given an array of integers, return a new array such that each element at index i of the new array is the product
 * of all the numbers in the original array except the one at i.
 * 
 * for example, if our input was [1,2,3,4,5], the expected output would be [120,60,40,30,24].
 * if our input was [3,2,1], the expected output would be [2,3,6].
*/

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("How many elements will be in this array?");
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int[] arr = new int[b];
            int[] newarr = new int[b];
            int[] mularr = new int[b];
            Console.WriteLine("Please enter the elements for the array...");
            for(int i = 0; i < arr.Length; i++)
            {
                string temp = Console.ReadLine();
                int res;
                res = Convert.ToInt32(temp);
                arr[i] = res;
            }
            Console.WriteLine("Here's what's in the array...");        

            for(int i = 0; i < arr.Length; i++)
            {
                List<int> list = new List<int>(arr);
                list.RemoveAt(i);
                newarr = list.ToArray();
                mularr[i] = multiply(newarr);
            }
            for(int i = 0; i < mularr.Length; i++)
            {
                Console.WriteLine(mularr[i]);
            }
            
            Console.Read();
        }
        static int multiply(int[] arr)
        {
            int pro = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                pro = pro * arr[i];
            }
            return pro;
        }
    }
}
