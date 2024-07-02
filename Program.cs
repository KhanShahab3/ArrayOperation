﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5];
        Console.WriteLine("{0}{1,8}", "Index", "Value");
        for (int counter = 0; counter < array.Length; counter++)
        {
            Console.WriteLine("{0,5}{1,8}", counter, array[counter]);
        }
        //using Array Initializer
        Console.WriteLine("Array Initializer......................!");
        int[] arrays = { 3, 20, 30, 45, 50, 46, 12, 78, 189 };
        Console.WriteLine("{0}{1,8}", "Index", "Value");
        for(int i=0; i<arrays.Length; i++)
        {
            Console.WriteLine("{0,5}{1,8}",i, arrays[i]);
        }
    }
}