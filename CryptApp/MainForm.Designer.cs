namespace CryptApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.TurnEncode = new System.Windows.Forms.RadioButton();
            this.TurnDecode = new System.Windows.Forms.RadioButton();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.OpenButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseCrypt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.Box2Hide = new System.Windows.Forms.RichTextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.SwapText = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Label();
            this.ActionPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwapText)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.DarkGray;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBox.Location = new System.Drawing.Point(11, 147);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(370, 154);
            this.InputBox.TabIndex = 13;
            this.InputBox.Text = "";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.InputBox.MouseEnter += new System.EventHandler(this.InputBox_MouseEnter);
            this.InputBox.MouseLeave += new System.EventHandler(this.InputBox_MouseLeave);
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.ActionButton.Location = new System.Drawing.Point(708, 382);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(104, 42);
            this.ActionButton.TabIndex = 15;
            this.ActionButton.Text = "Count";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // TurnEncode
            // 
            this.TurnEncode.AutoSize = true;
            this.TurnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnEncode.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnEncode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TurnEncode.Location = new System.Drawing.Point(3, 3);
            this.TurnEncode.Name = "TurnEncode";
            this.TurnEncode.Size = new System.Drawing.Size(95, 30);
            this.TurnEncode.TabIndex = 5;
            this.TurnEncode.TabStop = true;
            this.TurnEncode.Text = "Encode";
            this.TurnEncode.UseVisualStyleBackColor = true;
            // 
            // TurnDecode
            // 
            this.TurnDecode.AutoSize = true;
            this.TurnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnDecode.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnDecode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TurnDecode.Location = new System.Drawing.Point(104, 3);
            this.TurnDecode.Name = "TurnDecode";
            this.TurnDecode.Size = new System.Drawing.Size(97, 30);
            this.TurnDecode.TabIndex = 6;
            this.TurnDecode.TabStop = true;
            this.TurnDecode.Text = "Decode";
            this.TurnDecode.UseVisualStyleBackColor = true;
            // 
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.TurnDecode);
            this.ActionPanel.Controls.Add(this.TurnEncode);
            this.ActionPanel.Controls.Add(this.OpenButton);
            this.ActionPanel.Location = new System.Drawing.Point(11, 302);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(370, 42);
            this.ActionPanel.TabIndex = 18;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold);
            this.OpenButton.Location = new System.Drawing.Point(266, 5);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(104, 30);
            this.OpenButton.TabIndex = 66;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(11, 350);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // KeyBox
            // 
            this.KeyBox.BackColor = System.Drawing.Color.DarkGray;
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.Location = new System.Drawing.Point(14, 78);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.ReadOnly = true;
            this.KeyBox.Size = new System.Drawing.Size(180, 29);
            this.KeyBox.TabIndex = 20;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            this.KeyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBox_KeyPress);
            this.KeyBox.MouseEnter += new System.EventHandler(this.KeyBox_MouseEnter);
            this.KeyBox.MouseLeave += new System.EventHandler(this.KeyBox_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(196, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Encoding";
            // 
            // ChooseCrypt
            // 
            this.ChooseCrypt.BackColor = System.Drawing.Color.DarkGray;
            this.ChooseCrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseCrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCrypt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCrypt.FormattingEnabled = true;
            this.ChooseCrypt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChooseCrypt.Items.AddRange(new object[] {
            "Caesar",
            "Vigener"});
            this.ChooseCrypt.Location = new System.Drawing.Point(200, 78);
            this.ChooseCrypt.Name = "ChooseCrypt";
            this.ChooseCrypt.Size = new System.Drawing.Size(180, 30);
            this.ChooseCrypt.TabIndex = 22;
            this.ChooseCrypt.SelectedValueChanged += new System.EventHandler(this.ChooseCrypt_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(442, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Converted text";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(824, 30);
            this.TopPanel.TabIndex = 28;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CryptApp.Properties.Resources.batman;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(38, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "BatCrypt";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(790, -16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 46);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "x";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 406);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(819, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 406);
            this.panel3.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 5);
            this.panel4.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 63;
            this.label5.Text = "Enter text";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Palatino Linotype", 10.5F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(447, 307);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 30);
            this.SaveButton.TabIndex = 65;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Text.txt";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.DarkGray;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBox.Location = new System.Drawing.Point(445, 147);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(367, 150);
            this.OutputBox.TabIndex = 27;
            this.OutputBox.Text = "";
            this.OutputBox.MouseEnter += new System.EventHandler(this.OutputBox_MouseEnter);
            this.OutputBox.MouseLeave += new System.EventHandler(this.OutputBox_MouseLeave);
            // 
            // Box2Hide
            // 
            this.Box2Hide.BackColor = System.Drawing.Color.DarkGray;
            this.Box2Hide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box2Hide.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box2Hide.Location = new System.Drawing.Point(445, 147);
            this.Box2Hide.Name = "Box2Hide";
            this.Box2Hide.ReadOnly = true;
            this.Box2Hide.Size = new System.Drawing.Size(367, 154);
            this.Box2Hide.TabIndex = 68;
            this.Box2Hide.Text = "";
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.DarkGray;
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathBox.Location = new System.Drawing.Point(557, 306);
            this.PathBox.Multiline = true;
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(255, 30);
            this.PathBox.TabIndex = 70;
            this.PathBox.Text = "file";
            // 
            // SwapText
            // 
            this.SwapText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwapText.Image = global::CryptApp.Properties.Resources.Arrow;
            this.SwapText.Location = new System.Drawing.Point(387, 198);
            this.SwapText.Name = "SwapText";
            this.SwapText.Size = new System.Drawing.Size(54, 50);
            this.SwapText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwapText.TabIndex = 64;
            this.SwapText.TabStop = false;
            this.SwapText.Click += new System.EventHandler(this.SwapText_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoSize = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoutButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LogoutButton.Location = new System.Drawing.Point(743, 30);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(76, 26);
            this.LogoutButton.TabIndex = 73;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseEnter += new System.EventHandler(this.LogoutButton_MouseEnter);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 436);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.Box2Hide);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SwapText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseCrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwapText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.RadioButton TurnEncode;
        private System.Windows.Forms.RadioButton TurnDecode;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChooseCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox SwapText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Box2Hide;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label LogoutButton;
    }
}