/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
int ReadInt(string message)
{
    System.Console.Write(message);
    string inputedmesag = Console.ReadLine();
    int number = Convert.ToInt32(inputedmesag);
    return number;
}
int value = ReadInt("Введите число, обозначающее день недели => ");
if (0 < value && value < 6)   // 0 < valuе < 6
{
    System.Console.WriteLine("нет"); 
}
if (5 < value && value < 8)
{
    System.Console.WriteLine("да");
}
if (value > 7)
{
System.Console.WriteLine($"Под номером {value} дня недели нет");
}