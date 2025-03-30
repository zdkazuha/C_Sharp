using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_homework_
{
    internal class CreditCard
    {
        public CreditCard(string name, string number, DateTime expirationDater, int cvv, string etc)
        {
            Name = name;
            Number = number;
            ExpirationDater = expirationDater;
            Cvv = cvv;
            Etc = etc;
        }
        public override string ToString()
        {
            return $"Name card       :: {Name} \nNumber card     :: {Number} \nExpiration date :: {ExpirationDater:dd/MM/yyyy} \nCvv             :: {Cvv} \nEtc             :: {Etc}";
        }

        private readonly string[] nameLib = { "Visa Platinum", "Visa Gold", "Visa Debit", "Visa Classic", "Visa Travel" };
        private string name;
        private string number;
        private DateTime expirationDater = DateTime.MinValue;
        private int cvv;
        private string etc;
        public string Name
        {
            get => name;
            set
            {
                bool found = false;

                foreach (var validName in nameLib)  
                {
                    if (validName == value)
                    {
                        name = value;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    throw new Exception("Not correct Name");
                }
            }
        }
        public string Number
        {
            get => number;  
            set
            {
                if (value.Length != 16)
                {
                    throw new Exception("The number must be a 16-digit numeric value");
                }
                number = value;
            }
        }
        public DateTime ExpirationDater
        {
            get => expirationDater;
            set
            {
                if (value <= DateTime.Now)
                {
                    throw new Exception("Incorrect expiration date");
                }
                expirationDater = value;
            }
        }

        public int Cvv
        {
            get => cvv;
            set
            {
                if (value < 100 || value > 999)
                {
                    throw new Exception("The CVV number must be three digits");
                }
                cvv = value;
            }

        }

        public string Etc
        {
            get => etc;
            set => etc = value;
        }
    }
}
