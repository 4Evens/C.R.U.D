namespace WepUI
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jtbLogin = new JMaterialTextbox.JMaterialTextbox();
            this.jfbLoginButton = new FlatButton.JFlatButton();
            this.jtxLogin = new JTextBox.JTextBox();
            this.jtxPassword = new JTextBox.JTextBox();
            this.jtbPassword = new JMaterialTextbox.JMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 144);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // jtbLogin
            // 
            this.jtbLogin.BackColor = System.Drawing.Color.Transparent;
            this.jtbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.jtbLogin.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.jtbLogin.ForeColors = System.Drawing.Color.Black;
            this.jtbLogin.HintText = null;
            this.jtbLogin.IsPassword = false;
            this.jtbLogin.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jtbLogin.LineThickness = 2;
            this.jtbLogin.Location = new System.Drawing.Point(43, 220);
            this.jtbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jtbLogin.MaxLength = 32767;
            this.jtbLogin.Name = "jtbLogin";
            this.jtbLogin.OnFocusedColor = System.Drawing.Color.Black;
            this.jtbLogin.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jtbLogin.ReadOnly = false;
            this.jtbLogin.Size = new System.Drawing.Size(127, 23);
            this.jtbLogin.TabIndex = 1;
            this.jtbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jtbLogin.TextName = "User Name :";
            // 
            // jfbLoginButton
            // 
            this.jfbLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.jfbLoginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.jfbLoginButton.ButtonText = "    LOGIN";
            this.jfbLoginButton.CausesValidation = false;
            this.jfbLoginButton.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("jfbLoginButton.ErrorImageLeft")));
            this.jfbLoginButton.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("jfbLoginButton.ErrorImageRight")));
            this.jfbLoginButton.FocusBackground = System.Drawing.Color.Empty;
            this.jfbLoginButton.FocusFontColor = System.Drawing.Color.Empty;
            this.jfbLoginButton.ForeColors = System.Drawing.Color.White;
            this.jfbLoginButton.HoverBackground = System.Drawing.Color.Empty;
            this.jfbLoginButton.HoverFontColor = System.Drawing.Color.Empty;
            this.jfbLoginButton.ImageLeft = ((System.Drawing.Image)(resources.GetObject("jfbLoginButton.ImageLeft")));
            this.jfbLoginButton.ImageRight = null;
            this.jfbLoginButton.LeftPictureColor = System.Drawing.Color.Transparent;
            this.jfbLoginButton.Location = new System.Drawing.Point(208, 353);
            this.jfbLoginButton.Name = "jfbLoginButton";
            this.jfbLoginButton.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.jfbLoginButton.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.jfbLoginButton.RightPictureColor = System.Drawing.Color.Transparent;
            this.jfbLoginButton.Size = new System.Drawing.Size(184, 43);
            this.jfbLoginButton.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jfbLoginButton.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.jfbLoginButton.TabIndex = 2;
            this.jfbLoginButton.Click += new System.EventHandler(this.jfbLoginButton_Click);
            // 
            // jtxLogin
            // 
            this.jtxLogin.AutoSize = true;
            this.jtxLogin.BorderColor = System.Drawing.Color.DarkGray;
            this.jtxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jtxLogin.Hint = "";
            this.jtxLogin.IsPassword = false;
            this.jtxLogin.Length = 0;
            this.jtxLogin.Location = new System.Drawing.Point(176, 204);
            this.jtxLogin.Name = "jtxLogin";
            this.jtxLogin.OnFocus = System.Drawing.Color.DarkGray;
            this.jtxLogin.OnlyChar = false;
            this.jtxLogin.OnlyNumber = false;
            this.jtxLogin.Size = new System.Drawing.Size(252, 39);
            this.jtxLogin.TabIndex = 3;
            this.jtxLogin.TextValue = "";
            // 
            // jtxPassword
            // 
            this.jtxPassword.AutoSize = true;
            this.jtxPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.jtxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jtxPassword.Hint = "";
            this.jtxPassword.IsPassword = false;
            this.jtxPassword.Length = 0;
            this.jtxPassword.Location = new System.Drawing.Point(176, 265);
            this.jtxPassword.Name = "jtxPassword";
            this.jtxPassword.OnFocus = System.Drawing.Color.DarkGray;
            this.jtxPassword.OnlyChar = false;
            this.jtxPassword.OnlyNumber = false;
            this.jtxPassword.Size = new System.Drawing.Size(252, 39);
            this.jtxPassword.TabIndex = 4;
            this.jtxPassword.TextValue = "";
            // 
            // jtbPassword
            // 
            this.jtbPassword.BackColor = System.Drawing.Color.Transparent;
            this.jtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.jtbPassword.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.jtbPassword.ForeColors = System.Drawing.Color.Black;
            this.jtbPassword.HintText = null;
            this.jtbPassword.IsPassword = false;
            this.jtbPassword.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jtbPassword.LineThickness = 2;
            this.jtbPassword.Location = new System.Drawing.Point(43, 281);
            this.jtbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jtbPassword.MaxLength = 32767;
            this.jtbPassword.Name = "jtbPassword";
            this.jtbPassword.OnFocusedColor = System.Drawing.Color.Black;
            this.jtbPassword.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jtbPassword.ReadOnly = false;
            this.jtbPassword.Size = new System.Drawing.Size(127, 23);
            this.jtbPassword.TabIndex = 5;
            this.jtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jtbPassword.TextName = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(235, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FORGET PASSWORD?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(434, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 427);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jtbPassword);
            this.Controls.Add(this.jtxPassword);
            this.Controls.Add(this.jtxLogin);
            this.Controls.Add(this.jfbLoginButton);
            this.Controls.Add(this.jtbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox jtbLogin;
        private FlatButton.JFlatButton jfbLoginButton;
        private JTextBox.JTextBox jtxLogin;
        private System.Windows.Forms.Label label2;
        private JMaterialTextbox.JMaterialTextbox jtbPassword;
        private JTextBox.JTextBox jtxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}