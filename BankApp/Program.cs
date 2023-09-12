// See https://aka.ms/new-console-template for more information

using BankApp;

var account = new BankAccount("Julie Smith", 2000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with an initial balance of €{account.Balance}.");

account.MakeWithdrawal(120, DateTime.Now, "Magazine Subscription");
Console.WriteLine(account.GetLastTransaction());
Console.WriteLine(account.DisplayBalance());

account.MakeWithdrawal(3, DateTime.Now, "Coffee");
Console.WriteLine(account.GetLastTransaction());
Console.WriteLine(account.DisplayBalance());

account.MakeWithdrawal(350, DateTime.Now, "IKEA");
Console.WriteLine(account.GetLastTransaction());
Console.WriteLine(account.DisplayBalance());

// Test that the initial balances must be positive.
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    //return;
//}

// Test for a negative balance.
//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//    Console.WriteLine(account.Balance);
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}

Console.WriteLine($"Account Statement for {account.Owner}");
Console.WriteLine(account.GetAccountHistory());