using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class Card
    {
        private string id;
        private float? limit;
        private float balance;

        public Card(string id, float? limit, float balance)
        {
            Id = id;
            Limit = Limit;
            this.balance = balance;
        }

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public float? Limit
        {
            get { return limit; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Limit");
                }
                limit = value;
            }
        }

        public float Balance
        {
            get { return balance; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Card balace can't be less than zero");
                }
                balance = value;
            }
        }
    }
}
