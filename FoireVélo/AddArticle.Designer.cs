namespace FoireVélo
{
    partial class AddArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Roue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Vitesse = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbPrixVente = new System.Windows.Forms.NumericUpDown();
            this.nbPrixRevientClient = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnToPrixClient = new System.Windows.Forms.Button();
            this.btnToPrixVente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.BtnToPrixVenteSolde = new System.Windows.Forms.Button();
            this.BtnToPrixSoldeClient = new System.Windows.Forms.Button();
            this.nbPrixSoldeClient = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nbPrixMini = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Roue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixRevientClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixSoldeClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixMini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(129, 9);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taille roues";
            // 
            // Roue
            // 
            this.Roue.Location = new System.Drawing.Point(129, 39);
            this.Roue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Roue.Name = "Roue";
            this.Roue.Size = new System.Drawing.Size(55, 20);
            this.Roue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de vitesse";
            // 
            // Vitesse
            // 
            this.Vitesse.Location = new System.Drawing.Point(129, 69);
            this.Vitesse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Vitesse.Name = "Vitesse";
            this.Vitesse.Size = new System.Drawing.Size(55, 20);
            this.Vitesse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(129, 99);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Commentaire";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(129, 129);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(270, 90);
            this.txtCommentaire.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prix de vente";
            // 
            // nbPrixVente
            // 
            this.nbPrixVente.Location = new System.Drawing.Point(130, 259);
            this.nbPrixVente.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixVente.Name = "nbPrixVente";
            this.nbPrixVente.Size = new System.Drawing.Size(120, 20);
            this.nbPrixVente.TabIndex = 13;
            // 
            // nbPrixRevientClient
            // 
            this.nbPrixRevientClient.Location = new System.Drawing.Point(462, 259);
            this.nbPrixRevientClient.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixRevientClient.Name = "nbPrixRevientClient";
            this.nbPrixRevientClient.Size = new System.Drawing.Size(120, 20);
            this.nbPrixRevientClient.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Prix revient client";
            // 
            // btnToPrixClient
            // 
            this.btnToPrixClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPrixClient.Location = new System.Drawing.Point(281, 251);
            this.btnToPrixClient.Name = "btnToPrixClient";
            this.btnToPrixClient.Size = new System.Drawing.Size(40, 18);
            this.btnToPrixClient.TabIndex = 17;
            this.btnToPrixClient.Text = "->";
            this.btnToPrixClient.UseVisualStyleBackColor = true;
            this.btnToPrixClient.Click += new System.EventHandler(this.btnToPrixClient_Click);
            // 
            // btnToPrixVente
            // 
            this.btnToPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPrixVente.Location = new System.Drawing.Point(281, 273);
            this.btnToPrixVente.Name = "btnToPrixVente";
            this.btnToPrixVente.Size = new System.Drawing.Size(40, 18);
            this.btnToPrixVente.TabIndex = 18;
            this.btnToPrixVente.Text = "<-";
            this.btnToPrixVente.UseVisualStyleBackColor = true;
            this.btnToPrixVente.Click += new System.EventHandler(this.btnToPrixVente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Couleur";
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(129, 229);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(100, 20);
            this.txtCouleur.TabIndex = 11;
            // 
            // BtnToPrixVenteSolde
            // 
            this.BtnToPrixVenteSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToPrixVenteSolde.Location = new System.Drawing.Point(281, 333);
            this.BtnToPrixVenteSolde.Name = "BtnToPrixVenteSolde";
            this.BtnToPrixVenteSolde.Size = new System.Drawing.Size(40, 18);
            this.BtnToPrixVenteSolde.TabIndex = 20;
            this.BtnToPrixVenteSolde.Text = "<-";
            this.BtnToPrixVenteSolde.UseVisualStyleBackColor = true;
            this.BtnToPrixVenteSolde.Click += new System.EventHandler(this.BtnToPrixVenteSolde_Click);
            // 
            // BtnToPrixSoldeClient
            // 
            this.BtnToPrixSoldeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnToPrixSoldeClient.Location = new System.Drawing.Point(281, 311);
            this.BtnToPrixSoldeClient.Name = "BtnToPrixSoldeClient";
            this.BtnToPrixSoldeClient.Size = new System.Drawing.Size(40, 18);
            this.BtnToPrixSoldeClient.TabIndex = 19;
            this.BtnToPrixSoldeClient.Text = "->";
            this.BtnToPrixSoldeClient.UseVisualStyleBackColor = true;
            this.BtnToPrixSoldeClient.Click += new System.EventHandler(this.BtnToPrixSoldeClient_Click);
            // 
            // nbPrixSoldeClient
            // 
            this.nbPrixSoldeClient.Location = new System.Drawing.Point(462, 319);
            this.nbPrixSoldeClient.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixSoldeClient.Name = "nbPrixSoldeClient";
            this.nbPrixSoldeClient.Size = new System.Drawing.Size(120, 20);
            this.nbPrixSoldeClient.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Prix revient client";
            // 
            // nbPrixMini
            // 
            this.nbPrixMini.Location = new System.Drawing.Point(129, 319);
            this.nbPrixMini.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbPrixMini.Name = "nbPrixMini";
            this.nbPrixMini.Size = new System.Drawing.Size(120, 20);
            this.nbPrixMini.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Prix soldé";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(264, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.BtnToPrixVenteSolde);
            this.Controls.Add(this.BtnToPrixSoldeClient);
            this.Controls.Add(this.nbPrixSoldeClient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nbPrixMini);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnToPrixVente);
            this.Controls.Add(this.btnToPrixClient);
            this.Controls.Add(this.nbPrixRevientClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nbPrixVente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vitesse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Roue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Name = "AddArticle";
            this.Text = "AddArticle";
            ((System.ComponentModel.ISupportInitialize)(this.Roue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixRevientClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixSoldeClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrixMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Roue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Vitesse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbPrixVente;
        private System.Windows.Forms.NumericUpDown nbPrixRevientClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnToPrixClient;
        private System.Windows.Forms.Button btnToPrixVente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Button BtnToPrixVenteSolde;
        private System.Windows.Forms.Button BtnToPrixSoldeClient;
        private System.Windows.Forms.NumericUpDown nbPrixSoldeClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nbPrixMini;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOK;
    }
}