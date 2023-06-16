Console.WriteLine("Напишите два числа для, програма выедет какое большее, а какое меньшее.");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)  
    Console.WriteLine($"Число {a}  больше числа {b} ");
else
    Console.WriteLine($"Число {b}  больше числа {a} ");
