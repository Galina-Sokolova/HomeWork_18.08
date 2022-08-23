// программa принимает на вход три числа и выдаёт максимальное из них
Console.WriteLine("Введите первое число:");
double input1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double input2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третье число:");
double input3 = Convert.ToDouble(Console.ReadLine());

double max = input1;

if (input2 > max) max = input2;
if (input3 > max) max = input3;

Console.Write("максимальное число равно ");
Console.WriteLine(max);
   
    

