Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("*");
int x1 = 100, y1 = 1, 
x2 = 1, y2 = 45,
x3 = 200, y3 = 45;
Console.SetCursorPosition(x1,y1);
Console.WriteLine("*");
Console.SetCursorPosition(x2,y2);
Console.WriteLine("*");
Console.SetCursorPosition(x3,y3);
Console.WriteLine("*");
int x = x1, y = y1;
int count = 0;
while (count < 100000)
{
    int Rand = new Random().Next(0,3); // интервал [0..3) 0, 1, 2
    if (Rand == 0)
    {
        x = (x + x1)/2;
        y = (y + y1)/2;
    }
     if (Rand == 1)
    {
        x = (x + x2)/2;
        y = (y + y2)/2;
    }
     if (Rand == 2)
    {
        x = (x + x3)/2;
        y = (y + y3)/2;
    }
    Console.SetCursorPosition(x,y);
Console.WriteLine("*");
count ++;
}