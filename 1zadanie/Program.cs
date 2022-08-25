Console.WriteLine ("Введите трезначное число: ");
int X = Convert.ToInt32(Console.ReadLine());
int X1 = X/10;
int X2 = X1%10;

if ((X>99)&(X<1000)) Console.WriteLine($"Вторая цифра: {X2}");

else Console.WriteLine("Вы ввели неверное число ");
