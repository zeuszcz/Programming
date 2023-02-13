using System;

namespace Programming.Model
{
    public class Contact
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        private string _number;

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять из 11 знаков");
                }
            }
        }

        public Contact()
        {
            
        }

        public Contact(string name, string surname,string number)
        {
            _name = name;
            _surname = surname;
            _number = number;
        }
        
    }
    
}