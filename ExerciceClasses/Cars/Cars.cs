using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceClasses;
public class Cars
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int NumberDoors { get; set; }
    public Cars(string brand, string model, int numberDoors)
    {
        this.Brand = brand;
        this.Model = model;
        if (ValidNumberDoors(numberDoors)) this.NumberDoors = numberDoors;
        else
        {
            Console.WriteLine($"Le nombre de porte pour la voiture {Brand} {Model} est incorrecte");
        }
    }
    public void ViewDetails()
    {
        if (ValidNumberDoors(NumberDoors))
            Console.WriteLine($"Marque : {this.Brand}, Modèle : {this.Model}, Nombres de portes : {this.NumberDoors}");
    }
    private bool ValidNumberDoors(int nbDoors)
    {
        if (nbDoors > 1 && nbDoors < 6)
            return true;
        return false;
    }
}