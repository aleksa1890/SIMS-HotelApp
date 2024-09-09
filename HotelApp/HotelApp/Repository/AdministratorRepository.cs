using HotelApp.Model;
using HotelApp.Repository.Repository_Interfaces;
using HotelApp.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository
{
    public class AdministratorRepository : IAdministratorRepository
    {
        private const string FilePath = "../../../Data/Administrator.csv";

        private readonly Serializer<Administrator> _serializer;
        private readonly List<Administrator> _administrators;
        private static IAdministratorRepository _instance;
        private static readonly object _lock = new object();

        private AdministratorRepository()
        {
            _serializer = new Serializer<Administrator>();
            _administrators = _serializer.FromCSV(FilePath);
        }

        // Method to retrieve the singleton instance of the repository
        public static IAdministratorRepository GetInstance()
        {
            // Double-check locking for thread safety
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdministratorRepository();
                    }
                }
            }

            return _instance;
        }

        // Method to retrieve all administrators
        public List<Administrator> GetAll()
        {
            return new List<Administrator>(_administrators);
        }

        // Method to retrieve an administrator by ID
        public Administrator Get(int id)
        {
            return _administrators.FirstOrDefault(a => a.Id == id);
        }

        // Method to update an existing administrator
        public Administrator Update(Administrator entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var index = _administrators.FindIndex(a => a.Id == entity.Id);
            if (index == -1)
            {
                return null;
            }

            _administrators[index] = entity;
            Save();
            return entity;
        }

        // Method to save changes to the repository
        public void Save()
        {
            _serializer.ToCSV(FilePath, _administrators);
        }
    }

}
