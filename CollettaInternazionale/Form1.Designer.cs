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
            this.AggiuntaQuota = new System.Windows.Forms.Button();
            this.RimuoviQuota = new System.Windows.Forms.Button();
            this.ModificaQuota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.totaleQuota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 263);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // AggiuntaQuota
            // 
            this.AggiuntaQuota.Location = new System.Drawing.Point(27, 350);
            this.AggiuntaQuota.Name = "AggiuntaQuota";
            this.AggiuntaQuota.Size = new System.Drawing.Size(89, 23);
            this.AggiuntaQuota.TabIndex = 4;
            this.AggiuntaQuota.Text = "Aggiungi Quota";
            this.AggiuntaQuota.UseVisualStyleBackColor = true;
            // 
            // RimuoviQuota
            // 
            this.RimuoviQuota.Location = new System.Drawing.Point(218, 350);
            this.RimuoviQuota.Name = "RimuoviQuota";
            this.RimuoviQuota.Size = new System.Drawing.Size(86, 23);
            this.RimuoviQuota.TabIndex = 10;
            this.RimuoviQuota.Text = "Rimuovi Quota";
            this.RimuoviQuota.UseVisualStyleBackColor = true;
            // 
            // ModificaQuota
            // 
            this.ModificaQuota.Location = new System.Drawing.Point(399, 350);
            this.ModificaQuota.Name = "ModificaQuota";
            this.ModificaQuota.Size = new System.Drawing.Size(87, 23);
            this.ModificaQuota.TabIndex = 11;
            this.ModificaQuota.Text = "Modifica quota";
            this.ModificaQuota.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(528, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inserire il nome del partecipante";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(546, 111);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(168, 20);
            this.textBoxP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(522, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inserire la quota del partecipante";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(546, 238);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(168, 20);
            this.textBoxQ.TabIndex = 15;
            // 
            // totaleQuota
            // 
            this.totaleQuota.AutoSize = true;
            this.totaleQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.totaleQuota.Location = new System.Drawing.Point(593, 353);
            this.totaleQuota.Name = "totaleQuota";
            this.totaleQuota.Size = new System.Drawing.Size(69, 20);
            this.totaleQuota.TabIndex = 16;
            this.totaleQuota.Text = "Totale:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totaleQuota);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModificaQuota);
            this.Controls.Add(this.RimuoviQuota);
            this.Controls.Add(this.AggiuntaQuota);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button AggiuntaQuota;
        private System.Windows.Forms.Button RimuoviQuota;
        private System.Windows.Forms.Button ModificaQuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label totaleQuota;
    }
}

