﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_PiuForm
{
    public partial class frmMain : Form
    {
        List<Contatto> contatti;

        public frmMain()
        {
            InitializeComponent();
            contatti = new List<Contatto>();
        }

        private void btnInserimentoDati_Click(object sender, EventArgs e)
        {
            // istanziamo (creiamo) la pagina di dettaglio dei dati
            frmDati f = new frmDati(txtNome.Text);

            // visualizza in maniera "modale" il form
            f.ShowDialog();

            // è modale il form dati e quindi ritorna qui solo quando viene chiuso frmDati

            // passo il model del form di dettaglio sulla view del form principale

            if(f.Status == true)
            {
                Contatto c = new Contatto(txtNome.Text, lblIndirizzo.Text, lblTelefono.Text, lblCitta.Text);

                contatti.Add(c);
            }

            lblIndirizzo.Text = f.Indirizzo;
            lblTelefono.Text = f.Telefono;
            lblCitta.Text = f.Citta; 
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout(txtNome.Text);

            f.ShowDialog();


            if (Convert.ToInt32("0" + f.Piacevolezza) < 3)
            {
                lblGradimento.Text = "Non ti piace tanto...";
                lblGradimento.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblGradimento.Text = "Ottimo, sono contento !";
                lblGradimento.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnVisualizzaContatti_Click(object sender, EventArgs e)
        {
            lstVisualizza.Items.Clear();
            foreach(Contatto c in contatti)
            {
                lstVisualizza.Items.Add(c.Visualizzati());
            }
        }
    }
}
