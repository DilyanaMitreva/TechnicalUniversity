using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook();
        }

        private static void Phonebook()
        {
            Phonebook phoneBook = new Phonebook();
            char key;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("a - Add; f - Find; d - delete; q - Quit");

                key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'a':
                        Console.WriteLine("ADD");

                        Console.WriteLine("Enter name of contact");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter phone of contact");
                        string phone = Console.ReadLine();

                        Console.WriteLine("Enter email of contact");
                        string email = Console.ReadLine();

                        phoneBook.Add(name, phone, email);

                        break;
                    case 'f':
                        Console.WriteLine("FIND");

                        Console.WriteLine("Enter name of contact to find");
                        string nameOfContact = Console.ReadLine();

                        Contact findContact = phoneBook.Find(nameOfContact);
                        Console.WriteLine($"{findContact.Name}'s number: {findContact.PhoneNumber}");

                        break;
                    case 'd':
                        Console.WriteLine("DELETE");

                        Console.WriteLine("Enter name of contact to delete");
                        string nameOfContactToDelete = Console.ReadLine();

                        Contact deletedContact = phoneBook.Delete(nameOfContactToDelete);

                        Console.WriteLine($"Deleted contact with name {deletedContact.Name}");

                        break;
                    case 'q':
                        return;
                }
            }
        }
    }
    
}