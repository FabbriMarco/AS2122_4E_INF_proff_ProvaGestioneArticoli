﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        string descrizione;
        string unitaMisura;
        double prezzo;

        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        public string Descrizione { get; }
        public string UnitaMisura { get; }
        public double Prezzo { get; }
        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo
            descrizione = txtDescrizione.Text;
            unitaMisura = cmbUnitaMisura.Text;
            prezzo = Convert.ToDouble(txtPrezzo.Text);


            if (unitaMisura==" " || prezzo== Convert.ToDouble("") || descrizione ==" ")
            {
                MessageBox.Show("i valori devono essere varolizzati");
            }

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
