namespace BankAccounts
{
    using System;

    public class Individual : Customer
    {
        public Individual(string name, string email, int gsm)
            : base(name,email,gsm)
        {

        }
    }
}
