namespace BankAccounts
{
    using System;
   public class MortgageAcc : Accounts, IDeposit
    {
       public MortgageAcc(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
       {

       }
       //Mortgage accounts have 1/2 interest for the first 12 months for companies and no interest for the first 6 months for individuals.
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
                if (numberofMonths <= 12)
                {
                    return base.CalculateInterestAmount((int)(numberofMonths * 0.5));
                }
                else
                {
                    decimal result = 0.5m * base.CalculateInterestAmount(12);
                    result += base.CalculateInterestAmount(numberofMonths - 12);
                    return result;
                }
            }
            else
            {
                if (numberofMonths <= 6)
                {
                    return 0m;
                }
                else
                {
                    numberofMonths -= 6;
                    return base.CalculateInterestAmount(numberofMonths);
                }
            }
        }
       
    }
}
