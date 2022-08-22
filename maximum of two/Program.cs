// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
string input1 = Console.ReadLine();
double a = double.Parse(input1);
Console.WriteLine("Введите второе число:");
string input2 = Console.ReadLine();
double b = double.Parse(input2);
if (a>b)
{
    Console.Write("max=");
    Console.WriteLine(a);
}    
else
{
   if (b>a)
   {
    Console.Write("max=");
    Console.WriteLine(b);
   }
   else
   {
    Console.Write("Числа равны");
   }
} 
    

