//Ask for the users name
Console.Write("What is your name? ");
string name = Console.ReadLine();

//Ask for the users age
Console.Write("What is your age? ");
string age = Console.ReadLine();

string line = new string ('-', 20);
Console.WriteLine(line);

//Display a personlized message that includes both pieces of information
Console.WriteLine($"Name: {name}\nAge: {age}");
Console.WriteLine(line);
