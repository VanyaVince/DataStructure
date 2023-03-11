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
        numbers.RemoveAt(0);
        numbers.Print();
    }
}