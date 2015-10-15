namespace ProjectManager
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.ErorMes = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я користувача:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Посада";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(114, 186);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(121, 20);
            this.UserName.TabIndex = 4;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(114, 212);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(121, 20);
            this.UserLogin.TabIndex = 5;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(114, 238);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(121, 20);
            this.UserPassword.TabIndex = 6;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "SCRUM-майстер",
            "Програміст",
            "Дизайнер",
            "Замовник"});
            this.comboBoxPost.Location = new System.Drawing.Point(114, 264);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPost.TabIndex = 7;
            // 
            // ErorMes
            // 
            this.ErorMes.AutoSize = true;
            this.ErorMes.Location = new System.Drawing.Point(27, 122);
            this.ErorMes.Name = "ErorMes";
            this.ErorMes.Size = new System.Drawing.Size(0, 13);
            this.ErorMes.TabIndex = 8;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(55, 314);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(121, 23);
            this.Register.TabIndex = 9;
            this.Register.Text = "Зареєструватися";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 164);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ErorMes);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "FormRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Label ErorMes;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}