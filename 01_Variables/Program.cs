// string firstName = "Chris";
// Console.WriteLine(firstName);

Console.WriteLine("Wuts yo name?");
string firstName = Console.ReadLine();
Console.WriteLine("You said your name is " + firstName);

Console.WriteLine("Wuts yo fav color?");

// Console.ReadLine is taking information in form the user, so it is blank
string color = Console.ReadLine();

Console.WriteLine("You said your favorite color is " + color +", " + firstName);