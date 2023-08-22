// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массива


int[,] CreateMartixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], +    5}");

        }
        Console.WriteLine("| ");
    }
    
}
void EvenElemMatrix(int[,] matrix){
    
     for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        { //if(i % 2  == 0 && j % 2  == 0)
            matrix[i,j]*= matrix[i,j];
        }
}
}


int[,] array_2d = CreateMartixRndInt(3, 4, 1, 5);
PrintMatrix(array_2d);
EvenElemMatrix(array_2d);
Console.WriteLine(" ");
PrintMatrix(array_2d);