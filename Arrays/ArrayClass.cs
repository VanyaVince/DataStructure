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
                var arrayCopy = new int[count * 2];

                for (int i = 0; i < array.Length; i++)
                    arrayCopy[i] = array[i];

                array = arrayCopy;
            }

            array[count++] = value;
        }

        public void RemoveAt(int indexToRemove)
        {
            if (indexToRemove > array.Length)
                throw new ArgumentOutOfRangeException();

            for (int i = indexToRemove; i < count; i++)
                array[i] = array[i + 1];
           
            count--;

            //var arrayToCopy = new int[array.Length - 1];
            //var indexOffset = 0;

            //for (int i = 0; i < arrayToCopy.Length; i++)
            //{
            //    if (i == indexToRemove)
            //    {
            //        indexOffset = 1;
            //    }

            //    arrayToCopy[i] = array[i + indexOffset];
            //}

            //array = arrayToCopy;
        }

        public int IndexOf(int number)
        {
            int indexToLookUp = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    indexToLookUp = i;
                }
            }

            return indexToLookUp;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(array[i]);
        }
    }
}