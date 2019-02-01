using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoireVélo.database
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public ArticleType Type { get; set; }
        public float DimensionRoue { get; set; }
        public float Vitesse { get; set; }
        public Genre Genre { get; set; }
        public string Commentaire { get; set; }
        public float PrixDemande { get; set; }
        public float PrixMini { get; set; }
        public float? PrixVente { get; set;}
        public float PrixRevientClient { get; set; }
        public string Couleur { get; set; }
        public string Code { get; set; }
        public int DeposantId { get; set; }

        public Article()
        {
            Type =  ArticleType.accessoire;
            DimensionRoue = 0;
            Vitesse = 0;
            Genre =  Genre.mixte;
            Commentaire = string.Empty;
            PrixDemande = 0;
            PrixMini = 0;
            PrixVente = 0;
            PrixRevientClient = 0;
            Couleur = string.Empty;
            Code = string.Empty;
            
        }



        public override string ToString()
        {
            return Code;
        }

    }
}
