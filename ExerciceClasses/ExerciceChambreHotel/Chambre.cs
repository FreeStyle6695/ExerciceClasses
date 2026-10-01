using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.ExerciceChambreHotel;
public class Chambre
{
    public int RoomNumber { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public int Capacity { get; set; }
    public Chambre(int roomNumber, string type, decimal price, int capacity)
    {
        RoomNumber = RoomNumber + 1;
        Type = type;
        if (price > 0) Price = price;
        else Console.WriteLine("Le prix doit être supérieur à 0.");
        if (capacity > 0) Capacity = capacity;
        else Console.WriteLine("La capacité doit être supérieure à 0.");
    }
}
