using LinearDataStructure.Arrays;
using LinearDataStructure.LinkedList;
//using LinearDataStructure.LinkedList;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Arrays
        var firstNumbers = new ArrayClass(3);
        var secondNumbers = new ArrayClass(4);

        firstNumbers.Insert(10);
        firstNumbers.Insert(20);
        firstNumbers.Insert(30);
        firstNumbers.Revert();
        firstNumbers.Print();

        secondNumbers.Insert(1);
        secondNumbers.Insert(70);
        secondNumbers.Insert(40);
        secondNumbers.Insert(280);
        secondNumbers.Revert();
        secondNumbers.Print();
         */

        var list = new LinkedList<int>();

        list.AddFirst(1);
        list.AddLast(10);
        list.AddFirst(2);
        list.AddLast(20);
        list.AddLast(30);
        list.AddFirst(3);

    }
}