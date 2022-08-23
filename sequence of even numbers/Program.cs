// программа выводит последовательность четных чисел от 1 до введенного числа
Console.Write("Введите целое число:");
int input = Convert.ToInt32(Console.ReadLine());
int first = 1;
//если введено положительное число
if (input > 0)
{
    while (first < input+1)
{
    if (first%2 == 0)
    {
        Console.WriteLine(first);
    }
    first++;
}
}
//если введен 0 или отрицательное число
else
{
    while (input < first)
{
    if (input%2 == 0)
    {
        Console.WriteLine(input);
    }
    input++;
}
}

