int[] numbers = { 0, -1, 2, 4, -3, 5, 0, 7, -2, -4, 10 };
int positive = 0;
int negative= 0;
for (int i = 0; i < numbers.Length; i++) 
{
    if (numbers[i] == 0)
    {
        continue;
    }
    else if (numbers[i] > 0)
                {
        positive++;
    }
    else
    { negative++; };
}
Console.WriteLine(positive);
Console.WriteLine(negative);