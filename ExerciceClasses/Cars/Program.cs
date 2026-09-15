using ExerciceClasses;
using ExerciceClasses.BankAccount;

//List<Cars> cars = new List<Cars>();
//Cars nissan = new Cars("Nissan", "GTR", 2);
//Cars honda = new Cars("Honda", "Civic", 2);
//Cars toyota = new Cars("Toyota", "Supra", 2);
//Cars mitsubishi = new Cars("Mitsubishi", "Lancer", 4);
//Cars subaru = new Cars("subaru", "Impreza WRX STI", 4);
//Cars error = new Cars("Renaut", "Scénic", 1);


//cars.Add(nissan);
//cars.Add(honda);
//cars.Add(toyota);
//cars.Add(mitsubishi);
//cars.Add(subaru);
//cars.Add(error);

//foreach (var car in cars)
//{
//    car.ViewDetails();
//}

List<BankAccount> bankAccount = new List<BankAccount>();
BankAccount bankAccount1 = new BankAccount("BE24845635247568");
bankAccount.Add(bankAccount1);

while (true)
{
    Console.WriteLine("Choisissez \"1\" pour consulter votre compte\nChoisissez \"2\" pour faire un retrait\nChoisissez \"3\" pour faire un dépôt");
    int choose = int.Parse(Console.ReadLine());
    if (choose == 0) break;
    else if (choose == 1) bankAccount1.AfficherSolde();
    else if (choose == 2) bankAccount1.Retirer();
    else if (choose == 3) bankAccount1.Deposer();
}