using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Банковский счет
//хранит деньги и информацию о персоне, хозяине счета
//деньги на счете - публичная информация и её должно быть можно просматривать
//Личный дневник
//хранит Список с личными записями персоны, и информацию о персоне, владельце
//записи дневника - приватная информация, просматривать её может только владелец

namespace Laba3
{

    internal class BankAccount : ILocker<decimal>
    {

        //Get — это код, который выполняется, когда вы пытаетесь получить значение свойства.
        //set — это код, который выполняется, когда вы пытаетесь присвоить свойству значение.


        public decimal Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private static int s_accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
            set
            {

            }
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма депозита должна быть положительной");
            }
            var balance = new Transaction(owner,amount, date, note);
            _allTransactions.Add(balance);
        }



        public void MakeWithdrawal(decimal amount, string note = "") //Произвести вывод средств
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма депозита должна быть положительной");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Недостаточно средств для этого вывода");
            }
            var withdrawal = new Transaction(-amount, DateTime.Now, note);
            _allTransactions.Add(withdrawal);
        }



        public BankAccount(string name, decimal initialBalance)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "начальный баланс");
        }

        private List<Transaction> _allTransactions = new List<Transaction>();
        public void LockEdit()
        {
            throw new NotImplementedException();
        }

        public void LockRead()
        {
            throw new NotImplementedException();
        }

        public void UnLock()
        {
            throw new NotImplementedException();
        }

    }
}
