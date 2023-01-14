Console.WriteLine("Введите ваше имя:");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
   Console.WriteLine("Привет Маша! Маша с УралМаша"); 
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}