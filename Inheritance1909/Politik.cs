using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class Politik : Human
    {
        private string department;
        public Politik(string name, byte age, string department) : base(name, age)
        {
            base.Name = name;
            base.Age = age;
            this.department = department;
        }

        public override string question()
        {
            return "Lez";
        }

    }
}
