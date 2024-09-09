using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Owner : User
    {
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();

        public Owner() : base() { }

        public override string[] ToCSV()
        {
            return base.ToCSV();
        }

        public override void FromCSV(string[] values)
        {
            base.FromCSV(values);
        }
    }

}
