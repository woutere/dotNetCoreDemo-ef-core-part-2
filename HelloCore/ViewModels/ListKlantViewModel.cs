using HelloCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.ViewModels
{
    public class ListKlantViewModel
    {
        public String Naam { get; set; }
        public String Voornaam { get; set; }
        public List<Klant> Bestellingen { get; set; }
    }
}
