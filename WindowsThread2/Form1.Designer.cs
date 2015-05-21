namespace WindowsThread2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAusgabe = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.labelZeit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonAusgabe
            // 
            this.buttonAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAusgabe.Location = new System.Drawing.Point(48, 42);
            this.buttonAusgabe.Name = "buttonAusgabe";
            this.buttonAusgabe.Size = new System.Drawing.Size(213, 37);
            this.buttonAusgabe.TabIndex = 0;
            this.buttonAusgabe.Text = "Ausgabe";
            this.buttonAusgabe.UseVisualStyleBackColor = true;
            this.buttonAusgabe.Click += new System.EventHandler(this.buttonAusgabe_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(50, 115);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(210, 251);
            this.listBoxAusgabe.TabIndex = 1;
            // 
            // labelZeit
            // 
            this.labelZeit.AutoSize = true;
            this.labelZeit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelZeit.Location = new System.Drawing.Point(308, 37);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(143, 33);
            this.labelZeit.TabIndex = 2;
            this.labelZeit.Text = "hh:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 527);
            this.Controls.Add(this.labelZeit);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonAusgabe);
            this.Name = "Form1";
            this.Text = "Thread Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAusgabe;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.Timer timer1;
    }
}

