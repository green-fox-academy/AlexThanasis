using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class AccountsOfTheBank
    {
        public int AccountCounter { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        public AccountsOfTheBank()
        {
            BankAccounts = new List<BankAccount>();
            AddingCharacters(BankAccounts);  
        }
        
        public static List<BankAccount> AddingCharacters(List<BankAccount>input)
        {

            input.Add(
                new BankAccount()
                {
                    Name = "Simba",
                    Balance = 2000,
                    AnimalType = "Animal.Lion",
                    IsKing = true,
                    IsGood = true
                }
                );
            input.Add(
               new BankAccount()
               {
                   Name = "Timon",
                   Balance = 1500,
                   AnimalType = "Animal.Suricata",
                   IsGood = true
               }
               );
            input.Add(
               new BankAccount()
               {
                   Name = "Pumba",
                   Balance = 1800,
                   AnimalType = "Animal.Warthog",
                   IsGood = true
               }
               );
            input.Add(
              new BankAccount()
              {
                  Name = "Mufasa",
                  Balance = 1900,
                  AnimalType = "Animal.Lion",
                  IsKing = true,
                  IsGood = true
              }
              );
            return input;
        }
    }
}
