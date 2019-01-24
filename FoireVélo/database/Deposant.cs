using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoireVélo
{
    public class Deposant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string telephone { get; set; }
       
        public Deposant()
        {
            Nom = string.Empty;
            Prenom = string.Empty;
            telephone = string.Empty;
         }

        public Deposant(string _nom, string _prenom, string _telephone)
        {
            Nom = _nom;
            Prenom = _prenom;
            telephone = _telephone;
        }

        public override string ToString()
        {
            return Nom;
        }

    }
}
