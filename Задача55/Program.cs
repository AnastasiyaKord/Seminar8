// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это 
// невозможно, программа должна вывести 
// сообщение для пользователя.

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] matrix = GetRandomMatrixColor(rows: 5, columns: 5, leftBorder: 0, rightBorder: 10);
//         PrintMatrix(matrix);
//         Print ("\n\n\n");
//         matrix = RotateMatrix(matrix);
//         PrintMatrix(matrix);
//     }


// public static int[,] SwapMatrixLastFirst(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(dimension: 1); i++)
//     {
//         int temp = matrix[0; i];
//         matrix[0, i] = matrix[matrix.GetLength(dimension: 0) - 1, i];
//         matrix[matrix.GetLength(dimension: 0) - 1, i] = temp;
//     }
//     return matrix;
// }

// public static int[,] RotateMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(dimension: 1), matrix.GetLength(dimension: 0)];
//     for (int i = 0; i < matrix.GetLength(dimension: 0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(dimension: 1); j++)
//         {
//             newMatrix[j, i] = matrix[i, j];
//         }
//     }
//     return newMatrix;
// }
// public static void WorkFormater(String articul, String brand, String price)
// {
//     Console.BackgroundColor = ConsoleColor.Gray;
//     Console.ForegroundColor = СonsoleColor.White;
//     int princeint = Int32.Parse(price);
//     princeint($ <offer sku=\"{articul}\">\n");
// }

// public static void PrintMatrixColor(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(dimension: 0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(dimension: 1); j++)
//         {
//             if(matrix[i, j] > 7)
//             {
//                 Console.BackgroundColor = ConsoleColor.Red;
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }    
// }

// public static void PrintMatrixColor(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(dimension: 0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(dimension: 1); j++)
//         {
// }
// }