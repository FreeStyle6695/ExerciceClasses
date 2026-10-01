using System;
using System.Collections.Generic;
using System.Text;
namespace ExerciceClasses.BankAccount;
public class BankAccount
{
    public string AccountNumber { get; set; }
    private decimal _solde { get; set; }
    public BankAccount (string accountNumber)
    {
        AccountNumber = accountNumber;
        _solde = 0;
    }
    public void Deposer()
    {
        Console.WriteLine("\nCombien souhaitez-vous déposer ?");
        int depot = int.Parse(Console.ReadLine());
        _solde = _solde + depot;
    }
    public void Retirer ()
    {
        Console.WriteLine("\nCombien souhaitez-vous retirer");
        int retrait = int.Parse(Console.ReadLine());
        if (_solde > retrait) _solde = _solde - retrait;
        else Console.WriteLine("\nLe solde du compte est insuffisant\n");
    }
    public void AfficherSolde()
    {
        Console.WriteLine($"\nle solde du compte {AccountNumber} est de {_solde}€\n");
    }
}