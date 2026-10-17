//Collect the bill amount and tip percentage
Console.WriteLine("Enter your bill amount: ");
Console.Write("Bill Amount: ");
decimal billAmount = Convert.ToDecimal(Console.ReadLine());
Console.Write("Tip Percentage: ");
decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

//Display the entered values
Console.WriteLine("\nBill Details: ");
Console.WriteLine($"Bill Amount: {billAmount}");
Console.WriteLine($"Tip Percentage: {tipPercentage}");

//Calculate the tip amount
decimal tipAmount =  billAmount * tipPercentage / 100;
decimal totalAmount = billAmount + tipAmount;

//Display the results
Console.WriteLine($"\nTip Amount: {tipAmount}");
Console.WriteLine($"Total Amount: {totalAmount}");