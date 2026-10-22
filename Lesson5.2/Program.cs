//Generate a random of days until expiration
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//Display an expiration message based on the days remaining
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
    discountPercentage = 30;
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription will expire soon.");
    discountPercentage = 20;
}
else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//Display a discount message if a discount applies
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
