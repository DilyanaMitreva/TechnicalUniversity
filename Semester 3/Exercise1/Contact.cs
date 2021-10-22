namespace Exercise1
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _email;

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            private set => _phoneNumber = value;
        }

        public string Email
        {
            get => _email;
            private set => _email = value;
        }
    }
}