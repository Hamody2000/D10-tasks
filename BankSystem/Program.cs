namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            BankAgent agent = new BankAgent();


            account.UnderBalanced += agent.WarnBankAccount;
            account.UnderBalanced += BlackListAccounts.AddToBlackList;


            //account.Credit(10000);


            EnterpriseBankAccount companyAccount = new EnterpriseBankAccount() 
            { Balance = 10000,
                Name = "ABC",
                Number = 1256
            };

            companyAccount.UnderBalanced += agent.WarnBankAccount;
            companyAccount.UnderBalanced += BlackListAccounts.AddToBlackList;

            companyAccount.Transfere(account, 50_000);
        }

    }
}
