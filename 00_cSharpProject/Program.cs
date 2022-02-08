// Gambling game simulator intro
//Phase 1
    //user enters number between 1-10; computer randomly generates number & comparison checks win/loss
Console.WriteLine("Welcome to the House!");
int minRange = 1;
int maxRange = 10;
Console.WriteLine($"Enter a number between {minRange} and {maxRange}");
int userInput = int.Parse(Console.ReadLine());
bool withinRange = userInput >=minRange && userInput <=maxRange;
//Console.WriteLine(withinRange); //checks whether value is within range

//Random number generator (found online)
Random r = new Random();
int houseResult = r.Next(minRange,maxRange);
Console.WriteLine("House Number = "+ houseResult);

bool winner = userInput == houseResult;

if (winner)
{
    Console.WriteLine("You're a winner!");
}
else {
    Console.WriteLine("You did not win");
};


//Formula to check if value is within range
// switch (withinRange) {
//     case false:
//         Console.WriteLine($"Value outside of range. Please enter a number between {minRange} and {maxRange}");
//     break;
//     case true:
//         bool winner = userInput > houseResult;
//         Console.WriteLine("You win!");
//     break;
//     default:
//         Console.WriteLine($"Please enter a number between {minRange} and {maxRange}");
// }




//Phase 1.1 user can wager money & has bank that money goes in/out of