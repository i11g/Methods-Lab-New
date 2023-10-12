static void PrintTheSignOfInteger(int num)
{
    string sign = "";
    if(num > 0)
    {
        sign = "positive";
    }
    else if(num < 0)
    {
        sign = "negative";

    }
    else
    {
        sign = "zero";
    }
    Console.WriteLine(sign);
}

int number=int.Parse(Console.ReadLine());

PrintTheSignOfInteger((int)number);