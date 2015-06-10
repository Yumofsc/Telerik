namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class TestAccounts
    {
        public static void Main()
        {
            Bank myBank = new Bank();
            myBank.AddAccount(new DepostitAcc(new Individual("Ivan Brejnev","brejnev@gmail.com",0889544545),10589m,7.5m));
            myBank.AddAccount(new MortgageAcc(new Company("G8 Studio","g8studio@gmail.com",0879554433), 1000000m, 4.2m));
            myBank.AddAccount(new LoanAcc(new Individual("Stefan Karaivanov", "stefko_picha@abv.bg",0883233445), 100m, 8m));
            myBank.AddAccount(new MortgageAcc(new Individual("Mich Bukianan", "spasiteliNaPlaja@yahoo.com",0898765432), 1020.345m, 4.5m));

            Console.WriteLine("Displaying different account's data:");
            Console.WriteLine(myBank);

            Console.WriteLine("\nDisplaying the result from the interest calculations:");

            int month = 7;
            Console.WriteLine();
            foreach (var account in myBank)
            {
                Console.WriteLine("Name: {1}, Period(months): {2}, Interest calc result: {0:c}", account.CalculateInterestAmount(month), account.Customer.Name, month);
                
            }

           
        }
    }
}
