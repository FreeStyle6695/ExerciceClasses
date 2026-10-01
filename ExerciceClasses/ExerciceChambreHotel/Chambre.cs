using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.ExerciceChambreHotel;
public class Chambre
{
    public static List<Chambre> ToutesLesChambres = new List<Chambre>();
    private static int _compteur = 0;
    public int RoomNumber { get; private set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public int Capacity { get; set; }
    public Chambre(string type, decimal price, int capacity)
    {
        if (price <= 0) throw new ArgumentException("Le prix doit être supérieur à 0.");
        if (capacity <= 0) throw new ArgumentException("La capacité doit être supérieure à 0.");
        _compteur++;
        RoomNumber = _compteur;
        Type = type;
        Price = price;
        Capacity = capacity;
    }
}