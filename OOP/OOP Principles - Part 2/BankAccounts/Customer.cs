namespace BankAccounts
{
    using System;
    public abstract class Customer
    {
        private string name;
        private string email;
        private int gsm;

        public Customer(string name, string email, int gsm)
        {
            this.Name = name;
            this.Email = email;
            this.Gsm = gsm;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can not be empty or null");
                }
                this.name = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The email can not be empty or null");
                }
                this.email = value;
            }
        }
        public int Gsm
        {
            get
            {
                return this.gsm;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The gsm number can not be negative number or zero");
                }
                this.gsm = value;
            }
        }
        
    }
}
