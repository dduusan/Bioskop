namespace MongoDB_Repository
{
    partial class Izmena
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
            this.txtNovoVreme = new System.Windows.Forms.TextBox();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovoIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNovoVreme
            // 
            this.txtNovoVreme.Location = new System.Drawing.Point(227, 52);
            this.txtNovoVreme.Name = "txtNovoVreme";
            this.txtNovoVreme.Size = new System.Drawing.Size(127, 22);
            this.txtNovoVreme.TabIndex = 0;
            // 
            // btnIzmena
            // 
            this.btnIzmena.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmena.Location = new System.Drawing.Point(133, 116);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(127, 45);
            this.btnIzmena.TabIndex = 1;
            this.btnIzmena.Text = "Izmeni Film";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vreme Odrzavanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv Filma";
            // 
            // txtNovoIme
            // 
            this.txtNovoIme.Location = new System.Drawing.Point(227, 12);
            this.txtNovoIme.Name = "txtNovoIme";
            this.txtNovoIme.Size = new System.Drawing.Size(127, 22);
            this.txtNovoIme.TabIndex = 5;
            // 
            // Izmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.DODAJFILM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 263);
            this.Controls.Add(this.txtNovoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.txtNovoVreme);
            this.Name = "Izmena";
            this.Text = "Izmena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovoVreme;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovoIme;
    }
}