using System;

class Address
{
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public string GetAddress()
    {
        return $"{street}, {city}, {state} {zip}";
    }
}

class Event
{
    private string title;
    private string description;
    private DateTime dateTime;
    private Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"{title}\n{description}\n{dateTime.ToString("MMMM dd, yyyy")} at {dateTime.ToString("hh:mm tt")}\n{address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {title} on {dateTime.ToString("MMMM dd, yyyy")}";
    }
}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity) : base(title, description, dateTime, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail) : base(title, description, dateTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {rsvpEmail}";
    }
}

class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast) : base(title, description, dateTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather forecast: {weatherForecast}";
    }
}

class Program
{
    static void Main(string[] args)
    {

        Event lecture = new Lecture("Introduction to C#", "Learn the basics of C# programming", new DateTime(2023, 4, 1, 14, 0, 0), new Address("155 Main St", "Charlotte", "NC", "28110"), "Dwayne Wade", 50);

        Event reception = new Reception("Networking Mixer", "Join us for drinks and appetizers", new DateTime(2023, 4, 28, 18, 0, 0), new Address("456 Oak St", "Raligh", "NC", "34404"), "rsvp@NETWOk.com");

        Event outdoorGathering = new OutdoorGathering(" OutDoor End Of Semester Bash", "Bring all your friends to an awesome event where we celebrate the final momnts of the semester", new DateTime(2023,7, 2, 20, 0, 0), new Address("1540 Thousand oaks Dr", "Calabasas", "CA", "25694");
    }
}