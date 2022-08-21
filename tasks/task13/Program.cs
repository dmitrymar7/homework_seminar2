//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

void Task13()
{
    Console.WriteLine("Введите число");
    string str = Console.ReadLine();
    if (!IsDigitOnly(str))
    {
        Console.WriteLine("Введено не число");
        return;
    }

    if (str.Length < 3)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    int number = Convert.ToInt32(str);
    int result = (number / Convert.ToInt32(Math.Pow(10, (str.Length - 3)))) % 10;
    Console.WriteLine($"Третья цифра числа {number} - {result}");
}

Task13();