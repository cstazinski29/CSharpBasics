bool isCool = false;
isCool = true;

bool isTrue = !false;
bool isFalse = !true;

bool trueAndExample = true && true;
bool falseAndExample = true && false;
Console.WriteLine(trueAndExample);
Console.WriteLine(falseAndExample);

bool trueAndNumber = true && 2!=3;
Console.WriteLine(trueAndNumber);

bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;
Console.WriteLine(trueExclusiveOr);
Console.WriteLine(falseExclusiveOr);

Console.WriteLine($"{trueAndExample} {falseAndExample} {trueAndNumber} {trueExclusiveOr} {falseExclusiveOr}");

if (trueAndExample && falseAndExample && trueAndNumber && trueExclusiveOr && falseExclusiveOr)
{
    Console.WriteLine("All True!");
};