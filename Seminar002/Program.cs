﻿Console.WriteLine("Введите номер от 1 до 7");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num==1)
{
    Console.WriteLine("Понедельник");
    }
else if (num==2)
{
    Console.WriteLine("Вторник");
    }
else if (num==3)
{
    Console.WriteLine("Среда");
}
else if (num==4)
{
    Console.WriteLine("Четверг");
}
else if (num==5)
{
    Console.WriteLine("Пятница");
}
else if (num==6)
{
    Console.WriteLine("Суббота");
}
else if (num==7)
{
    Console.WriteLine("Воскресенье");
}
else
{
  Console.WriteLine("Нет такого дня недели");
}