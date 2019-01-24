namespace FoireVélo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlVelo = new System.Windows.Forms.TabControl();
            this.PageDepot = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.btnPrintArticle = new System.Windows.Forms.Button();
            this.btnDelDepot = new System.Windows.Forms.Button();
            this.btnModifyDepot = new System.Windows.Forms.Button();
            this.btnNewDepot = new System.Windows.Forms.Button();
            this.dgArticle = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPaied = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDeposant = new System.Windows.Forms.ComboBox();
            this.PageVentes = new System.Windows.Forms.TabPage();
            this.BtnOKVente = new System.Windows.Forms.Button();
            this.nbPrixVendu = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nbPrixMiniArticle = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nbPrixVenteArticle = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCodeArticle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbStat = new System.Windows.Forms.TabPage();
            this.btnArticleSolde = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBenefTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBenef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalDroitEntree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNbArticle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNbDeposant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEtiquetteClient = new System.Windows.Forms.Button();
            this.tabControlVelo.SuspendLayout();
            this.PageDepot.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArticle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PageVentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVendu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixMiniArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVenteArticle)).BeginInit();
            this.tbStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVelo
            // 
            this.tabControlVelo.Controls.Add(this.PageDepot);
            this.tabControlVelo.Controls.Add(this.PageVentes);
            this.tabControlVelo.Controls.Add(this.tbStat);
            this.tabControlVelo.Location = new System.Drawing.Point(0, 1);
            this.tabControlVelo.Name = "tabControlVelo";
            this.tabControlVelo.SelectedIndex = 0;
            this.tabControlVelo.Size = new System.Drawing.Size(689, 487);
            this.tabControlVelo.TabIndex = 0;
            this.tabControlVelo.SelectedIndexChanged += new System.EventHandler(this.tabControlVelo_SelectedIndexChanged);
            // 
            // PageDepot
            // 
            this.PageDepot.Controls.Add(this.groupBox3);
            this.PageDepot.Controls.Add(this.groupBox2);
            this.PageDepot.Controls.Add(this.groupBox1);
            this.PageDepot.Location = new System.Drawing.Point(4, 22);
            this.PageDepot.Name = "PageDepot";
            this.PageDepot.Padding = new System.Windows.Forms.Padding(3);
            this.PageDepot.Size = new System.Drawing.Size(681, 461);
            this.PageDepot.TabIndex = 0;
            this.PageDepot.Text = "Dépots";
            this.PageDepot.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrintList);
            this.groupBox3.Controls.Add(this.btnPrintArticle);
            this.groupBox3.Controls.Add(this.btnDelDepot);
            this.groupBox3.Controls.Add(this.btnModifyDepot);
            this.groupBox3.Controls.Add(this.btnNewDepot);
            this.groupBox3.Controls.Add(this.dgArticle);
            this.groupBox3.Location = new System.Drawing.Point(15, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 263);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articles déposés";
            // 
            // btnPrintList
            // 
            this.btnPrintList.Location = new System.Drawing.Point(543, 19);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(75, 23);
            this.btnPrintList.TabIndex = 18;
            this.btnPrintList.Text = "Imprimer liste";
            this.btnPrintList.UseVisualStyleBackColor = true;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnPrintArticle
            // 
            this.btnPrintArticle.Location = new System.Drawing.Point(398, 19);
            this.btnPrintArticle.Name = "btnPrintArticle";
            this.btnPrintArticle.Size = new System.Drawing.Size(138, 23);
            this.btnPrintArticle.TabIndex = 17;
            this.btnPrintArticle.Text = "Imprimer fiches articles";
            this.btnPrintArticle.UseVisualStyleBackColor = true;
            this.btnPrintArticle.Click += new System.EventHandler(this.btnPrintArticle_Click);
            // 
            // btnDelDepot
            // 
            this.btnDelDepot.Location = new System.Drawing.Point(159, 19);
            this.btnDelDepot.Name = "btnDelDepot";
            this.btnDelDepot.Size = new System.Drawing.Size(62, 23);
            this.btnDelDepot.TabIndex = 16;
            this.btnDelDepot.Text = "Supprimer";
            this.btnDelDepot.UseVisualStyleBackColor = true;
            this.btnDelDepot.Click += new System.EventHandler(this.btnDelDepot_Click);
            // 
            // btnModifyDepot
            // 
            this.btnModifyDepot.Location = new System.Drawing.Point(94, 19);
            this.btnModifyDepot.Name = "btnModifyDepot";
            this.btnModifyDepot.Size = new System.Drawing.Size(59, 23);
            this.btnModifyDepot.TabIndex = 15;
            this.btnModifyDepot.Text = "Modifier";
            this.btnModifyDepot.UseVisualStyleBackColor = true;
            this.btnModifyDepot.Click += new System.EventHandler(this.btnModifyDepot_Click);
            // 
            // btnNewDepot
            // 
            this.btnNewDepot.Location = new System.Drawing.Point(13, 19);
            this.btnNewDepot.Name = "btnNewDepot";
            this.btnNewDepot.Size = new System.Drawing.Size(75, 23);
            this.btnNewDepot.TabIndex = 14;
            this.btnNewDepot.Text = "Nouveau";
            this.btnNewDepot.UseVisualStyleBackColor = true;
            this.btnNewDepot.Click += new System.EventHandler(this.btnNewDepot_Click);
            // 
            // dgArticle
            // 
            this.dgArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArticle.Location = new System.Drawing.Point(13, 46);
            this.dgArticle.Name = "dgArticle";
            this.dgArticle.Size = new System.Drawing.Size(609, 207);
            this.dgArticle.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPaied);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(11, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 91);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations du déposant";
            // 
            // cbPaied
            // 
            this.cbPaied.AutoSize = true;
            this.cbPaied.Location = new System.Drawing.Point(237, 51);
            this.cbPaied.Name = "cbPaied";
            this.cbPaied.Size = new System.Drawing.Size(109, 17);
            this.cbPaied.TabIndex = 8;
            this.cbPaied.Text = "Droit d\'entré payé";
            this.cbPaied.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(83, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Téléphone:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(301, 16);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnModify);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDeposant);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisir ou définir un déposant";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(348, 14);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(62, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(283, 14);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(59, 23);
            this.BtnModify.TabIndex = 9;
            this.BtnModify.Text = "Modifier";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(218, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Déposant";
            // 
            // cbDeposant
            // 
            this.cbDeposant.FormattingEnabled = true;
            this.cbDeposant.Location = new System.Drawing.Point(81, 14);
            this.cbDeposant.Name = "cbDeposant";
            this.cbDeposant.Size = new System.Drawing.Size(121, 21);
            this.cbDeposant.TabIndex = 0;
            this.cbDeposant.SelectedIndexChanged += new System.EventHandler(this.cbDeposant_SelectedIndexChanged);
            // 
            // PageVentes
            // 
            this.PageVentes.Controls.Add(this.BtnOKVente);
            this.PageVentes.Controls.Add(this.nbPrixVendu);
            this.PageVentes.Controls.Add(this.label14);
            this.PageVentes.Controls.Add(this.nbPrixMiniArticle);
            this.PageVentes.Controls.Add(this.label12);
            this.PageVentes.Controls.Add(this.nbPrixVenteArticle);
            this.PageVentes.Controls.Add(this.label13);
            this.PageVentes.Controls.Add(this.cbCodeArticle);
            this.PageVentes.Controls.Add(this.label11);
            this.PageVentes.Location = new System.Drawing.Point(4, 22);
            this.PageVentes.Name = "PageVentes";
            this.PageVentes.Padding = new System.Windows.Forms.Padding(3);
            this.PageVentes.Size = new System.Drawing.Size(681, 461);
            this.PageVentes.TabIndex = 1;
            this.PageVentes.Text = "Ventes";
            this.PageVentes.UseVisualStyleBackColor = true;
            // 
            // BtnOKVente
            // 
            this.BtnOKVente.Location = new System.Drawing.Point(169, 278);
            this.BtnOKVente.Name = "BtnOKVente";
            this.BtnOKVente.Size = new System.Drawing.Size(75, 23);
            this.BtnOKVente.TabIndex = 26;
            this.BtnOKVente.Text = "OK";
            this.BtnOKVente.UseVisualStyleBackColor = true;
            this.BtnOKVente.Click += new System.EventHandler(this.BtnOKVente_Click);
            // 
            // nbPrixVendu
            // 
            this.nbPrixVendu.Location = new System.Drawing.Point(129, 196);
            this.nbPrixVendu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixVendu.Name = "nbPrixVendu";
            this.nbPrixVendu.Size = new System.Drawing.Size(120, 20);
            this.nbPrixVendu.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Prix de vente final";
            // 
            // nbPrixMiniArticle
            // 
            this.nbPrixMiniArticle.Location = new System.Drawing.Point(128, 139);
            this.nbPrixMiniArticle.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixMiniArticle.Name = "nbPrixMiniArticle";
            this.nbPrixMiniArticle.ReadOnly = true;
            this.nbPrixMiniArticle.Size = new System.Drawing.Size(120, 20);
            this.nbPrixMiniArticle.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Prix soldé";
            // 
            // nbPrixVenteArticle
            // 
            this.nbPrixVenteArticle.Location = new System.Drawing.Point(129, 79);
            this.nbPrixVenteArticle.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixVenteArticle.Name = "nbPrixVenteArticle";
            this.nbPrixVenteArticle.ReadOnly = true;
            this.nbPrixVenteArticle.Size = new System.Drawing.Size(120, 20);
            this.nbPrixVenteArticle.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Prix de vente";
            // 
            // cbCodeArticle
            // 
            this.cbCodeArticle.FormattingEnabled = true;
            this.cbCodeArticle.Location = new System.Drawing.Point(128, 30);
            this.cbCodeArticle.Name = "cbCodeArticle";
            this.cbCodeArticle.Size = new System.Drawing.Size(121, 21);
            this.cbCodeArticle.TabIndex = 1;
            this.cbCodeArticle.SelectedIndexChanged += new System.EventHandler(this.cbCodeArticle_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Code Article";
            // 
            // tbStat
            // 
            this.tbStat.Controls.Add(this.BtnEtiquetteClient);
            this.tbStat.Controls.Add(this.btnArticleSolde);
            this.tbStat.Controls.Add(this.button1);
            this.tbStat.Controls.Add(this.txtBenefTotal);
            this.tbStat.Controls.Add(this.label10);
            this.tbStat.Controls.Add(this.txtBenef);
            this.tbStat.Controls.Add(this.label9);
            this.tbStat.Controls.Add(this.txtVente);
            this.tbStat.Controls.Add(this.label8);
            this.tbStat.Controls.Add(this.txtTotalDroitEntree);
            this.tbStat.Controls.Add(this.label7);
            this.tbStat.Controls.Add(this.txtNbArticle);
            this.tbStat.Controls.Add(this.label6);
            this.tbStat.Controls.Add(this.txtNbDeposant);
            this.tbStat.Controls.Add(this.label5);
            this.tbStat.Location = new System.Drawing.Point(4, 22);
            this.tbStat.Name = "tbStat";
            this.tbStat.Size = new System.Drawing.Size(681, 461);
            this.tbStat.TabIndex = 2;
            this.tbStat.Text = "Statistiques";
            this.tbStat.UseVisualStyleBackColor = true;
            // 
            // btnArticleSolde
            // 
            this.btnArticleSolde.Location = new System.Drawing.Point(401, 70);
            this.btnArticleSolde.Name = "btnArticleSolde";
            this.btnArticleSolde.Size = new System.Drawing.Size(186, 23);
            this.btnArticleSolde.TabIndex = 13;
            this.btnArticleSolde.Text = "Impression articles soldés";
            this.btnArticleSolde.UseVisualStyleBackColor = true;
            this.btnArticleSolde.Click += new System.EventHandler(this.btnArticleSolde_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Imprimer la liste des déposants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBenefTotal
            // 
            this.txtBenefTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefTotal.Location = new System.Drawing.Point(201, 268);
            this.txtBenefTotal.Name = "txtBenefTotal";
            this.txtBenefTotal.ReadOnly = true;
            this.txtBenefTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBenefTotal.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bénéfice total";
            // 
            // txtBenef
            // 
            this.txtBenef.Location = new System.Drawing.Point(201, 216);
            this.txtBenef.Name = "txtBenef";
            this.txtBenef.ReadOnly = true;
            this.txtBenef.Size = new System.Drawing.Size(100, 20);
            this.txtBenef.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bénéfice vente ";
            // 
            // txtVente
            // 
            this.txtVente.Location = new System.Drawing.Point(201, 176);
            this.txtVente.Name = "txtVente";
            this.txtVente.ReadOnly = true;
            this.txtVente.Size = new System.Drawing.Size(100, 20);
            this.txtVente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total vente";
            // 
            // txtTotalDroitEntree
            // 
            this.txtTotalDroitEntree.Location = new System.Drawing.Point(200, 126);
            this.txtTotalDroitEntree.Name = "txtTotalDroitEntree";
            this.txtTotalDroitEntree.ReadOnly = true;
            this.txtTotalDroitEntree.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDroitEntree.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total droit entrée";
            // 
            // txtNbArticle
            // 
            this.txtNbArticle.Location = new System.Drawing.Point(200, 77);
            this.txtNbArticle.Name = "txtNbArticle";
            this.txtNbArticle.ReadOnly = true;
            this.txtNbArticle.Size = new System.Drawing.Size(100, 20);
            this.txtNbArticle.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre d\'articles";
            // 
            // txtNbDeposant
            // 
            this.txtNbDeposant.Location = new System.Drawing.Point(200, 30);
            this.txtNbDeposant.Name = "txtNbDeposant";
            this.txtNbDeposant.ReadOnly = true;
            this.txtNbDeposant.Size = new System.Drawing.Size(100, 20);
            this.txtNbDeposant.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre de déposants";
            // 
            // BtnEtiquetteClient
            // 
            this.BtnEtiquetteClient.Location = new System.Drawing.Point(401, 219);
            this.BtnEtiquetteClient.Name = "BtnEtiquetteClient";
            this.BtnEtiquetteClient.Size = new System.Drawing.Size(186, 23);
            this.BtnEtiquetteClient.TabIndex = 14;
            this.BtnEtiquetteClient.Text = "Imprimer solde du par client";
            this.BtnEtiquetteClient.UseVisualStyleBackColor = true;
            this.BtnEtiquetteClient.Click += new System.EventHandler(this.BtnEtiquetteClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 489);
            this.Controls.Add(this.tabControlVelo);
            this.Name = "Form1";
            this.Text = "Foire aux Vélos";
            this.tabControlVelo.ResumeLayout(false);
            this.PageDepot.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArticle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PageVentes.ResumeLayout(false);
            this.PageVentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVendu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixMiniArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVenteArticle)).EndInit();
            this.tbStat.ResumeLayout(false);
            this.tbStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVelo;
        private System.Windows.Forms.TabPage PageDepot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeposant;
        private System.Windows.Forms.TabPage PageVentes;
        private System.Windows.Forms.DataGridView dgArticle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelDepot;
        private System.Windows.Forms.Button btnModifyDepot;
        private System.Windows.Forms.Button btnNewDepot;
        private System.Windows.Forms.CheckBox cbPaied;
        private System.Windows.Forms.TabPage tbStat;
        private System.Windows.Forms.TextBox txtBenefTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBenef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalDroitEntree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNbArticle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNbDeposant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Button btnPrintArticle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCodeArticle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnOKVente;
        private System.Windows.Forms.NumericUpDown nbPrixVendu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nbPrixMiniArticle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nbPrixVenteArticle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnArticleSolde;
        private System.Windows.Forms.Button BtnEtiquetteClient;
    }
}

