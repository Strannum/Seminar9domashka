/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());

int SumOfInterval(int firstNum, int secondNum)
{

    int sum = 0;
    if (firstNum == secondNum) return secondNum;
    sum = firstNum + SumOfInterval(firstNum + 1, secondNum);
    Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
    return sum;
}

Console.WriteLine(SumOfInterval(M, N));
