// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string message)
{
    System.Console.Write(message);
    string inputedmesag = Console.ReadLine();
    int number = Convert.ToInt32(inputedmesag);
    return number;
}
bool Validate3Digits(int number)
{
    if (99 < number && number < 1000)   // 99 < number < 1000
    {
        return true;    // Проверка прошла успешно
    }
    System.Console.WriteLine("Число не трехзначное");    // проверка не прошла
    return false;
}
int value = ReadInt("Введите трехзначное число => ");
if (Validate3Digits(value))
{
    int seconddigit = (value / 10) % 10;
    System.Console.WriteLine($"Вторая цифра из числа {value} равна {seconddigit}");
}