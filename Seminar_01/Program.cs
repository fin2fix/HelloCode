Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
double a = Convert.ToDouble(numberStr1);

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
double b = Convert.ToDouble(numberStr2);

double c = a / b;

if (c == b)
{
  Console.WriteLine("Число является квадратом");
}
else
{
  Console.WriteLine("Число не является квадратом");
}