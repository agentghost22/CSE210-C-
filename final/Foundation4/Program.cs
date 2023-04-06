using System;

public abstract class Activity
{
    private DateTime date;
    private int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date:d} - {GetType().Name} ({lengthMinutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (base.GetSpeed() / 60);
    }

    public override double GetPace()
    {
        return base.GetSpeed() / distance;
    }
}

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return base.GetSpeed() / 60 * speed;
    }

    public override double GetPace()
    {
        return 60 / base.GetSpeed() * speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Speed: {speed:F1} mph";
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (base.GetSpeed() / 60);
    }

    public override double GetPace()
    {
        return base.GetSpeed() / GetDistance();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new Running(new DateTime(2022, 11, 3), 30, 3),
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 45, 15),
            new Swimming(new DateTime(2022, 11, 3), 60, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
