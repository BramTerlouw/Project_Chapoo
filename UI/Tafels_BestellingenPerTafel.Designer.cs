
namespace UI
{
    partial class Tafels_BestellingenPerTafel
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
            this.pnl_AfrekenenPerTafel = new System.Windows.Forms.Panel();
            this.lst_BestellingPerTafel = new System.Windows.Forms.ListView();
            this.col_tafelID = new System.Windows.Forms.ColumnHeader();
            this.col_BestelD = new System.Windows.Forms.ColumnHeader();
            this.col_medewerkerID = new System.Windows.Forms.ColumnHeader();
            this.col_status = new System.Windows.Forms.ColumnHeader();
            this.col_datumtijd = new System.Windows.Forms.ColumnHeader();
            this.lbl_GekozenTafel = new System.Windows.Forms.Label();
            this.lbl_BestellingPerTafelTitle = new System.Windows.Forms.Label();
            this.btnTerugTafelsMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooTafelsMain)).BeginInit();
            this.pnl_AfrekenenPerTafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbx_LogoChapooTafelsMain
            // 
            this.pcbx_LogoChapooTafelsMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooTafelsMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooTafelsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooTafelsMain.Location = new System.Drawing.Point(12, 2);
            this.pcbx_LogoChapooTafelsMain.Name = "pcbx_LogoChapooTafelsMain";
            this.pcbx_LogoChapooTafelsMain.Size = new System.Drawing.Size(83, 49);
            this.pcbx_LogoChapooTafelsMain.TabIndex = 5;
            this.pcbx_LogoChapooTafelsMain.TabStop = false;
            // 
            // pnl_AfrekenenPerTafel
            // 
            this.pnl_AfrekenenPerTafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lst_BestellingPerTafel);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_GekozenTafel);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_BestellingPerTafelTitle);
            this.pnl_AfrekenenPerTafel.Location = new System.Drawing.Point(0, 57);
            this.pnl_AfrekenenPerTafel.Name = "pnl_AfrekenenPerTafel";
            this.pnl_AfrekenenPerTafel.Size = new System.Drawing.Size(498, 465);
            this.pnl_AfrekenenPerTafel.TabIndex = 6;
            // 
            // lst_BestellingPerTafel
            // 
            this.lst_BestellingPerTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tafelID,
            this.col_BestelD,
            this.col_medewerkerID,
            this.col_status,
            this.col_datumtijd});
            this.lst_BestellingPerTafel.FullRowSelect = true;
            this.lst_BestellingPerTafel.HideSelection = false;
            this.lst_BestellingPerTafel.Location = new System.Drawing.Point(84, 79);
            this.lst_BestellingPerTafel.Name = "lst_BestellingPerTafel";
            this.lst_BestellingPerTafel.Size = new System.Drawing.Size(356, 276);
            this.lst_BestellingPerTafel.TabIndex = 5;
            this.lst_BestellingPerTafel.UseCompatibleStateImageBehavior = false;
            this.lst_BestellingPerTafel.View = System.Windows.Forms.View.Details;
            // 
            // col_tafelID
            // 
            this.col_tafelID.Text = "Tafel_ID";
            // 
            // col_BestelD
            // 
            this.col_BestelD.Text = "Bestelling";
            this.col_BestelD.Width = 70;
            // 
            // col_medewerkerID
            // 
            this.col_medewerkerID.Text = "Medewerker";
            this.col_medewerkerID.Width = 80;
            // 
            // col_status
            // 
            this.col_status.Text = "Status";
            // 
            // col_datumtijd
            // 
            this.col_datumtijd.Text = "Datum";
            this.col_datumtijd.Width = 80;
            // 
            // lbl_GekozenTafel
            // 
            this.lbl_GekozenTafel.AutoSize = true;
            this.lbl_GekozenTafel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_GekozenTafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_GekozenTafel.Location = new System.Drawing.Point(205, 55);
            this.lbl_GekozenTafel.Name = "lbl_GekozenTafel";
            this.lbl_GekozenTafel.Size = new System.Drawing.Size(0, 21);
            this.lbl_GekozenTafel.TabIndex = 4;
            // 
            // lbl_BestellingPerTafelTitle
            // 
            this.lbl_BestellingPerTafelTitle.AutoSize = true;
            this.lbl_BestellingPerTafelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BestellingPerTafelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_BestellingPerTafelTitle.Location = new System.Drawing.Point(120, 23);
            this.lbl_BestellingPerTafelTitle.Name = "lbl_BestellingPerTafelTitle";
            this.lbl_BestellingPerTafelTitle.Size = new System.Drawing.Size(260, 32);
            this.lbl_BestellingPerTafelTitle.TabIndex = 3;
            this.lbl_BestellingPerTafelTitle.Text = "Bestellingen per Tafel";
            this.lbl_BestellingPerTafelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTerugTafelsMain
            // 
            this.btnTerugTafelsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnTerugTafelsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugTafelsMain.Location = new System.Drawing.Point(375, 10);
            this.btnTerugTafelsMain.Name = "btnTerugTafelsMain";
            this.btnTerugTafelsMain.Size = new System.Drawing.Size(108, 38);
            this.btnTerugTafelsMain.TabIndex = 7;
            this.btnTerugTafelsMain.Text = "Terug";
            this.btnTerugTafelsMain.UseVisualStyleBackColor = false;
            this.btnTerugTafelsMain.Click += new System.EventHandler(this.btnTerugTafelsMain_Click);
            // 
            // Tafels_BestellingenPerTafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.btnTerugTafelsMain);
            this.Controls.Add(this.pnl_AfrekenenPerTafel);
            this.Controls.Add(this.pcbx_LogoChapooTafelsMain);
            this.Name = "Tafels_BestellingenPerTafel";
            this.Text = "Tafels_BestellingenPerTafel";
            this.Load += new System.EventHandler(this.Tafels_BestellingenPerTafel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooTafelsMain)).EndInit();
            this.pnl_AfrekenenPerTafel.ResumeLayout(false);
            this.pnl_AfrekenenPerTafel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbx_LogoChapooTafelsMain;
        private System.Windows.Forms.Panel pnl_AfrekenenPerTafel;
        private System.Windows.Forms.ListView lst_BestellingPerTafel;
        private System.Windows.Forms.ColumnHeader col_tafelID;
        private System.Windows.Forms.ColumnHeader col_BestelD;
        private System.Windows.Forms.ColumnHeader col_medewerkerID;
        private System.Windows.Forms.ColumnHeader col_status;
        private System.Windows.Forms.Label lbl_GekozenTafel;
        private System.Windows.Forms.Label lbl_BestellingPerTafelTitle;
        private System.Windows.Forms.Button btnTerugTafelsMain;
        private System.Windows.Forms.ColumnHeader col_datumtijd;
    }
}