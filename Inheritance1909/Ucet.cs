using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class Ucet
    {

        private float balance;

        public Ucet(float balance)
        {
            Balance = balance;
        }
        public float Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("Balance nemuze byt mensi nez nula");
                }

            }
        }
        public virtual void vklad(float amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Vklad nesmi byt zaporny ci nula");
            }
        }

        public virtual void vyber(float amount)
        {
            if (amount > 0)
            {
                if (balance > amount)
                {
                    balance -= amount;
                }
                else
                {
                    throw new Exception("Nedostatek penez na vyber");
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException("Vyber nesmi byt zaporny ci nula");
            }
        }

        public virtual float status()
        {
            return Balance;
        }
    }
}
