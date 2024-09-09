using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Administrator : User
    {
        // List of hotels and users managed by the administrator
        public List<Hotel> Hotels { get; set; } = new List<Hotel>();
        public List<User> Users { get; set; } = new List<User>();

        public Administrator() : base()
        {
        }

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
