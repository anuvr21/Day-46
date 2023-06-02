using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] dateParts = input.Split(' ');

        int month = int.Parse(dateParts[0]);
        int day = int.Parse(dateParts[1]);
        int year = int.Parse(dateParts[2]);

        DateTime date = new DateTime(year, month, day);
        DayOfWeek dayOfWeek = date.DayOfWeek;

        string dayOfWeekString = dayOfWeek.ToString().ToUpper();
        Console.WriteLine(dayOfWeekString);
    }
}
