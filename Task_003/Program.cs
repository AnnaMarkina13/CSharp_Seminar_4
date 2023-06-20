// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] InitArray(int length)
{
    var array = new int[length]; 
    return array;
}

void FillArray(int[] array, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ",array)}]");
} 

var array = InitArray(8);
FillArray(array, 0, 100);
PrintArray(array);
