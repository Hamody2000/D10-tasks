using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankAccount
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public BankAccount()
        {
            Balance = 5000;
            Number = 1234;
            Name = "Ali";
        }
        public bool Debit(decimal _amount)
        {
            if (_amount > 0)
            {
                Balance += _amount;
                return true;
            }
            return false;

        }

        public bool Credit(decimal _amount)
        {
            if (_amount > 0 && _amount < Balance)
            {
                Balance -= _amount;
                return true;
            }else
            {
                Balance -= _amount;
                OnUnderBalanced(_amount);
                //fire event
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Number}:{Name}->{Balance}";
        }

        public event EventHandler<decimal> UnderBalanced;
        protected virtual void OnUnderBalanced(decimal _delta) 
        {

            UnderBalanced?.Invoke(this, _delta);

        }


    }
}
