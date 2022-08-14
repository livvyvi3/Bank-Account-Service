// See https://aka.ms/new-console-template for more information
using Bank_Account_Service.Services;
using System;

var db = new SystemDB();
SavingsAccount mySavingsAcc = new SavingsAccount(db);
CurrentAccount myCurrentAccount = new CurrentAccount(db);

foreach (var acc in db.getSavingsAccounts())
{
    Console.WriteLine($"Savings Acc: {acc.AccountId}  Amt: {acc.Balance}");
}


mySavingsAcc.Deposit(1, 50);
mySavingsAcc.Deposit(2, 5000);
mySavingsAcc.Withdraw(1, 100);

//print Balnce for Savings Accounts
foreach (var acc in db.getSavingsAccounts())
{
    Console.WriteLine($"Savings Acc: {acc.AccountId}  Amt: {acc.Balance}");
}

//print Balance for Current Acc before transactions
foreach (var acc in db.getCurrentAccounts())
{
    Console.WriteLine($"Current Acc: {acc.AccountID}  Amt: {acc.Balance}");
}
myCurrentAccount.Deposit(3, 50);
myCurrentAccount.Deposit(4, 5000);

foreach (var acc in db.getCurrentAccounts())
{
    Console.WriteLine($"Current Acc: {acc.AccountID}  Amt: {acc.Balance}");
}
myCurrentAccount.Withdraw(3, 1000);
myCurrentAccount.Withdraw(4, 5000);
foreach (var acc in db.getCurrentAccounts())
{
    Console.WriteLine($"Current Acc: {acc.AccountID}  Amt: {acc.Balance}");
}


