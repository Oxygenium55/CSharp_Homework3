/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.Write(message);
        
        if(int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 100000)
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Введенное число не подходит под требования. Повторите ввод \n");
        }
    }
    return result;
}

bool Palindrom(int number)
{
    int n = number;
    int reverse = 0;
    while (n > 0)
    {
        int m = n % 10;
        reverse = reverse * 10 + m;
        n = n / 10;
    }
    return (number == reverse);
}
int number = GetNumber("Введите пятизначное число: ");

bool Pal = Palindrom(number);
if(Pal == true) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} не является палиндромом");

