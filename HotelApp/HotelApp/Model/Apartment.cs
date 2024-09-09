using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Apartment : HotelApp.Serializer.ISerializable
    {
        // Auto-implemented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoomNumber { get; set; }
        public int MaxGuestNumber { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        // Default constructor
        public Apartment() { }

        // Parameterized constructor to initialize all properties
        public Apartment(int id, string name, string description, int roomNumber, int maxGuestNumber, Hotel hotel)
        {
            Id = id != 0 ? id : throw new ArgumentException("Id cannot be 0.");
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            Description = !string.IsNullOrWhiteSpace(description) ? description : throw new ArgumentNullException(nameof(description));
            RoomNumber = roomNumber != 0 ? roomNumber : throw new ArgumentException("Room number cannot be 0.");
            MaxGuestNumber = maxGuestNumber != 0 ? maxGuestNumber : throw new ArgumentException("Max guest number cannot be 0.");
            Hotel = hotel ?? throw new ArgumentNullException(nameof(hotel));
            HotelId = hotel.Id;
        }

        // Method to convert apartment data to a CSV string array
        public virtual string[] ToCSV()
        {
            return new string[]
            {
            Id.ToString(),
            Name,
            Description,
            RoomNumber.ToString(),
            MaxGuestNumber.ToString(),
            HotelId.ToString()
            };
        }

        // Method to populate apartment data from a CSV string array
        public virtual void FromCSV(string[] values)
        {
            if (values == null || values.Length != 6)
                throw new ArgumentException("Invalid CSV data.");

            Id = int.Parse(values[0]);
            Name = values[1];
            Description = values[2];
            RoomNumber = int.Parse(values[3]);
            MaxGuestNumber = int.Parse(values[4]);
            HotelId = int.Parse(values[5]);
        }
    }

}
