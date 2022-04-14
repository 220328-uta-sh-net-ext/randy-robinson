using System;
using Classes;

/*var account = new BankAccount("Jimmy T.", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);*/


Console.WriteLine("Please enter two strings: ");
string anagram1= Console.ReadLine();
Console.WriteLine("Please enter the next string: ");
string anagram2= Console.ReadLine();
var theAnagram= new Anagram(anagram1, anagram2);