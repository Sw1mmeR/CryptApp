namespace CryptApp
{
    partial class LoadForm
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.TopOfLoadForm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 50);
            this.ProgressBar.Maximum = 5;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(340, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 0;
            // 
            // TopOfLoadForm
            // 
            this.TopOfLoadForm.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopOfLoadForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopOfLoadForm.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.TopOfLoadForm.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TopOfLoadForm.Location = new System.Drawing.Point(0, 0);
            this.TopOfLoadForm.Name = "TopOfLoadForm";
            this.TopOfLoadForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopOfLoadForm.Size = new System.Drawing.Size(364, 36);
            this.TopOfLoadForm.TabIndex = 41;
            this.TopOfLoadForm.Text = "Loading";
            this.TopOfLoadForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopOfLoadForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopOfLoadForm_MouseDown);
            this.TopOfLoadForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopOfLoadForm_MouseMove);
            this.TopOfLoadForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopOfLoadForm_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 90);
            this.Controls.Add(this.TopOfLoadForm);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label TopOfLoadForm;
        private System.Windows.Forms.Timer timer1;
    }
}