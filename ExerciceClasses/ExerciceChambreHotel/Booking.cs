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
        if (startDate >= endDate) throw new ArgumentException("La date de début doit être antérieure à la date de fin.");
        foreach (Chambre chambreDemandee in rooms)
        {
            bool chambreExiste = false;

            foreach (Chambre chambreReelle in Chambre.ToutesLesChambres)
            {
                if (chambreDemandee.RoomNumber == chambreReelle.RoomNumber)
                {
                    chambreExiste = true;
                    break; // Trouvée, on passe à la chambre suivante
                }
            }

            // Si le tour complet est fait sans la trouver, on bloque la réservation
            if (!chambreExiste)
            {
                throw new ArgumentException($"La chambre n°{chambreDemandee.RoomNumber} n'existe pas dans l'hôtel.");
            }
        }
        Rooms = rooms;
        StartDate = startDate;
        EndDate = endDate;
    }
}