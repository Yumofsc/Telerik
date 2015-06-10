using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class Bank : IEnumerable<Accounts>
    {
        public List<Accounts> Accounts { get; private set; }

        public Bank()
        {
            this.Accounts = new List<Accounts>();
        }

        // Basic account funcionalities below
        // indexer
        public Accounts this[int index]
        {
            get
            {
                return this.Accounts[index];
            }
        }

        // adding/removing accounts
        public void AddAccount(Accounts account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAccount(int index)
        {
            this.Accounts.RemoveAt(index);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            var queryResult = this.Accounts.OrderBy(x => x.Balance).ToList();

            foreach (var account in queryResult)
            {
                result.AppendLine(account.ToString());
            }

            return result.ToString();
        }
        public IEnumerator<Accounts> GetEnumerator()
        {
            return Accounts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }        
    }
}