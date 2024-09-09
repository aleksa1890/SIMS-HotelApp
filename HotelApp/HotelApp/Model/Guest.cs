using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Guest : User
    {
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();

        // Default constructor
        public Guest() : base() { }

        // Override the ToCSV method to include Guest-specific data if needed
        public override string[] ToCSV()
        {
            return base.ToCSV();
        }

        // Override the FromCSV method to populate Guest-specific data if needed
        public override void FromCSV(string[] values)
        {
            base.FromCSV(values);
        }
    }

}
