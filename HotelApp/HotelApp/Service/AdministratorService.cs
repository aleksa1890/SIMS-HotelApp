using HotelApp.Model;
using HotelApp.Service.Service_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Service
{
    public class AdministratorService : IAdministratorService
    {
        private readonly IAdministratorRepository _administratorRepository;

        // Constructor injection of the administrator repository
        public AdministratorService(IAdministratorRepository administratorRepository)
        {
            _administratorRepository = administratorRepository ?? throw new ArgumentNullException(nameof(administratorRepository));
        }

        // Retrieves all administrators
        public List<Administrator> GetAll()
        {
            return _administratorRepository.GetAll();
        }

        // Retrieves an administrator by ID
        public Administrator Get(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID must be greater than zero.", nameof(id));

            return _administratorRepository.Get(id);
        }

        // Updates an existing administrator
        public Administrator Update(Administrator administrator)
        {
            if (administrator == null)
                throw new ArgumentNullException(nameof(administrator));

            return _administratorRepository.Update(administrator);
        }

        // Retrieves an administrator by email and password
        public Administrator GetByEmailAndPassword(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));

            var administrators = GetAll();
            return administrators.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && a.Password.Equals(password));
        }

        // Saves changes made to administrators
        public void Save()
        {
            _administratorRepository.Save();
        }
    }

}
