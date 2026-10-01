using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.Exercice5;
public class Bibliotheque
{
    public List<Livre> ListeLivre = new List<Livre>();
    public void AddBook(Livre livre)
    {
        ListeLivre.Add(livre);
    }
    public void DeleteBook(Guid id)
    {
        Livre livreASupprimer = ListeLivre.FirstOrDefault(livre => livre.Id == id);
        ListeLivre.Remove(livreASupprimer);
    }
    public void DisplayBooks()
    {
        foreach (var book in ListeLivre)
        {
            Console.WriteLine($"\"{book.Titre}\" - {book.Auteur.ToUpper()} sortie en {book.Annee}\tson ID est {book.Id}");
        }
        Console.WriteLine();
    }
    public void SearchBook(string search)
    {
        var result = ListeLivre.Where(livre => livre.Titre.Contains(search) || livre.Auteur.Contains(search) || livre.Annee.ToString().Contains(search)).ToList();
        foreach (var book in result)
        {
            Console.WriteLine($"{book.Titre} {book.Auteur} {book.Annee} son ID est {book.Id}");
        }
        Console.WriteLine();
    }
}