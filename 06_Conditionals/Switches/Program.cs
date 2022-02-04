Console.WriteLine("Give name.");
string name = Console.ReadLine();

string greeting = name switch
{
    "Chris" => "sup Chris",
    _ => "Who you?"
};
Console.WriteLine(greeting);



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

Console.WriteLine("how feel yesterday?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "dang",
    2 => "better",
    3 => "coolio",
    _ => "tight"
};
Console.WriteLine(response);