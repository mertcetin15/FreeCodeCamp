//Collect the bill amount and tip percentage
Console.WriteLine("Enter your bill amount: ");
Console.Write("Bill Amount: ");
decimal billAmount = Convert.ToDecimal(Console.ReadLine());
Console.Write("Tip Percentage: ");
decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

//Display the entered values
Console.WriteLine("\nBill Details: ");
Console.WriteLine($"Bill Amount: {billAmount:C}");
Console.WriteLine($"Tip Percentage: {tipPercentage}");

//Calculate the tip amount
decimal tipAmount = Math.Round(billAmount * tipPercentage / 100 , 2);
decimal totalAmount = billAmount + tipAmount;

//Display the results
Console.WriteLine($"\nTip Amount: {tipAmount:C}");
Console.WriteLine($"Total Amount: {totalAmount:C}");

//Compare with a previous total
decimal previousTotal = 40.00m;
Console.WriteLine($"Higher Total: {Math.Max(previousTotal, totalAmount):C}");
