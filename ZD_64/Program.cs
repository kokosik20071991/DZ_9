Console.WriteLine("Введите натуральное число больше 1: ");
int n = int.Parse(Console.ReadLine());

void NumCount(int n)
{
    if (n < 0) Console.Write($"{n} введено не натуральное число.");
    if (n == 0) return;
    Console.Write("{0, 4}", n);
    NumCount(n - 1);
}

NumCount(n);