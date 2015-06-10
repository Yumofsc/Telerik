namespace BankAccounts
{
    using System;
    public abstract class Accounts
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Accounts(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                this.customer = value;
            }
        }

        public decimal Balance { get; set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Interest Rate can not be negative number");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int numberofMonths)
        {
            if (numberofMonths < 0)
            {
                throw new ArgumentException("Number of months can not be negative number");
            }
            return numberofMonths * (this.InterestRate/100m * this.Balance);
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nemail: {3}\nBalance: {1:c}\nInterestRate: {2}\n", this.Customer.Name, this.Balance, this.InterestRate, this.Customer.Email);
        }
    }
}
