using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class Svetec : Human
    {
        private byte svetecRate;

        public Svetec(string name, byte age, byte svetecRate) : base(name, age)
        {
            base.Name = name;
            base.Age = age;
            SvetecRate = svetecRate;
        }

        public byte SvetecRate
        {
            get { return svetecRate; }
            set { svetecRate = value; }
        }

        public override string question()
        {
            return "Pravda";
        }
    }
}
