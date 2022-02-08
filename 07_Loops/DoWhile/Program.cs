int iterator = 0;

//print Hello regardless of whether the statement is true
do
{
    Console.WriteLine("Hello!");
    iterator++;
}
while (iterator < 5);

do{
    Console.WriteLine("condition is false");
}
while(false);

while(false){
    Console.WriteLine("condition is false too");
}