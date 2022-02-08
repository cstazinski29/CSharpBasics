//create initial target
int n = 10;

// for (initiatilzer; condition; iterator) {body}

//1   //2       //3     //4
for (int i = 1; i <= n; i++) //i++ = i +1 (use the value, add 1)
{
    //5
    Console.WriteLine(i);
}

int numberTwo = 200;
for (int i = 1; i <= numberTwo; i++)
{
    numberTwo = numberTwo - i;
    Console.WriteLine(numberTwo);
    //Console.WriteLine($"minus {i}");
}

//1 - for keyword
//2 - declaration and initialization of iterator
//3 - boolean expression for the loop
//4 - increment the iterator at the end of loop
    //4: e.g. i++ increments after the writeline command
//5 - body, runs per iteration if the condition is true