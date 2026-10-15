//Display a welcome message
Console.WriteLine("Welcom to the greeting program!");

//Ask for the users name
Console.WriteLine("What is your name? ");
String name = Console.ReadLine();

//Display a personalized greeting
Console.WriteLine($"Hello, {name.ToUpper()}! Its great to meet you.");
