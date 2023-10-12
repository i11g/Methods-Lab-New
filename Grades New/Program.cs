static void PrintTheGradeInWords(double num)
{
    string grades = "";
    if(num>=2.00&&num<=2.99)
    {
        grades = "Fail";
    }
    else if(num>=3.00&&num<=3.49)
    {
        grades = "Average";
    }
    else if (num >= 3.50 && num <= 4.49)
    {
        grades = "Good";
    }
    else if (num >= 4.50 && num <= 5.49)
    {
        grades = "Very Good";
    }
    else if (num >= 5.50 && num <= 6.00)
    {
        grades = "Exelent";
    }
    Console.WriteLine(grades);
}

double grade=double.Parse(Console.ReadLine());

PrintTheGradeInWords(grade);
