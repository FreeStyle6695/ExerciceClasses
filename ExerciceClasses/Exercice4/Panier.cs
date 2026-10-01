using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.Exercice4;
public class Panier
{
    public List<Produit> Produits = new List<Produit>();
    public void AddProduct(Produit p)
    {
        Produits.Add(p);
    }
    public void DeleteProduct(Produit p)
    {
        Produits.Remove(p);
    }
    public void DisplayBasketful()
    {
        Console.WriteLine("Le Panier contient\n===================\n");
        foreach (var item in Produits)
        {
            Console.WriteLine($"le panier contient {item.Name} et coûte {item.Price}€\n");
        }
    }
}