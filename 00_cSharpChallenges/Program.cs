// // Declare and initialize variables. One of type int, one of type string, one of type DateTime and looks up and use a variable type you haven't used yet.
// int number = 1;
// string name = "chris";
// var date1 = new DateTime(2022, 5, 1, 8, 30, 52);
// Console.WriteLine(number + " | " + name + " | " + date1);

// // Use operators to subtracts two numbers and print the value.
// Console.WriteLine(10-6);

// // Use operators that takes a strings from the user and outputs that string into a sentence.
// Console.WriteLine("noun?");
// string noun = Console.ReadLine();
// Console.WriteLine("verb?");
// string verb = Console.ReadLine();
// Console.WriteLine("adjective?");
// string adjective = Console.ReadLine();
// Console.WriteLine($"{noun} {verb} {adjective}");

// // Write a switch case that asks the user if they are wearing clothes.
// Console.WriteLine("clothes?");
// string clothes = Console.ReadLine();

// switch (clothes)
// {
//     case "yes":
//     Console.WriteLine("good");
//     break;
//     case "no":
//     Console.WriteLine("ew");
//     break;
//     default:
//     Console.WriteLine("yes or no?");
//     break;
// };

// // Write a switch expression that asks the user to to judge the outfit of choice for the day.
// Console.WriteLine("rating number?");
// string rating = Console.ReadLine();
// int ratingNumber = int.Parse(rating);

// Console.WriteLine(
// ratingNumber switch
// {
//     3 => "good",
//     2 => "fine",
//     1 => "bad",
//     _ => "no comment"
// });

// // Write a switch expression that takes in the user meal request for either McDonalds,Wendys,Burger King , etc.


// // Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;
// // Console.WriteLine("happy true/false?");
// // string happy = Console.ReadLine();
// bool happy = false;
// if (happy)
// {
//     Console.WriteLine("cool");
// }
// else
// {
//     Console.WriteLine("dang");
//     };

// // Write an if, else if, else that asks the user how much money they make a year. Check ranges between 1,000-10,000,  11,000-50,000, and 51,000-100,000. Output to the test runner based on each salary range. Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking.
// Console.WriteLine("money?");
// string incomeInput = Console.ReadLine();
// //int income = int.Parse(incomeInput);
// decimal income = decimal.Parse(incomeInput);

// if (income <= 100000)
//     {
//         Console.WriteLine("nice");
//     }
// else if (income <= 50000)
//     {
//         Console.WriteLine("still nice");
//     }
// else if (income <= 10000)
//     {
//         Console.WriteLine("okay nice");
//     }
// else 
// {
//     Console.WriteLine("fine");
//     };


// //found from online
// for (int i = 1; i <= 6; i++)
//            {
//              for (int j = 1; j <= i; j++)
//              {
//                 Console.Write("*");
//              }
//             Console.WriteLine();
//            };

