
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_BestellingPerTafel = new System.Windows.Forms.ListView();
            this.col_tafelID = new System.Windows.Forms.ColumnHeader();
            this.lbl_GekozenTafel = new System.Windows.Forms.Label();
            this.lbl_AfrekenenTitle = new System.Windows.Forms.Label();
            this.pcbx_LogoChapooAfrekenenMain = new System.Windows.Forms.PictureBox();
            this.col_BestelD = new System.Windows.Forms.ColumnHeader();
            this.col_medewerkerID = new System.Windows.Forms.ColumnHeader();
            this.col_status = new System.Windows.Forms.ColumnHeader();
            this.col_subtotaal = new System.Windows.Forms.ColumnHeader();
            this.btn_AfrekenenConfirm = new System.Windows.Forms.Button();
            this.btn_MaakBon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.lst_BestellingPerTafel);
            this.panel1.Controls.Add(this.lbl_GekozenTafel);
            this.panel1.Controls.Add(this.lbl_AfrekenenTitle);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 465);
            this.panel1.TabIndex = 0;
            // 
            // lst_BestellingPerTafel
            // 
            this.lst_BestellingPerTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tafelID,
            this.col_BestelD,
            this.col_medewerkerID,
            this.col_status,
            this.col_subtotaal});
            this.lst_BestellingPerTafel.FullRowSelect = true;
            this.lst_BestellingPerTafel.HideSelection = false;
            this.lst_BestellingPerTafel.Location = new System.Drawing.Point(12, 79);
            this.lst_BestellingPerTafel.Name = "lst_BestellingPerTafel";
            this.lst_BestellingPerTafel.Size = new System.Drawing.Size(471, 362);
            this.lst_BestellingPerTafel.TabIndex = 5;
            this.lst_BestellingPerTafel.UseCompatibleStateImageBehavior = false;
            this.lst_BestellingPerTafel.View = System.Windows.Forms.View.Details;
            // 
            // col_tafelID
            // 
            this.col_tafelID.Text = "Tafel_ID";
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
            this.pcbx_LogoChapooAfrekenenMain.Size = new System.Drawing.Size(100, 58);
            this.pcbx_LogoChapooAfrekenenMain.TabIndex = 4;
            this.pcbx_LogoChapooAfrekenenMain.TabStop = false;
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
            // btn_AfrekenenConfirm
            // 
            this.btn_AfrekenenConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_AfrekenenConfirm.Location = new System.Drawing.Point(117, 522);
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
            this.btn_MaakBon.Location = new System.Drawing.Point(299, 522);
            this.btn_MaakBon.Name = "btn_MaakBon";
            this.btn_MaakBon.Size = new System.Drawing.Size(88, 42);
            this.btn_MaakBon.TabIndex = 6;
            this.btn_MaakBon.Text = "Maak bon";
            this.btn_MaakBon.UseVisualStyleBackColor = false;
            this.btn_MaakBon.Click += new System.EventHandler(this.btn_MaakBon_Click);
            // 
            // Afrekenen_PerTafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.btn_MaakBon);
            this.Controls.Add(this.btn_AfrekenenConfirm);
            this.Controls.Add(this.pcbx_LogoChapooAfrekenenMain);
            this.Controls.Add(this.panel1);
            this.Name = "Afrekenen_PerTafel";
            this.Text = "Afrekenen per tafel";
            this.Load += new System.EventHandler(this.Afrekenen_PerTafel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}