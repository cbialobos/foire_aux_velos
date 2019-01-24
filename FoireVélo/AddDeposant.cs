using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoireVélo
{
    public partial class AddDeposant : Form
    {
        public Deposant currentDeposant = null;
        public bool edit = false;
        
        public AddDeposant()
        {
            InitializeComponent();
            this.Text = "Créer un nouveau déposant";
        }
        
        public AddDeposant(Deposant deposant)
        {
            InitializeComponent();
            edit = true;
            this.Text = "Modifier les données du déposant";
            currentDeposant = deposant;
            if (currentDeposant != null)
            {
                txtNom.Text = currentDeposant.Nom;
                txtPrenom.Text = currentDeposant.Prenom;
                txtTelephone.Text = currentDeposant.telephone;
              
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentDeposant == null)
            {
                currentDeposant = new Deposant();
            }
            currentDeposant.Nom = txtNom.Text;
            currentDeposant.Prenom = txtPrenom.Text;
            currentDeposant.telephone = txtTelephone.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        
    }
}
