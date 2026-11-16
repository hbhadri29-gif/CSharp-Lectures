using System;


class Calendar
{

public void input()
{
DateTime start = DateTime.Today;
DateTime futu=start.AddDays(45);

Console.WriteLine(futu.ToString("yyyy-mm-dd"));
Console.WriteLine(futu.DayOfWeek);
}

static void Main()
{
 Calendar cal = new Calendar();
cal.input();
}
}