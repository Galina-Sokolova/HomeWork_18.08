// Нахождение максимального и минимального из двух чисел
Console.WriteLine("Введите первое число:");
string input1 = Console.ReadLine();
double a = double.Parse(input1);
Console.WriteLine("Введите второе число:");
string input2 = Console.ReadLine();
double b = double.Parse(input2);

if (a>b)
{
    Console.Write("максимальное число равно ");
    Console.WriteLine(a);
    Console.Write("минимальное число равно ");
    Console.WriteLine(b);
}    
else
{
   if (b>a)
   {
    Console.Write("максимальное число равно ");
    Console.WriteLine(b);
    Console.Write("минимальное число равно ");
    Console.WriteLine(a);
   }
   else
   {
    Console.Write("Числа равны");
   }
} 
    

