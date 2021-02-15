using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int f=0;
            int[,] matriz = new int[8, 5] {
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,1},
                { 1,1,1,1,0}
            };

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i,j] == 0)
                    {
                        f = i;
                        c = j;
                    }
                    
                }
                
            }
        

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == f || j == c)
                    {
                        matriz[i, j] = 0;
                    }
                    Console.Write(" " + matriz[i, j]);

                }
                Console.WriteLine();
            }
            
        }
    }
}
