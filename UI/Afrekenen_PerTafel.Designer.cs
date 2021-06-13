
namespace UI
{
    partial class Afrekenen_PerTafel
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
            this.pnl_AfrekenenPerTafel = new System.Windows.Forms.Panel();
            this.lbl_Opmerking = new System.Windows.Forms.Label();
            this.rtb_OpmerkingPlaatsen = new System.Windows.Forms.RichTextBox();
            this.lbl_BetaalMehode = new System.Windows.Forms.Label();
            this.cmbx_BetaalMethode = new System.Windows.Forms.ComboBox();
            this.nup_FooiBedragGeven = new System.Windows.Forms.NumericUpDown();
            this.lbl_FooiGeven = new System.Windows.Forms.Label();
            this.lst_BestellingPerTafel = new System.Windows.Forms.ListView();
            this.col_tafelID = new System.Windows.Forms.ColumnHeader();
            this.col_BestelD = new System.Windows.Forms.ColumnHeader();
            this.col_medewerkerID = new System.Windows.Forms.ColumnHeader();
            this.col_status = new System.Windows.Forms.ColumnHeader();
            this.col_subtotaal = new System.Windows.Forms.ColumnHeader();
            this.col_BTW = new System.Windows.Forms.ColumnHeader();
            this.lbl_GekozenTafel = new System.Windows.Forms.Label();
            this.lbl_AfrekenenTitle = new System.Windows.Forms.Label();
            this.pcbx_LogoChapooAfrekenenMain = new System.Windows.Forms.PictureBox();
            this.btn_AfrekenenConfirm = new System.Windows.Forms.Button();
            this.btn_MaakBon = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.pnl_AfrekenenPerTafel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_FooiBedragGeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AfrekenenPerTafel
            // 
            this.pnl_AfrekenenPerTafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_Opmerking);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.rtb_OpmerkingPlaatsen);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_BetaalMehode);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.cmbx_BetaalMethode);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.nup_FooiBedragGeven);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_FooiGeven);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lst_BestellingPerTafel);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_GekozenTafel);
            this.pnl_AfrekenenPerTafel.Controls.Add(this.lbl_AfrekenenTitle);
            this.pnl_AfrekenenPerTafel.Location = new System.Drawing.Point(0, 57);
            this.pnl_AfrekenenPerTafel.Name = "pnl_AfrekenenPerTafel";
            this.pnl_AfrekenenPerTafel.Size = new System.Drawing.Size(498, 465);
            this.pnl_AfrekenenPerTafel.TabIndex = 0;
            // 
            // lbl_Opmerking
            // 
            this.lbl_Opmerking.AutoSize = true;
            this.lbl_Opmerking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Opmerking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_Opmerking.Location = new System.Drawing.Point(205, 356);
            this.lbl_Opmerking.Name = "lbl_Opmerking";
            this.lbl_Opmerking.Size = new System.Drawing.Size(96, 21);
            this.lbl_Opmerking.TabIndex = 12;
            this.lbl_Opmerking.Text = "Opmerking";
            this.lbl_Opmerking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtb_OpmerkingPlaatsen
            // 
            this.rtb_OpmerkingPlaatsen.Location = new System.Drawing.Point(205, 380);
            this.rtb_OpmerkingPlaatsen.Name = "rtb_OpmerkingPlaatsen";
            this.rtb_OpmerkingPlaatsen.Size = new System.Drawing.Size(100, 68);
            this.rtb_OpmerkingPlaatsen.TabIndex = 11;
            this.rtb_OpmerkingPlaatsen.Text = "";
            // 
            // lbl_BetaalMehode
            // 
            this.lbl_BetaalMehode.AutoSize = true;
            this.lbl_BetaalMehode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BetaalMehode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_BetaalMehode.Location = new System.Drawing.Point(362, 358);
            this.lbl_BetaalMehode.Name = "lbl_BetaalMehode";
            this.lbl_BetaalMehode.Size = new System.Drawing.Size(127, 21);
            this.lbl_BetaalMehode.TabIndex = 10;
            this.lbl_BetaalMehode.Text = "Betaalmethode";
            // 
            // cmbx_BetaalMethode
            // 
            this.cmbx_BetaalMethode.AllowDrop = true;
            this.cmbx_BetaalMethode.FormattingEnabled = true;
            this.cmbx_BetaalMethode.Items.AddRange(new object[] {
            "PIN",
            "CreditCard",
            "Contant"});
            this.cmbx_BetaalMethode.Location = new System.Drawing.Point(362, 380);
            this.cmbx_BetaalMethode.MaxDropDownItems = 3;
            this.cmbx_BetaalMethode.Name = "cmbx_BetaalMethode";
            this.cmbx_BetaalMethode.Size = new System.Drawing.Size(121, 23);
            this.cmbx_BetaalMethode.TabIndex = 9;
            // 
            // nup_FooiBedragGeven
            // 
            this.nup_FooiBedragGeven.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nup_FooiBedragGeven.Location = new System.Drawing.Point(12, 380);
            this.nup_FooiBedragGeven.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nup_FooiBedragGeven.Name = "nup_FooiBedragGeven";
            this.nup_FooiBedragGeven.Size = new System.Drawing.Size(120, 23);
            this.nup_FooiBedragGeven.TabIndex = 8;
            // 
            // lbl_FooiGeven
            // 
            this.lbl_FooiGeven.AutoSize = true;
            this.lbl_FooiGeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_FooiGeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_FooiGeven.Location = new System.Drawing.Point(12, 358);
            this.lbl_FooiGeven.Name = "lbl_FooiGeven";
            this.lbl_FooiGeven.Size = new System.Drawing.Size(43, 21);
            this.lbl_FooiGeven.TabIndex = 7;
            this.lbl_FooiGeven.Text = "Fooi";
            // 
            // lst_BestellingPerTafel
            // 
            this.lst_BestellingPerTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tafelID,
            this.col_BestelD,
            this.col_medewerkerID,
            this.col_status,
            this.col_subtotaal,
            this.col_BTW});
            this.lst_BestellingPerTafel.FullRowSelect = true;
            this.lst_BestellingPerTafel.HideSelection = false;
            this.lst_BestellingPerTafel.Location = new System.Drawing.Point(12, 79);
            this.lst_BestellingPerTafel.Name = "lst_BestellingPerTafel";
            this.lst_BestellingPerTafel.Size = new System.Drawing.Size(471, 276);
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
            // col_subtotaal
            // 
            this.col_subtotaal.Text = "Subtotaal";
            this.col_subtotaal.Width = 65;
            // 
            // col_BTW
            // 
            this.col_BTW.Text = "BTW";
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
            // lbl_AfrekenenTitle
            // 
            this.lbl_AfrekenenTitle.AutoSize = true;
            this.lbl_AfrekenenTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AfrekenenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_AfrekenenTitle.Location = new System.Drawing.Point(183, 23);
            this.lbl_AfrekenenTitle.Name = "lbl_AfrekenenTitle";
            this.lbl_AfrekenenTitle.Size = new System.Drawing.Size(132, 32);
            this.lbl_AfrekenenTitle.TabIndex = 3;
            this.lbl_AfrekenenTitle.Text = "Afrekenen";
            // 
            // pcbx_LogoChapooAfrekenenMain
            // 
            this.pcbx_LogoChapooAfrekenenMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooAfrekenenMain.Location = new System.Drawing.Point(12, 2);
            this.pcbx_LogoChapooAfrekenenMain.Name = "pcbx_LogoChapooAfrekenenMain";
            this.pcbx_LogoChapooAfrekenenMain.Size = new System.Drawing.Size(83, 49);
            this.pcbx_LogoChapooAfrekenenMain.TabIndex = 4;
            this.pcbx_LogoChapooAfrekenenMain.TabStop = false;
            // 
            // btn_AfrekenenConfirm
            // 
            this.btn_AfrekenenConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_AfrekenenConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AfrekenenConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_AfrekenenConfirm.Location = new System.Drawing.Point(205, 522);
            this.btn_AfrekenenConfirm.Name = "btn_AfrekenenConfirm";
            this.btn_AfrekenenConfirm.Size = new System.Drawing.Size(88, 42);
            this.btn_AfrekenenConfirm.TabIndex = 5;
            this.btn_AfrekenenConfirm.Text = "Afrekenen";
            this.btn_AfrekenenConfirm.UseVisualStyleBackColor = false;
            this.btn_AfrekenenConfirm.Click += new System.EventHandler(this.btn_AfrekenenConfirm_Click);
            // 
            // btn_MaakBon
            // 
            this.btn_MaakBon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_MaakBon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MaakBon.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_MaakBon.Location = new System.Drawing.Point(342, 522);
            this.btn_MaakBon.Name = "btn_MaakBon";
            this.btn_MaakBon.Size = new System.Drawing.Size(88, 42);
            this.btn_MaakBon.TabIndex = 6;
            this.btn_MaakBon.Text = "Maak bon";
            this.btn_MaakBon.UseVisualStyleBackColor = false;
            this.btn_MaakBon.Click += new System.EventHandler(this.btn_MaakBon_Click);
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Annuleren.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Annuleren.Location = new System.Drawing.Point(71, 522);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(88, 42);
            this.btn_Annuleren.TabIndex = 7;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = false;
            this.btn_Annuleren.Click += new System.EventHandler(this.btn_Annuleren_Click);
            // 
            // Afrekenen_PerTafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_MaakBon);
            this.Controls.Add(this.btn_AfrekenenConfirm);
            this.Controls.Add(this.pcbx_LogoChapooAfrekenenMain);
            this.Controls.Add(this.pnl_AfrekenenPerTafel);
            this.Name = "Afrekenen_PerTafel";
            this.Text = "Afrekenen per tafel";
            this.Load += new System.EventHandler(this.Afrekenen_PerTafel_Load);
            this.pnl_AfrekenenPerTafel.ResumeLayout(false);
            this.pnl_AfrekenenPerTafel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_FooiBedragGeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AfrekenenPerTafel;
        private System.Windows.Forms.ListView lst_BestellingPerTafel;
        private System.Windows.Forms.ColumnHeader col_tafelID;
        private System.Windows.Forms.Label lbl_GekozenTafel;
        private System.Windows.Forms.Label lbl_AfrekenenTitle;
        private System.Windows.Forms.PictureBox pcbx_LogoChapooAfrekenenMain;
        private System.Windows.Forms.ColumnHeader col_BestelD;
        private System.Windows.Forms.ColumnHeader col_medewerkerID;
        private System.Windows.Forms.ColumnHeader col_status;
        private System.Windows.Forms.ColumnHeader col_subtotaal;
        private System.Windows.Forms.Button btn_AfrekenenConfirm;
        private System.Windows.Forms.Button btn_MaakBon;
        private System.Windows.Forms.ColumnHeader col_BTW;
        private System.Windows.Forms.Label lbl_FooiGeven;
        private System.Windows.Forms.NumericUpDown nup_FooiBedragGeven;
        private System.Windows.Forms.Label lbl_BetaalMehode;
        private System.Windows.Forms.ComboBox cmbx_BetaalMethode;
        private System.Windows.Forms.Button btn_Annuleren;
        private System.Windows.Forms.Label lbl_Opmerking;
        private System.Windows.Forms.RichTextBox rtb_OpmerkingPlaatsen;
    }
}