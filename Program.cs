// программа, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Clear();
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"число {a} больше числа {b}");
}
else if (a < b)
{
    Console.WriteLine($"число {a} меньше числа {b}");
}