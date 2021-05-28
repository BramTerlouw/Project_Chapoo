
namespace UI
{
    partial class Login
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
            this.pnlHeaderMedewerkers = new System.Windows.Forms.Panel();
            this.lblLoginGebruikersID = new System.Windows.Forms.Label();
            this.lblLoginWachtwoord = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtLoginWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlHeaderMedewerkers
            // 
            this.pnlHeaderMedewerkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.pnlHeaderMedewerkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderMedewerkers.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderMedewerkers.Name = "pnlHeaderMedewerkers";
            this.pnlHeaderMedewerkers.Size = new System.Drawing.Size(1064, 100);
            this.pnlHeaderMedewerkers.TabIndex = 18;
            // 
            // lblLoginGebruikersID
            // 
            this.lblLoginGebruikersID.AutoSize = true;
            this.lblLoginGebruikersID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginGebruikersID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lblLoginGebruikersID.Location = new System.Drawing.Point(467, 247);
            this.lblLoginGebruikersID.Name = "lblLoginGebruikersID";
            this.lblLoginGebruikersID.Size = new System.Drawing.Size(82, 15);
            this.lblLoginGebruikersID.TabIndex = 19;
            this.lblLoginGebruikersID.Text = "GebruikersID";
            // 
            // lblLoginWachtwoord
            // 
            this.lblLoginWachtwoord.AutoSize = true;
            this.lblLoginWachtwoord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginWachtwoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(133)))));
            this.lblLoginWachtwoord.Location = new System.Drawing.Point(467, 322);
            this.lblLoginWachtwoord.Name = "lblLoginWachtwoord";
            this.lblLoginWachtwoord.Size = new System.Drawing.Size(79, 15);
            this.lblLoginWachtwoord.TabIndex = 20;
            this.lblLoginWachtwoord.Text = "Wachtwoord";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(427, 265);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(159, 23);
            this.txtLoginID.TabIndex = 21;
            // 
            // txtLoginWachtwoord
            // 
            this.txtLoginWachtwoord.Location = new System.Drawing.Point(427, 340);
            this.txtLoginWachtwoord.Name = "txtLoginWachtwoord";
            this.txtLoginWachtwoord.Size = new System.Drawing.Size(159, 23);
            this.txtLoginWachtwoord.TabIndex = 22;
            this.txtLoginWachtwoord.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(467, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 38);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginWachtwoord);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.lblLoginWachtwoord);
            this.Controls.Add(this.lblLoginGebruikersID);
            this.Controls.Add(this.pnlHeaderMedewerkers);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderMedewerkers;
        private System.Windows.Forms.Label lblLoginGebruikersID;
        private System.Windows.Forms.Label lblLoginWachtwoord;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtLoginWachtwoord;
        private System.Windows.Forms.Button btnLogin;
    }
}