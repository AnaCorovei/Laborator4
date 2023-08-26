using System;

namespace laborator4exercitii
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            Ex5();
            //Ex6();
            //Ex7();
        }


        static void Ex1()
        {
            /*Exercitii matrici
             Ex 1
             Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.Scrieti o
             functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul*/

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = ReadVector(n);
            ShowVector(InvertArray(vector));
        }

        static int[] InvertArray(int[] toInvert)
        {
            int[] inverted = new int[toInvert.Length];

            for (int i = 0; i < toInvert.Length; i++)
            {
                inverted[toInvert.Length - 1 - i] = toInvert[i];
            }
            return inverted;
        }

        //functie citire vector
        static int[] ReadVector(int n)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());

            int[] result = new int[n];

            Console.WriteLine("Introduceti elementele vectorului");

            for (int i = 0; i < n; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void ShowVector(int[] vectorToSHow)
        {
            Console.WriteLine(" Afisam vectorul: ");

            for (int i = 0; i < vectorToSHow.Length; i++)
            {
                Console.WriteLine(vectorToSHow[i]);
            }
        }

        static void Ex2()
        {
            /*
             * Ex2
            Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m 
            k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura. 
             Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
            rezultatul. 
             Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
            rezultatul. 
            */
            Console.WriteLine("Introduceti prima dimensiune:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a doua dimensiune:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a treia dimensiune:");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele vectorului: ");
            int[,,] vector3Dimeniuni = ReadMatrix(n, m, k);

            int suma = GetSumaNumerelor(vector3Dimeniuni);
            Console.WriteLine("suma este:" + suma);
            Console.WriteLine("elementul maxim este:" + GetMaximDinMAtrice(vector3Dimeniuni));
        }

        static int GetSumaNumerelor(int[,,] matrix)
        {
            int suma = 0;
            foreach (int element in matrix)
            {
                suma = suma + element;
            }
            return suma;
        }

        static int GetMaximDinMAtrice(int[,,] matrix)
        {
            int max = matrix[0, 0, 0];
            foreach (int element in matrix)
            {
                if (element > max)
                    max = element;
            }
            return max;
        }

        static int[,,] ReadMatrix(int n, int m, int k)
        {

            int[,,] result = new int[n, m, k];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    for (var l = 0; l < k; l++)
                    {
                        result[i, j, l] = int.Parse(Console.ReadLine()); //facem citirea
                    }
                }
            }
            return result;

        }


        static void Ex3()
        {
            /*
             Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n 
            m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la 
            tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I 
            rezultatul
             */
            Console.WriteLine("Introduceti prima dimensiune:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a doua dimensiune:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele vectorului: ");
            int[,] vector2Dimeniuni = ReadMatrix2Dimensiuni(n, m);

            int produs = GetProdusulNumerelor(vector2Dimeniuni);
            Console.WriteLine("produsul este:" + produs);

        }
        static int[,] ReadMatrix2Dimensiuni(int n, int m)
        {
            int[,] result = new int[n, m];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine()); //facem citirea

                }
            }
            return result;

        }

        static int GetProdusulNumerelor(int[,] matrix)
        {
            int produs = 1;
            foreach (int element in matrix)
            {
                produs = produs * element;
            }
            return produs;
        }

        static void Ex4()
        {
            /*           
            Exercitii – functii, functii recursive
            Ex 4
            Scrieti o functie recursiva care va afisa elementele unui vector de intregi.
            */
            ShowArrayElements(new int[] { 1, 2, 3, 4 }, 0);
        }
        static void ShowArrayElements(int[] array, int index) //daca punem index = 0; va fi un parametru optional; el va lua valoarea automat val 0 declarat aici
        {
            //pentru ca ii recursivitate, daca le vrem in ordinea citirii
            if (index >= array.Length) // daca suntem la finalul vectorului retun 
            {
                return;
            }
            Console.WriteLine(array[index]);    // daca nu suntem la finalul vectorului , adica suntem in vector
            ShowArrayElements(array, index + 1);
        }

        static void Ex5()
        {
            /*
             Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, 
            apelati-o si afisati-i rezultatul.
             */
            Console.WriteLine("Introduceti un numar:");
            SumaNumerelor(int.Parse(Console.ReadLine()));
            Console.WriteLine("Suma este:" + SumaNumerelor(int.Parse(Console.ReadLine())));
        }

        static int SumaNumerelor(int n) 
        {       
            if (n<=1)
            {
                return 1;
            }
            return n = SumaNumerelor(n - 1);

        }
    }
}


