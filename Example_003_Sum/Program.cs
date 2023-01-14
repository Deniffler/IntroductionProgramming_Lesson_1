// программа сложение 2-х переменных
// сложение переменных заданных программно
//int numberA = 10;
//int numberB = 20;
//Console.WriteLine(numberA + numberB);
//Console.WriteLine("Теперь введем переменные с клавиатуры");
//Console.WriteLine("Введите переменную А (целое число)");
//string numberA1 = Console.ReadLine();
//int numberA1int = Convert.ToInt32(numberA1);
//Console.WriteLine("Введите переменную В (целое число)");
//string numberB1 = Console.ReadLine();
//int numberB1int = Convert.ToInt32(numberB1);
int numberA = new Random().Next(1,11);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,11);
Console.WriteLine(numberB);
Console.Write("Сумма равна: ");
Console.WriteLine(numberA + numberB);
