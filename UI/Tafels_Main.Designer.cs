
namespace UI
{
    partial class Tafels_Main
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
            this.pcbx_LogoChapooTafelsMain = new System.Windows.Forms.PictureBox();
            this.pnl_Tafels = new System.Windows.Forms.Panel();
            this.lst_KiesTafel = new System.Windows.Forms.ListView();
            this.col_tafelID = new System.Windows.Forms.ColumnHeader();
            this.col_AantalStoelen = new System.Windows.Forms.ColumnHeader();
            this.col_Status = new System.Windows.Forms.ColumnHeader();
            this.lbl_KiesTafelSubTitle = new System.Windows.Forms.Label();
            this.lbl_TafelsTitle = new System.Windows.Forms.Label();
            this.btnTerugHoofdMenu = new System.Windows.Forms.Button();
            this.btn_StatusBezet = new System.Windows.Forms.Button();
            this.btn_StatusVrij = new System.Windows.Forms.Button();
            this.btn_BestellingPerTafel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooTafelsMain)).BeginInit();
            this.pnl_Tafels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbx_LogoChapooTafelsMain
            // 
            this.pcbx_LogoChapooTafelsMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooTafelsMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooTafelsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooTafelsMain.Location = new System.Drawing.Point(12, 2);
            this.pcbx_LogoChapooTafelsMain.Name = "pcbx_LogoChapooTafelsMain";
            this.pcbx_LogoChapooTafelsMain.Size = new System.Drawing.Size(100, 58);
            this.pcbx_LogoChapooTafelsMain.TabIndex = 4;
            this.pcbx_LogoChapooTafelsMain.TabStop = false;
            // 
            // pnl_Tafels
            // 
            this.pnl_Tafels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_Tafels.Controls.Add(this.lst_KiesTafel);
            this.pnl_Tafels.Controls.Add(this.lbl_KiesTafelSubTitle);
            this.pnl_Tafels.Controls.Add(this.lbl_TafelsTitle);
            this.pnl_Tafels.Location = new System.Drawing.Point(0, 57);
            this.pnl_Tafels.Name = "pnl_Tafels";
            this.pnl_Tafels.Size = new System.Drawing.Size(498, 465);
            this.pnl_Tafels.TabIndex = 5;
            // 
            // lst_KiesTafel
            // 
            this.lst_KiesTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tafelID,
            this.col_AantalStoelen,
            this.col_Status});
            this.lst_KiesTafel.FullRowSelect = true;
            this.lst_KiesTafel.HideSelection = false;
            this.lst_KiesTafel.Location = new System.Drawing.Point(157, 79);
            this.lst_KiesTafel.Name = "lst_KiesTafel";
            this.lst_KiesTafel.Size = new System.Drawing.Size(185, 362);
            this.lst_KiesTafel.TabIndex = 5;
            this.lst_KiesTafel.UseCompatibleStateImageBehavior = false;
            this.lst_KiesTafel.View = System.Windows.Forms.View.Details;
            // 
            // col_tafelID
            // 
            this.col_tafelID.Text = "Tafel_ID";
            // 
            // col_AantalStoelen
            // 
            this.col_AantalStoelen.Text = "Stoelen";
            // 
            // col_Status
            // 
            this.col_Status.Text = "Status";
            // 
            // lbl_KiesTafelSubTitle
            // 
            this.lbl_KiesTafelSubTitle.AutoSize = true;
            this.lbl_KiesTafelSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KiesTafelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_KiesTafelSubTitle.Location = new System.Drawing.Point(217, 55);
            this.lbl_KiesTafelSubTitle.Name = "lbl_KiesTafelSubTitle";
            this.lbl_KiesTafelSubTitle.Size = new System.Drawing.Size(80, 21);
            this.lbl_KiesTafelSubTitle.TabIndex = 4;
            this.lbl_KiesTafelSubTitle.Text = "Kies tafel";
            // 
            // lbl_TafelsTitle
            // 
            this.lbl_TafelsTitle.AutoSize = true;
            this.lbl_TafelsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TafelsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_TafelsTitle.Location = new System.Drawing.Point(169, 23);
            this.lbl_TafelsTitle.Name = "lbl_TafelsTitle";
            this.lbl_TafelsTitle.Size = new System.Drawing.Size(173, 32);
            this.lbl_TafelsTitle.TabIndex = 3;
            this.lbl_TafelsTitle.Text = "Tafeloverzicht";
            this.lbl_TafelsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTerugHoofdMenu
            // 
            this.btnTerugHoofdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnTerugHoofdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugHoofdMenu.Location = new System.Drawing.Point(375, 12);
            this.btnTerugHoofdMenu.Name = "btnTerugHoofdMenu";
            this.btnTerugHoofdMenu.Size = new System.Drawing.Size(108, 38);
            this.btnTerugHoofdMenu.TabIndex = 6;
            this.btnTerugHoofdMenu.Text = "Terug";
            this.btnTerugHoofdMenu.UseVisualStyleBackColor = false;
            this.btnTerugHoofdMenu.Click += new System.EventHandler(this.btnTerugHoofdMenu_Click);
            // 
            // btn_StatusBezet
            // 
            this.btn_StatusBezet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_StatusBezet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatusBezet.Location = new System.Drawing.Point(12, 528);
            this.btn_StatusBezet.Name = "btn_StatusBezet";
            this.btn_StatusBezet.Size = new System.Drawing.Size(108, 38);
            this.btn_StatusBezet.TabIndex = 7;
            this.btn_StatusBezet.Text = "Bezet";
            this.btn_StatusBezet.UseVisualStyleBackColor = false;
            this.btn_StatusBezet.Click += new System.EventHandler(this.btn_StatusBezet_Click);
            // 
            // btn_StatusVrij
            // 
            this.btn_StatusVrij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_StatusVrij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatusVrij.Location = new System.Drawing.Point(137, 528);
            this.btn_StatusVrij.Name = "btn_StatusVrij";
            this.btn_StatusVrij.Size = new System.Drawing.Size(108, 38);
            this.btn_StatusVrij.TabIndex = 8;
            this.btn_StatusVrij.Text = "Vrij";
            this.btn_StatusVrij.UseVisualStyleBackColor = false;
            this.btn_StatusVrij.Click += new System.EventHandler(this.btn_StatusVrij_Click);
            // 
            // btn_BestellingPerTafel
            // 
            this.btn_BestellingPerTafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_BestellingPerTafel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BestellingPerTafel.Location = new System.Drawing.Point(375, 528);
            this.btn_BestellingPerTafel.Name = "btn_BestellingPerTafel";
            this.btn_BestellingPerTafel.Size = new System.Drawing.Size(108, 38);
            this.btn_BestellingPerTafel.TabIndex = 9;
            this.btn_BestellingPerTafel.Text = "Bestellingen";
            this.btn_BestellingPerTafel.UseVisualStyleBackColor = false;
            this.btn_BestellingPerTafel.Click += new System.EventHandler(this.btn_BestellingPerTafel_Click);
            // 
            // Tafels_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.btn_BestellingPerTafel);
            this.Controls.Add(this.btn_StatusVrij);
            this.Controls.Add(this.btn_StatusBezet);
            this.Controls.Add(this.btnTerugHoofdMenu);
            this.Controls.Add(this.pnl_Tafels);
            this.Controls.Add(this.pcbx_LogoChapooTafelsMain);
            this.Name = "Tafels_Main";
            this.Text = "Tafels_Main";
            this.Load += new System.EventHandler(this.Tafels_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooTafelsMain)).EndInit();
            this.pnl_Tafels.ResumeLayout(false);
            this.pnl_Tafels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbx_LogoChapooTafelsMain;
        private System.Windows.Forms.Panel pnl_Tafels;
        private System.Windows.Forms.ListView lst_KiesTafel;
        private System.Windows.Forms.ColumnHeader col_tafelID;
        private System.Windows.Forms.ColumnHeader col_AantalStoelen;
        private System.Windows.Forms.ColumnHeader col_Status;
        private System.Windows.Forms.Label lbl_KiesTafelSubTitle;
        private System.Windows.Forms.Label lbl_TafelsTitle;
        private System.Windows.Forms.Button btnTerugHoofdMenu;
        private System.Windows.Forms.Button btn_StatusBezet;
        private System.Windows.Forms.Button btn_StatusVrij;
        private System.Windows.Forms.Button btn_BestellingPerTafel;
    }
}