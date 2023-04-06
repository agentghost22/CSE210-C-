
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";
        public Person()
        {
        }
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
