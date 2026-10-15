//Declare variables using an explicit type
string favouriteFood = "Pizza";
int slicesEaten = 3;
bool isHungry = false;

//Declare a variable using var
var favouriteColor = "Blue";

//Display the values of your variables
Console.WriteLine($"Favourite Food: {favouriteFood}");
Console.WriteLine($"Slices Eaten: {slicesEaten}");
Console.WriteLine($"IsHungry: {isHungry}");
Console.WriteLine($"Favourite Color: {favouriteColor}");

//Reassign a variable to a new value
Console.WriteLine($"Slices Eaten Before Dessert: {slicesEaten}");
slicesEaten = 5;
Console.WriteLine($"Slices Eaten After Dessert: {slicesEaten}");