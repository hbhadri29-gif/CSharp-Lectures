using System;

class Duration
{
    public int Hours;
    public int Minutes;

    public Duration(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;

        this.Hours = totalMinutes / 60;
        this.Minutes = totalMinutes % 60;
    }

    public static Duration operator +(Duration d1, Duration d2)
    {
        return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes);
    }

    public static Duration operator -(Duration d1, Duration d2)
    {
        return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes);
    }

    public override string ToString()
    {
        return $"{Hours}h {Minutes}m";
    }
}

class Program
{
    static void Main()
    {
        Duration d1 = new Duration(1, 45);
        Duration d2 = new Duration(0, 30);

        Duration sum = d1 + d2;
        Duration diff = d1 - d2;

        Console.WriteLine($"{d1} + {d2} = {sum}");
        Console.WriteLine($"{d1} - {d2} = {diff}");
    }
}