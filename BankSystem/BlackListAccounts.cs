using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public static class BlackListAccounts
    {
        public static List<String> BlackListNames { get; } = new List<String>();

        public static void AddToBlackList(object sender, decimal _amount)
        {
            if (sender is BankAccount ba && _amount > 0)
            {
                Console.WriteLine($"{ba.Name} is added to the black list");
                BlackListNames.Add(ba.Name );
            }
        }


    }
}
