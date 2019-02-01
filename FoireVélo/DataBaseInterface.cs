using System;
using System.Linq;
using System.Collections.Generic;
using FoireVélo.database;

namespace FoireVélo
{
    public class DataBaseInterface : IDataBaseInterface
    {
        private FoireAuxVeloDbContext m_Sqlconnection;
        public DataBaseInterface(FoireAuxVeloDbContext cnx)
        {
            m_Sqlconnection = cnx;
        }

        public List<Deposant> GetDeposantList()
        {
            return m_Sqlconnection.Deposants.OrderBy(x => x.Nom).ToList();
        }

        public void InsertDeposant(string nom, string prenom, string telephone)
        {
            m_Sqlconnection.Deposants.Add(new Deposant { Nom = nom, Prenom = prenom, telephone = telephone });
            m_Sqlconnection.SaveChanges();
        }

        public int GetNbDeposant()
        {
            return m_Sqlconnection.Deposants.Count();
        }


        public int GetNBArticles()
        {
            return m_Sqlconnection.Articles.Count();
        }

        public double GetTotalVente()
        {
            return m_Sqlconnection.Articles.Sum(x => x.PrixVente.GetValueOrDefault());
        }


        public double GetBenefVente()
        {
            var TotalVente = m_Sqlconnection.Articles.Sum(x => x.PrixVente.GetValueOrDefault());
            var PrixRevientClient = m_Sqlconnection.Articles.Sum(x => x.PrixRevientClient);
            return (TotalVente - PrixRevientClient);
        }


        public double GetDroitEntree()
        {
            return GetNbDeposant() * (double)2.5;
        }


        public double getBenefTotal()
        {
            return GetDroitEntree() + GetBenefVente();
        }

        public int InsertArticle(Article article)
        {
            m_Sqlconnection.Articles.Add(article);
            m_Sqlconnection.SaveChanges();
            return article.Id;
        }

        public void UpdateArticleCode(string articleCode, int articleId)
        {
            Article article = new Article { Id = articleId };
            m_Sqlconnection.Articles.Attach(article);
            article.Code = articleCode;
            m_Sqlconnection.SaveChanges();
        }

        public void UpdateArticle(Article article)
        {
            m_Sqlconnection.Articles.Attach(article);
            m_Sqlconnection.SaveChanges();
        }

        internal void DeleteArticle(int articleId)
        {
            Article article = new Article { Id = articleId };
            m_Sqlconnection.Articles.Attach(article);
            m_Sqlconnection.Articles.Remove(article);
            m_Sqlconnection.SaveChanges();
        }

        internal void UpdateDeposant(int id, string nom, string prenom, string telephone)
        {
            Deposant deposant = new Deposant { Id = id };
            m_Sqlconnection.Deposants.Attach(deposant);
            deposant.Nom = nom;
            deposant.Prenom = prenom;
            deposant.telephone = telephone;
            m_Sqlconnection.SaveChanges();
        }

        internal void DeleteDeposant(int deposantId)
        {
            Deposant deposant = new Deposant { Id = deposantId };
            m_Sqlconnection.Deposants.Attach(deposant);
            m_Sqlconnection.Deposants.Remove(deposant);
            m_Sqlconnection.SaveChanges();
        }

        public List<Article> GetArticlesByDeposant(int deposantId)
        {
            return m_Sqlconnection.Articles.Where(a => a.DeposantId == deposantId).OrderBy(a => a.Code).ToList();
        }

        public List<Article> GetUnsoldedArticlesByDeposant(int deposantId)
        {
            return m_Sqlconnection.Articles.Where(x => x.DeposantId == deposantId && x.PrixVente == 0 || x.PrixVente == null).OrderBy(x => x.Code).ToList();
        }

        public List<Article> GetSaleArticlesByDeposant(int deposantId)
        {
            return m_Sqlconnection.Articles.Where(x => x.DeposantId == deposantId && x.PrixVente != 0).OrderBy(x => x.Code).ToList();
        }

        public List<Article> GetArticleList()
        {
            return m_Sqlconnection.Articles.OrderBy(x => x.Code).ToList();
        }

        public int UpdatePrixVenteArticle(int articleId, float prixVente)
        {
            double prixRevientClient = PrixVenteToPrixClient(prixVente);

            Article article = new Article { Id = articleId };
            m_Sqlconnection.Articles.Attach(article);
            article.PrixVente = prixVente;
            article.PrixRevientClient = (float)prixRevientClient;
            return m_Sqlconnection.SaveChanges();
        }

        public List<Article> GetDiscountArticleNotSold()
        {
            return m_Sqlconnection.Articles.Where(a => (a.PrixMini != 0 && a.PrixMini != a.PrixDemande) && (a.PrixVente == 0 || a.PrixVente == null)).OrderBy(x => x.Code).ToList();
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
    }
}
