string first = "The cars we sell are";
string second = "BMW, Lexus, Mercedes and Tesla.";

string concatenatedResult = first + " " + second;

Console.WriteLine(concatenatedResult);

string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
Console.WriteLine(compositeResult);

// string compositeResult = string.Format("Her name is {0} {1} {2} {3}", firstName, lastName, first, second);
// Console.WriteLine(compositeResult);

string interpolationResult = $"Her name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);
Console.WriteLine($"Her name is still {firstName} {lastName}!");