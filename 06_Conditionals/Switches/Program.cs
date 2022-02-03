Console.WriteLine("Give name.");
string name = Console.ReadLine();
switch(name)
{
    case "Chris":
    Console.WriteLine("sup");
    break;
    default:
    Console.WriteLine("nope");
    break;
}

Console.WriteLine("how feeling?");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5":
    Console.WriteLine("cool");
    break;
    case "4":
    Console.WriteLine("less cool");
    break;
    case "3":
    Console.WriteLine("meh");
    break;
    default:
    Console.WriteLine("ugh");
    break;
}

// Console.WriteLine("how feeling number?");
// int feelingNumber = Console.ReadLine();

// switch(feelingNumber)
// {
//     case >=3:
//     Console.WriteLine("cool");
//     break;
//     default:
//     Console.WriteLine("ugh");
//     break;
// }


