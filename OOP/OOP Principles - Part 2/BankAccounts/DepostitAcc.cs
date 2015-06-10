namespace BankAccounts
{
    using System;
    public class DepostitAcc : Accounts, IDeposit, IWithDraw
    {

        private const decimal interestLimit = 1000m;
        public DepostitAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer,balance,interestRate)
        {

        }
        public override decimal CalculateInterestAmount(int numberofMonths)
        {
            if (this.Balance < 0 && this.Balance < interestLimit)
            {
                return 0m;
            }
            return base.CalculateInterestAmount(numberofMonths);
        }
        public void DepositeMoney(decimal moneyAmount)
        {
            TransactionValidation(moneyAmount);
            this.Balance -= moneyAmount;
        }

        public void withDrawMoney(decimal moneyAmount)
        {
            TransactionValidation(moneyAmount);
            this.Balance += moneyAmount;
        }
        private static void TransactionValidation(decimal moneyAmount)
        {
            if (moneyAmount < 0)
            {
                throw new ArgumentException("The deposit/with draw money can not be negative number");
            }
        }
    }
}
