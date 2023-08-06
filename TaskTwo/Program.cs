while (true)
{    
    Console.WriteLine("Введите цифру обозначающую день недели");
    int day = int.Parse(Console.ReadLine());
    Weekend(day);
    Console.ReadKey();
}
void Weekend (int value)
{   
    if(value > 0 && value < 6)
    {
        Console.WriteLine($"{value} рабочий день(");
    }
    else if(value > 5 && value < 8)
    {
        Console.WriteLine($"{value} выходной день!Ура!");
    }
    else
    {
        Console.WriteLine($"{value} такого дня в неделе нет");
    }
}
