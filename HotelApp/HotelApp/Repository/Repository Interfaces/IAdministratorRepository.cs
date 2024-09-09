using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Repository_Interfaces
{
    public interface IAdministratorRepository
    {
        // Updates an existing administrator
        Administrator Update(Administrator administrator);

        // Retrieves all administrators
        List<Administrator> GetAll();

        // Retrieves an administrator by their ID
        Administrator Get(int id);

        // Saves changes made to the repository
        void Save();
    }

}
