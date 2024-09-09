using HotelApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Controller.Controller_Interfaces
{
    public interface IReservationController
    {
        // Binds apartments to the reservation controller
        void BindApartment();

        // Binds owners to the reservation controller
        void BindOwner();

        // Binds guests to the reservation controller
        void BindGuest();

        // Retrieves all reservations
        List<Reservation> GetAll();

        // Retrieves a reservation by ID
        Reservation Get(int id);

        // Creates a new reservation
        void Create(Reservation reservation);

        // Subscribes an observer to reservation updates
        //void Subscribe(IObserver observer);

        // Unsubscribes an observer from reservation updates
        //void Unsubscribe(IObserver observer);

        // Updates the specified reservation
        void Update(Reservation reservation);

        // Deletes the specified reservation
        void Delete(Reservation reservation);

        // Saves changes to the data source
        void Save();
    }

}
