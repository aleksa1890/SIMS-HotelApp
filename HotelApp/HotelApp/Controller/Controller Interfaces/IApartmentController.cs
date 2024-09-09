using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IApartmentController
    {
        // Binds apartments to their respective hotels
        void BindHotel();

        // Retrieves all apartments
        List<Apartment> GetAll();

        // Retrieves an apartment by ID
        Apartment Get(int id);

        // Creates a new apartment
        void Create(Apartment apartment);

        // Deletes the specified apartment
        void Delete(Apartment apartment);

        // Updates the specified apartment and returns the updated object
        Apartment Update(Apartment apartment);

        // Saves changes to the data source
        void Save();
    }

}
