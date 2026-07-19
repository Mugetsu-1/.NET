using System;

namespace IndexerApp
{
    
    class Matrix
    {
        private int[,] data;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            data = new int[rows, cols];
        }

        // 2D Indexer
        public int this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < Rows && col >= 0 && col < Cols)
                    return data[row, col];
                else
                    throw new IndexOutOfRangeException("Invalid row or column index");
            }
            set
            {
                if (row >= 0 && row < Rows && col >= 0 && col < Cols)
                    data[row, col] = value;
                else
                    throw new IndexOutOfRangeException("Invalid row or column index");
            }
        }

        public void Display()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{data[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("2D MATRIX INDEXER\n");

            Matrix mat = new Matrix(3, 3);

            
            Console.WriteLine("Setting values...");
            mat[0, 0] = 1;
            mat[0, 1] = 2;
            mat[0, 2] = 3;
            mat[1, 0] = 4;
            mat[1, 1] = 5;
            mat[1, 2] = 6;
            mat[2, 0] = 7;
            mat[2, 1] = 8;
            mat[2, 2] = 9;

            Console.WriteLine("\nMatrix:");
            mat.Display();

            Console.WriteLine($"\nmat[1, 1] = {mat[1, 1]}");
            Console.WriteLine($"mat[2, 0] = {mat[2, 0]}");
        }
        */
    }
}