using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IGuestController
    {
        // Retrieves all guests
        List<Guest> GetAll();

        // Retrieves a guest by ID
        Guest Get(int id);

        // Updates the specified guest
        void Update(Guest guest);

        // Retrieves a guest by email and password
        Guest GetByEmailAndPassword(string email, string password);

        // Saves changes to the data source
        void Save();
    }

}
