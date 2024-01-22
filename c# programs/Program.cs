// See https://aka.ms/new-console-template for more information
using System;
namespace programs{
    class Temp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine() + "");
            try
            {
                Convert.ToDouble("12");
            } 
            catch(FormatException e) {
                Console.WriteLine(e.Message);
            }
           
        }
        public void Matrix(int n)
        {
            //Write your code here
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int val = -1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                        val = 1;
                    }
                    else
                    {
                        matrix[i, j] = val;
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public bool Matrix(int n,int m)
        {
            //Write your code here
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int val = -1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                        val = 1;
                    }
                    else
                    {
                        matrix[i, j] = val;
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            return true;

        }

        //priyanka's changes
        public int Sum(int a,int b)
        {
            return a + b;
        }

        //hi
        //Gopi's changes
        public int Substract(int a,int b)
        {
            return a - b;
        }
    }
}