using System;

namespace functiirecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TestRecursiv();
            //Console.WriteLine("Goodbye World!");
            AfisareNumere(5);

            //int fact = ShowFActorial(1, 5, 1);

            int[] vec = { 6, 2, 3, 4, 5, 1 };
            SortArray(vec);

            foreach(int n in vec)
            {
                Console.WriteLine(n);
            }
        }

        //static void TestRecursiv()
        //{
        //    Console.WriteLine("test");
        //    TestRecursiv();

        //}

        static void AfisareNumere(int n)
        {
            if (n<=0)
            {
                return;
            }

            AfisareNumere(n - 1);
            Console.WriteLine(n);
           
        }
       
        //functie recursiva care afiseaza factorialul unui numar;

        static void ShowFActorial(int i, int n, int result)
        {
            if (i == n)
            {
                Console.WriteLine(result);
                return;
            }
            ShowFActorial(i + 1, n, result * i);
        }

        //algoritm sortare - BUBBLE SORT

        static void SortArray(int[] array)
        {
            bool isSorted;
            do
            {
                isSorted = false;
                for (var i = 0; i < array.Length-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;
                        isSorted = false;
                    }
                }
            }
            while (isSorted == false);
        }
    }
}
