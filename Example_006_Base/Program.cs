int a = new Random().Next(1,101);
int b = new Random().Next(1,101);
int c = new Random().Next(1,101);
int d = new Random().Next(1,101);
int e = new Random().Next(1,101);
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine("Введены следующие числа: ");
Console.Write(a);
Console.Write(", ");
Console.Write(b);
Console.Write(", ");
Console.Write(c);
Console.Write(", ");
Console.Write(d);
Console.Write(", ");
Console.WriteLine(e);
Console.Write("Максимальное число равняется: ");
Console.WriteLine(max);