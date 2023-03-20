namespace CollettaInternazionale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.totaleQuota = new System.Windows.Forms.Label();
            this.AggiuntaQuota = new System.Windows.Forms.Button();
            this.ModificaQuota = new System.Windows.Forms.Button();
            this.EliminaQuota = new System.Windows.Forms.Button();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ordinaCash = new System.Windows.Forms.Button();
            this.OrdinaSoldi = new System.Windows.Forms.Button();
            this.trovaPersona = new System.Windows.Forms.Button();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 263);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(522, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inserire il nome del partecipante";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(542, 101);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(168, 20);
            this.textBoxP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(522, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inserire la quota del partecipante";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(542, 178);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(168, 20);
            this.textBoxQ.TabIndex = 15;
            // 
            // totaleQuota
            // 
            this.totaleQuota.AutoSize = true;
            this.totaleQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.totaleQuota.Location = new System.Drawing.Point(641, 353);
            this.totaleQuota.Name = "totaleQuota";
            this.totaleQuota.Size = new System.Drawing.Size(69, 20);
            this.totaleQuota.TabIndex = 16;
            this.totaleQuota.Text = "Totale:0";
            // 
            // AggiuntaQuota
            // 
            this.AggiuntaQuota.Location = new System.Drawing.Point(27, 350);
            this.AggiuntaQuota.Name = "AggiuntaQuota";
            this.AggiuntaQuota.Size = new System.Drawing.Size(101, 23);
            this.AggiuntaQuota.TabIndex = 17;
            this.AggiuntaQuota.Text = "Aggiungi quota";
            this.AggiuntaQuota.UseVisualStyleBackColor = true;
            this.AggiuntaQuota.Click += new System.EventHandler(this.AggiuntaQuota_Click);
            // 
            // ModificaQuota
            // 
            this.ModificaQuota.Location = new System.Drawing.Point(391, 350);
            this.ModificaQuota.Name = "ModificaQuota";
            this.ModificaQuota.Size = new System.Drawing.Size(95, 23);
            this.ModificaQuota.TabIndex = 18;
            this.ModificaQuota.Text = "Modifica quota";
            this.ModificaQuota.UseVisualStyleBackColor = true;
            this.ModificaQuota.Click += new System.EventHandler(this.ModificaQuota_Click);
            // 
            // EliminaQuota
            // 
            this.EliminaQuota.Location = new System.Drawing.Point(213, 350);
            this.EliminaQuota.Name = "EliminaQuota";
            this.EliminaQuota.Size = new System.Drawing.Size(98, 23);
            this.EliminaQuota.TabIndex = 19;
            this.EliminaQuota.Text = "Elimina quota";
            this.EliminaQuota.UseVisualStyleBackColor = true;
            this.EliminaQuota.Click += new System.EventHandler(this.EliminaQuota_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(574, 251);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 20);
            this.textBoxV.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(539, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Inserire la valuta dell\'importo";
            // 
            // ordinaCash
            // 
            this.ordinaCash.Location = new System.Drawing.Point(27, 390);
            this.ordinaCash.Name = "ordinaCash";
            this.ordinaCash.Size = new System.Drawing.Size(101, 23);
            this.ordinaCash.TabIndex = 23;
            this.ordinaCash.Text = "Ordina per soldi";
            this.ordinaCash.UseVisualStyleBackColor = true;
            this.ordinaCash.Click += new System.EventHandler(this.ordinaCash_Click);
            // 
            // OrdinaSoldi
            // 
            this.OrdinaSoldi.Location = new System.Drawing.Point(213, 390);
            this.OrdinaSoldi.Name = "OrdinaSoldi";
            this.OrdinaSoldi.Size = new System.Drawing.Size(98, 23);
            this.OrdinaSoldi.TabIndex = 24;
            this.OrdinaSoldi.Text = "Ordina per nome";
            this.OrdinaSoldi.UseVisualStyleBackColor = true;
            this.OrdinaSoldi.Click += new System.EventHandler(this.OrdinaSoldi_Click);
            // 
            // trovaPersona
            // 
            this.trovaPersona.Location = new System.Drawing.Point(391, 390);
            this.trovaPersona.Name = "trovaPersona";
            this.trovaPersona.Size = new System.Drawing.Size(95, 23);
            this.trovaPersona.TabIndex = 25;
            this.trovaPersona.Text = "Trova persona";
            this.trovaPersona.UseVisualStyleBackColor = true;
            this.trovaPersona.Click += new System.EventHandler(this.trovaPersona_Click);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(506, 393);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.trovaPersona);
            this.Controls.Add(this.OrdinaSoldi);
            this.Controls.Add(this.ordinaCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.EliminaQuota);
            this.Controls.Add(this.ModificaQuota);
            this.Controls.Add(this.AggiuntaQuota);
            this.Controls.Add(this.totaleQuota);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label totaleQuota;
        private System.Windows.Forms.Button AggiuntaQuota;
        private System.Windows.Forms.Button ModificaQuota;
        private System.Windows.Forms.Button EliminaQuota;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ordinaCash;
        private System.Windows.Forms.Button OrdinaSoldi;
        private System.Windows.Forms.Button trovaPersona;
        private System.Windows.Forms.TextBox textBoxT;
    }
}

