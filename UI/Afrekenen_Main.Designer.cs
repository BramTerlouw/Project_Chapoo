
namespace UI
{
    partial class Afrekenen_Main
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
            this.pnl_AfrekenenMain = new System.Windows.Forms.Panel();
            this.lst_KiesTafel = new System.Windows.Forms.ListView();
            this.col_tafelID = new System.Windows.Forms.ColumnHeader();
            this.lbl_KiesTafelSubTitle = new System.Windows.Forms.Label();
            this.lbl_AfrekenenTitle = new System.Windows.Forms.Label();
            this.btn_KiesTafelConfirm = new System.Windows.Forms.Button();
            this.pcbx_LogoChapooAfrekenenMain = new System.Windows.Forms.PictureBox();
            this.btnTerugHoofdMenu = new System.Windows.Forms.Button();
            this.pnl_AfrekenenMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AfrekenenMain
            // 
            this.pnl_AfrekenenMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_AfrekenenMain.Controls.Add(this.lst_KiesTafel);
            this.pnl_AfrekenenMain.Controls.Add(this.lbl_KiesTafelSubTitle);
            this.pnl_AfrekenenMain.Controls.Add(this.lbl_AfrekenenTitle);
            this.pnl_AfrekenenMain.Location = new System.Drawing.Point(0, 57);
            this.pnl_AfrekenenMain.Name = "pnl_AfrekenenMain";
            this.pnl_AfrekenenMain.Size = new System.Drawing.Size(498, 465);
            this.pnl_AfrekenenMain.TabIndex = 0;
            // 
            // lst_KiesTafel
            // 
            this.lst_KiesTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tafelID});
            this.lst_KiesTafel.FullRowSelect = true;
            this.lst_KiesTafel.HideSelection = false;
            this.lst_KiesTafel.Location = new System.Drawing.Point(224, 70);
            this.lst_KiesTafel.Name = "lst_KiesTafel";
            this.lst_KiesTafel.Size = new System.Drawing.Size(64, 362);
            this.lst_KiesTafel.TabIndex = 2;
            this.lst_KiesTafel.UseCompatibleStateImageBehavior = false;
            this.lst_KiesTafel.View = System.Windows.Forms.View.Details;
            // 
            // col_tafelID
            // 
            this.col_tafelID.Text = "Tafel_ID";
            // 
            // lbl_KiesTafelSubTitle
            // 
            this.lbl_KiesTafelSubTitle.AutoSize = true;
            this.lbl_KiesTafelSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_KiesTafelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_KiesTafelSubTitle.Location = new System.Drawing.Point(215, 46);
            this.lbl_KiesTafelSubTitle.Name = "lbl_KiesTafelSubTitle";
            this.lbl_KiesTafelSubTitle.Size = new System.Drawing.Size(80, 21);
            this.lbl_KiesTafelSubTitle.TabIndex = 1;
            this.lbl_KiesTafelSubTitle.Text = "Kies tafel";
            // 
            // lbl_AfrekenenTitle
            // 
            this.lbl_AfrekenenTitle.AutoSize = true;
            this.lbl_AfrekenenTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AfrekenenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lbl_AfrekenenTitle.Location = new System.Drawing.Point(193, 14);
            this.lbl_AfrekenenTitle.Name = "lbl_AfrekenenTitle";
            this.lbl_AfrekenenTitle.Size = new System.Drawing.Size(132, 32);
            this.lbl_AfrekenenTitle.TabIndex = 0;
            this.lbl_AfrekenenTitle.Text = "Afrekenen";
            // 
            // btn_KiesTafelConfirm
            // 
            this.btn_KiesTafelConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btn_KiesTafelConfirm.Location = new System.Drawing.Point(207, 528);
            this.btn_KiesTafelConfirm.Name = "btn_KiesTafelConfirm";
            this.btn_KiesTafelConfirm.Size = new System.Drawing.Size(88, 42);
            this.btn_KiesTafelConfirm.TabIndex = 3;
            this.btn_KiesTafelConfirm.Text = "Verder";
            this.btn_KiesTafelConfirm.UseVisualStyleBackColor = false;
            this.btn_KiesTafelConfirm.Click += new System.EventHandler(this.btn_KiesTafelConfirm_Click);
            // 
            // pcbx_LogoChapooAfrekenenMain
            // 
            this.pcbx_LogoChapooAfrekenenMain.BackColor = System.Drawing.Color.White;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImage = global::UI.Properties.Resources.Chapoo_Logo;
            this.pcbx_LogoChapooAfrekenenMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbx_LogoChapooAfrekenenMain.Location = new System.Drawing.Point(12, 2);
            this.pcbx_LogoChapooAfrekenenMain.Name = "pcbx_LogoChapooAfrekenenMain";
            this.pcbx_LogoChapooAfrekenenMain.Size = new System.Drawing.Size(100, 58);
            this.pcbx_LogoChapooAfrekenenMain.TabIndex = 3;
            this.pcbx_LogoChapooAfrekenenMain.TabStop = false;
            // 
            // btnTerugHoofdMenu
            // 
            this.btnTerugHoofdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnTerugHoofdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerugHoofdMenu.Location = new System.Drawing.Point(375, 12);
            this.btnTerugHoofdMenu.Name = "btnTerugHoofdMenu";
            this.btnTerugHoofdMenu.Size = new System.Drawing.Size(108, 38);
            this.btnTerugHoofdMenu.TabIndex = 5;
            this.btnTerugHoofdMenu.Text = "Terug";
            this.btnTerugHoofdMenu.UseVisualStyleBackColor = false;
            this.btnTerugHoofdMenu.Click += new System.EventHandler(this.btnTerugHoofdMenu_Click);
            // 
            // Afrekenen_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(495, 573);
            this.Controls.Add(this.btnTerugHoofdMenu);
            this.Controls.Add(this.pcbx_LogoChapooAfrekenenMain);
            this.Controls.Add(this.btn_KiesTafelConfirm);
            this.Controls.Add(this.pnl_AfrekenenMain);
            this.Name = "Afrekenen_Main";
            this.Text = "Afrekenen";
            this.Load += new System.EventHandler(this.Afrekenen_Main_Load);
            this.pnl_AfrekenenMain.ResumeLayout(false);
            this.pnl_AfrekenenMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_LogoChapooAfrekenenMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AfrekenenMain;
        private System.Windows.Forms.Label lbl_AfrekenenTitle;
        private System.Windows.Forms.Label lbl_KiesTafelSubTitle;
        private System.Windows.Forms.ListView lst_KiesTafel;
        private System.Windows.Forms.ColumnHeader col_tafelID;
        private System.Windows.Forms.Button btn_KiesTafelConfirm;
        private System.Windows.Forms.PictureBox pcbx_LogoChapooAfrekenenMain;
        private System.Windows.Forms.Button btnTerugHoofdMenu;
    }
}