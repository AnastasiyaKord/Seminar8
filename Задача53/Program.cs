// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
class Program
{
    static void Main(string[] args)
    {
       int [,] matrix = GetRandomMatrix(rows: 5, columns: 5, leftBorder: 0, rightBorder: 10);
       PrintMatrix(matrix);
       Print("n\n");

       matrix = SwapMatrixLastFirst(matrix);
       PrintMatrix(matrix);
    }
}

public static int[,] SwapMatrixLastFirst(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(dimension: 1); i++)
    {
        int temp = matrix[0; i];
        matrix[0, i] = matrix[matrix.GetLength(dimension: 0) - 1, i];
        matrix[matrix.GetLength(dimension: 0) - 1, i] = temp;
    }
    return matrix;
}

public static void WorkFormater(String articul, String brand, String price)
{
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = СonsoleColor.White;
    int princeint = Int32.Parse(price);
    princeint($ <offer sku=\"{articul}\">\n");

    // и т.д. дальше решение задачи не показали:)
}