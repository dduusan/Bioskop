namespace MongoDB_Repository
{
    partial class RezervisaneKarte
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
            this.btnRezervaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(669, 201);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnRezervaciju
            // 
            this.btnRezervaciju.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervaciju.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervaciju.Location = new System.Drawing.Point(315, 243);
            this.btnRezervaciju.Name = "btnRezervaciju";
            this.btnRezervaciju.Size = new System.Drawing.Size(165, 50);
            this.btnRezervaciju.TabIndex = 1;
            this.btnRezervaciju.Text = "Otkazi Rezervaciju";
            this.btnRezervaciju.UseVisualStyleBackColor = true;
            this.btnRezervaciju.Click += new System.EventHandler(this.btnRezervaciju_Click);
            // 
            // RezervisaneKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.karte;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.btnRezervaciju);
            this.Controls.Add(this.listView1);
            this.Name = "RezervisaneKarte";
            this.Text = "RezervisaneKarte";
            this.Load += new System.EventHandler(this.RezervisaneKarte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRezervaciju;
    }
}