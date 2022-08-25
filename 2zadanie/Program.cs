Console.WriteLine("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());

while(X>999)
{
    X = X/10;
}
if(X/100==0) Console.WriteLine("Третьей цифры нет");

else
{
    X = X%10;
Console.WriteLine($"Третья цифра {X}");
}