using Laba3;

var account = new BankAccount("Валерия", 1000);
Console.WriteLine($"Аккаунт {account.Number} был создан для пользователя {account.Owner}, начальный баланс:  {account.Balance}");
var account1 = new BankAccount("Иван", 100000);
Console.WriteLine($"Аккаунт {account1.Number} был создан для пользователя {account1.Owner}, начальный баланс:  {account1.Balance}");


account.MakeWithdrawal(500, "Арендная плата");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Друг вернул мне долг");
Console.WriteLine(account.Balance);