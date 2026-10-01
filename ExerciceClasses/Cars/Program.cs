using ExerciceClasses;
using ExerciceClasses.BankAccount;
using ExerciceClasses.Exercice4;
using ExerciceClasses.Exercice5;
using ExerciceClasses.ExerciceChambreHotel;
Console.OutputEncoding = System.Text.Encoding.UTF8;     // Force l'encodage de la console en UTF-8

while (true)
{
    Console.WriteLine("Choisissez l'exercice à voir");
    Console.WriteLine("============================");
    Console.WriteLine("0 >> QUITTER\n1 >> Exercice 1 et 2.\n3 >> Exercice 3.\n4 >> Exercice 4.\n5 >> Exercice 5.\n6 >> Exercice Chambre d'hôtel");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (choice)
    {
        case 0:
            return;
        case 1:
            Exercice1And2();
            break;
        case 3:
            Exercice3();
            break;
        case 4:
            Exercice4();
            break;
        case 5:
            Exercice5();
            break;
        case 6:
            ExerciceChambreHotel();
            break;
        default:
            Console.WriteLine("L'exercice n'existe pas espèce de connard !\n");
            break;
    }
}
void Exercice1And2()
{
    List<Cars> cars = new List<Cars>();
    Cars nissan = new Cars("Nissan", "GTR", 2);
    Cars honda = new Cars("Honda", "Civic", 2);
    Cars toyota = new Cars("Toyota", "Supra", 2);
    Cars mitsubishi = new Cars("Mitsubishi", "Lancer", 4);
    Cars subaru = new Cars("subaru", "Impreza WRX STI", 4);
    Cars error = new Cars("Renaut", "Scénic", 1);

    cars.Add(nissan);
    cars.Add(honda);
    cars.Add(toyota);
    cars.Add(mitsubishi);
    cars.Add(subaru);
    cars.Add(error);

    foreach (var car in cars)
    {
        car.ViewDetails();
    }
    Console.WriteLine();
}
void Exercice3()
{
    List<BankAccount> bankAccount = new List<BankAccount>();
    BankAccount bankAccount1 = new BankAccount("BE24845635247568");
    bankAccount.Add(bankAccount1);

    while (true)
    {
        Console.WriteLine("Choisissez \"1\" pour consulter votre compte\nChoisissez \"2\" pour faire un retrait\nChoisissez \"3\" pour faire un dépôt\nChoisissez \"0\" pour QUITTER");
        int choose = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        if (choose == 0) break;
        else if (choose == 1) bankAccount1.AfficherSolde();
        else if (choose == 2) bankAccount1.Retirer();
        else if (choose == 3) bankAccount1.Deposer();
    }
}
void Exercice4()
{
    Produit capote = new Produit("capote", 0.5m);
    Produit shampoing = new Produit("shampoing", 14.2m);
    Produit dentifrice = new Produit("dentifrice", 9.4m);
    Panier panier = new Panier();
    panier.AddProduct(capote);
    panier.AddProduct(shampoing);
    panier.AddProduct(dentifrice);
    panier.DisplayBasketful();
    panier.DeleteProduct(capote);
    panier.DisplayBasketful();
}
void Exercice5()
{
    bool vrai = true;
    Bibliotheque bibliotheque = new Bibliotheque();
    Livre cool = new Livre("La POO pour les GROS nuls", "Adrien HUBERT", 2026);
    Livre pasCool = new Livre("La POO pour les pros", "Choquet", 2024);
    Livre salope = new Livre("J'aime sucer des queues", "Céline Lecroart", 2025);
    bibliotheque.AddBook(cool);
    bibliotheque.AddBook(pasCool);
    bibliotheque.AddBook(salope);
    while (vrai)
    {
        Console.WriteLine("Choisissez \"1\" pour ajouter un livre\nChoisissez \"2\" pour afficher les livres\nChoisissez \"3\" pour supprimer un livre\nChoisissez \"4\" pour rechercher un livre\nChoisissez \"0\" pour QUITTER");
        int choose = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        switch (choose)
        {
            case 0:
                vrai = false;
                break;
            case 1:
                Console.WriteLine("Entrez le titre du livre :");
                string titre = Console.ReadLine();
                Console.WriteLine("Entrez l'auteur du livre :");
                string auteur = Console.ReadLine();
                Console.WriteLine("Entrez l'année de publication du livre :");
                int annee = int.Parse(Console.ReadLine());
                Livre livre = new Livre(titre, auteur, annee);
                bibliotheque.AddBook(livre);
                break;
            case 2:
                bibliotheque.DisplayBooks();
                break;
            case 3:
                bibliotheque.DisplayBooks();
                Console.WriteLine("Entrez l'ID du livre à supprimer :");
                Guid id = Guid.Parse(Console.ReadLine());
                bibliotheque.DeleteBook(id);
                break;
            case 4:
                Console.WriteLine("Entrez le titre, l'auteur ou l'année de parution du livre à rechercher :");
                string search = Console.ReadLine();
                bibliotheque.SearchBook(search);
                break;
            default:
                break;
        }
    }
}
void ExerciceChambreHotel()
{
    Hotel hotel = new Hotel();
    List<Chambre> chambresLibres = new List<Chambre>();
    List<Chambre> chambres = new List<Chambre>();
    chambres.Add(new Chambre("Simple", 50m, 1));
    chambres.Add(new Chambre("Double", 80m, 2));
    chambres.Add(new Chambre("Suite", 150m, 3));
    chambres.Add(new Chambre("Suite", 200m, 4));
    //chambres.Add(new Chambre("Suite", 0, 4));
    bool vrai = true;
    while (vrai)
    {
        Console.WriteLine($"Choisissez \"1\" pour ajouter une chambre\nChoisissez \"2\" pour lister les chambres\nChoisissez \"3\" " +
                $"pour rechercher des chambres\nChoisissez \"4\" pour afficher les chambres libre en fonction des dates\nChoisissez \"5\" " +
                $"pour annuler une réservationChoisissez \"0\" pour QUITTER");
        int chose = int.Parse(Console.ReadLine());
        switch (chose)
        {
            case 0:
                vrai = false;
                break;
            case 1:
                Console.WriteLine("Entrez le type de chambre :");
                string type = Console.ReadLine();
                Console.WriteLine("Entrez le prix de la chambre :");
                decimal prix = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Entrez le nombre de lits de la chambre :");
                int nbLits = int.Parse(Console.ReadLine());
                chambres.Add(new Chambre(type, prix, nbLits));
                break;
            case 2:
                foreach (Chambre chambre in chambres)
                {
                    Console.WriteLine($"Chambre n°{chambre.RoomNumber} : {chambre.Type}, {chambre.Price}€, {chambre.Capacity} lits");
                }
                break;
            case 3:
                Console.WriteLine("Entrez le type de chambre à rechercher :");
                string typeRecherche = Console.ReadLine();
                List<Chambre> chambresTrouvees = chambres.FindAll(c => c.Type.ToLower() == typeRecherche.ToLower());
                if (chambresTrouvees.Count == 0)
                {
                    Console.WriteLine("Aucune chambre trouvée.");
                }
                else
                {
                    foreach (Chambre chambre in chambresTrouvees)
                    {
                        Console.WriteLine($"Chambre n°{chambre.RoomNumber} : {chambre.Type}, {chambre.Price}€, {chambre.Capacity} lits");
                    }
                }
                break;
            case 4:
                Console.WriteLine("Entrez la date de début (format : yyyy-MM-dd) :");
                DateOnly startDate = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Entrez la date de fin (format : yyyy-MM-dd) :");
                DateOnly endDate = DateOnly.Parse(Console.ReadLine());
                foreach (Booking booking in hotel.AllBookings)
                {
                    if (booking.StartDate < endDate && booking.EndDate > startDate)
                    {
                        foreach (Chambre chambre in booking.Rooms)
                        {
                            chambresLibres.RemoveAll(c => c.RoomNumber == chambre.RoomNumber);
                        }
                    }
                }
                break;
            case 5:
                Console.WriteLine("Entrez la date de début de la réservation à annuler (format : yyyy-MM-dd) :");
                DateOnly startDateAnnulation = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Entrez la date de fin de la réservation à annuler (format : yyyy-MM-dd) :");
                DateOnly endDateAnnulation = DateOnly.Parse(Console.ReadLine());
                Booking bookingToRemove = hotel.AllBookings.Find(b => b.StartDate == startDateAnnulation && b.EndDate == endDateAnnulation);
                if (bookingToRemove != null)
                {
                    hotel.AllBookings.Remove(bookingToRemove);
                    Console.WriteLine("Réservation annulée avec succès.");
                }
                else
                {
                    Console.WriteLine("Aucune réservation trouvée pour les dates spécifiées.");
                }
                break;
            default:
                Console.WriteLine("Choix invalide.");
                break;
        }
    }
}