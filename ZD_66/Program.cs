Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void NumSum(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    NumSum(M, N, sum);
}

NumSum(M, N, 0);
