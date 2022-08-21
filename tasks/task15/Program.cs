// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsDigitOnly(string str){
    foreach (char i in str){
        if (Convert.ToInt32(i) < 49 || Convert.ToInt32(i) > 57){
            return false;
        }
    }
    return true;
}

void Task15()
{
    Console.WriteLine("Введите число");
    string str = Console.ReadLine();
    if (!IsDigitOnly(str))
    {
        Console.WriteLine("Введено не число");
        return;
    }
    
    int number = Convert.ToInt32(str);

    if (number > 7 || number < 1){
        Console.WriteLine("Введенное число не обозначает день недели");
        return;
    }

    if (number == 7 || number == 6) Console.WriteLine("Да");
    else Console.WriteLine("Нет");

}

Task15();