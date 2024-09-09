using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class User : HotelApp.Serializer.ISerializable
    {
        public int Id { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public bool Blocked { get; set; }
        public User()
        {
        }

        // Parameterized constructor to initialize all properties
        public User(int id, string jmbg, string email, string password, string name, string surname, string phoneNumber)
        {
            Id = id != 0 ? id : throw new ArgumentException("Id cannot be 0.");
            Jmbg = !string.IsNullOrWhiteSpace(jmbg) ? jmbg : throw new ArgumentNullException(nameof(jmbg));
            Email = !string.IsNullOrWhiteSpace(email) ? email : throw new ArgumentNullException(nameof(email));
            Password = !string.IsNullOrWhiteSpace(password) ? password : throw new ArgumentNullException(nameof(password));
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            Surname = !string.IsNullOrWhiteSpace(surname) ? surname : throw new ArgumentNullException(nameof(surname));
            PhoneNumber = !string.IsNullOrWhiteSpace(phoneNumber) ? phoneNumber : throw new ArgumentNullException(nameof(phoneNumber));
        }

        // Method to convert user data to a CSV string array
        public virtual string[] ToCSV()
        {
            return new string[]
            {
            Id.ToString(),
            Jmbg,
            Email,
            Password,
            Name,
            Surname,
            PhoneNumber,
            Blocked.ToString()
            };
        }

        // Method to populate user data from a CSV string array
        public virtual void FromCSV(string[] values)
        {
            if (values == null || values.Length != 8)
                throw new ArgumentException("Invalid CSV data.");

            Id = int.Parse(values[0]);
            Jmbg = values[1];
            Email = values[2];
            Password = values[3];
            Name = values[4];
            Surname = values[5];
            PhoneNumber = values[6];
            Blocked = bool.Parse(values[7]);
        }
    }

}
