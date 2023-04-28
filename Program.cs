Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int res = (num / 10) % 10;
Console.WriteLine("Вторая цифра введенного числа: " + res);