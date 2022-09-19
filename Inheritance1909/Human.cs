using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1909
{
    internal class Human
    {
        private string name;
        private byte age;

        public Human(string name, byte age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual string question()
        {
            Random random = new Random();

            int a = random.Next(0, 2);

            if (a == 1)
            {
                return "Pravda";
            }
            else
            {
                return "Lez";
            }
        }
    }
}
