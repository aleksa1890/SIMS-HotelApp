using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Hotel : HotelApp.Serializer.ISerializable
    {
        // Auto-implemented properties with initialization for collections
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int ConstructionYear { get; set; }
        public Dictionary<int, Apartment> Apartments { get; set; } = new Dictionary<int, Apartment>();
        public int StarsNumber { get; set; }
        public string JmbgOwner { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public bool Accepted { get; set; }

        // Default constructor
        public Hotel() { }

        // Parameterized constructor to initialize all properties
        public Hotel(int id, string code, string name, Dictionary<int, Apartment> apartments, int constructionYear, int starsNumber, string jmbgOwner, int ownerId, Owner owner)
        {
            Id = id != 0 ? id : throw new ArgumentException("Id cannot be 0.");
            Code = !string.IsNullOrWhiteSpace(code) ? code : throw new ArgumentNullException(nameof(code));
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            Apartments = apartments ?? throw new ArgumentNullException(nameof(apartments));
            ConstructionYear = constructionYear != 0 ? constructionYear : throw new ArgumentException("Construction Year cannot be 0.");
            StarsNumber = starsNumber != 0 ? starsNumber : throw new ArgumentException("Stars Number cannot be 0.");
            JmbgOwner = !string.IsNullOrWhiteSpace(jmbgOwner) ? jmbgOwner : throw new ArgumentNullException(nameof(jmbgOwner));
            OwnerId = ownerId;
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }

        // Method to convert hotel data to a CSV string array
        public virtual string[] ToCSV()
        {
            return new string[]
            {
            Id.ToString(),
            Code,
            Name,
            ConstructionYear.ToString(),
            StarsNumber.ToString(),
            JmbgOwner,
            OwnerId.ToString(),
            Accepted.ToString()
            };
        }

        // Method to populate hotel data from a CSV string array
        public virtual void FromCSV(string[] values)
        {
            if (values == null || values.Length != 8)
                throw new ArgumentException("Invalid CSV data.");

            Id = int.Parse(values[0]);
            Code = values[1];
            Name = values[2];
            ConstructionYear = int.Parse(values[3]);
            StarsNumber = int.Parse(values[4]);
            JmbgOwner = values[5];
            OwnerId = int.Parse(values[6]);
            Accepted = bool.Parse(values[7]);
        }
    }

}
