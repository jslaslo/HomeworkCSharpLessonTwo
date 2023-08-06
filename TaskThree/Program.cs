Console.Write("Введите трехзначное число: ");
int value = int.Parse(Console.ReadLine());
OutputTwoNumber(782);
Console.ReadKey();
void OutputTwoNumber(int value)
{
    value %= 100;
    value /= 10;

    Console.WriteLine(value);
}

