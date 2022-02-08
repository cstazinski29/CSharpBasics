// int bronze = 500;
// while (bronze <=525)
//     {
//         Console.WriteLine(bronze);
//         bronze = bronze + 5;
//     }

// int bronzeFor = 500;
// for (int i = 10; bronzeFor >=500 && bronzeFor <=525; )
//     {
//         Console.WriteLine(bronzeFor);
//         bronzeFor = bronzeFor + i;
//     }

// SILVER
// for (int i = 0; i <= 100; i+=5)
// {
//     Console.WriteLine(i);
//     }

//GOLD
// for (int i = 1; i <= 100; i++)
// {
//     if(i % 3 == 0 && i % 5 == 0)
//         {Console.WriteLine("FizzBuzz");}
//     if(i % 3 == 0)
//         {Console.WriteLine("Fizz");}
//     else if (i % 5 == 0)
//             {Console.WriteLine("Buzz");}
//     else Console.WriteLine(i);
// }

for (int i = 1; i <= 30; i++)
{
    //dynamic output = i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 ==0 ? "Buzz" : i;
    Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 ==0 ? "Buzz" : i);
    
    // if(i % 3 == 0 && i % 5 == 0)
    //     {Console.WriteLine("FizzBuzz");}
    // if(i % 3 == 0)
    //     {Console.WriteLine("Fizz");}
    // else if (i % 5 == 0)
    //         {Console.WriteLine("Buzz");}
    // else Console.WriteLine(i);
    //Console.WriteLine(output);
}