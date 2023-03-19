using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollettaInternazionale
{
    public partial class Form1 : Form
    {
        public CollettaP colletta;
        string[] intes = { "Key", "Partecipante", "Quota","Valuta" };
        Partecipante temp;
        Importo temp2;
        public Form1()
        {
            InitializeComponent();
            colletta = new CollettaP();
            for (int i = 0; i < intes.Length; i++)
            {
                listView1.Columns.Add(intes[i]);
            }
        }
        private void AggiuntaQuota_Click(object sender, EventArgs e)
        {
            string ris = "";
            temp = new Partecipante(textBoxP.Text);
            temp2 = new Importo(float.Parse(textBoxQ.Text), textBoxV.Text);
            if (textBoxP.Text != "" && textBoxQ.Text != "" && textBoxV.Text!="")
            {
                colletta.Aggiungi(temp,temp2);
                ris = temp.ToString() + temp2.ToString();
                ListViewItem riga = new ListViewItem(ris.Split(';'));
                listView1.Items.Add(riga);
                totaleQuota.Text = "Totale:" + colletta.QuotaTotale.ToString();
                textBoxP.Text = "";
                textBoxQ.Text = "";
                textBoxV.Text = "";
            }
            else
                throw new Exception("compilare tutte le textbox");
        }

        private void ModificaQuota_Click(object sender, EventArgs e)
        {
            int selezionato = 0;
            string key;
            temp = new Partecipante(textBoxP.Text);
            temp2 = new Importo(float.Parse(textBoxQ.Text), textBoxV.Text);
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            key = listView1.SelectedItems[0].SubItems[0].Text;
            if (textBoxP.Text != "" && textBoxQ.Text != "")
            {
                colletta.Modifica(colletta.RaccoltaP[key],temp,colletta.Raccolta[colletta.RaccoltaP[key]],temp2);
                listView1.SelectedItems[0].SubItems[1].Text = textBoxP.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBoxQ.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBoxV.Text;
                totaleQuota.Text = "Totale:" + colletta.QuotaTotale.ToString();
                textBoxP.Text = "";
                textBoxQ.Text = "";
                textBoxV.Text = "";
            }
            else
                throw new Exception("compilare tutte le textbox");
        }

        private void EliminaQuota_Click(object sender, EventArgs e)
        {
            int selezionato = 0;
            string key;
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            key = listView1.SelectedItems[0].Text;
            temp = colletta.RaccoltaP[key];
            colletta.Rimuovi(temp);
            listView1.Items.RemoveAt(selezionato);
            totaleQuota.Text = "Totale:" + colletta.QuotaTotale.ToString();
        }
    }
}
