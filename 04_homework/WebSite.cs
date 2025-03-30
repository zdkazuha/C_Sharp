using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04_homework
{
    internal class WebSite
    {
        private string name = "NoName";
        private string pathToTheSite = "NoPath";
        private string siteDescription = "NoDescription";
        private string ipAddressOfTheSite = "NoIpAddress";

        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        public string PathToTheSite
        {
            get => pathToTheSite;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.pathToTheSite = value;
                }
            }
        }
        public string SiteDescription
        {
            get => siteDescription;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.siteDescription = value;
                }
            }
        }
        public string IpAddressOfTheSite
        {
            get => ipAddressOfTheSite;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.ipAddressOfTheSite = value;
                }
            }
        }

        public void Input(string name, string pathToTheSite, string siteDescription, string ipAddressOfTheSite)
        {
            this.name = name;
            this.pathToTheSite = pathToTheSite;
            this.siteDescription = siteDescription;
            this.ipAddressOfTheSite = ipAddressOfTheSite;
        }

        public WebSite() { }
        public WebSite(string name, string pathToTheSite, string siteDescription, string ipAddressOfTheSite)
        {
            Name = name;
            PathToTheSite = pathToTheSite;
            SiteDescription = siteDescription;
            IpAddressOfTheSite = ipAddressOfTheSite;
        }

        public override string ToString()
        {
            return $"Name :: {Name,-15} Path site :: {PathToTheSite,-15} Site descriprion :: {SiteDescription,-15} Ip address  :: {IpAddressOfTheSite,-15}";
        }
    }

    internal class Magazine
    {
        private string name = "NoName";
        private DateTime date = DateTime.MinValue;
        private string magazineDescription = "NoDescription";
        private ulong telephone = 380000000000;
        private string email = "NoEmail@gmail.com";

        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
                else
                {
                    Console.WriteLine("Error!!!");
                }
            }
        }

        public DateTime Date { get; set; }

        public string MagazineDescription
        {
            get => magazineDescription;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
                else
                {
                    Console.WriteLine("Error!!!");
                }
            }
        }
        public ulong Telephone
        {
            get => telephone;
            set
            {
                if (value < 380999999999 && value > 380000000000)
                    telephone = value;
                else
                {
                    Console.WriteLine("Not found telephone!!!");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) || value.Length < 15)
                    email = value;
                else
                {
                    Console.WriteLine("Error!!!");
                }
            }
        }
        public Magazine() {}
        public Magazine(string name, DateTime date, string magazineDescription, ulong telephone, string email)
        {
            Name = name;
            Date = date;
            MagazineDescription = magazineDescription;
            Telephone = telephone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name :: {Name,-15} Date :: {Date.ToShortDateString(),-15} Magazine description :: {MagazineDescription,-15} Telephone  :: {Telephone,-15} Email :: {Email,-15}";
        }

        public void Input(string name, DateTime date, string magazineDescription, ulong telephone, string email)
        {
            Name = name;
            Date = date;
            MagazineDescription = magazineDescription;
            Telephone = telephone;
            Email = email;
        }
    }
}