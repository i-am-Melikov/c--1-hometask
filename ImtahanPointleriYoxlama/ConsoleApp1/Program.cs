using System.ComponentModel.Design;

int point = 52;
if (point <= 100 && point >= 0)
{
    if (point <= 100 && point > 90)
    {
        Console.WriteLine("A");
    }
    else if (point <= 90 && point > 80)
    {
        Console.WriteLine("B");
    }
    else if (point <= 80 && point > 70)
    {
        Console.WriteLine("C");
    }
    else if (point <= 70 && point > 60)
    {
        Console.WriteLine("D");
    }
    else if (point <= 60 && point > 50)
    {
        Console.WriteLine("E");
    }
    else
    {
        Console.WriteLine("Kesildiniz");
    }
}
else
{
    Console.WriteLine("Point 100 ve 0 araliginda olmalidir.");
}