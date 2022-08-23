//программа принимает на вход число и выдаёт, является ли оно чётным
Console.WriteLine("Введите целое число:");
int input = Convert.ToInt32(Console.ReadLine());

int rem = input % 2;
if (rem == 0)
{
    Console.WriteLine("число "+input+" является чётным");
}
else
{
    Console.WriteLine("число "+input+" является нечётным");
}