using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Exercise3
{
    public delegate void PhoneBookChange();

    public class PhoneBook
    {
        private List<Person> _people = new List<Person>();

        public PhoneBookChange OnChange { get; set; }

        public event PhoneBookChange OnChange1;

        public void Add(Person person)
        {
            _people.Add(person);
            OnChange?.Invoke();
        }

        public void Delete(Person person)
        {
            _people.Remove(person);
            OnChange?.Invoke();
        }

        public IEnumerable<Person> Search(String name)
        {
            //List<Person> result = new List<Person>();
            foreach (var person in _people)
            {
                if (person.Name.ToLower().Contains(name.ToLower()))
                {
                    yield return person;
                }
            }

            //return result;
        }
    }
}