using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Word = Microsoft.Office.Interop.Word;

namespace FoireVélo
{
    public partial class Form1 : Form
    {
        private DataBaseInterface m_databaseInterface;
        public List<Deposant> deposantList = new List<Deposant>();
        List<Article> m_articleList = new List<Article>();

        public Deposant currentDeposant;
        SqlConnection cnx;
        public Form1()
        {
            InitializeComponent();
            InitSqlConnection();
            m_databaseInterface = new DataBaseInterface(cnx);
            InitDeposantList();
            InitArticleDataGrid();
             
        }

        private void InitSqlConnection()
        {
            ConnectionStringSettings connex = ConfigurationManager.ConnectionStrings["DbConnection"];
            cnx = new SqlConnection (connex.ConnectionString);
            cnx.Open();
        }

        private void InitDeposantList()
        {
            currentDeposant = new Deposant();
            cbDeposant.DataSource = m_databaseInterface.GetDeposantList();
            cbDeposant.DisplayMember = "Nom";
        }

        private void InitArticleList()
        {
            cbCodeArticle.DataSource = m_databaseInterface.GetArticleList();
            cbDeposant.DisplayMember = "Code";
        }


        private void InitArticleDataGrid()
        {
            if(currentDeposant !=null)
            {
                m_articleList = m_databaseInterface.GetArticlesByDeposant(currentDeposant.Id);
                dgArticle.DataSource = m_articleList;
            }
            
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddDeposant newdepForm = new AddDeposant();
            if (newdepForm.ShowDialog() == DialogResult.OK)
            {
                m_databaseInterface.InsertDeposant(newdepForm.currentDeposant.Nom, newdepForm.currentDeposant.Prenom, newdepForm.currentDeposant.telephone);
                InitDeposantList();
                SelectCbIndexByName(newdepForm.currentDeposant.Nom);
            }
        }

        private void SelectCbIndexByName(string nom)
        {
            foreach (Deposant item in cbDeposant.Items)
            {
                if(item.Nom == nom)
                {
                    cbDeposant.SelectedItem = item;
                    break;
                }
            }
        }

        private void cbDeposant_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDeposant = (Deposant)cbDeposant.SelectedItem;
            refreshDeposantInformation();
            InitArticleDataGrid();
        }

        private void refreshDeposantInformation()
        {
            txtName.Text = currentDeposant.Nom;
            txtPrenom.Text = currentDeposant.Prenom;
            txtPhone.Text = currentDeposant.telephone;
        }

        private void tabControlVelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlVelo.SelectedTab == tbStat)
            {
                txtNbDeposant.Text = m_databaseInterface.GetNbDeposant().ToString();
                txtNbArticle.Text = m_databaseInterface.GetNBArticles().ToString();
                txtVente.Text = m_databaseInterface.GetTotalVente().ToString();
                txtBenef.Text = m_databaseInterface.GetBenefVente().ToString();
                txtTotalDroitEntree.Text = m_databaseInterface.GetDroitEntree().ToString();
                txtBenefTotal.Text = m_databaseInterface.getBenefTotal().ToString();

            }
            else if(tabControlVelo.SelectedTab == PageVentes)
            {
                InitArticleList();
            }
        }

        private void btnNewDepot_Click(object sender, EventArgs e)
        {
            if (m_articleList.Count >= 5)
            {
                MessageBox.Show("Le nombre d'article par déposant est de 5 maximum. Il faut créer un nouveau déposant!");
            }
            else
            {
                AddArticle NewArticleForm = new AddArticle(null);
                if (NewArticleForm.ShowDialog() == DialogResult.OK)
                {
                    NewArticleForm.CurrentArticle.DeposantId = currentDeposant.Id;
                    var articleId = m_databaseInterface.InsertArticle(NewArticleForm.CurrentArticle);
                    string articleCode = currentDeposant.Id + "-" + articleId;
                    m_databaseInterface.UpdateArticleCode(articleCode, articleId);
                    InitArticleDataGrid();

                }
            }
            
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            AddDeposant newdepForm = new AddDeposant(currentDeposant);
            if (newdepForm.ShowDialog() == DialogResult.OK)
            {
                m_databaseInterface.UpdateDeposant(currentDeposant.Id, newdepForm.currentDeposant.Nom, newdepForm.currentDeposant.Prenom, newdepForm.currentDeposant.telephone);
                InitDeposantList();
                SelectCbIndexByName(newdepForm.currentDeposant.Nom);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            m_databaseInterface.DeleteDeposant(currentDeposant.Id);
            InitDeposantList();
        }

        private void btnModifyDepot_Click(object sender, EventArgs e)
        {
            if (dgArticle.CurrentRow != null && dgArticle.CurrentRow.DataBoundItem != null)
            {
                AddArticle NewArticleForm = new AddArticle((Article)dgArticle.CurrentRow.DataBoundItem);
                if (NewArticleForm.ShowDialog() == DialogResult.OK)
                {
                    m_databaseInterface.UpdateArticle(NewArticleForm.CurrentArticle);
                    InitArticleDataGrid();

                }
            }
        }

        private void btnDelDepot_Click(object sender, EventArgs e)
        {
            if (dgArticle.CurrentRow != null && dgArticle.CurrentRow.DataBoundItem != null)
            {
                m_databaseInterface.DeleteArticle(((Article)dgArticle.CurrentRow.DataBoundItem).Id);
                InitArticleDataGrid();
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            PrintList();
        }

        private void PrintList()
        {
            // Get the Word application object.
            Word._Application word_app = new Word.Application();

            // Make Word visible (optional).
            word_app.Visible = true;

            // Create the Word document.
            object missing = Type.Missing;
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            // Create a header paragraph.
            Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
            para.Range.Text = "Information concernant le déposant";
            object style_name = "Heading 1";
             para.Range.InsertParagraphAfter();

            // Add more text.
            para.Range.Text = "Nom: " + currentDeposant.Nom ;
            para.Range.Text += "Prénom: " + currentDeposant.Prenom;
            para.Range.Text += "Téléphone: " + currentDeposant.telephone;
            para.Range.InsertParagraphAfter();

            Word.Paragraph para1 = word_doc.Paragraphs.Add(ref missing);
            para1.Range.Text = "Liste d'article";
            para1.Range.InsertParagraphAfter();

            // Add more text.
            foreach (Article curArticle in m_articleList)
            {
                para1.Range.Text = "Code de l'article: " + curArticle.Code;
                para1.Range.Text += "Type: " + curArticle.Type.ToString();
                para1.Range.Text += "Commentaire: " + curArticle.Commentaire;
                para1.Range.Text += "Prix demandé: " + curArticle.PrixDemande;
                para1.Range.Text += "Prix soldé: " + curArticle.PrixMini;
                para1.Range.Text += "******************************************************\r\n";
            }

           para1.Range.InsertParagraphAfter();

         
        }

        private void btnPrintArticle_Click(object sender, EventArgs e)
        {
            PrintArticle();
        }

        private void PrintArticle()
        {
            // Get the Word application object.
            Word._Application word_app = new Word.Application();

            // Make Word visible (optional).
            word_app.Visible = true;

            // Create the Word document.
            object missing = Type.Missing;
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            // Create a header paragraph.
            Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
           
            object style_name = "Title";
          //  para.Range.set_Style(ref style_name);
            para.Range.InsertParagraphAfter();

          
            para.Range.InsertParagraphAfter();

          
            para.Range.InsertParagraphAfter();

            // Add more text.
            foreach (Article curArticle in m_articleList)
            {
                para.Range.Font.Size = 20;
                para.Range.Font.Bold = 1;
                // para.Range.set_Style(ref style_name);
                para.Range.Text = "Code de l'article: " + curArticle.Code;
                para.Range.Text += "Type: " + curArticle.Type.ToString();
                para.Range.Text += "Genre:" + curArticle.Genre.ToString();
                para.Range.Text += "Nombre vitesses:" + curArticle.Vitesse.ToString();
                para.Range.Text += "Dimension roue:" + curArticle.DimensionRoue.ToString();
                para.Range.Text += "Commentaire: " + curArticle.Commentaire;
                para.Range.Text += "Prix: " + curArticle.PrixDemande;
                para.Range.Text += "";
                para.Range.InsertBreak();
             
            }
          
            para.Range.InsertParagraphAfter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDeposantList();
        }

        private void PrintDeposantList()
        {
            var deposantList = m_databaseInterface.GetDeposantList();

            // Get the Word application object.
            Word._Application word_app = new Word.Application();

            // Make Word visible (optional).
            word_app.Visible = true;

            // Create the Word document.
            object missing = Type.Missing;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            // Create a header paragraph.
            Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
            object style_name = "Title";
          //  para.Range.set_Style(ref style_name);
            para.Range.InsertParagraphAfter();
            para.Range.Text = "Liste des déposants";

            //Insert a 3 x 5 table, fill it with data, and make the first row
            //bold and italic.
            Word.Table oTable;
            Word.Range wrdRng = word_doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = word_doc.Tables.Add(wrdRng, deposantList.Count+1, 2, ref missing, ref missing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            int r;
            string strText;
            //oTable.Cell(0, 0).Range.Text = "Nom";
            //oTable.Cell(0, 1).Range.Text = "Signature";
            for (r = 0; r < deposantList.Count; r++)
            {
                strText = deposantList[r].Nom;
                oTable.Cell(r+1, 0).Range.Text = strText;
            }
         
            oTable.Columns[1].Width = 200;
            oTable.Borders.Enable = 1;


        }

        private void cbCodeArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedArticle = (Article)cbCodeArticle.SelectedItem;
            nbPrixMiniArticle.Value = (decimal)selectedArticle.PrixMini;
            nbPrixVenteArticle.Value = (decimal)selectedArticle.PrixDemande;
            nbPrixVendu.Value = (decimal)selectedArticle.PrixVente;
        }

        private void BtnOKVente_Click(object sender, EventArgs e)
        {
            var selectedArticle = (Article)cbCodeArticle.SelectedItem;
           if(m_databaseInterface.UpdatePrixVenteArticle(selectedArticle.Id, (float)nbPrixVendu.Value) ==1)
            {
                MessageBox.Show("le prix de vente de l'article " + selectedArticle.Code + " est de " + nbPrixVendu.Value + " euros");
            }
            else 
            {
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement du prix de vente de l'article " + selectedArticle.Code);
            }
        }

        private void btnArticleSolde_Click(object sender, EventArgs e)
        {
            PrintSoldArticle();
        }

        private void PrintSoldArticle()
        {
            List<Article> articleSolde = m_databaseInterface.GetDiscountArticleNotSold();
            // Get the Word application object.
            Word._Application word_app = new Word.Application();

            // Make Word visible (optional).
            word_app.Visible = true;

            // Create the Word document.
            object missing = Type.Missing;
          
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

            // Create a header paragraph.
            Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
            object style_name = "Title";
        //    para.Range.set_Style(ref style_name);
            para.Range.Text = "Articles Soldés";
            para.Range.InsertParagraphAfter();

            foreach (Article curArticle in articleSolde)
            {
                para.Range.Text = "Code de l'article: " + curArticle.Code;
                para.Range.Text += "Prix demandé: " + curArticle.PrixDemande;
                para.Range.Text += "Prix soldé: " + curArticle.PrixMini;
                para.Range.Text += "******************************************************\r\n";
            }
            foreach (Word.Section section in word_app.ActiveDocument.Sections)
            {
                Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            }
            para.Range.InsertParagraphAfter();

        }

        private void BtnEtiquetteClient_Click(object sender, EventArgs e)
        {
            PrintResult();
        }

        private void PrintResult()
        {

            var deposantList = m_databaseInterface.GetDeposantList();
            // Get the Word application object.
            Word._Application word_app = new Word.Application();

            // Make Word visible (optional).
            word_app.Visible = true;

            // Create the Word document.
            object missing = Type.Missing;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            Word._Document word_doc = word_app.Documents.Add(
                ref missing, ref missing, ref missing, ref missing);

             // Create a header paragraph.
        Word.Paragraph para = word_doc.Paragraphs.Add(ref missing);
            object style_name = "Title";
          //  para.Range.set_Style(ref style_name);
            para.Range.InsertParagraphAfter();
            Word.Range wrdRng = word_doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            Word.Table oTable = word_doc.Tables.Add(wrdRng, deposantList.Count+3/3, 2, ref missing, ref missing);
            oTable.Rows.AllowBreakAcrossPages = 0;
            //   oTable.Rows.Height = 340;
            oTable.Rows.Height = 227;
            oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            int k = 1;
            for (int i = 0; i < deposantList.Count + 3 / 3; i++)
            {
                if (i < oTable.Rows.Count && i<deposantList.Count)
                {
                    oTable.Cell(k, 1).Range.Text = BuildResultDeposantString
                    (m_databaseInterface.GetUnsoldedArticlesByDeposant(deposantList[i].Id),
                    m_databaseInterface.GetSaleArticlesByDeposant(deposantList[i].Id),
                    deposantList[i]) + "\r\n";
                }
                if (i + 1 < oTable.Rows.Count && i+1< deposantList.Count)
                {
                    oTable.Cell(k, 2).Range.Text = BuildResultDeposantString
                        (m_databaseInterface.GetUnsoldedArticlesByDeposant(deposantList[i + 1].Id),
                        m_databaseInterface.GetSaleArticlesByDeposant(deposantList[i + 1].Id),
                        deposantList[i + 1]) + "\r\n";
                    i = i + 1;
                }
                k++;
                
            }
        }

        private string BuildResultDeposantString(List<Article> unsoldedArticle, List<Article> saleArticle, Deposant deposant)
        {
            string result = "Nom du déposant: " + deposant.Nom + "\r\n";
            result += GetSumArticle(saleArticle, deposant);
            result += GetUnsoldedArticle(unsoldedArticle);
            return result;
        }

        private string GetSumArticle(List<Article> saleArticle, Deposant deposant)
        {
            string sumArticle = "Montant dû: ";
            float somme = 0;
            foreach(var article in saleArticle)
            {
                sumArticle += article.PrixRevientClient + "+";
                somme += article.PrixRevientClient;
            }
           string sumArticle1= sumArticle.Substring(0, sumArticle.Length - 1);
           somme = somme - (float)2.5;
           sumArticle1 = sumArticle1 + "-2.5";
           sumArticle1 = sumArticle1 + "=" + somme + "\r\n";
           return sumArticle1;
        }

        private string GetUnsoldedArticle(List<Article> unsaleArticle)
        {
            string invendus = "Invendus: \r\n";
            foreach (var article in unsaleArticle)
            {
                invendus += article.Code + "/" + article.Type.ToString() + "\r\n";
            }
            return invendus;
        }
    }
}
