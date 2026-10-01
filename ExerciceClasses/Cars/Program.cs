using ExerciceClasses;
using ExerciceClasses.BankAccount;
using ExerciceClasses.Exercice4;
using ExerciceClasses.Exercice5;
// Force l'encodage de la console en UTF-8
Console.OutputEncoding = System.Text.Encoding.UTF8;

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
    Bibliotheque bibliotheque = new Bibliotheque();
    Livre cool = new Livre("La POO pour les GROS nuls", "Adrien HUBERT", 2026);
    Livre pasCool = new Livre("La POO pour les pros", "Choquet", 2024);
    Livre salope = new Livre("J'aime sucer des queues", "Céline Lecroart", 2025);
    bibliotheque.AddBook(cool);
    bibliotheque.DisplayBooks();
}
void ExerciceChambreHotel()
{

}