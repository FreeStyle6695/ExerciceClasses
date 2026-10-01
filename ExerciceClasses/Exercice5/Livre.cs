using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.Exercice5;
public class Livre
{
    public Guid Id { get; set; }
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int Annee { get; set; }
    public Livre(string titre, string auteur, int annee)
    {
        Titre = titre;
        Auteur = auteur;
        Annee = annee;
    }
}