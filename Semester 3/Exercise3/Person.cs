using System;

namespace Exercise3
{
    public class Person
    {
        public String Name { get; }

        public String Num { get; }


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