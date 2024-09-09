using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IOwnerController
    {
        // Retrieves all owners
        List<Owner> GetAll();

        // Retrieves an owner by ID
        Owner Get(int id);

        // Updates the specified owner and returns the updated object
        Owner Update(Owner owner);

        // Retrieves an owner by email and password
        Owner GetByEmailAndPassword(string email, string password);

        // Creates a new owner
        void Create(Owner owner);

        // Saves changes to the data source
        void Save();
    }

}
