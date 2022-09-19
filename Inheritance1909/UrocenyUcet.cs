using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class UrocenyUcet : Ucet
    {
        private float urok;
        private float urokPercent;

        public UrocenyUcet(float balance, Card? card, float urokPercent) : base(balance, card)
        {
            base.Balance = balance;

            Urok = vypoceteUroku(urokPercent, balance);

        }

        public float Urok
        {
            get { return urok; }
            set { urok = value; }
        }

        public float UrokPercent
        {
            get { return urokPercent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Urokovy procent nesmi byt mensi nez nula");
                }
                else
                {
                    urokPercent = value;
                }
            }
        }

        private float vypoceteUroku(float percentage, float balance)
        {
            return balance / percentage;

        }



    }
}
