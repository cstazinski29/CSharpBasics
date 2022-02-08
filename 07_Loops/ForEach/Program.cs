//arrays cannot be added to or removed from?

string instructorName = "Jacob";
string[] instructors = new string[] {"Adam", "Kate", instructorName};
//Console.WriteLine(List<instructors>;);
//List<string>



//foreach(declaredIterator is enumerableCollection){body}

foreach(string name in instructors)
{
    Console.WriteLine($"Hello {name}");
}

foreach(char letter in instructorName)
{
    if(letter == 'c')
        {Console.WriteLine('k');
        } 
        else
    Console.WriteLine(letter);
}