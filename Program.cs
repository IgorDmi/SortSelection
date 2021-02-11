using System;

namespace SortSelection
{

    class Selection
    {
        public void enterData(int array_size, int[] array)
        {
            Random rnd = new Random();

            for (int _i = 0; _i < array_size; _i++)
            {
                array[_i] = (rnd.Next(1,100));
            }
        }
        public void processData(int array_size, int[] array)
        {
            int _i=0;
            int _j = 0;
            int _min;
            int _temp = 0;

            while ((_j != array_size))
            {
                _min = array[_j];

                for (_i=_j; _i < array_size; _i++)
                {
                    if(_min>array[_i])
                    {
                        _temp = _i;
                        _min = array[_i];
                    }
                }
                array[_temp] = array[_j];
                array[_j] = _min;
                _j++;
            }
        }
        public void writeData(int array_size, int[] array)
        {
            Console.WriteLine("NO. \t NUMBERS");

            for(int _i = 0; _i < array_size; _i++)
            {
                Console.WriteLine($"{_i}: \t    "+array[_i]);
            }
        }          
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Enter array size: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];

            Selection search = new Selection();

            search.enterData(n, array1);
            Console.WriteLine("Array before selection: ");
            search.writeData(n, array1);
            search.processData(n, array1);
            Console.WriteLine("Array after selection: ");
            search.writeData(n, array1);
        }
    }
}
