// look up property vs variable

using Classes;

Donut doug = new Donut("Jelly Filled", true, false);
doug.SetDonutType("Glazed");
doug.Filling = "Jam";
Console.WriteLine(doug.GetDonutType());
Console.WriteLine(doug.Filling);

Donut derrick = new Donut("Chocolate", false, true, 3.99);
Console.WriteLine(derrick.Price);

Greeter greet = new Greeter();
Console.WriteLine(greet.SayHello("Chris"));
Console.WriteLine(greet.SayHello());

greet.PrintHello("sup");
greet.PrintHello("buddy");

greet.PrintRandomGreeting();

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Age(new DateTime(1990, 02, 04)));

Person me = new Person();
me.FirstName = "Chris";
me.LastName = "Stazinski";
me.DateOfBirth = new DateTime(1990, 01, 22);
me.Introduction();

Person finn = new Person("Finn","Mertens",new DateTime(3035,7,11));
finn.Introduction();

// I couldn't get the below to work
// finn.Donut = derrick;
// Console.WriteLine($"{finn.FullName} has a {finn.Donut.GetDonutType()}");

Person homer = new Person("Homer","Simpson",new DateTime(1970,01,01),"Glazed",true,true);
homer.Introduction();
Console.WriteLine($"He loves {homer.Donut.GetDonutType()}");

namespace Classes
{

    class Donut
    {
        // Field
        public string donutType;
        // Constructors
        // public Donut(){} <-- Implicit constructor
        // v Defined constructor, implicit constructor removed
        public Donut(string type, bool sprinkles, bool icing)
        {
            donutType = type;
            HasSprinkles = sprinkles;
            HasIcing = icing;
        }

        public Donut(string type, bool sprinkles, bool icing, double price)
        {
            donutType = type;
            HasSprinkles = sprinkles;
            HasIcing = icing;
            Price = price;
        }

        // 1    2       3
        public string GetDonutType()
        {
            // 4
            return donutType;
        }

        public void SetDonutType(string type)
        {
            donutType = type;
        }


        public string Filling { get; set; }
        public bool HasSprinkles { get; set; }
        public bool HasIcing { get; set; }
        public double Price { get; set; }
    }

    //CLASS LINE BREAK

    class Greeter
    {
        Random _random = new Random();
        public string SayHello()
        {
            return "Hello!";
        }
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }

        public void PrintHello(string name)
        {
            Console.WriteLine($"Greetings {name}!");
        }

        public void PrintRandomGreeting()
        {
            // Lists/arrays/enumerable index at zero    0       1   2       3   4   5
            string[] availableGreeting = new string[] { "Hello", "Hey", "Sup", "Yo", "Hi", "Ayo" };
            // Min value inclusive, max value exclusive
            int randomNumber = _random.Next(0, availableGreeting.Length);
            string randomGreeting = availableGreeting.ElementAt(randomNumber);
            Console.WriteLine(randomGreeting);
        }

        public string RandomGreeting()
        {
            // Lists/arrays/enumerable index at zero    0       1   2       3   4   5
            string[] availableGreeting = new string[] { "Hello", "Hey", "Sup", "Yo", "Hi", "Ayo" };
            // Min value inclusive, max value exclusive
            int randomNumber = _random.Next(0, availableGreeting.Length);
            string randomGreeting = availableGreeting.ElementAt(randomNumber);
            return randomGreeting;
        }
    }

    //CLASS LINE BREAK

    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public int Remainder(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }
        public int Age(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }

    //CLASS LINE BREAK

    class Person
    {
        public Person(){}
        public Person(string firstName, string lastName, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dOB;
        }

        //Chaining the constructors together, looks for a matching constructor for those variables, then uses it
        public Person(string firstName, string lastName, DateTime dOB, string donutType, bool HasSprinkles, bool HasIcing) : this(firstName, lastName, dOB)
        {
            Donut = new Donut(donutType, HasSprinkles, HasIcing, 2.99);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Readonly property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // public string FullName()
        // {
        //     return $"{FirstName} + {LastName}";
        // }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                // DRY style
                Calculator calc = new Calculator();
                return calc.Age(DateOfBirth);
            }
        }

        public void Greet()
        {
            Greeter greeter = new Greeter();
            // semantic satiation
            greeter.PrintHello(FullName);
        }

        public void Introduction()
        {
            Greeter greeter = new Greeter();
            Console.WriteLine($"{greeter.RandomGreeting()}, my name is {FullName} and I am {Age} years old");
        }
    }

}