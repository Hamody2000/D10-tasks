using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class EnterpriseBankAccount : BankAccount
    {
        public bool Transfere(BankAccount employee, decimal _salary)
        {
            if (Balance > _salary)
            {
                Balance -= _salary;
                employee.Balance += _salary;
                return true;
            }
            else
            {
                employee.Balance += _salary;
                this.Balance -= _salary;

                OnUnderBalanced(_salary);
                return false;
            }
        }
    }
}
