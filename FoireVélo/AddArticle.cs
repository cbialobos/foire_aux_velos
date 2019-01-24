using System;
using System.Windows.Forms;
using FoireVélo.database;

namespace FoireVélo
{
    public partial class AddArticle : Form
    {
        public Article CurrentArticle { get; set; }
        bool edit = false;

        public AddArticle(Article article)
        {
            InitializeComponent();
            if(article!=null)
            {
                CurrentArticle = article;
                edit = true;
            }
            else
            {
                CurrentArticle = new Article();
            }
            Init();
        }

        private void Init()
        {
            cbType.DataSource = Enum.GetValues(typeof(ArticleType));
            cbGenre.DataSource = Enum.GetValues(typeof(Genre));
            if(edit && CurrentArticle !=null )
            {
                cbType.SelectedItem = CurrentArticle.Type;
                Roue.Value = (decimal)CurrentArticle.DimensionRoue;
                Vitesse.Value = (decimal)CurrentArticle.Vitesse;
                cbGenre.SelectedItem = CurrentArticle.Genre;
                txtCommentaire.Text = CurrentArticle.Commentaire;
                nbPrixVente.Value = (decimal)CurrentArticle.PrixDemande;
                txtCouleur.Text = CurrentArticle.Couleur;
                nbPrixMini.Value = (decimal)CurrentArticle.PrixMini;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CurrentArticle.Type = (ArticleType)cbType.SelectedItem;
            CurrentArticle.DimensionRoue = (float) Roue.Value;
            CurrentArticle.Vitesse = (float)Vitesse.Value;
            CurrentArticle.Genre = (Genre)cbGenre.SelectedItem;
            CurrentArticle.Commentaire = txtCommentaire.Text;
            CurrentArticle.PrixDemande = (float)nbPrixVente.Value;
            CurrentArticle.Couleur = txtCouleur.Text;
            CurrentArticle.PrixMini = (float)nbPrixMini.Value;


            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public double PrixClientToPrixVente(double prixClient)
        {
            var prixVente = 0.0;
            if(prixClient <=50)
            {
                prixVente = Math.Round(prixClient * 1.2);
            }
            else if(prixClient <= 100)
            {
                prixVente = Math.Round(prixClient * 1.15);
            }
            else
            {
                prixVente = Math.Round(prixClient *1.1);
            }
            return prixVente;
        }

        public double PrixVenteToPrixClient(double prixVente)
        {
            var prixClient = 0.0;
            if (prixVente <= 60)
            {
                prixClient = Math.Round(prixVente / 1.2);
            }
            else if (prixVente <= 120)
            {
                prixClient = Math.Round(prixVente / 1.15);
            }
            else
            {
                prixClient = Math.Round(prixVente / 1.1);
            }
            return prixClient;
        }

        private void btnToPrixClient_Click(object sender, EventArgs e)
        {
            nbPrixRevientClient.Value = (decimal)PrixVenteToPrixClient((double)nbPrixVente.Value);
        }

        private void btnToPrixVente_Click(object sender, EventArgs e)
        {
            nbPrixVente.Value = (decimal)PrixClientToPrixVente((double)nbPrixRevientClient.Value);
        }

        private void BtnToPrixSoldeClient_Click(object sender, EventArgs e)
        {
            nbPrixSoldeClient.Value = (decimal)PrixVenteToPrixClient((double)nbPrixMini.Value);
        }

        private void BtnToPrixVenteSolde_Click(object sender, EventArgs e)
        {
            nbPrixMini.Value = (decimal)PrixClientToPrixVente((double)nbPrixSoldeClient.Value);
        }
    }
}
