
namespace UI
{
    partial class Administratie_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoorraad = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMedewerkers = new System.Windows.Forms.Button();
            this.pnlHeaderMedewerkers = new System.Windows.Forms.Panel();
            this.btnBackAdministratie = new System.Windows.Forms.Button();
            this.pnlHeaderMedewerkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoorraad
            // 
            this.btnVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoorraad.Location = new System.Drawing.Point(273, 225);
            this.btnVoorraad.Name = "btnVoorraad";
            this.btnVoorraad.Size = new System.Drawing.Size(198, 77);
            this.btnVoorraad.TabIndex = 0;
            this.btnVoorraad.Text = "Voorraad";
            this.btnVoorraad.UseVisualStyleBackColor = false;
            this.btnVoorraad.Click += new System.EventHandler(this.btnVoorraad_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(541, 225);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(198, 77);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMedewerkers
            // 
            this.btnMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnMedewerkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedewerkers.Location = new System.Drawing.Point(408, 340);
            this.btnMedewerkers.Name = "btnMedewerkers";
            this.btnMedewerkers.Size = new System.Drawing.Size(198, 77);
            this.btnMedewerkers.TabIndex = 2;
            this.btnMedewerkers.Text = "Medewerkers";
            this.btnMedewerkers.UseVisualStyleBackColor = false;
            this.btnMedewerkers.Click += new System.EventHandler(this.btnMedewerkers_Click);
            // 
            // pnlHeaderMedewerkers
            // 
            this.pnlHeaderMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.pnlHeaderMedewerkers.Controls.Add(this.btnBackAdministratie);
            this.pnlHeaderMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMedewerkers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMedewerkers.Name = "pnlHeaderMedewerkers";
            this.pnlHeaderMedewerkers.Size = new System.Drawing.Size(1064, 100);
            this.pnlHeaderMedewerkers.TabIndex = 18;
            // 
            // btnBackAdministratie
            // 
            this.btnBackAdministratie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnBackAdministratie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAdministratie.Location = new System.Drawing.Point(931, 30);
            this.btnBackAdministratie.Name = "btnBackAdministratie";
            this.btnBackAdministratie.Size = new System.Drawing.Size(108, 38);
            this.btnBackAdministratie.TabIndex = 3;
            this.btnBackAdministratie.Text = "Terug";
            this.btnBackAdministratie.UseVisualStyleBackColor = false;
            this.btnBackAdministratie.Click += new System.EventHandler(this.btnLogOutAdministratie_Click);
            // 
            // Administratie_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.pnlHeaderMedewerkers);
            this.Controls.Add(this.btnMedewerkers);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnVoorraad);
            this.Name = "Administratie_Main";
            this.Text = "Form1";
            this.pnlHeaderMedewerkers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoorraad;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMedewerkers;
        private System.Windows.Forms.Panel pnlHeaderMedewerkers;
        private System.Windows.Forms.Button btnBackAdministratie;
    }
}

