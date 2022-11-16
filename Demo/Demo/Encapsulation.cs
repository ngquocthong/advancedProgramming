using System.Text.RegularExpressions;
namespace Demo
{
    internal class Encapsulation
    {

    }

    public class CLient
    {
        public CLient()
        {

        }
        private string firstName, lastName, email, address, phoneNumber;
        private int age; 
        public string FirstName
        {
            get => this.firstName; 
             set
            {
                if (ValidateEmptyField(value)) throw new ArgumentException("Should not be empty");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName; 
             set
            {
                if (ValidateEmptyField(value)) throw new ArgumentException("Should not be empty");
                this.lastName = value;
                    
            }
        }
        public int Age
        {
            get => this.age;
             set
            {
                if (!ValidateAge(value)) throw new ArgumentException("Must be greater than 18");
                this.age = value;
            }
        }
        public string Email
        {
            get => this.email;
            set
            {
                if(!ValidateEmail(value)) throw new ArgumentException("Invalid Email");
                this.email = value;
            }
        }
        public string Address
        {
            get => this.address;
            private set
            {
                if (ValidateEmptyField(value)) throw new ArgumentException("Address should not be empty");
                this.address = value;
            }
        }
        private string PhoneNumber
        {
            get => this.phoneNumber;
            set
            {
                if(ValidatePhoneNumber(value)) throw new ArgumentException("Invalid Phhone Number");
                this.phoneNumber = value;
            }
        }

        public CLient(string firstName, string lastName, int age, string email, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public static bool ValidateAge(int age)
        {
            if (age >= 18) return true;
            return false;
        }
        public bool ValidateEmail(string email)
        {
            if (email.Contains('@')) return true;
            else return false;
        }
        public static bool ValidateEmptyField(string text)
        {
            return text.Length == 0;
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string strRegex = @"^[0 - 9]{ 10}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phoneNumber))
                return (true);
            else
                return (false);
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age +" "+ Address +" "+ PhoneNumber;
        }
    }
}
