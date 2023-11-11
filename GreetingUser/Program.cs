// GreetingUser
//Author: Justin Spencer
//In this application, we will welcome the user to our application and then we will ask them their first name. We will greet them by name, then ask their favorite color and respond.


Console.WriteLine("Hello, welcome to my application.");
Console.WriteLine("What is your first name?");
string? userName = Console.ReadLine();
//Console.WriteLine("Thank you for using my application " + username + ".");
Console.WriteLine($"Thank you for using my application {userName}.");
Console.WriteLine($"{userName}, what is you favorite color?");
string? userColor = Console.ReadLine();
Console.WriteLine($"{userColor} is my favorite too!");
