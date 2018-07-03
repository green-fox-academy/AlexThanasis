using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public static int IdCount = 0;
        public int Id { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount()
        {
            IdCount++;
            Id = IdCount;
        }

        public BankAccount(string name, string balance, string animalType)
        {
            IdCount++;
            Id = IdCount;
            Name = name;
            Balance = Double.Parse(balance);
            AnimalType = animalType;
            IsKing = false;
            IsGood = true;
        }
    }
}
