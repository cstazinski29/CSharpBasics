bool isSnowing = true;
bool isGoingOutside = false;

if(isSnowing && isGoingOutside)
{
    Console.WriteLine("wear boots!");
}

if(!isSnowing || !isGoingOutside)
{
    Console.WriteLine("no boots!");
}

if(isSnowing ^ isGoingOutside)
{
    Console.WriteLine("Outside maybe!");
}