namespace LMS
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.ToolTip(this.components);
            this.Password = new System.Windows.Forms.ToolTip(this.components);
            this.Login = new System.Windows.Forms.ToolTip(this.components);
            this.Exit = new System.Windows.Forms.ToolTip(this.components);
            this.Minimize = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonForgotten = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pictureBoxShow);
            this.panelLogin.Controls.Add(this.buttonForgotten);
            this.panelLogin.Controls.Add(this.labelError);
            this.panelLogin.Controls.Add(this.pictureBoxError);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.pictureBoxPassword);
            this.panelLogin.Controls.Add(this.pictureBoxUsername);
            this.panelLogin.Controls.Add(this.pictureBoxHide);
            this.panelLogin.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panelLogin, "panelLogin");
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.Name = "labelUsername";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(52)))), ((int)(((byte)(164)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Username
            // 
            this.Username.ToolTipTitle = "Username";
            // 
            // Password
            // 
            this.Password.ToolTipTitle = "Password";
            // 
            // Login
            // 
            this.Login.ToolTipTitle = "Login";
            // 
            // Exit
            // 
            this.Exit.ToolTipTitle = "Exit";
            // 
            // Minimize
            // 
            this.Minimize.ToolTipTitle = "Minimize";
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = global::LMS.Properties.Resources.shield_exclamation_free_icon_font;
            resources.ApplyResources(this.pictureBoxError, "pictureBoxError");
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.TabStop = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = global::LMS.Properties.Resources.eye_free_icon_font;
            resources.ApplyResources(this.pictureBoxShow, "pictureBoxShow");
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::LMS.Properties.Resources.sign_in_alt_free_icon_font;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::LMS.Properties.Resources.lock_free_icon_font;
            resources.ApplyResources(this.pictureBoxPassword, "pictureBoxPassword");
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Image = global::LMS.Properties.Resources.user_free_icon_font;
            resources.ApplyResources(this.pictureBoxUsername, "pictureBoxUsername");
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.TabStop = false;
            this.pictureBoxUsername.MouseHover += new System.EventHandler(this.pictureBoxUsername_MouseHover);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = global::LMS.Properties.Resources.eye_crossed_free_icon_font;
            resources.ApplyResources(this.pictureBoxHide, "pictureBoxHide");
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::LMS.Properties.Resources.Screensh;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // labelError
            // 
            resources.ApplyResources(this.labelError, "labelError");
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Name = "labelError";
            // 
            // buttonForgotten
            // 
            this.buttonForgotten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(52)))), ((int)(((byte)(164)))));
            resources.ApplyResources(this.buttonForgotten, "buttonForgotten");
            this.buttonForgotten.ForeColor = System.Drawing.Color.White;
            this.buttonForgotten.Name = "buttonForgotten";
            this.buttonForgotten.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.Logo);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip Username;
        private System.Windows.Forms.ToolTip Password;
        private System.Windows.Forms.ToolTip Login;
        private System.Windows.Forms.ToolTip Exit;
        private System.Windows.Forms.ToolTip Minimize;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonForgotten;
    }
}

