using System;

namespace Exercise2
{
    public class Person
    {
        public String Name { get; set; }

        public String Num { get; set; }


        public Person(string name, string num)
        {
            Name = name;
            Num = num;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}