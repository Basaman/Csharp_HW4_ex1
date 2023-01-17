//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
int numA = GetNumberAfromUser("Введите целое число А: ", "Ошибка ввода!");
int numB = GetNumberBfromUser("Введите целое число В: ", "Ошибка ввода!");
int PawNumbers = GetPawNumbers(numA);
Console.WriteLine($"{numA}, {numB} -> {PawNumbers}");

int GetNumberAfromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberBfromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetPawNumbers(int Paw)
{
    int result = numA;
    for (Paw = 1; Paw < numB; Paw++)
    {
        if (numB == 1)
        {
            result = numA;
        }
        else
        {
            result = result * numA;
        }
    }
    return result;
}