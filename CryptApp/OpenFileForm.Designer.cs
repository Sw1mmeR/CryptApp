namespace CryptApp
{
    partial class OpenFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFileForm));
            this.TopOfLoginForm = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FileBox = new System.Windows.Forms.ListBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TopOfLoginForm
            // 
            this.TopOfLoginForm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopOfLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOfLoginForm.Font = new System.Drawing.Font("Palatino Linotype", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopOfLoginForm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TopOfLoginForm.Location = new System.Drawing.Point(0, 0);
            this.TopOfLoginForm.Name = "TopOfLoginForm";
            this.TopOfLoginForm.Size = new System.Drawing.Size(348, 53);
            this.TopOfLoginForm.TabIndex = 61;
            this.TopOfLoginForm.Text = "Choose file";
            this.TopOfLoginForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopOfLoginForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseDown);
            this.TopOfLoginForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseMove);
            this.TopOfLoginForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopOfLoginForm_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox3.Image = global::CryptApp.Properties.Resources.batman;
            this.pictureBox3.Location = new System.Drawing.Point(9, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // FileBox
            // 
            this.FileBox.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.FileBox.FormattingEnabled = true;
            this.FileBox.ItemHeight = 26;
            this.FileBox.Location = new System.Drawing.Point(12, 56);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(324, 186);
            this.FileBox.TabIndex = 65;
            this.FileBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileBox_MouseDoubleClick);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold);
            this.OpenButton.Location = new System.Drawing.Point(232, 247);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(104, 30);
            this.OpenButton.TabIndex = 67;
            this.OpenButton.Text = "Ok";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(317, -12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 46);
            this.ExitButton.TabIndex = 68;
            this.ExitButton.Text = "x";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButon_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 236);
            this.panel2.TabIndex = 69;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(343, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 236);
            this.panel3.TabIndex = 70;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 5);
            this.panel4.TabIndex = 71;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(12, 247);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 30);
            this.BackButton.TabIndex = 72;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.Location = new System.Drawing.Point(122, 247);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 30);
            this.DeleteButton.TabIndex = 73;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 289);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TopOfLoginForm);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenFileForm";
            this.Load += new System.EventHandler(this.OpenFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopOfLoginForm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox FileBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}