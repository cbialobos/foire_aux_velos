namespace FoireVélo
{
    partial class AddDepot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.TxtRoue = new System.Windows.Forms.TextBox();
            this.CbGenre = new System.Windows.Forms.ComboBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.NumVitesse = new System.Windows.Forms.NumericUpDown();
            this.txtPrixDeposant = new System.Windows.Forms.TextBox();
            this.txtPrixMini = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumVitesse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dimension roue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Commentaires";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nb Vitesses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Couleur";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Prix demandé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prix mini";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(150, 10);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(120, 21);
            this.cbType.TabIndex = 1;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(150, 40);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(120, 20);
            this.txtCouleur.TabIndex = 3;
            // 
            // TxtRoue
            // 
            this.TxtRoue.Location = new System.Drawing.Point(150, 67);
            this.TxtRoue.Name = "TxtRoue";
            this.TxtRoue.Size = new System.Drawing.Size(49, 20);
            this.TxtRoue.TabIndex = 5;
            // 
            // CbGenre
            // 
            this.CbGenre.FormattingEnabled = true;
            this.CbGenre.Location = new System.Drawing.Point(150, 97);
            this.CbGenre.Name = "CbGenre";
            this.CbGenre.Size = new System.Drawing.Size(49, 21);
            this.CbGenre.TabIndex = 7;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(150, 160);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(281, 86);
            this.txtCommentaire.TabIndex = 11;
            // 
            // NumVitesse
            // 
            this.NumVitesse.Location = new System.Drawing.Point(150, 130);
            this.NumVitesse.Name = "NumVitesse";
            this.NumVitesse.Size = new System.Drawing.Size(49, 20);
            this.NumVitesse.TabIndex = 9;
            // 
            // txtPrixDeposant
            // 
            this.txtPrixDeposant.Location = new System.Drawing.Point(150, 252);
            this.txtPrixDeposant.Name = "txtPrixDeposant";
            this.txtPrixDeposant.Size = new System.Drawing.Size(120, 20);
            this.txtPrixDeposant.TabIndex = 13;
            // 
            // txtPrixMini
            // 
            this.txtPrixMini.Location = new System.Drawing.Point(150, 279);
            this.txtPrixMini.Name = "txtPrixMini";
            this.txtPrixMini.Size = new System.Drawing.Size(120, 20);
            this.txtPrixMini.TabIndex = 15;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 269);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(48, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // AddDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 331);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPrixMini);
            this.Controls.Add(this.txtPrixDeposant);
            this.Controls.Add(this.NumVitesse);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.CbGenre);
            this.Controls.Add(this.TxtRoue);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDepot";
            this.Text = "Ajouter un article";
            ((System.ComponentModel.ISupportInitialize)(this.NumVitesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox TxtRoue;
        private System.Windows.Forms.ComboBox CbGenre;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.NumericUpDown NumVitesse;
        private System.Windows.Forms.TextBox txtPrixDeposant;
        private System.Windows.Forms.TextBox txtPrixMini;
        private System.Windows.Forms.Button btnOK;
    }
}