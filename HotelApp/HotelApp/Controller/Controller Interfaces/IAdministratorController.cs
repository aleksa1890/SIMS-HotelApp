using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IAdministratorController
    {
        // Retrieves all administrators
        List<Administrator> GetAll();

        // Retrieves an administrator by ID
        Administrator Get(int id);

        // Updates an administrator and returns the updated object
        Administrator Update(Administrator administrator);

        // Retrieves an administrator by email and password
        Administrator GetByEmailAndPassword(string email, string password);

        // Saves changes to the data source
        void Save();
    }

}
