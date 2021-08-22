namespace CryptApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Go2Log = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatPassField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopOfRegisterForm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RepeatPassTick = new System.Windows.Forms.PictureBox();
            this.PassTick = new System.Windows.Forms.PictureBox();
            this.LoginTick = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PassBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPassTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Go2Log
            // 
            this.Go2Log.BackColor = System.Drawing.Color.Transparent;
            this.Go2Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go2Log.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go2Log.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Go2Log.Location = new System.Drawing.Point(-3, 473);
            this.Go2Log.Name = "Go2Log";
            this.Go2Log.Size = new System.Drawing.Size(500, 37);
            this.Go2Log.TabIndex = 54;
            this.Go2Log.Text = "I already have an account";
            this.Go2Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Go2Log.Click += new System.EventHandler(this.Go2Log_Click);
            this.Go2Log.MouseLeave += new System.EventHandler(this.Go2Log_MouseLeave);
            this.Go2Log.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Go2Log_MouseMove);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowPassword.Location = new System.Drawing.Point(102, 287);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(148, 26);
            this.ShowPassword.TabIndex = 53;
            this.ShowPassword.Text = "Show password";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(3)))));
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(106)))), ((int)(((byte)(2)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegisterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegisterButton.Location = new System.Drawing.Point(174, 428);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(150, 40);
            this.RegisterButton.TabIndex = 49;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Visible = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(96, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 48;
            this.label7.Text = "Repeat password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(96, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Enter login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(96, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Enter login";
            // 
            // RepeatPassField
            // 
            this.RepeatPassField.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassField.Location = new System.Drawing.Point(102, 365);
            this.RepeatPassField.Name = "RepeatPassField";
            this.RepeatPassField.Size = new System.Drawing.Size(300, 57);
            this.RepeatPassField.TabIndex = 45;
            this.RepeatPassField.UseSystemPasswordChar = true;
            this.RepeatPassField.TextChanged += new System.EventHandler(this.RepeatPassField_TextChanged);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(102, 208);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(300, 57);
            this.PassField.TabIndex = 43;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.TextChanged += new System.EventHandler(this.RegPassField_TextChanged);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(102, 104);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(300, 57);
            this.LoginField.TabIndex = 41;
            this.LoginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(96, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Enter password";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(469, -13);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 46);
            this.ExitButton.TabIndex = 56;
            this.ExitButton.Text = "x";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(495, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 450);
            this.panel1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 450);
            this.panel2.TabIndex = 58;
            // 
            // TopOfRegisterForm
            // 
            this.TopOfRegisterForm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopOfRegisterForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOfRegisterForm.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Bold);
            this.TopOfRegisterForm.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TopOfRegisterForm.Location = new System.Drawing.Point(0, 0);
            this.TopOfRegisterForm.Name = "TopOfRegisterForm";
            this.TopOfRegisterForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopOfRegisterForm.Size = new System.Drawing.Size(500, 60);
            this.TopOfRegisterForm.TabIndex = 1;
            this.TopOfRegisterForm.Text = "Registration";
            this.TopOfRegisterForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopOfRegisterForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopOfRegisterForm_MouseDown);
            this.TopOfRegisterForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopOfRegisterForm_MouseMove);
            this.TopOfRegisterForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopOfRegisterForm_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 5);
            this.panel3.TabIndex = 59;
            // 
            // RepeatPassTick
            // 
            this.RepeatPassTick.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPassTick.Image = global::CryptApp.Properties.Resources.Tick;
            this.RepeatPassTick.Location = new System.Drawing.Point(408, 365);
            this.RepeatPassTick.Name = "RepeatPassTick";
            this.RepeatPassTick.Size = new System.Drawing.Size(60, 57);
            this.RepeatPassTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RepeatPassTick.TabIndex = 52;
            this.RepeatPassTick.TabStop = false;
            this.RepeatPassTick.Visible = false;
            this.RepeatPassTick.VisibleChanged += new System.EventHandler(this.RepeatPassTick_VisibleChanged);
            // 
            // PassTick
            // 
            this.PassTick.BackColor = System.Drawing.Color.Transparent;
            this.PassTick.Image = global::CryptApp.Properties.Resources.Tick;
            this.PassTick.Location = new System.Drawing.Point(408, 208);
            this.PassTick.Name = "PassTick";
            this.PassTick.Size = new System.Drawing.Size(60, 57);
            this.PassTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassTick.TabIndex = 51;
            this.PassTick.TabStop = false;
            this.PassTick.Visible = false;
            this.PassTick.VisibleChanged += new System.EventHandler(this.PassTick_VisibleChanged);
            // 
            // LoginTick
            // 
            this.LoginTick.BackColor = System.Drawing.Color.Transparent;
            this.LoginTick.Image = global::CryptApp.Properties.Resources.Tick;
            this.LoginTick.Location = new System.Drawing.Point(408, 104);
            this.LoginTick.Name = "LoginTick";
            this.LoginTick.Size = new System.Drawing.Size(60, 57);
            this.LoginTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginTick.TabIndex = 50;
            this.LoginTick.TabStop = false;
            this.LoginTick.Visible = false;
            this.LoginTick.VisibleChanged += new System.EventHandler(this.LoginTick_VisibleChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CryptApp.Properties.Resources._lock;
            this.pictureBox4.Location = new System.Drawing.Point(36, 365);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CryptApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(36, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CryptApp.Properties.Resources.userI;
            this.pictureBox1.Location = new System.Drawing.Point(36, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox3.Image = global::CryptApp.Properties.Resources.batman;
            this.pictureBox3.Location = new System.Drawing.Point(91, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 65;
            this.label6.Text = "BatCrypt";
            // 
            // PassBar
            // 
            this.PassBar.Location = new System.Drawing.Point(102, 271);
            this.PassBar.MarqueeAnimationSpeed = 1000;
            this.PassBar.Maximum = 12;
            this.PassBar.Name = "PassBar";
            this.PassBar.Size = new System.Drawing.Size(300, 10);
            this.PassBar.Step = 1;
            this.PassBar.TabIndex = 66;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 510);
            this.Controls.Add(this.PassBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.RepeatPassTick);
            this.Controls.Add(this.PassTick);
            this.Controls.Add(this.LoginTick);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepeatPassField);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopOfRegisterForm);
            this.Controls.Add(this.Go2Log);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPassTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Go2Log;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.PictureBox RepeatPassTick;
        private System.Windows.Forms.PictureBox PassTick;
        private System.Windows.Forms.PictureBox LoginTick;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RepeatPassField;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TopOfRegisterForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PassBar;
    }
}