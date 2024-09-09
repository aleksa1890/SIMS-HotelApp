using HotelApp.Controller.Controller_Interfaces;
using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller
{
    public class AdministratorController : IAdministratorController
    {
        private readonly AdministratorService _administratorService;

        // Constructor to initialize the AdministratorService
        public AdministratorController(AdministratorService administratorService)
        {
            _administratorService = administratorService ?? throw new ArgumentNullException(nameof(administratorService));
        }

        // Retrieves all administrators
        public List<Administrator> GetAll()
        {
            return _administratorService.GetAll();
        }

        // Retrieves an administrator by ID
        public Administrator Get(int id)
        {
            return _administratorService.Get(id);
        }

        // Updates the specified administrator
        public Administrator Update(Administrator administrator)
        {
            if (administrator == null)
                throw new ArgumentNullException(nameof(administrator));

            return _administratorService.Update(administrator);
        }

        // Retrieves an administrator by email and password (for login)
        public Administrator GetByEmailAndPassword(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));

            return _administratorService.GetByEmailAndPassword(email, password);
        }

        // Saves changes made to administrators
        public void Save()
        {
            _administratorService.Save();
        }
    }

}
