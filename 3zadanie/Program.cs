Console.WriteLine("Введите число от 1 до 7: ");
int X = Convert.ToInt32(Console.ReadLine());
 if(X<6)
 {
    Console.WriteLine("Рабочий день ");
 }
else if(X>7)
{
    Console.WriteLine("Неверное число ");
}
else
{
    Console.WriteLine("Выходной день ");
}