using System;

public class Class1
{
	//public static void Main(string[] args)
    {
        Class1 c= new Class1();
        c.Readdata();
        c.leapyear();

    }
    public void Readdata()
    {
        Console.WriteLine("enter the year");
        int year = Convert.ToInt32(Console.ReadLine());
    }
    public int leapyear()
   {
        if(((year%4)|| (year%100)) && (year % 400))
         {
            return year;
         }
        else
        {
            Console.WriteLine("year is not a leap year");
        }
    }
}
