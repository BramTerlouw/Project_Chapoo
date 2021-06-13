
namespace UI
{
    partial class HoofdMenu
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
            this.pnlHeaderHoofdmenu = new System.Windows.Forms.Panel();
            this.btnLogOutHoofdMenu = new System.Windows.Forms.Button();
            this.btnKeuken = new System.Windows.Forms.Button();
            this.btnBestellingOpnemen = new System.Windows.Forms.Button();
            this.btnAdministratie = new System.Windows.Forms.Button();
            this.btnBestellingAfrekenen = new System.Windows.Forms.Button();
            this.btnTafelOverzicht = new System.Windows.Forms.Button();
            this.pcbx_LogoChapooAfrekenenMain = new System.Windows.Forms.PictureBox();
            this.pnlHeaderHoofdmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderHoofdmenu
            // 
            this.pnlHeaderHoofdmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.pnlHeaderHoofdmenu.Controls.Add(this.pcbx_LogoChapooAfrekenenMain);
            this.pnlHeaderHoofdmenu.Controls.Add(this.btnLogOutHoofdMenu);
            this.pnlHeaderHoofdmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderHoofdmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderHoofdmenu.Name = "pnlHeaderHoofdmenu";
            this.pnlHeaderHoofdmenu.Size = new System.Drawing.Size(1064, 100);
            this.pnlHeaderHoofdmenu.TabIndex = 19;
            // 
            // btnLogOutHoofdMenu
            // 
            this.btnLogOutHoofdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnLogOutHoofdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHoofdMenu.Location = new System.Drawing.Point(931, 30);
            this.btnLogOutHoofdMenu.Name = "btnLogOutHoofdMenu";
            this.btnLogOutHoofdMenu.Size = new System.Drawing.Size(108, 38);
            this.btnLogOutHoofdMenu.TabIndex = 3;
            this.btnLogOutHoofdMenu.Text = "Log uit";
            this.btnLogOutHoofdMenu.UseVisualStyleBackColor = false;
            this.btnLogOutHoofdMenu.Click += new System.EventHandler(this.btnLogOutHoofdMenu_Click);
            // 
            // btnKeuken
            // 
            this.btnKeuken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnKeuken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeuken.Location = new System.Drawing.Point(194, 289);
            this.btnKeuken.Name = "btnKeuken";
            this.btnKeuken.Size = new System.Drawing.Size(198, 77);
            this.btnKeuken.TabIndex = 20;
            this.btnKeuken.Text = "Keuken/Bar";
            this.btnKeuken.UseVisualStyleBackColor = false;
            this.btnKeuken.Click += new System.EventHandler(this.btnKeuken_Click);
            // 
            // btnBestellingOpnemen
            // 
            this.btnBestellingOpnemen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnBestellingOpnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellingOpnemen.Location = new System.Drawing.Point(448, 221);
            this.btnBestellingOpnemen.Name = "btnBestellingOpnemen";
            this.btnBestellingOpnemen.Size = new System.Drawing.Size(198, 77);
            this.btnBestellingOpnemen.TabIndex = 21;
            this.btnBestellingOpnemen.Text = "Bestelling opnemen";
            this.btnBestellingOpnemen.UseVisualStyleBackColor = false;
            this.btnBestellingOpnemen.Click += new System.EventHandler(this.btnBestellingOpnemen_Click);
            // 
            // btnAdministratie
            // 
            this.btnAdministratie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnAdministratie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministratie.Location = new System.Drawing.Point(448, 351);
            this.btnAdministratie.Name = "btnAdministratie";
            this.btnAdministratie.Size = new System.Drawing.Size(198, 77);
            this.btnAdministratie.TabIndex = 23;
            this.btnAdministratie.Text = "Administratie";
            this.btnAdministratie.UseVisualStyleBackColor = false;
            this.btnAdministratie.Click += new System.EventHandler(this.btnAdministratie_Click);
            // 
            // btnBestellingAfrekenen
            // 
            this.btnBestellingAfrekenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnBestellingAfrekenen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellingAfrekenen.Location = new System.Drawing.Point(697, 221);
            this.btnBestellingAfrekenen.Name = "btnBestellingAfrekenen";
            this.btnBestellingAfrekenen.Size = new System.Drawing.Size(198, 77);
            this.btnBestellingAfrekenen.TabIndex = 24;
            this.btnBestellingAfrekenen.Text = "Bestelling afrekenen";
            this.btnBestellingAfrekenen.UseVisualStyleBackColor = false;
            this.btnBestellingAfrekenen.Click += new System.EventHandler(this.btnBestellingAfrekenen_Click);
            // 
            // btnTafelOverzicht
            // 
            this.btnTafelOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnTafelOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTafelOverzicht.Location = new System.Drawing.Point(697, 351);
            this.btnTafelOverzicht.Name = "btnTafelOverzicht";
            this.btnTafelOverzicht.Size = new System.Drawing.Size(198, 77);
            this.btnTafelOverzicht.TabIndex = 25;
            this.btnTafelOverzicht.Text = "Tafeloverzicht";
            this.btnTafelOverzicht.UseVisualStyleBackColor = false;
            this.btnTafelOverzicht.Click += new System.EventHandler(this.btnTafelOverzicht_Click);
            // 
            // pcbx_LogoChapooAfrekenenMain
            // 
            this.pcbx_LogoChapooAfrekenenMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooAfrekenenMain.Location = new System.Drawing.Point(16, 12);
            this.pcbx_LogoChapooAfrekenenMain.Name = "pcbx_LogoChapooAfrekenenMain";
            this.pcbx_LogoChapooAfrekenenMain.Size = new System.Drawing.Size(137, 73);
            this.pcbx_LogoChapooAfrekenenMain.TabIndex = 6;
            this.pcbx_LogoChapooAfrekenenMain.TabStop = false;
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.btnTafelOverzicht);
            this.Controls.Add(this.btnBestellingAfrekenen);
            this.Controls.Add(this.btnAdministratie);
            this.Controls.Add(this.btnBestellingOpnemen);
            this.Controls.Add(this.btnKeuken);
            this.Controls.Add(this.pnlHeaderHoofdmenu);
            this.Name = "HoofdMenu";
            this.Text = "HoofdMenu";
            this.pnlHeaderHoofdmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderHoofdmenu;
        private System.Windows.Forms.Button btnLogOutHoofdMenu;
        private System.Windows.Forms.Button btnKeuken;
        private System.Windows.Forms.Button btnBestellingOpnemen;
        private System.Windows.Forms.Button btnAdministratie;
        private System.Windows.Forms.Button btnBestellingAfrekenen;
        private System.Windows.Forms.Button btnTafelOverzicht;
        private System.Windows.Forms.PictureBox pcbx_LogoChapooAfrekenenMain;
    }
}