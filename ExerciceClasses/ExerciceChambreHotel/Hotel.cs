using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.ExerciceChambreHotel;
public class Hotel
{
    public List<Booking> AllBookings = new List<Booking>();
    public void AddBooking(Booking booking)
    {
        foreach (var existingBooking in AllBookings)
        {
            // Check if the new booking overlaps with any existing booking
            if (booking.StartDate < existingBooking.EndDate && booking.EndDate > existingBooking.StartDate)
            {
                foreach (Chambre chNouvelle in booking.Rooms)
                {
                    foreach (Chambre chExistante in existingBooking.Rooms)
                    {
                        if (chNouvelle.RoomNumber == chExistante.RoomNumber)
                        {
                            throw new ArgumentException($"La chambre {chNouvelle.RoomNumber} est déjà réservée sur la période {existingBooking.StartDate} à {existingBooking.EndDate}!");
                        }
                    }
                }
            }
        }
        AllBookings.Add(booking);
        Console.WriteLine("Réservation ajoutée avec succès.");
    }
}
