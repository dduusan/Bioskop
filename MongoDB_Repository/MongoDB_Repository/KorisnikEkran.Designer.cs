namespace MongoDB_Repository
{
    partial class KorisnikEkran
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.btnVidiSve = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervisi.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(22, 367);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(103, 30);
            this.btnRezervisi.TabIndex = 1;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // btnVidiSve
            // 
            this.btnVidiSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVidiSve.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVidiSve.Location = new System.Drawing.Point(160, 367);
            this.btnVidiSve.Name = "btnVidiSve";
            this.btnVidiSve.Size = new System.Drawing.Size(126, 30);
            this.btnVidiSve.TabIndex = 2;
            this.btnVidiSve.Text = "Rezervacije";
            this.btnVidiSve.UseVisualStyleBackColor = true;
            this.btnVidiSve.Click += new System.EventHandler(this.btnVidiSve_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(733, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(184, 26);
            this.txtPretraga.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite Film za Pretragu";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackgroundImage = global::MongoDB_Repository.Properties.Resources.pretraga;
            this.btnPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.Location = new System.Drawing.Point(847, 64);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(70, 37);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(685, 107);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(270, 245);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Osvezi Tabelu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KorisnikEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.KorisnikPoz;
            this.ClientSize = new System.Drawing.Size(1006, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnVidiSve);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.listView1);
            this.Name = "KorisnikEkran";
            this.Text = "KorisnikEkran";
            this.Load += new System.EventHandler(this.KorisnikEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Button btnVidiSve;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
    }
}