
namespace Minu_kalkulaator
{
    partial class Calculator
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
            this.arv1_label = new System.Windows.Forms.Label();
            this.arv2_label = new System.Windows.Forms.Label();
            this.arv1 = new System.Windows.Forms.TextBox();
            this.arv2 = new System.Windows.Forms.TextBox();
            this.vastusele_viitaja = new System.Windows.Forms.Label();
            this.Jaga = new System.Windows.Forms.RadioButton();
            this.Lahuta = new System.Windows.Forms.RadioButton();
            this.Korruta = new System.Windows.Forms.RadioButton();
            this.Liida = new System.Windows.Forms.RadioButton();
            this.vastus = new System.Windows.Forms.Label();
            this.arvuta = new System.Windows.Forms.Button();
            this.Aritmeetilised_Operaatorid = new System.Windows.Forms.Panel();
            this.Aritmeetilised_Operaatorid.SuspendLayout();
            this.SuspendLayout();
            // 
            // arv1_label
            // 
            this.arv1_label.AutoSize = true;
            this.arv1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arv1_label.ForeColor = System.Drawing.Color.Black;
            this.arv1_label.Location = new System.Drawing.Point(27, 45);
            this.arv1_label.Name = "arv1_label";
            this.arv1_label.Size = new System.Drawing.Size(90, 18);
            this.arv1_label.TabIndex = 0;
            this.arv1_label.Text = "Esimene arv";
            // 
            // arv2_label
            // 
            this.arv2_label.AutoSize = true;
            this.arv2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arv2_label.ForeColor = System.Drawing.Color.Black;
            this.arv2_label.Location = new System.Drawing.Point(206, 45);
            this.arv2_label.Name = "arv2_label";
            this.arv2_label.Size = new System.Drawing.Size(68, 18);
            this.arv2_label.TabIndex = 1;
            this.arv2_label.Text = "Teine arv";
            // 
            // arv1
            // 
            this.arv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.arv1.Location = new System.Drawing.Point(30, 66);
            this.arv1.Name = "arv1";
            this.arv1.Size = new System.Drawing.Size(125, 23);
            this.arv1.TabIndex = 2;
            this.arv1.Tag = "";
            this.arv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arv1.TextChanged += new System.EventHandler(this.ControlPasting_Textbox);
            this.arv1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterKeyPress_Textbox);
            // 
            // arv2
            // 
            this.arv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.arv2.Location = new System.Drawing.Point(209, 66);
            this.arv2.Name = "arv2";
            this.arv2.Size = new System.Drawing.Size(125, 23);
            this.arv2.TabIndex = 3;
            this.arv2.Tag = "";
            this.arv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arv2.TextChanged += new System.EventHandler(this.ControlPasting_Textbox);
            this.arv2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterKeyPress_Textbox);
            // 
            // vastusele_viitaja
            // 
            this.vastusele_viitaja.AutoSize = true;
            this.vastusele_viitaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.vastusele_viitaja.ForeColor = System.Drawing.Color.Black;
            this.vastusele_viitaja.Location = new System.Drawing.Point(27, 126);
            this.vastusele_viitaja.Name = "vastusele_viitaja";
            this.vastusele_viitaja.Size = new System.Drawing.Size(53, 18);
            this.vastusele_viitaja.TabIndex = 4;
            this.vastusele_viitaja.Text = "Vastus";
            // 
            // Jaga
            // 
            this.Jaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Jaga.AutoSize = true;
            this.Jaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Jaga.Location = new System.Drawing.Point(179, 44);
            this.Jaga.Name = "Jaga";
            this.Jaga.Size = new System.Drawing.Size(57, 21);
            this.Jaga.TabIndex = 3;
            this.Jaga.TabStop = true;
            this.Jaga.Text = "Jaga";
            this.Jaga.UseVisualStyleBackColor = true;
            // 
            // Lahuta
            // 
            this.Lahuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lahuta.AutoSize = true;
            this.Lahuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lahuta.Location = new System.Drawing.Point(8, 44);
            this.Lahuta.Name = "Lahuta";
            this.Lahuta.Size = new System.Drawing.Size(70, 21);
            this.Lahuta.TabIndex = 1;
            this.Lahuta.TabStop = true;
            this.Lahuta.Text = "Lahuta";
            this.Lahuta.UseVisualStyleBackColor = true;
            // 
            // Korruta
            // 
            this.Korruta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Korruta.AutoSize = true;
            this.Korruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Korruta.Location = new System.Drawing.Point(179, 8);
            this.Korruta.Name = "Korruta";
            this.Korruta.Size = new System.Drawing.Size(73, 21);
            this.Korruta.TabIndex = 2;
            this.Korruta.TabStop = true;
            this.Korruta.Text = "Korruta";
            this.Korruta.UseVisualStyleBackColor = true;
            // 
            // Liida
            // 
            this.Liida.AutoSize = true;
            this.Liida.Checked = true;
            this.Liida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Liida.Location = new System.Drawing.Point(8, 8);
            this.Liida.Name = "Liida";
            this.Liida.Size = new System.Drawing.Size(56, 21);
            this.Liida.TabIndex = 0;
            this.Liida.TabStop = true;
            this.Liida.Text = "Liida";
            this.Liida.UseVisualStyleBackColor = true;
            // 
            // vastus
            // 
            this.vastus.AutoSize = true;
            this.vastus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vastus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vastus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vastus.Location = new System.Drawing.Point(86, 122);
            this.vastus.MinimumSize = new System.Drawing.Size(248, 30);
            this.vastus.Name = "vastus";
            this.vastus.Size = new System.Drawing.Size(257, 30);
            this.vastus.TabIndex = 6;
            this.vastus.Text = "Vajuta nuppu \"Arvuta\", et saada vastus";
            this.vastus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // arvuta
            // 
            this.arvuta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.arvuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.arvuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.arvuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arvuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arvuta.Location = new System.Drawing.Point(86, 272);
            this.arvuta.Name = "arvuta";
            this.arvuta.Size = new System.Drawing.Size(183, 36);
            this.arvuta.TabIndex = 8;
            this.arvuta.Text = "Arvuta";
            this.arvuta.UseVisualStyleBackColor = false;
            this.arvuta.Click += new System.EventHandler(this.Calculate);
            // 
            // Aritmeetilised_Operaatorid
            // 
            this.Aritmeetilised_Operaatorid.Controls.Add(this.Jaga);
            this.Aritmeetilised_Operaatorid.Controls.Add(this.Liida);
            this.Aritmeetilised_Operaatorid.Controls.Add(this.Korruta);
            this.Aritmeetilised_Operaatorid.Controls.Add(this.Lahuta);
            this.Aritmeetilised_Operaatorid.Location = new System.Drawing.Point(48, 176);
            this.Aritmeetilised_Operaatorid.Name = "Aritmeetilised_Operaatorid";
            this.Aritmeetilised_Operaatorid.Padding = new System.Windows.Forms.Padding(5);
            this.Aritmeetilised_Operaatorid.Size = new System.Drawing.Size(265, 75);
            this.Aritmeetilised_Operaatorid.TabIndex = 7;
            this.Aritmeetilised_Operaatorid.TabStop = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(364, 321);
            this.Controls.Add(this.Aritmeetilised_Operaatorid);
            this.Controls.Add(this.arvuta);
            this.Controls.Add(this.vastus);
            this.Controls.Add(this.vastusele_viitaja);
            this.Controls.Add(this.arv2);
            this.Controls.Add(this.arv1);
            this.Controls.Add(this.arv2_label);
            this.Controls.Add(this.arv1_label);
            this.MaximumSize = new System.Drawing.Size(1600, 360);
            this.MinimumSize = new System.Drawing.Size(380, 360);
            this.Name = "Calculator";
            this.Text = "Minu kalkulaator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Aritmeetilised_Operaatorid.ResumeLayout(false);
            this.Aritmeetilised_Operaatorid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arv1_label;
        private System.Windows.Forms.Label arv2_label;
        private System.Windows.Forms.TextBox arv1;
        private System.Windows.Forms.TextBox arv2;
        private System.Windows.Forms.Label vastusele_viitaja;
        private System.Windows.Forms.RadioButton Lahuta;
        private System.Windows.Forms.RadioButton Korruta;
        private System.Windows.Forms.RadioButton Liida;
        private System.Windows.Forms.RadioButton Jaga;
        private System.Windows.Forms.Label vastus;
        private System.Windows.Forms.Button arvuta;
        private System.Windows.Forms.Panel Aritmeetilised_Operaatorid;
    }
}

