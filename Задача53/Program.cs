// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
// class Program
// {
//     static void Main(string[] args)
//     {
//        int [,] matrix = GetRandomMatrix(rows: 5, columns: 5, leftBorder: 0, rightBorder: 10);
//        PrintMatrix(matrix);
//        Print("n\n");

//        matrix = SwapMatrixLastFirst(matrix);
//        PrintMatrix(matrix);
//     }
// }

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

// public static void WorkFormater(String articul, String brand, String price)
// {
//     Console.BackgroundColor = ConsoleColor.Gray;
//     Console.ForegroundColor = СonsoleColor.White;
//     int princeint = Int32.Parse(price);
//     princeint($ <offer sku=\"{articul}\">\n");

//     // и т.д. дальше решение задачи не показали:)
// }


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix (int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{   
    int[,] matrix = new int [rows, columns];
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               matrix[i, j] = Random.Shared.Next(leftBorder,rightBorder + 1);
           }
       }
       return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               Console.Write(matrix[i, j] + " "); 
           }
           Console.WriteLine();
       }
}

void SwapBorderLines(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }

}
int m = ReadNumber("Введите колличество строк:");
int n = ReadNumber("Введите колличество столбцов:");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
SwapBorderLines(myMatrix);
Console.WriteLine("------------------");
PrintMatrix(myMatrix);


