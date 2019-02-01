using System.Collections.Generic;
using FoireVélo.database;

namespace FoireVélo
{
    public interface IDataBaseInterface
    {
        List<Article> GetArticleList();
        List<Article> GetArticlesByDeposant(int deposantId);
        double getBenefTotal();
        double GetBenefVente();
        List<Deposant> GetDeposantList();
        List<Article> GetDiscountArticleNotSold();
        double GetDroitEntree();
        int GetNbDeposant();
        List<Article> GetSaleArticlesByDeposant(int deposantId);
        double GetTotalVente();
        List<Article> GetUnsoldedArticlesByDeposant(int deposantId);
        int InsertArticle(Article article);
        void InsertDeposant(string nom, string prenom, string telephone);
        double PrixVenteToPrixClient(double prixVente);
        void UpdateArticle(Article article);
        void UpdateArticleCode(string articleCode, int articleId);
        int UpdatePrixVenteArticle(int articleId, float prixVente);
    }
}