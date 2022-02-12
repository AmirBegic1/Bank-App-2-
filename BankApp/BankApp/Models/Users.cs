using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    class Users
    {
        private string Ime { get; set; } 
        private string Prezime { get; set; }
        private int Datum_Rodjenja { get; set; }
        private string Ime_Roditelja
        {
            get; set;
        }
        private string Mjesto_Rodjenja
        {
            get; set;
        }

        private int Password { get; set; }
        private int Password2 { get; set; }
    }
}
