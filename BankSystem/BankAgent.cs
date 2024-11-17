using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankAgent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BankAgent()
        {
            Id = 10;
            Name = "Ahmed";
        }


        public void WarnBankAccount(object sender,  decimal e)
        {
            if (sender is BankAccount ba && e > 100)
            {
                Console.WriteLine($"Ajent {Name} warns {ba.Name} from under balanced!!!");
            }
        }

    }
}
