namespace КлиенткаПрактика
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.EnterB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.LoginL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.LoginT = new System.Windows.Forms.TextBox();
            this.PasswordT = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.authTableAdapter = new КлиенткаПрактика.AuthDataSetTableAdapters.AuthTableAdapter();
            this.passwordErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterB
            // 
            this.EnterB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.EnterB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterB.Location = new System.Drawing.Point(311, 221);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(116, 39);
            this.EnterB.TabIndex = 0;
            this.EnterB.Text = "Войти";
            this.EnterB.UseVisualStyleBackColor = false;
            this.EnterB.Click += new System.EventHandler(this.EnterB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.ExitB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitB.Location = new System.Drawing.Point(142, 221);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(116, 39);
            this.ExitB.TabIndex = 1;
            this.ExitB.Text = "Закрыть";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginL.Location = new System.Drawing.Point(138, 79);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(70, 23);
            this.LoginL.TabIndex = 2;
            this.LoginL.Text = "Логин";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordL.Location = new System.Drawing.Point(138, 119);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(83, 23);
            this.PasswordL.TabIndex = 3;
            this.PasswordL.Text = "Пароль";
            // 
            // LoginT
            // 
            this.LoginT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginT.Location = new System.Drawing.Point(227, 73);
            this.LoginT.Name = "LoginT";
            this.LoginT.Size = new System.Drawing.Size(200, 29);
            this.LoginT.TabIndex = 4;
            // 
            // PasswordT
            // 
            this.PasswordT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordT.Location = new System.Drawing.Point(227, 116);
            this.PasswordT.Name = "PasswordT";
            this.PasswordT.PasswordChar = '*';
            this.PasswordT.Size = new System.Drawing.Size(200, 29);
            this.PasswordT.TabIndex = 5;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.Location = new System.Drawing.Point(227, 161);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(199, 27);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.Text = "Показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // passwordErrorMessage
            // 
            this.passwordErrorMessage.AutoSize = true;
            this.passwordErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.passwordErrorMessage.Location = new System.Drawing.Point(12, 279);
            this.passwordErrorMessage.Name = "passwordErrorMessage";
            this.passwordErrorMessage.Size = new System.Drawing.Size(46, 17);
            this.passwordErrorMessage.TabIndex = 7;
            this.passwordErrorMessage.Text = "label1";
            this.passwordErrorMessage.Visible = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(622, 378);
            this.Controls.Add(this.passwordErrorMessage);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.PasswordT);
            this.Controls.Add(this.LoginT);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.LoginL);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.EnterB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.Text = "Auth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.TextBox LoginT;
        private System.Windows.Forms.TextBox PasswordT;
        private System.Windows.Forms.CheckBox ShowPassword;
        public System.Windows.Forms.Button EnterB;
        private AuthDataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private System.Windows.Forms.Label passwordErrorMessage;
    }
}