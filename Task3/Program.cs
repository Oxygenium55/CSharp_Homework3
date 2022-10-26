/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine(" Ввели не число или число равное нулю. Повторите ввод \n");
        }
    }
    return result;
}
void Cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i != n)
            Console.Write($"{i * i * i}, ");
        else
            Console.Write($"{i * i * i} ");
    }
}

int number = GetNumber("Введите число N");
Cube(number);
