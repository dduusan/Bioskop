namespace MongoDB_Repository
{
    partial class EkranAdmina
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
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.btnObrisiFilm = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 214);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajFilm.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFilm.Location = new System.Drawing.Point(82, 286);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(97, 46);
            this.btnDodajFilm.TabIndex = 2;
            this.btnDodajFilm.Text = "Dodaj Film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.btnDodajFilm_Click);
            // 
            // btnObrisiFilm
            // 
            this.btnObrisiFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiFilm.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiFilm.Location = new System.Drawing.Point(253, 286);
            this.btnObrisiFilm.Name = "btnObrisiFilm";
            this.btnObrisiFilm.Size = new System.Drawing.Size(99, 46);
            this.btnObrisiFilm.TabIndex = 3;
            this.btnObrisiFilm.Text = "Brisi Film";
            this.btnObrisiFilm.UseVisualStyleBackColor = true;
            this.btnObrisiFilm.Click += new System.EventHandler(this.btnObrisiFilm_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmeni.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(412, 286);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(98, 46);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni Film";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(595, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Osvezi Stanje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EkranAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.PLATNO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisiFilm);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.listView1);
            this.Name = "EkranAdmina";
            this.Text = "EkranAdmina";
            this.Load += new System.EventHandler(this.EkranAdmina_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDodajFilm;
        private System.Windows.Forms.Button btnObrisiFilm;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button button1;
    }
}