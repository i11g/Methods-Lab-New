int BasesRaisedToPower(int bases, int power)
{
    int result = 1;
    for (int i = 1; i <=power; i++)
    {
        result *= bases;
    }
    return result;
}

int bases = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result=BasesRaisedToPower(bases, power);

Console.WriteLine(result);

