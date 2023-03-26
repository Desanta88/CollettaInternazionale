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
        public Dictionary<Partecipante,Importo> colletta;
        string[] intes = { "Key", "Partecipante", "Quota","Valuta" };
        Partecipante temp;
        Importo temp2;
        public float QuotaTotale;
        public Form1()
        {
            InitializeComponent();
            colletta = new Dictionary<Partecipante, Importo>();
            QuotaTotale = 0;
            for (int i = 0; i < intes.Length; i++)
            {
                listView1.Columns.Add(intes[i]);
            }
        }
        private void AggiuntaQuota_Click(object sender, EventArgs e)
        {
            string ris = "";
            if (textBoxP.Text != "" && textBoxQ.Text != "" && textBoxV.Text!="")
            {
                temp = new Partecipante(textBoxP.Text);
                temp2 = new Importo(float.Parse(textBoxQ.Text), textBoxV.Text);
                colletta.Add(temp,temp2);
                QuotaTotale += colletta[temp].Soldi;
                ris = temp.ToString() + temp2.ToString();
                ListViewItem riga = new ListViewItem(ris.Split(';'));
                listView1.Items.Add(riga);
                totaleQuota.Text = "Totale:" + QuotaTotale.ToString();
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
            {
                selezionato = listView1.SelectedIndices[0];
            }
            key = listView1.SelectedItems[0].SubItems[0].Text;
            if (textBoxV.Text != "" && textBoxQ.Text != "")
            {
                foreach(KeyValuePair<Partecipante, Importo> kvp in colletta)
                {
                    if (kvp.Key.Id == int.Parse(key))
                    {
                        QuotaTotale -= colletta[kvp.Key].Soldi;
                        colletta[kvp.Key].Soldi = float.Parse(textBoxQ.Text);
                        QuotaTotale += colletta[kvp.Key].Soldi;
                        Reload();
                    }

                }
                totaleQuota.Text = "Totale:" + QuotaTotale.ToString();
                textBoxQ.Text = "";
                textBoxV.Text = "";
            }
            else
                throw new Exception("compilare tutte le textbox");
        }

        private void EliminaQuota_Click(object sender, EventArgs e)
        {
            Partecipante tmp;
            int selezionato = 0;
            string key,name;
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            key = listView1.SelectedItems[0].Text;
            name = listView1.SelectedItems[0].SubItems[1].Text;
            tmp = new Partecipante(name); 
            tmp.Id = int.Parse(key);
            QuotaTotale -= colletta[tmp].Soldi;
            colletta.Remove(tmp);
            listView1.Items.RemoveAt(selezionato);
            totaleQuota.Text = "Totale:" + QuotaTotale.ToString();
            foreach (KeyValuePair<Partecipante, Importo> kvp in colletta)
            {
                MessageBox.Show(kvp.Key.Nome);
            }
        }
        private void Reload()
        {
            listView1.Items.Clear();
            for (int a = 0; a < colletta.Count; a++)
            {
                string[] row = { colletta.ElementAt(a).Key.Id.ToString(), colletta.ElementAt(a).Key.Nome, colletta.ElementAt(a).Value.Soldi.ToString(), colletta.ElementAt(a).Value.Valuta };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }


        }

        private void ordinaCash_Click(object sender, EventArgs e)
        {
            //colletta.sortByCash();
            Reload();
        }

        private void OrdinaSoldi_Click(object sender, EventArgs e)
        {
            //colletta.sortByName();
            Reload();
        }
        private string TrovaP(float s,string v)
        {
            foreach (KeyValuePair<Partecipante, Importo> kvp in colletta)
            {
                if (colletta[kvp.Key].Valuta == v && colletta[kvp.Key].Soldi == s)
                {
                    return kvp.Key.Nome;
                }
            }
            return "Partecipante non trovato";
        }

        private void trovaPersona_Click(object sender, EventArgs e)
        {
            if (textBoxT.Text != "" && textBoxT2.Text!="")
            {
                MessageBox.Show(TrovaP(float.Parse(textBoxT.Text),textBoxT2.Text));
            }
        }
    }
}
