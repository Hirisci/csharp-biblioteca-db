using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Product
    {
        public int Id {get;}
        public string Code { get;}
        public string Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public DateOnly EditionDate { get; set; }
        public int Quantity { get; set; }
        public string Sector { get; set; }


        
        public Product(string code, string title, DateOnly releasedate, DateOnly editionDate, int quantity, string sector)
        {
            Code=code;
            Title=title;
            ReleaseDate=releasedate;
            EditionDate=editionDate;
            Quantity=quantity;
            Sector=sector;
        }
        public override string? ToString()
        {
            return String.Format("| Codice: {0} \t| Titolo: {1,30} \t| Autore: {2,30} \t| Anno: {3} \t| Posizione: {4,10} \t| Quantita: {5}", Code, Title, ReleaseDate, Sector, Quantity);
        }
    }


 
}
