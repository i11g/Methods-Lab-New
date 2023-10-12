static string RepeatedText(string text, int count)
{
    string result = "";
    for (int i = 0; i<count; i++)
    {
        result += text;
    }     
    return result;
}


string text = Console.ReadLine();
int repeatCount=int.Parse(Console.ReadLine());

string result=RepeatedText(text, repeatCount);

