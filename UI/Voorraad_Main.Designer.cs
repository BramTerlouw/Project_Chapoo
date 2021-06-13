
namespace UI
{
    partial class Voorraad_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoorraadTerug = new System.Windows.Forms.Button();
            this.dgv_Voorraad = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilterEten = new System.Windows.Forms.Button();
            this.btnFilterDrinken = new System.Windows.Forms.Button();
            this.pnlVoorraadAanpassen = new System.Windows.Forms.Panel();
            this.cmdAanpassenID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPnlHeaderAanpassen = new System.Windows.Forms.Label();
            this.txtAanpassenAantal = new System.Windows.Forms.TextBox();
            this.lblAanpassenVoorraadText2 = new System.Windows.Forms.Label();
            this.lblAanpassenVoorraadText1 = new System.Windows.Forms.Label();
            this.btnNieuweVoorraad = new System.Windows.Forms.Button();
            this.pnlFilterVoorraad = new System.Windows.Forms.Panel();
            this.btnCloseVoorraadFilter = new System.Windows.Forms.Button();
            this.btnFilterVoorraad = new System.Windows.Forms.Button();
            this.txtVoorraadFilter = new System.Windows.Forms.TextBox();
            this.lblFilterVraag = new System.Windows.Forms.Label();
            this.lblVoorraadFilterHeader = new System.Windows.Forms.Label();
            this.btnVoorraadAanpassen = new System.Windows.Forms.Button();
            this.btnFilterVoorraadpnl = new System.Windows.Forms.Button();
            this.pnlHeaderMedewerkers = new System.Windows.Forms.Panel();
            this.btnRefreshVoorraad = new System.Windows.Forms.Button();
            this.pcbx_LogoChapooAfrekenenMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voorraad)).BeginInit();
            this.pnlVoorraadAanpassen.SuspendLayout();
            this.pnlFilterVoorraad.SuspendLayout();
            this.pnlHeaderMedewerkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voorraad";
            // 
            // btnVoorraadTerug
            // 
            this.btnVoorraadTerug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnVoorraadTerug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoorraadTerug.Location = new System.Drawing.Point(944, 578);
            this.btnVoorraadTerug.Name = "btnVoorraadTerug";
            this.btnVoorraadTerug.Size = new System.Drawing.Size(108, 38);
            this.btnVoorraadTerug.TabIndex = 2;
            this.btnVoorraadTerug.Text = "Terug";
            this.btnVoorraadTerug.UseVisualStyleBackColor = false;
            this.btnVoorraadTerug.Click += new System.EventHandler(this.btnVoorraadTerug_Click);
            // 
            // dgv_Voorraad
            // 
            this.dgv_Voorraad.AllowUserToAddRows = false;
            this.dgv_Voorraad.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Voorraad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Voorraad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Voorraad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Voorraad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Voorraad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNaam,
            this.ColumnAantal});
            this.dgv_Voorraad.EnableHeadersVisualStyles = false;
            this.dgv_Voorraad.Location = new System.Drawing.Point(16, 174);
            this.dgv_Voorraad.Name = "dgv_Voorraad";
            this.dgv_Voorraad.RowHeadersVisible = false;
            this.dgv_Voorraad.RowTemplate.Height = 25;
            this.dgv_Voorraad.Size = new System.Drawing.Size(427, 303);
            this.dgv_Voorraad.TabIndex = 3;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 75;
            // 
            // ColumnNaam
            // 
            this.ColumnNaam.HeaderText = "Naam";
            this.ColumnNaam.Name = "ColumnNaam";
            this.ColumnNaam.Width = 225;
            // 
            // ColumnAantal
            // 
            this.ColumnAantal.HeaderText = "Aantal";
            this.ColumnAantal.Name = "ColumnAantal";
            // 
            // btnFilterEten
            // 
            this.btnFilterEten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnFilterEten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterEten.Location = new System.Drawing.Point(16, 145);
            this.btnFilterEten.Name = "btnFilterEten";
            this.btnFilterEten.Size = new System.Drawing.Size(75, 23);
            this.btnFilterEten.TabIndex = 4;
            this.btnFilterEten.Text = "Eten";
            this.btnFilterEten.UseVisualStyleBackColor = false;
            this.btnFilterEten.Click += new System.EventHandler(this.btnFilterEten_Click);
            // 
            // btnFilterDrinken
            // 
            this.btnFilterDrinken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnFilterDrinken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDrinken.Location = new System.Drawing.Point(97, 145);
            this.btnFilterDrinken.Name = "btnFilterDrinken";
            this.btnFilterDrinken.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDrinken.TabIndex = 5;
            this.btnFilterDrinken.Text = "Drinken";
            this.btnFilterDrinken.UseVisualStyleBackColor = false;
            this.btnFilterDrinken.Click += new System.EventHandler(this.btnFilterDrinken_Click);
            // 
            // pnlVoorraadAanpassen
            // 
            this.pnlVoorraadAanpassen.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVoorraadAanpassen.Controls.Add(this.cmdAanpassenID);
            this.pnlVoorraadAanpassen.Controls.Add(this.button1);
            this.pnlVoorraadAanpassen.Controls.Add(this.lblPnlHeaderAanpassen);
            this.pnlVoorraadAanpassen.Controls.Add(this.txtAanpassenAantal);
            this.pnlVoorraadAanpassen.Controls.Add(this.lblAanpassenVoorraadText2);
            this.pnlVoorraadAanpassen.Controls.Add(this.lblAanpassenVoorraadText1);
            this.pnlVoorraadAanpassen.Controls.Add(this.btnNieuweVoorraad);
            this.pnlVoorraadAanpassen.Location = new System.Drawing.Point(461, 174);
            this.pnlVoorraadAanpassen.Name = "pnlVoorraadAanpassen";
            this.pnlVoorraadAanpassen.Size = new System.Drawing.Size(320, 303);
            this.pnlVoorraadAanpassen.TabIndex = 6;
            // 
            // cmdAanpassenID
            // 
            this.cmdAanpassenID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdAanpassenID.FormattingEnabled = true;
            this.cmdAanpassenID.Location = new System.Drawing.Point(39, 115);
            this.cmdAanpassenID.Name = "cmdAanpassenID";
            this.cmdAanpassenID.Size = new System.Drawing.Size(222, 23);
            this.cmdAanpassenID.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(301, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPnlHeaderAanpassen
            // 
            this.lblPnlHeaderAanpassen.AutoSize = true;
            this.lblPnlHeaderAanpassen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPnlHeaderAanpassen.Location = new System.Drawing.Point(38, 23);
            this.lblPnlHeaderAanpassen.Name = "lblPnlHeaderAanpassen";
            this.lblPnlHeaderAanpassen.Size = new System.Drawing.Size(137, 32);
            this.lblPnlHeaderAanpassen.TabIndex = 9;
            this.lblPnlHeaderAanpassen.Text = "Aanpassen";
            // 
            // txtAanpassenAantal
            // 
            this.txtAanpassenAantal.Location = new System.Drawing.Point(38, 182);
            this.txtAanpassenAantal.Name = "txtAanpassenAantal";
            this.txtAanpassenAantal.Size = new System.Drawing.Size(222, 23);
            this.txtAanpassenAantal.TabIndex = 4;
            // 
            // lblAanpassenVoorraadText2
            // 
            this.lblAanpassenVoorraadText2.AutoSize = true;
            this.lblAanpassenVoorraadText2.Location = new System.Drawing.Point(38, 164);
            this.lblAanpassenVoorraadText2.Name = "lblAanpassenVoorraadText2";
            this.lblAanpassenVoorraadText2.Size = new System.Drawing.Size(100, 15);
            this.lblAanpassenVoorraadText2.TabIndex = 2;
            this.lblAanpassenVoorraadText2.Text = "Nieuwe Voorraad:";
            // 
            // lblAanpassenVoorraadText1
            // 
            this.lblAanpassenVoorraadText1.AutoSize = true;
            this.lblAanpassenVoorraadText1.Location = new System.Drawing.Point(38, 96);
            this.lblAanpassenVoorraadText1.Name = "lblAanpassenVoorraadText1";
            this.lblAanpassenVoorraadText1.Size = new System.Drawing.Size(60, 15);
            this.lblAanpassenVoorraadText1.TabIndex = 1;
            this.lblAanpassenVoorraadText1.Text = "Voer ID in:";
            // 
            // btnNieuweVoorraad
            // 
            this.btnNieuweVoorraad.Location = new System.Drawing.Point(125, 247);
            this.btnNieuweVoorraad.Name = "btnNieuweVoorraad";
            this.btnNieuweVoorraad.Size = new System.Drawing.Size(75, 23);
            this.btnNieuweVoorraad.TabIndex = 0;
            this.btnNieuweVoorraad.Text = "Pas aan";
            this.btnNieuweVoorraad.UseVisualStyleBackColor = true;
            this.btnNieuweVoorraad.Click += new System.EventHandler(this.btnNieuweVoorraad_Click);
            // 
            // pnlFilterVoorraad
            // 
            this.pnlFilterVoorraad.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFilterVoorraad.Controls.Add(this.btnCloseVoorraadFilter);
            this.pnlFilterVoorraad.Controls.Add(this.btnFilterVoorraad);
            this.pnlFilterVoorraad.Controls.Add(this.txtVoorraadFilter);
            this.pnlFilterVoorraad.Controls.Add(this.lblFilterVraag);
            this.pnlFilterVoorraad.Controls.Add(this.lblVoorraadFilterHeader);
            this.pnlFilterVoorraad.Location = new System.Drawing.Point(461, 174);
            this.pnlFilterVoorraad.Name = "pnlFilterVoorraad";
            this.pnlFilterVoorraad.Size = new System.Drawing.Size(320, 303);
            this.pnlFilterVoorraad.TabIndex = 10;
            // 
            // btnCloseVoorraadFilter
            // 
            this.btnCloseVoorraadFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseVoorraadFilter.Location = new System.Drawing.Point(302, 0);
            this.btnCloseVoorraadFilter.Name = "btnCloseVoorraadFilter";
            this.btnCloseVoorraadFilter.Size = new System.Drawing.Size(18, 23);
            this.btnCloseVoorraadFilter.TabIndex = 13;
            this.btnCloseVoorraadFilter.Text = "X";
            this.btnCloseVoorraadFilter.UseVisualStyleBackColor = true;
            this.btnCloseVoorraadFilter.Click += new System.EventHandler(this.btnCloseVoorraadFilter_Click);
            // 
            // btnFilterVoorraad
            // 
            this.btnFilterVoorraad.Location = new System.Drawing.Point(126, 219);
            this.btnFilterVoorraad.Name = "btnFilterVoorraad";
            this.btnFilterVoorraad.Size = new System.Drawing.Size(75, 23);
            this.btnFilterVoorraad.TabIndex = 12;
            this.btnFilterVoorraad.Text = "Filter";
            this.btnFilterVoorraad.UseVisualStyleBackColor = true;
            this.btnFilterVoorraad.Click += new System.EventHandler(this.btnFilterVoorraad_Click);
            // 
            // txtVoorraadFilter
            // 
            this.txtVoorraadFilter.Location = new System.Drawing.Point(49, 115);
            this.txtVoorraadFilter.Name = "txtVoorraadFilter";
            this.txtVoorraadFilter.Size = new System.Drawing.Size(212, 23);
            this.txtVoorraadFilter.TabIndex = 11;
            // 
            // lblFilterVraag
            // 
            this.lblFilterVraag.AutoSize = true;
            this.lblFilterVraag.Location = new System.Drawing.Point(49, 82);
            this.lblFilterVraag.Name = "lblFilterVraag";
            this.lblFilterVraag.Size = new System.Drawing.Size(74, 15);
            this.lblFilterVraag.TabIndex = 10;
            this.lblFilterVraag.Text = "Wat zoekt u?";
            // 
            // lblVoorraadFilterHeader
            // 
            this.lblVoorraadFilterHeader.AutoSize = true;
            this.lblVoorraadFilterHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVoorraadFilterHeader.Location = new System.Drawing.Point(39, 24);
            this.lblVoorraadFilterHeader.Name = "lblVoorraadFilterHeader";
            this.lblVoorraadFilterHeader.Size = new System.Drawing.Size(72, 32);
            this.lblVoorraadFilterHeader.TabIndex = 9;
            this.lblVoorraadFilterHeader.Text = "Filter";
            // 
            // btnVoorraadAanpassen
            // 
            this.btnVoorraadAanpassen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnVoorraadAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoorraadAanpassen.Location = new System.Drawing.Point(129, 483);
            this.btnVoorraadAanpassen.Name = "btnVoorraadAanpassen";
            this.btnVoorraadAanpassen.Size = new System.Drawing.Size(108, 38);
            this.btnVoorraadAanpassen.TabIndex = 7;
            this.btnVoorraadAanpassen.Text = "Aanpassen";
            this.btnVoorraadAanpassen.UseVisualStyleBackColor = false;
            this.btnVoorraadAanpassen.Click += new System.EventHandler(this.btnVoorraadAanpassen_Click);
            // 
            // btnFilterVoorraadpnl
            // 
            this.btnFilterVoorraadpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnFilterVoorraadpnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterVoorraadpnl.Location = new System.Drawing.Point(15, 483);
            this.btnFilterVoorraadpnl.Name = "btnFilterVoorraadpnl";
            this.btnFilterVoorraadpnl.Size = new System.Drawing.Size(108, 38);
            this.btnFilterVoorraadpnl.TabIndex = 8;
            this.btnFilterVoorraadpnl.Text = "Filteren";
            this.btnFilterVoorraadpnl.UseVisualStyleBackColor = false;
            this.btnFilterVoorraadpnl.Click += new System.EventHandler(this.btnFilterVoorraadpnl_Click);
            // 
            // pnlHeaderMedewerkers
            // 
            this.pnlHeaderMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.pnlHeaderMedewerkers.Controls.Add(this.pcbx_LogoChapooAfrekenenMain);
            this.pnlHeaderMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMedewerkers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMedewerkers.Name = "pnlHeaderMedewerkers";
            this.pnlHeaderMedewerkers.Size = new System.Drawing.Size(1064, 100);
            this.pnlHeaderMedewerkers.TabIndex = 18;
            // 
            // btnRefreshVoorraad
            // 
            this.btnRefreshVoorraad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnRefreshVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshVoorraad.Location = new System.Drawing.Point(243, 483);
            this.btnRefreshVoorraad.Name = "btnRefreshVoorraad";
            this.btnRefreshVoorraad.Size = new System.Drawing.Size(108, 38);
            this.btnRefreshVoorraad.TabIndex = 19;
            this.btnRefreshVoorraad.Text = "Refresh";
            this.btnRefreshVoorraad.UseVisualStyleBackColor = false;
            this.btnRefreshVoorraad.Click += new System.EventHandler(this.btnRefreshVoorraad_Click);
            // 
            // pcbx_LogoChapooAfrekenenMain
            // 
            this.pcbx_LogoChapooAfrekenenMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooAfrekenenMain.Location = new System.Drawing.Point(16, 12);
            this.pcbx_LogoChapooAfrekenenMain.Name = "pcbx_LogoChapooAfrekenenMain";
            this.pcbx_LogoChapooAfrekenenMain.Size = new System.Drawing.Size(137, 73);
            this.pcbx_LogoChapooAfrekenenMain.TabIndex = 4;
            this.pcbx_LogoChapooAfrekenenMain.TabStop = false;
            // 
            // Voorraad_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.btnRefreshVoorraad);
            this.Controls.Add(this.pnlHeaderMedewerkers);
            this.Controls.Add(this.pnlFilterVoorraad);
            this.Controls.Add(this.btnFilterVoorraadpnl);
            this.Controls.Add(this.btnVoorraadAanpassen);
            this.Controls.Add(this.pnlVoorraadAanpassen);
            this.Controls.Add(this.btnFilterDrinken);
            this.Controls.Add(this.btnFilterEten);
            this.Controls.Add(this.dgv_Voorraad);
            this.Controls.Add(this.btnVoorraadTerug);
            this.Controls.Add(this.label1);
            this.Name = "Voorraad_Main";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voorraad)).EndInit();
            this.pnlVoorraadAanpassen.ResumeLayout(false);
            this.pnlVoorraadAanpassen.PerformLayout();
            this.pnlFilterVoorraad.ResumeLayout(false);
            this.pnlFilterVoorraad.PerformLayout();
            this.pnlHeaderMedewerkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoorraadTerug;
        private System.Windows.Forms.DataGridView dgv_Voorraad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAantal;
        private System.Windows.Forms.Button btnFilterEten;
        private System.Windows.Forms.Button btnFilterDrinken;
        private System.Windows.Forms.Panel pnlVoorraadAanpassen;
        private System.Windows.Forms.TextBox txtAanpassenAantal;
        private System.Windows.Forms.Label lblAanpassenVoorraadText2;
        private System.Windows.Forms.Label lblAanpassenVoorraadText1;
        private System.Windows.Forms.Button btnNieuweVoorraad;
        private System.Windows.Forms.Button btnVoorraadAanpassen;
        private System.Windows.Forms.Button btnFilterVoorraadpnl;
        private System.Windows.Forms.Label lblPnlHeaderAanpassen;
        private System.Windows.Forms.Panel pnlFilterVoorraad;
        private System.Windows.Forms.Button btnFilterVoorraad;
        private System.Windows.Forms.TextBox txtVoorraadFilter;
        private System.Windows.Forms.Label lblFilterVraag;
        private System.Windows.Forms.Label lblVoorraadFilterHeader;
        private System.Windows.Forms.Button btnCloseVoorraadFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlHeaderMedewerkers;
        private System.Windows.Forms.Button btnRefreshVoorraad;
        private System.Windows.Forms.ComboBox cmdAanpassenID;
        private System.Windows.Forms.PictureBox pcbx_LogoChapooAfrekenenMain;
    }
}