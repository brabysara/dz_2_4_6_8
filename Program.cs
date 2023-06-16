// задача 2

Console.WriteLine("Напишите два числа , програма вычеслит какое большее, а какое меньшее.");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)  
    Console.WriteLine($"Число {a}  больше числа {b} ");
    else
Console.WriteLine($"Число {b}  больше числа {a} ");


// задача 4  

  Console.WriteLine("Напишите 3 числа , програма вычеслит какое самое большое ");
int a2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int s2 = int.Parse(Console.ReadLine());
    int max = a2 ;
    if (b2 > max)max = b2 ;
    if (s2 > max)max = s2 ;
    Console.WriteLine($"Число {max} самое большое из введенных ");
    

// задача 6
 
Console.Write("Напишите число программа покажет является ли оно чётным :");

int a3 = int.Parse(Console.ReadLine());
if ( a3 % 2 == 1 )
    Console.WriteLine($"Число {a3} не чётное ");
else
Console.WriteLine($"Число {a3}  чётное ");

 

﻿Console.Write("Введите число и программа покажет все чётные числа от 1 до вашего числа : ");
int a4 = int.Parse(Console.ReadLine());
int b4 = 2;

while (a4 >= b4)
{
    Console.Write(b4 + " ");
    b4 = b4 + 2;
}


