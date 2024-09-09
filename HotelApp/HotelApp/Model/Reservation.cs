using HotelApp.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Reservation : HotelApp.Serializer.ISerializable
    {
        // Auto-implemented properties for reservation information
        public int Id { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public Apartment Apartment { get; set; }
        public int ApartmentId { get; set; }
        public DateTime StartDate { get; set; }
        public ReservationStatus Status { get; internal set; }
        public bool Deleted { get; set; }
        public string Comment { get; set; }

        // Default constructor
        public Reservation() { }

        // Parameterized constructor to initialize reservation properties
        public Reservation(Guest guest, Owner owner, ReservationStatus status, Apartment apartment, DateTime startDate)
        {
            Status = status;
            Guest = guest;
            GuestId = guest?.Id ?? 0;
            Owner = owner;
            OwnerId = owner?.Id ?? 0;
            Apartment = apartment;
            ApartmentId = apartment?.Id ?? 0;
            StartDate = startDate;
        }

        // Method to convert reservation data to a CSV string array
        public string[] ToCSV()
        {
            return new string[]
            {
            Id.ToString(),
            Status.ToString(),
            GuestId.ToString(),
            ApartmentId.ToString(),
            DateHelper.DateToString(StartDate),
            Deleted.ToString(),
            OwnerId.ToString(),
            Comment
            };
        }

        // Method to populate reservation data from a CSV string array
        public void FromCSV(string[] values)
        {
            Id = Convert.ToInt32(values[0]);
            Status = Enum.Parse<ReservationStatus>(values[1]);
            GuestId = Convert.ToInt32(values[2]);
            ApartmentId = Convert.ToInt32(values[3]);
            StartDate = DateHelper.StringToDate(values[4]);
            Deleted = Convert.ToBoolean(values[5]);
            OwnerId = Convert.ToInt32(values[6]);
            Comment = values[7];
        }
    }
    public enum ReservationStatus
    {
        Approved, Rejected, Waiting, Canceled
    }

}
