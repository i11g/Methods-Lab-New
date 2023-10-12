
string type =Console.ReadLine();
static int ReaturnMax(int num1, int num2)
{
   int max = 0;
   if (num1 > num2)
    {
        max = num1;
    }
   else
    {
        max=num2;
    }
   return max;

}
if (type=="int")
{
    int num1=int.Parse(Console.ReadLine());
    int num2=int.Parse(Console.ReadLine());

    int max=ReaturnMax(num1,num2);

    Console.WriteLine(max);
}
static char ReturnedMax(char ch1, char ch2)
{
    

    if (ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
    
}
if (type=="char")
{
    char ch1=char.Parse(Console.ReadLine());
    char ch2=char.Parse(Console.ReadLine());

    char result=ReturnedMax(ch1, ch2);

    Console.WriteLine(result);
}
string ReturnedBiggest(string str1, string str2)
{
    string max ="";

    if(str1.CompareTo(str2)>0)
    {
        max=str1;
    }
    else
    {
        max=str2;
    }
    return max;
}
if (type=="string")
{
    string text1 = Console.ReadLine();
    string text2 = Console.ReadLine();

    string biggest=ReturnedBiggest(text1,text2);

    Console.WriteLine(biggest);
}

