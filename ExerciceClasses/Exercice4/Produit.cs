using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.Exercice4;
public class Produit
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Produit (string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}