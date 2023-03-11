using System;

namespace LinearDataStructure.Arrays
{
    public class ArrayClass
    {
        private int[] array;
        private int count;

        public ArrayClass(int size)
        {
            array = new int[size];
        }

        public void Insert(int value)
        {
            if (array.Length == count)
            {
                var arrayToCopy = new int[count * 2];

                for (int i = 0; i < count; i++)
                    arrayToCopy[i] = array[i];

                array = arrayToCopy;
            }

            array[count++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException("index");

            for (int i = index; i < count; i++)
                array[i] = array[i + 1];

            count--;
        }

        public int IndexOf(int number)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }

        public void Print()
        {
            for(int i = 0; i < count; i++)
                Console.WriteLine(array[i]);
        }
    }
}