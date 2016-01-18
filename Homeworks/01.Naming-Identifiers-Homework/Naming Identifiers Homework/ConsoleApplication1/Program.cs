namespace ConsoleApplication1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var matrixOne = new double[,]
            {
                { 1, 3 }, 
                { 5, 7 }
            };
            var matrixTwo = new double[,]
            {
                { 4, 2 }, 
                { 1, 5 }
            };
            var resultMatrix = MultiplyMatrices(matrixOne, matrixTwo);

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyMatrices(double[,] leftMatrix, double[,] rightMatrix)
        {
            if (leftMatrix.GetLength(1) != rightMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var matrixRows = leftMatrix.GetLength(0);
            var matrixCols = leftMatrix.GetLength(1);
            var resultMatrix = new double[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    for (int rowColSwitch = 0; rowColSwitch < matrixCols; rowColSwitch++)
                    {
                        resultMatrix[row, col] += leftMatrix[row, rowColSwitch] * rightMatrix[rowColSwitch, col];
                    }
                }
            }
                
            return resultMatrix;
        }
    }
}