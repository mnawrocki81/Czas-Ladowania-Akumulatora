namespace Akumulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.tbPrądładowania = new System.Windows.Forms.TextBox();
            this.tbPojemność = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Czas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(197, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź pojemność akumulatora (mAh)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wprowadź prąd ładowania ładowarki (mA)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tbPrądładowania
            // 
            this.tbPrądładowania.Location = new System.Drawing.Point(321, 67);
            this.tbPrądładowania.Name = "tbPrądładowania";
            this.tbPrądładowania.Size = new System.Drawing.Size(100, 20);
            this.tbPrądładowania.TabIndex = 4;
            this.tbPrądładowania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrądładowania.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPojemność
            // 
            this.tbPojemność.Location = new System.Drawing.Point(75, 67);
            this.tbPojemność.Name = "tbPojemność";
            this.tbPojemność.Size = new System.Drawing.Size(100, 20);
            this.tbPojemność.TabIndex = 5;
            this.tbPojemność.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPojemność.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(179, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Czas
            // 
            this.Czas.AutoSize = true;
            this.Czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Czas.Location = new System.Drawing.Point(92, 9);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(329, 16);
            this.Czas.TabIndex = 7;
            this.Czas.Text = "Czas ładowonia akumulatora przez ładowarkę";
            this.Czas.Click += new System.EventHandler(this.Czas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Czas ładowania";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbPojemność);
            this.Controls.Add(this.tbPrądładowania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Czas ładowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbPojemność;
        private System.Windows.Forms.TextBox tbPrądładowania;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

