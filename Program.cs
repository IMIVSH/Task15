// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Ваше число дня недели: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6 || number == 7)
{
    if(number == 6 || number == 7)
    {
    Console.WriteLine("ДА!");
    }
    else
    {
    Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("На планете Земля в неделе семь дней!");
}