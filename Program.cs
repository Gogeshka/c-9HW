/*Task 1
int InI(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int NNumber(int i, int z)
{
    if (i == z)
        return i;
    else
        Console.Write($"{NNumber(i, z + 1)}, ");
    return z;
}
int i = InI("Введите положительное число: ");
int z = 1;
if (i < 1) Console.WriteLine("Это не положительное число! ");

Console.WriteLine(NNumber(i, z));
*/

/*Task 2
int InI(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Summa(int m, int n)
{
    if (m == n)
        return n;
    return n + Summa(m, n - 1);
}
int m = InI("M= ");
int n = InI("N= ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Summa(m, n)}");
*/

/*Task 3
int InI(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int AkkerMana(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkerMana(m - 1, 1);
    else
        return AkkerMana(m - 1, AkkerMana(m, n - 1));
}
int m = InI("M = ");
int n = InI("N = ");
Console.WriteLine($"A({m},{n}) = {AkkerMana(m, n)}");
*/
