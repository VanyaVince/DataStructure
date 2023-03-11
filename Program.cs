using System;
using LinearDataStructure.Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new ArrayClass(3);

        numbers.Insert(10);
        numbers.Insert(20);
        numbers.Insert(30);
        numbers.Insert(40);
        numbers.Insert(40);
        Console.WriteLine(numbers.IndexOf(40));
        //numbers.RemoveAt(2);
        //numbers.Print();
    }
}