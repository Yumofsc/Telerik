namespace BankAccounts
{
    using System;
    public class LoanAcc : Accounts, IDeposit
    {
        public LoanAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void DepositeMoney(decimal moneyAmount)
        {
            if (moneyAmount < 0)
            {
                throw new ArgumentException("The deposit money can not be negative number");
            }
            this.Balance += moneyAmount;
        }
        public override decimal CalculateInterestAmount(int numberofMonths)
        {
            if (this.Customer is Individual)
            {
                numberofMonths -= 3;
            }
            else if (this.Customer is Company)
            {
                numberofMonths -= 2;
            }
            if (numberofMonths < 0)
            {
                return 0;
            }
            return base.CalculateInterestAmount(numberofMonths);
        }
    }
}
