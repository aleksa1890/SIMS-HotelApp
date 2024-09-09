using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Service.Service_Interfaces
{
    public interface IAdministratorService : IService<Administrator>
    {
        Administrator GetByEmailAndPassword(string email, string password);
    }
}
