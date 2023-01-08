Console.Write("Введите положительное число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите положительное число N: ");
int N = int.Parse(Console.ReadLine());


int AckermannFun(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFun(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFun(M - 1, AckermannFun(M, N - 1));
    return AckermannFun(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел ({M}, {N}) = {AckermannFun(M, N)}");