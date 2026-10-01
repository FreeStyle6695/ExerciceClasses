using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.ExerciceChambreHotel;
public class Booking
{
    public List<Chambre> Rooms { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public Booking (List<Chambre> rooms, DateOnly startDate, DateOnly endDate)
    {
        Rooms = rooms;
        if (startDate < endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        else Console.WriteLine("La date de début doit être antérieure à la date de fin.");
    }
}