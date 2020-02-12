using System;

namespace Matrix {
    class Program {
        static void Main(string[] args) {
            int count = 0;
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("\nSua Matriz: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + "\t");
                    if (mat[i, j] < 0) {
                        count += 1;
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nMain diagonal: ");

            for(int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + "\t");
            }

            Console.WriteLine($"\nNegative Numbers: {count}");

        
        }
    }
}
