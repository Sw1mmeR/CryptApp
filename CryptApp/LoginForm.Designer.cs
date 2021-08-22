namespace CryptApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Go2Reg = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopOfLoginForm = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassTick = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginTick = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ShowPassword.Location = new System.Drawing.Point(93, 353);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(148, 26);
            this.ShowPassword.TabIndex = 47;
            this.ShowPassword.Text = "Show password";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Go2Reg
            // 
            this.Go2Reg.BackColor = System.Drawing.Color.Transparent;
            this.Go2Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go2Reg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go2Reg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Go2Reg.Location = new System.Drawing.Point(0, 479);
            this.Go2Reg.Name = "Go2Reg";
            this.Go2Reg.Size = new System.Drawing.Size(500, 22);
            this.Go2Reg.TabIndex = 46;
            this.Go2Reg.Text = "No account yet?";
            this.Go2Reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Go2Reg.Click += new System.EventHandler(this.Go2Reg_Click);
            this.Go2Reg.MouseLeave += new System.EventHandler(this.Go2Reg_MouseLeave);
            this.Go2Reg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Go2Reg_MouseMove);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(3)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.Location = new System.Drawing.Point(170, 436);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 40);
            this.LoginButton.TabIndex = 45;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(87, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Enter password";
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(93, 290);
            this.PassField.MaxLength = 20;
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(300, 57);
            this.PassField.TabIndex = 42;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.TextChanged += new System.EventHandler(this.PassField_TextChanged);
            this.PassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassField_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(87, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter login";
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(93, 161);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(300, 57);
            this.LoginField.TabIndex = 37;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(495, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 450);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 450);
            this.panel2.TabIndex = 59;
            // 
            // TopOfLoginForm
            // 
            this.TopOfLoginForm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopOfLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOfLoginForm.Font = new System.Drawing.Font("Palatino Linotype", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopOfLoginForm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TopOfLoginForm.Location = new System.Drawing.Point(0, 0);
            this.TopOfLoginForm.Name = "TopOfLoginForm";
            this.TopOfLoginForm.Size = new System.Drawing.Size(500, 60);
            this.TopOfLoginForm.TabIndex = 60;
            this.TopOfLoginForm.Text = "Login";
            this.TopOfLoginForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopOfLoginForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseDown);
            this.TopOfLoginForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseMove);
            this.TopOfLoginForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseUp);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(469, -12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 46);
            this.ExitButton.TabIndex = 61;
            this.ExitButton.Text = "x";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButon_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 5);
            this.panel3.TabIndex = 62;
            // 
            // PassTick
            // 
            this.PassTick.BackColor = System.Drawing.Color.Transparent;
            this.PassTick.Image = global::CryptApp.Properties.Resources.Tick;
            this.PassTick.Location = new System.Drawing.Point(399, 290);
            this.PassTick.Name = "PassTick";
            this.PassTick.Size = new System.Drawing.Size(60, 57);
            this.PassTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassTick.TabIndex = 44;
            this.PassTick.TabStop = false;
            this.PassTick.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CryptApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(27, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // LoginTick
            // 
            this.LoginTick.BackColor = System.Drawing.Color.Transparent;
            this.LoginTick.Image = global::CryptApp.Properties.Resources.Tick;
            this.LoginTick.Location = new System.Drawing.Point(399, 161);
            this.LoginTick.Name = "LoginTick";
            this.LoginTick.Size = new System.Drawing.Size(60, 57);
            this.LoginTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginTick.TabIndex = 40;
            this.LoginTick.TabStop = false;
            this.LoginTick.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CryptApp.Properties.Resources.userI;
            this.pictureBox1.Location = new System.Drawing.Point(27, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox3.Image = global::CryptApp.Properties.Resources.batman;
            this.pictureBox3.Location = new System.Drawing.Point(134, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 64;
            this.label6.Text = "BatCrypt";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopOfLoginForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassTick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginTick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Go2Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.PassTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label Go2Reg;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox PassTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox LoginTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TopOfLoginForm;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox LoginField;
    }
}