using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IHotelController
    {
        // Retrieves all hotels
        List<Hotel> GetAll();

        // Retrieves a hotel by ID
        Hotel Get(int id);

        // Updates the specified hotel
        void Update(Hotel hotel);

        // Creates a new hotel
        void Create(Hotel hotel);

        // Retrieves all apartments
        List<Apartment> GetAllApartments();

        // Deletes the specified hotel
        void Delete(Hotel hotel);

        // Saves changes to the data source
        void Save();
    }

}
