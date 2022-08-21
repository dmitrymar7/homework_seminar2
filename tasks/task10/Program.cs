//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

bool IsDigitOnly(string str)
{
    foreach (char i in str)
    {
        if (Convert.ToInt32(i) < 49 || Convert.ToInt32(i) > 57)
        {
            return false;
        }
    }
    return true;
}

void Task10()
{
    Console.WriteLine("Введите трехзначное число");
    string str = Console.ReadLine();
    if (!IsDigitOnly(str))
    {
        Console.WriteLine("Введено не число");
        return;
    }

    if (str.Length != 3)
    {
        Console.WriteLine("Введено не трехзначное число");
        return;
    }

    int number = Convert.ToInt32(str);
    int result = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} - {result}");
}

Task10();

