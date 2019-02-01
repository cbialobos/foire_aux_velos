using System;
using System.Collections.Generic;
using FoireVélo.database;
using System.Data.SqlClient;

namespace FoireVélo
{
    public class LegacyDataBaseInterface : IDataBaseInterface
    {
        private SqlConnection m_Sqlconnection;
        public LegacyDataBaseInterface(SqlConnection cnx)
        {
            m_Sqlconnection = cnx;
        }

        public List<Deposant> GetDeposantList()
        {
            var deposantList = new List<Deposant>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, Nom, Prenom, Telephone FROM Deposant order by Nom";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Deposant newDeposant = new Deposant
                        {
                            Id = dataReader.GetInt32(0),
                            Nom = dataReader.GetString(1),
                            Prenom = dataReader.GetString(2),
                            telephone = dataReader.GetString(3)
                        };
                        deposantList.Add(newDeposant);
                    }
                    dataReader.Close();
                }
            }
            return deposantList;
        }

        public void InsertDeposant(string nom, string prenom, string telephone)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "INSERT INTO Deposant (Nom, Prenom, Telephone) VALUES ("
                                       + "'" + nom + "' , '" + prenom + "', '" + telephone + "');";
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        public int GetNbDeposant()
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT count(*) FROM Deposant";
                object res = maCommande.ExecuteScalar();
                if (res != null && res is int)
                {
                    return (int)res;
                }
            }
            return 0;
        }


        public int GetNBArticles()
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT count(*) FROM Article";
                object res = maCommande.ExecuteScalar();
                if (res != null && res is int)
                {
                    return (int)res;
                }
            }
            return 0;
        }

        public double GetTotalVente()
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "select SUM(PrixVente) from Article";
                object res = maCommande.ExecuteScalar();
                if (res != null && res is double)
                {
                    return (double)res;
                }
            }
            return 0;
        }


        public double GetBenefVente()
        {
            double TotalVente = 0;
            double PrixRevientClient = 0;
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "select SUM(PrixVente) from Article";
                object res = maCommande.ExecuteScalar();
                if (res != null && res is double)
                {
                    TotalVente = (double)res;
                }
                maCommande.CommandText = "select SUM(PrixRevientClient) from Article";
                object resRevient = maCommande.ExecuteScalar();
                if (resRevient != null && resRevient is double)
                {
                    PrixRevientClient = (double)resRevient;
                }
            }
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
            int articleId = 0;
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "INSERT INTO Article (type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini, Couleur, Code, DeposantId) VALUES ("
                                       + "'" + (int)article.Type + "' , '" + (int)article.DimensionRoue + "', '" + (int)article.Vitesse + "', '" + (int)article.Genre
                                       + "', '" + article.Commentaire + "', '" + (float)article.PrixDemande + "', '" + (float)article.PrixMini
                                       + "', '" + article.Couleur + "', '" + article.Code + "', '" + article.DeposantId + "');SELECT SCOPE_IDENTITY()";
                articleId = (int)(decimal)maCommande.ExecuteScalar();
                maCommande.Dispose();
            }
            return articleId;
        }

        public void UpdateArticleCode(string articleCode, int articleId)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "Update Article set Code=@1 where id=@2";
                maCommande.Parameters.AddWithValue("@1", articleCode);
                maCommande.Parameters.AddWithValue("@2", articleId);
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        public void UpdateArticle(Article article)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "Update Article set type=@1, Roue=@2, Vitesse=@3, Sexe=@4, Commentaire=@5, PrixDemandé=@6, PrixMini=@7, ";
                maCommande.CommandText += " Couleur=@8, Code=@9, DeposantId=@10 where id=@11";
                maCommande.Parameters.AddWithValue("@1", article.Type);
                maCommande.Parameters.AddWithValue("@2", article.DimensionRoue);
                maCommande.Parameters.AddWithValue("@3", article.Vitesse);
                maCommande.Parameters.AddWithValue("@4", article.Genre);
                maCommande.Parameters.AddWithValue("@5", article.Commentaire);
                maCommande.Parameters.AddWithValue("@6", article.PrixDemande);
                maCommande.Parameters.AddWithValue("@7", article.PrixMini);
                maCommande.Parameters.AddWithValue("@8", article.Couleur);
                maCommande.Parameters.AddWithValue("@9", article.Code);
                maCommande.Parameters.AddWithValue("@10", article.DeposantId);
                maCommande.Parameters.AddWithValue("@11", article.Id);
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        internal void DeleteArticle(int articleId)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "Delete from Article WHERE id = @1;";
                maCommande.Parameters.AddWithValue("@1", articleId);
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        internal void UpdateDeposant(int id, string nom, string prenom, string telephone)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "UPDATE Deposant  SET[Nom] = @1, [Telephone] = @2,[Prenom] = @3 WHERE id = @4;";
                maCommande.Parameters.AddWithValue("@1", nom);
                maCommande.Parameters.AddWithValue("@2", telephone);
                maCommande.Parameters.AddWithValue("@3", prenom);
                maCommande.Parameters.AddWithValue("@4", id);
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        internal void DeleteDeposant(int deposantId)
        {
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "Delete from Deposant WHERE id = @1;";
                maCommande.Parameters.AddWithValue("@1", deposantId);
                maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
        }

        public List<Article> GetArticlesByDeposant(int deposantId)
        {
            var articleList = new List<Article>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini,PrixVente,PrixRevientClient, Couleur, Code, DeposantId FROM Article where deposantId=" + deposantId + " order by Code";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Article newArticle = new Article();
                        newArticle.Id = dataReader.GetInt32(0);
                        if (!dataReader.IsDBNull(1))
                        {
                            newArticle.Type = (ArticleType)dataReader.GetInt32(1);
                        }
                        if (!dataReader.IsDBNull(2))
                        {
                            newArticle.DimensionRoue = dataReader.GetInt32(2);
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            newArticle.Vitesse = dataReader.GetInt32(3);
                        }
                        if (!dataReader.IsDBNull(4))
                        {
                            newArticle.Genre = (Genre)dataReader.GetInt32(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            newArticle.Commentaire = dataReader.GetString(5);
                        }
                        if (!dataReader.IsDBNull(6))
                        {
                            newArticle.PrixDemande = (float)dataReader.GetDouble(6);
                        }
                        if (!dataReader.IsDBNull(7))
                        {
                            newArticle.PrixMini = (float)dataReader.GetDouble(7);
                        }
                        if (!dataReader.IsDBNull(8))
                        {
                            newArticle.PrixVente = (float)dataReader.GetDouble(8);
                        }
                        if (!dataReader.IsDBNull(9))
                        {
                            newArticle.PrixRevientClient = (float)dataReader.GetDouble(9);
                        }
                        if (!dataReader.IsDBNull(10))
                        {
                            newArticle.Couleur = dataReader.GetString(10);
                        }
                        if (!dataReader.IsDBNull(11))
                        {
                            newArticle.Code = dataReader.GetString(11);
                        }
                        newArticle.DeposantId = dataReader.GetInt32(12);



                        articleList.Add(newArticle);
                    }
                    dataReader.Close();
                }
            }
            return articleList;
        }

        public List<Article> GetUnsoldedArticlesByDeposant(int deposantId)
        {
            var articleList = new List<Article>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini,PrixVente,PrixRevientClient, Couleur, Code, DeposantId FROM Article where deposantId=" + deposantId + " and (PrixVente=0 or PrixVente is null) order by Code";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Article newArticle = new Article();
                        newArticle.Id = dataReader.GetInt32(0);
                        if (!dataReader.IsDBNull(1))
                        {
                            newArticle.Type = (ArticleType)dataReader.GetInt32(1);
                        }
                        if (!dataReader.IsDBNull(2))
                        {
                            newArticle.DimensionRoue = dataReader.GetInt32(2);
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            newArticle.Vitesse = dataReader.GetInt32(3);
                        }
                        if (!dataReader.IsDBNull(4))
                        {
                            newArticle.Genre = (Genre)dataReader.GetInt32(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            newArticle.Commentaire = dataReader.GetString(5);
                        }
                        if (!dataReader.IsDBNull(6))
                        {
                            newArticle.PrixDemande = (float)dataReader.GetDouble(6);
                        }
                        if (!dataReader.IsDBNull(7))
                        {
                            newArticle.PrixMini = (float)dataReader.GetDouble(7);
                        }
                        if (!dataReader.IsDBNull(8))
                        {
                            newArticle.PrixVente = (float)dataReader.GetDouble(8);
                        }
                        if (!dataReader.IsDBNull(9))
                        {
                            newArticle.PrixRevientClient = (float)dataReader.GetDouble(9);
                        }
                        if (!dataReader.IsDBNull(10))
                        {
                            newArticle.Couleur = dataReader.GetString(10);
                        }
                        if (!dataReader.IsDBNull(11))
                        {
                            newArticle.Code = dataReader.GetString(11);
                        }
                        newArticle.DeposantId = dataReader.GetInt32(12);



                        articleList.Add(newArticle);
                    }
                    dataReader.Close();
                }
            }
            return articleList;
        }

        public List<Article> GetSaleArticlesByDeposant(int deposantId)
        {
            var articleList = new List<Article>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini,PrixVente,PrixRevientClient, Couleur, Code, DeposantId FROM Article where deposantId=" + deposantId + " and PrixVente!=0 order by Code";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Article newArticle = new Article();
                        newArticle.Id = dataReader.GetInt32(0);
                        if (!dataReader.IsDBNull(1))
                        {
                            newArticle.Type = (ArticleType)dataReader.GetInt32(1);
                        }
                        if (!dataReader.IsDBNull(2))
                        {
                            newArticle.DimensionRoue = dataReader.GetInt32(2);
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            newArticle.Vitesse = dataReader.GetInt32(3);
                        }
                        if (!dataReader.IsDBNull(4))
                        {
                            newArticle.Genre = (Genre)dataReader.GetInt32(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            newArticle.Commentaire = dataReader.GetString(5);
                        }
                        if (!dataReader.IsDBNull(6))
                        {
                            newArticle.PrixDemande = (float)dataReader.GetDouble(6);
                        }
                        if (!dataReader.IsDBNull(7))
                        {
                            newArticle.PrixMini = (float)dataReader.GetDouble(7);
                        }
                        if (!dataReader.IsDBNull(8))
                        {
                            newArticle.PrixVente = (float)dataReader.GetDouble(8);
                        }
                        if (!dataReader.IsDBNull(9))
                        {
                            newArticle.PrixRevientClient = (float)dataReader.GetDouble(9);
                        }
                        if (!dataReader.IsDBNull(10))
                        {
                            newArticle.Couleur = dataReader.GetString(10);
                        }
                        if (!dataReader.IsDBNull(11))
                        {
                            newArticle.Code = dataReader.GetString(11);
                        }
                        newArticle.DeposantId = dataReader.GetInt32(12);

                        articleList.Add(newArticle);
                    }
                    dataReader.Close();
                }
            }
            return articleList;
        }

        public List<Article> GetArticleList()
        {
            var articleList = new List<Article>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini,PrixVente,PrixRevientClient, Couleur, Code, DeposantId FROM Article order by Code";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Article newArticle = new Article();
                        newArticle.Id = dataReader.GetInt32(0);
                        if (!dataReader.IsDBNull(1))
                        {
                            newArticle.Type = (ArticleType)dataReader.GetInt32(1);
                        }
                        if (!dataReader.IsDBNull(2))
                        {
                            newArticle.DimensionRoue = dataReader.GetInt32(2);
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            newArticle.Vitesse = dataReader.GetInt32(3);
                        }
                        if (!dataReader.IsDBNull(4))
                        {
                            newArticle.Genre = (Genre)dataReader.GetInt32(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            newArticle.Commentaire = dataReader.GetString(5);
                        }
                        if (!dataReader.IsDBNull(6))
                        {
                            newArticle.PrixDemande = (float)dataReader.GetDouble(6);
                        }
                        if (!dataReader.IsDBNull(7))
                        {
                            newArticle.PrixMini = (float)dataReader.GetDouble(7);
                        }
                        if (!dataReader.IsDBNull(8))
                        {
                            newArticle.PrixVente = (float)dataReader.GetDouble(8);
                        }
                        if (!dataReader.IsDBNull(9))
                        {
                            newArticle.PrixRevientClient = (float)dataReader.GetDouble(9);
                        }
                        if (!dataReader.IsDBNull(10))
                        {
                            newArticle.Couleur = dataReader.GetString(10);
                        }
                        if (!dataReader.IsDBNull(11))
                        {
                            newArticle.Code = dataReader.GetString(11);
                        }
                        newArticle.DeposantId = dataReader.GetInt32(12);



                        articleList.Add(newArticle);
                    }
                    dataReader.Close();
                }
            }
            return articleList;
        }

        public int UpdatePrixVenteArticle(int articleId, float prixVente)
        {
            int result = 0;
            double prixRevientClient = PrixVenteToPrixClient(prixVente);
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "Update Article set PrixVente=@1, PrixRevientClient=@2 where id=@3";
                maCommande.Parameters.AddWithValue("@1", prixVente);
                maCommande.Parameters.AddWithValue("@2", prixRevientClient);
                maCommande.Parameters.AddWithValue("@3", articleId);
                result = maCommande.ExecuteNonQuery();
                maCommande.Dispose();
            }
            return result;
        }

        public List<Article> GetDiscountArticleNotSold()
        {
            var articleList = new List<Article>();
            using (SqlCommand maCommande = m_Sqlconnection.CreateCommand())
            {
                maCommande.CommandText = "SELECT Id, type, Roue, Vitesse, Sexe, Commentaire, PrixDemandé, PrixMini,PrixVente,PrixRevientClient, Couleur, Code, DeposantId ";
                maCommande.CommandText += "FROM Article where ((PrixMini<>0 and PrixMini<>PrixDemandé) and (PrixVente=0 or PrixVente is null)) order by Code";
                using (SqlDataReader dataReader = maCommande.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Article newArticle = new Article();
                        newArticle.Id = dataReader.GetInt32(0);
                        if (!dataReader.IsDBNull(1))
                        {
                            newArticle.Type = (ArticleType)dataReader.GetInt32(1);
                        }
                        if (!dataReader.IsDBNull(2))
                        {
                            newArticle.DimensionRoue = dataReader.GetInt32(2);
                        }
                        if (!dataReader.IsDBNull(3))
                        {
                            newArticle.Vitesse = dataReader.GetInt32(3);
                        }
                        if (!dataReader.IsDBNull(4))
                        {
                            newArticle.Genre = (Genre)dataReader.GetInt32(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            newArticle.Commentaire = dataReader.GetString(5);
                        }
                        if (!dataReader.IsDBNull(6))
                        {
                            newArticle.PrixDemande = (float)dataReader.GetDouble(6);
                        }
                        if (!dataReader.IsDBNull(7))
                        {
                            newArticle.PrixMini = (float)dataReader.GetDouble(7);
                        }
                        if (!dataReader.IsDBNull(8))
                        {
                            newArticle.PrixVente = (float)dataReader.GetDouble(8);
                        }
                        if (!dataReader.IsDBNull(9))
                        {
                            newArticle.PrixRevientClient = (float)dataReader.GetDouble(9);
                        }
                        if (!dataReader.IsDBNull(10))
                        {
                            newArticle.Couleur = dataReader.GetString(10);
                        }
                        if (!dataReader.IsDBNull(11))
                        {
                            newArticle.Code = dataReader.GetString(11);
                        }
                        newArticle.DeposantId = dataReader.GetInt32(12);

                        articleList.Add(newArticle);
                    }
                    dataReader.Close();
                }
            }
            return articleList;
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
