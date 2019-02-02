
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoireVélo
{
    public class Deposant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
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
