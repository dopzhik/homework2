// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string message)
{
    System.Console.Write(message);
    string inputedmesag = Console.ReadLine();
    int number = Convert.ToInt32(inputedmesag);
    return number;
}
bool Validate3Digits(int number)
{
    if (number > 99)   // условие что число больше 99
    {
        return true;    // Проверка прошла успешно
    }
    System.Console.WriteLine("В заданном числе третьей цифры нет");    // проверка не прошла
    return false;
}
int[] GetIntArray(int number)
{
    List<int> listOfInts = new List<int>();
    while(number > 0)
    {
        listOfInts.Add(number % 10);
        number = number / 10;
    }
    listOfInts.Reverse();
    return listOfInts.ToArray();
}
int value = ReadInt("Введите любое число => ");
if (Validate3Digits(value))
{
    int[] listOfdigits = GetIntArray(value);
    System.Console.Write($"Третья цифра из числа {value} равна {listOfdigits[2]}");
}