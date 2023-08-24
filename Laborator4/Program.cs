using System;

namespace Laborator4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercitiu
            • Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni
            avand lungimile m, n. Lungimile celor doua dimensiuni ale matricii, m si n, 
            vor fi citite de la tastaura. 
             Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
             Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul */

            //int x = 3;
            //int[] vect = { 1, 2, 3, 4 }; //tipul ii un vector de intregi: int[]!!
            //int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 } }; // tipul este : int[,] = adica  matrice pe 2 dimensiuni de intregi
            ////mat = new int[2, 2] { {1, 2}, { 2,3 } };

            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));

            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m:");
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = ReadMatrix(n,m); //citim prima matrice;
            ShowMatrix(mat1);
            //int[,] mat2 = ReadMatrix(n,m); //citim cea de-a doua matrice;

        }

        static int[,] ReadMatrix(int n, int m) //functie care citeste o matrice
        {
            Console.WriteLine("Introduceti matricea:");
            int[,] result = new int[n, m];
            for (int i =0; i<n; i++)
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
                    return result;
        }

        static int[,] AddMatrix (int[,]mat1, int[,]mat2)
        {
            return null;
        }
         

        static void ShowMatrix(int[,] matrix) //functie care afiseaza matricea;
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
