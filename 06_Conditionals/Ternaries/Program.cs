Console.Write("Enter age:");
string response = System.Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!!" : "You can't vote";

Console.WriteLine(output);