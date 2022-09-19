using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class UrocenyUcetSPoplatkem : UrocenyUcet
    {
        private float platba;
        public UrocenyUcetSPoplatkem(float balance, float urokPercent) : base(balance, urokPercent)
        {
            base.Balance = balance;
            base.UrokPercent = urokPercent;
            Platba = prictiUrok();
        }

        public float Platba
        {
            get { return platba; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Platba nesmu byt min nez 0");
                }
                platba = value;
            }
        }

        public float prictiUrok()
        {
            return base.Balance + base.Urok;
            
        }
    }
}
