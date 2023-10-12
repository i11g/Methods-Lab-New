int RectangleArea(int width, int length)
{
    return width * length;
}


int width =int.Parse(Console.ReadLine());
int length=int.Parse(Console.ReadLine());

int area=RectangleArea(width,length);

Console.WriteLine(area);