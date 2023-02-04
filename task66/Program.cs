// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int getData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int getSum(int start, int finish)
{
    if (finish == 0)
    {
        return start;
    }
    return start + finish + getSum(start, finish - 1);
}

int start = getData("Введите значение M");
int finish = getData("Введите значение N");
// string rage = GetStrRange(userNumberStart, userNumberFinish);
int sum = getSum(start, finish);
Console.WriteLine(sum);

