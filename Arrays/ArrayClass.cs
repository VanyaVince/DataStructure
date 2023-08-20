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
            ResizeIfRequired();

            array[count++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException();

            for (int i = index; i < count; i++)
                array[i] = array[i + 1];

            count--;
        }

        public void InsertAt(int number, int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException();

            ResizeIfRequired();

            for (int i = count - 1; i >= index; i--)
                array[i + 1] = array[i];

            array[index] = number;
            count++;
        }

        public int IndexOf(int number)
        {
            for (int i = 0; i < count; i++)
                if (array[i] == number)
                    return i;

            return -1;
        }

        public int Max()
        {
            var max = 0;

            foreach(int item in array)
                if(item > max)
                    max = item;

            return max;
        }

        public ArrayClass Intersect(ArrayClass other)
        {
            var commonItems = new ArrayClass(count - 1);

            foreach(int item in array)
                if (other.IndexOf(item) >= 0)
                    commonItems.Insert(item);

            return commonItems;
        }

        public void Revert()
        {
            var size = count - 1;

            for (int i = 0; i <= size / 2; i++)
            {
                var buffer = array[i];
                array[i] = array[size - i];
                array[size - i] = buffer;
            }
        }

        public void Print()
        {
            for(int i = 0; i < count; i++)
                Console.WriteLine(array[i]);
        }

        private void ResizeIfRequired()
        {
            if(count == array.Length)
            {
                var arrayToCopy = new int[count * 2];

                for (int i = 0; i < count; i++)
                    arrayToCopy[i] = array[i];

                array = arrayToCopy;
            }
        }
    }
}