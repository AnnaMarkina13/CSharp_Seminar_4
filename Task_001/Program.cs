// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

int firstNumber = ReadInt("Введите число, которое необходимо возвести в степень: ");
int secondNumber = ReadInt("Введите степень, в которую необходимо возвести число: ");
System.Console.WriteLine(Pow(firstNumber, secondNumber));
