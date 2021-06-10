
namespace UI
{
    partial class Keuken_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeaderMedewerkers = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnTerugHoofdMenu = new System.Windows.Forms.Button();
            this.lbl_Locatie = new System.Windows.Forms.Label();
            this.dgv_Keuken_Bestellingen = new System.Windows.Forms.DataGridView();
            this.ColumnTafelNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBestellingNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Keuken_Open_Gereed = new System.Windows.Forms.Panel();
            this.btn_Keuken_Gereed = new System.Windows.Forms.Button();
            this.btn_Keuken_Openstaand = new System.Windows.Forms.Button();
            this.dgv_Keuken_BestellingDetails = new System.Windows.Forms.DataGridView();
            this.col_Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gerecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Opmerkingen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Keuken_Bestelling_Afmelden = new System.Windows.Forms.Button();
            this.btn_Keuken_Details_Sluiten = new System.Windows.Forms.Button();
            this.pnlHeaderMedewerkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keuken_Bestellingen)).BeginInit();
            this.pnl_Keuken_Open_Gereed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keuken_BestellingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderMedewerkers
            // 
            this.pnlHeaderMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.pnlHeaderMedewerkers.Controls.Add(this.lblTime);
            this.pnlHeaderMedewerkers.Controls.Add(this.btnTerugHoofdMenu);
            this.pnlHeaderMedewerkers.Controls.Add(this.lbl_Locatie);
            this.pnlHeaderMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMedewerkers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMedewerkers.Name = "pnlHeaderMedewerkers";
            this.pnlHeaderMedewerkers.Size = new System.Drawing.Size(1064, 100);
            this.pnlHeaderMedewerkers.TabIndex = 19;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(485, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 46);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00";
            // 
            // btnTerugHoofdMenu
            // 
            this.btnTerugHoofdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnTerugHoofdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugHoofdMenu.Location = new System.Drawing.Point(925, 24);
            this.btnTerugHoofdMenu.Name = "btnTerugHoofdMenu";
            this.btnTerugHoofdMenu.Size = new System.Drawing.Size(108, 38);
            this.btnTerugHoofdMenu.TabIndex = 4;
            this.btnTerugHoofdMenu.Text = "Terug";
            this.btnTerugHoofdMenu.UseVisualStyleBackColor = false;
            this.btnTerugHoofdMenu.Click += new System.EventHandler(this.btnTerugHoofdMenu_Click);
            // 
            // lbl_Locatie
            // 
            this.lbl_Locatie.AutoSize = true;
            this.lbl_Locatie.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Locatie.ForeColor = System.Drawing.Color.White;
            this.lbl_Locatie.Location = new System.Drawing.Point(40, 24);
            this.lbl_Locatie.Name = "lbl_Locatie";
            this.lbl_Locatie.Size = new System.Drawing.Size(131, 46);
            this.lbl_Locatie.TabIndex = 0;
            this.lbl_Locatie.Text = "Keuken";
            // 
            // dgv_Keuken_Bestellingen
            // 
            this.dgv_Keuken_Bestellingen.AllowUserToAddRows = false;
            this.dgv_Keuken_Bestellingen.AllowUserToResizeRows = false;
            this.dgv_Keuken_Bestellingen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Keuken_Bestellingen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Keuken_Bestellingen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Keuken_Bestellingen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Keuken_Bestellingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Keuken_Bestellingen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTafelNR,
            this.ColumnBestellingNR,
            this.ColumnTijd});
            this.dgv_Keuken_Bestellingen.EnableHeadersVisualStyles = false;
            this.dgv_Keuken_Bestellingen.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Keuken_Bestellingen.Location = new System.Drawing.Point(0, 161);
            this.dgv_Keuken_Bestellingen.MultiSelect = false;
            this.dgv_Keuken_Bestellingen.Name = "dgv_Keuken_Bestellingen";
            this.dgv_Keuken_Bestellingen.RowHeadersVisible = false;
            this.dgv_Keuken_Bestellingen.RowHeadersWidth = 51;
            this.dgv_Keuken_Bestellingen.RowTemplate.Height = 25;
            this.dgv_Keuken_Bestellingen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Keuken_Bestellingen.Size = new System.Drawing.Size(532, 465);
            this.dgv_Keuken_Bestellingen.TabIndex = 20;
            this.dgv_Keuken_Bestellingen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Keuken_Bestellingen_CellContentClick);
            // 
            // ColumnTafelNR
            // 
            this.ColumnTafelNR.HeaderText = "TafelNR";
            this.ColumnTafelNR.MinimumWidth = 6;
            this.ColumnTafelNR.Name = "ColumnTafelNR";
            this.ColumnTafelNR.Width = 75;
            // 
            // ColumnBestellingNR
            // 
            this.ColumnBestellingNR.HeaderText = "Bestelling NR";
            this.ColumnBestellingNR.MinimumWidth = 6;
            this.ColumnBestellingNR.Name = "ColumnBestellingNR";
            this.ColumnBestellingNR.Width = 225;
            // 
            // ColumnTijd
            // 
            this.ColumnTijd.HeaderText = "Tijd Opname";
            this.ColumnTijd.MinimumWidth = 6;
            this.ColumnTijd.Name = "ColumnTijd";
            this.ColumnTijd.Width = 125;
            // 
            // pnl_Keuken_Open_Gereed
            // 
            this.pnl_Keuken_Open_Gereed.Controls.Add(this.btn_Keuken_Gereed);
            this.pnl_Keuken_Open_Gereed.Controls.Add(this.btn_Keuken_Openstaand);
            this.pnl_Keuken_Open_Gereed.Location = new System.Drawing.Point(0, 99);
            this.pnl_Keuken_Open_Gereed.Name = "pnl_Keuken_Open_Gereed";
            this.pnl_Keuken_Open_Gereed.Size = new System.Drawing.Size(1064, 63);
            this.pnl_Keuken_Open_Gereed.TabIndex = 21;
            // 
            // btn_Keuken_Gereed
            // 
            this.btn_Keuken_Gereed.BackColor = System.Drawing.Color.White;
            this.btn_Keuken_Gereed.Location = new System.Drawing.Point(532, 0);
            this.btn_Keuken_Gereed.Name = "btn_Keuken_Gereed";
            this.btn_Keuken_Gereed.Size = new System.Drawing.Size(532, 63);
            this.btn_Keuken_Gereed.TabIndex = 1;
            this.btn_Keuken_Gereed.Text = "Gereed";
            this.btn_Keuken_Gereed.UseVisualStyleBackColor = false;
            this.btn_Keuken_Gereed.Click += new System.EventHandler(this.btn_Keuken_Gereed_Click);
            // 
            // btn_Keuken_Openstaand
            // 
            this.btn_Keuken_Openstaand.BackColor = System.Drawing.Color.White;
            this.btn_Keuken_Openstaand.Location = new System.Drawing.Point(0, 0);
            this.btn_Keuken_Openstaand.Name = "btn_Keuken_Openstaand";
            this.btn_Keuken_Openstaand.Size = new System.Drawing.Size(532, 63);
            this.btn_Keuken_Openstaand.TabIndex = 0;
            this.btn_Keuken_Openstaand.Text = "Openstaand";
            this.btn_Keuken_Openstaand.UseVisualStyleBackColor = false;
            this.btn_Keuken_Openstaand.Click += new System.EventHandler(this.btn_Keuken_Openstaand_Click);
            // 
            // dgv_Keuken_BestellingDetails
            // 
            this.dgv_Keuken_BestellingDetails.AllowUserToAddRows = false;
            this.dgv_Keuken_BestellingDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Keuken_BestellingDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Keuken_BestellingDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Keuken_BestellingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Keuken_BestellingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Keuken_BestellingDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Aantal,
            this.col_Gerecht,
            this.col_Opmerkingen});
            this.dgv_Keuken_BestellingDetails.EnableHeadersVisualStyles = false;
            this.dgv_Keuken_BestellingDetails.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Keuken_BestellingDetails.Location = new System.Drawing.Point(532, 161);
            this.dgv_Keuken_BestellingDetails.Name = "dgv_Keuken_BestellingDetails";
            this.dgv_Keuken_BestellingDetails.RowHeadersVisible = false;
            this.dgv_Keuken_BestellingDetails.RowHeadersWidth = 51;
            this.dgv_Keuken_BestellingDetails.RowTemplate.Height = 25;
            this.dgv_Keuken_BestellingDetails.Size = new System.Drawing.Size(532, 396);
            this.dgv_Keuken_BestellingDetails.TabIndex = 22;
            // 
            // col_Aantal
            // 
            this.col_Aantal.HeaderText = "Aantal";
            this.col_Aantal.MinimumWidth = 6;
            this.col_Aantal.Name = "col_Aantal";
            this.col_Aantal.Width = 75;
            // 
            // col_Gerecht
            // 
            this.col_Gerecht.HeaderText = "Gerecht";
            this.col_Gerecht.MinimumWidth = 6;
            this.col_Gerecht.Name = "col_Gerecht";
            this.col_Gerecht.Width = 225;
            // 
            // col_Opmerkingen
            // 
            this.col_Opmerkingen.HeaderText = "Opmerkingen";
            this.col_Opmerkingen.MinimumWidth = 6;
            this.col_Opmerkingen.Name = "col_Opmerkingen";
            this.col_Opmerkingen.Width = 125;
            // 
            // btn_Keuken_Bestelling_Afmelden
            // 
            this.btn_Keuken_Bestelling_Afmelden.Location = new System.Drawing.Point(908, 569);
            this.btn_Keuken_Bestelling_Afmelden.Name = "btn_Keuken_Bestelling_Afmelden";
            this.btn_Keuken_Bestelling_Afmelden.Size = new System.Drawing.Size(144, 47);
            this.btn_Keuken_Bestelling_Afmelden.TabIndex = 23;
            this.btn_Keuken_Bestelling_Afmelden.Text = "Gereed Melden";
            this.btn_Keuken_Bestelling_Afmelden.UseVisualStyleBackColor = true;
            this.btn_Keuken_Bestelling_Afmelden.Click += new System.EventHandler(this.btn_Keuken_Bestelling_Afmelden_Click);
            // 
            // btn_Keuken_Details_Sluiten
            // 
            this.btn_Keuken_Details_Sluiten.Location = new System.Drawing.Point(538, 569);
            this.btn_Keuken_Details_Sluiten.Name = "btn_Keuken_Details_Sluiten";
            this.btn_Keuken_Details_Sluiten.Size = new System.Drawing.Size(144, 47);
            this.btn_Keuken_Details_Sluiten.TabIndex = 24;
            this.btn_Keuken_Details_Sluiten.Text = "Sluiten";
            this.btn_Keuken_Details_Sluiten.UseVisualStyleBackColor = true;
            this.btn_Keuken_Details_Sluiten.Click += new System.EventHandler(this.btn_Keuken_Details_Sluiten_Click);
            // 
            // Keuken_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.btn_Keuken_Details_Sluiten);
            this.Controls.Add(this.btn_Keuken_Bestelling_Afmelden);
            this.Controls.Add(this.dgv_Keuken_BestellingDetails);
            this.Controls.Add(this.pnl_Keuken_Open_Gereed);
            this.Controls.Add(this.dgv_Keuken_Bestellingen);
            this.Controls.Add(this.pnlHeaderMedewerkers);
            this.Name = "Keuken_Main";
            this.Text = "Keuken";
            this.pnlHeaderMedewerkers.ResumeLayout(false);
            this.pnlHeaderMedewerkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keuken_Bestellingen)).EndInit();
            this.pnl_Keuken_Open_Gereed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Keuken_BestellingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderMedewerkers;
        private System.Windows.Forms.Label lbl_Locatie;
        private System.Windows.Forms.DataGridView dgv_Keuken_Bestellingen;
        private System.Windows.Forms.DataGridView dgv_Keuken_Bestelli;
        private System.Windows.Forms.Panel pnl_Keuken_Open_Gereed;
        private System.Windows.Forms.Button btn_Keuken_Gereed;
        private System.Windows.Forms.Button btn_Keuken_Openstaand;
        private System.Windows.Forms.DataGridView dgv_Keuken_BestellingDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gerecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Opmerkingen;
        private System.Windows.Forms.Button btn_Keuken_Bestelling_Afmelden;
        private System.Windows.Forms.Button btn_Keuken_Details_Sluiten;
        private System.Windows.Forms.Button btnTerugHoofdMenu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTafelNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBestellingNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTijd;
    }
}