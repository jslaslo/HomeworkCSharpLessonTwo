while (true)
{
    Console.WriteLine("Введите число: ");
    int value = int.Parse(Console.ReadLine());

    OutputThirdNumber(value);
    Console.ReadKey();
}
void OutputThirdNumber(int value)
{
    Console.WriteLine(value);
    string strVal = Convert.ToString(value);
    if(value > 0)
    {
        if (strVal.Length > 2)
        {
            Console.WriteLine(strVal[2]);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет...");
        }
    }
    else
    {
        if (strVal.Length > 3)
        {
            Console.WriteLine(strVal[3]);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет...");
        }
    }     
}
