using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace CryptApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //
        // Нажатие на кнопку шифровать
        //
        private void ActionButton_Click(object sender, EventArgs e)
        {
            Box2Hide.Visible = true;
            string words;
            string key;

            key = KeyBox.Text;
            words = InputBox.Text;

            timer1.Start();            
            try
            {
                if (ChooseCrypt.SelectedIndex == 1)
                {
                    int[] key_num = new int[key.Length];
                    key_num = Convertation.ToNumber(key);

                    int[] words_num = new int[words.Length];
                    words_num = Convertation.ToNumber(words);

                    if (TurnEncode.Checked)
                    {
                        int[] encoded_num = new int[words.Length];
                        encoded_num = Vigener.Encode(words_num, key_num);

                        string encoded = Convertation.ToStr(encoded_num);
                        OutputBox.Text = encoded;
                    }
                    if (TurnDecode.Checked)
                    {
                        int[] decoded_num = new int[words.Length];
                        decoded_num = Vigener.Decode(words_num, key_num);

                        string decoded = Convertation.ToStr(decoded_num);
                        OutputBox.Text = decoded;
                    }
                }
                if (ChooseCrypt.SelectedIndex == 0)
                {
                    int intKey = Convert.ToInt32(key);

                    int[] words_num = new int[words.Length];
                    words_num = Convertation.ToNumber(words);

                    if (TurnEncode.Checked)
                    {
                        int[] encoded_num = new int[words.Length];
                        encoded_num = Caesar.Encode(words_num, intKey);

                        string encoded = Convertation.ToStr(encoded_num);
                        OutputBox.Text = encoded;
                    }
                    if (TurnDecode.Checked)
                    {
                        int[] decoded_num = new int[words.Length];
                        decoded_num = Caesar.Decode(words_num, intKey);

                        string decoded = Convertation.ToStr(decoded_num);
                        OutputBox.Text = decoded;
                    }

                }
                //
                //Progress bar
                //
                progressBar1.Value = 0;
                progressBar1.Maximum = 100;
                for (int i = 0; i < 100; ++i)
                {
                    progressBar1.Value++;
                }
                //
            }
            // Обработчик ошибок при шифровании
            catch
            {
                Application.Exit();
                MessageBox.Show("The application closed with exit code: 2", "BatCrypt: Error");
            }
        }
        //
        // Выход из окна
        //
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure?",
            "Exit", 
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
        }
        //
        // Свап текста в текстбоксах
        //
        private void SwapText_Click(object sender, EventArgs e)
        {
            InputBox.Text = OutputBox.Text;
            OutputBox.Clear();
        }
        //
        // Свечение при наведении на textbox
        //
        private void KeyBox_MouseEnter(object sender, EventArgs e)
        {
            KeyBox.BackColor = Color.Silver;
        }
        private void KeyBox_MouseLeave(object sender, EventArgs e)
        {
            KeyBox.BackColor = Color.DarkGray;
        }
        private void InputBox_MouseEnter(object sender, EventArgs e)
        {
            InputBox.BackColor = Color.Silver;
        }
        private void InputBox_MouseLeave(object sender, EventArgs e)
        {
            InputBox.BackColor = Color.DarkGray;
        }

        private void OutputBox_MouseEnter(object sender, EventArgs e)
        {
            OutputBox.BackColor = Color.Silver;
        }
        private void OutputBox_MouseLeave(object sender, EventArgs e)
        {
            OutputBox.BackColor = Color.DarkGray;
        }
        //
        // Выбрать файл
        //
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileForm file = new OpenFileForm();
                file.ShowDialog();
                InputBox.Text = DataSender.Text;
            }
            // Обработчик ошибок при открытии файла
            catch
            {
                Application.Exit();
                MessageBox.Show("Failed to open file\nError code: 3", "BatCrypt: Error");
            }
        }
        //
        // Сохранить в файл
        //
        private void SaveButton_Click(object sender, EventArgs e)
        {            
            try
            {
                string path = "";
                if (TurnEncode.Checked)
                {
                    path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\Encoded\\" + PathBox.Text + ".txt";
                }
                else if (TurnDecode.Checked)
                {
                    path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\Decoded\\" + PathBox.Text + ".txt";
                }

                FileStream DataBase = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter data_writer = new StreamWriter(DataBase);

                data_writer.Write(OutputBox.Text + '\n');

                data_writer.Close();
                MessageBox.Show("Text successfully saved!", "BatCrypt: Info");
            }
            // Обработчик ошибок сохранения файла
            catch
            {
                MessageBox.Show("Saving failed!\nError code: 4", "BatCrypt: Error");
            }
        }
        //
        //Перемещение окна
        //
        private Point mouse;
        private bool mouse_down = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int x;
            int y;

            if (e.Button == MouseButtons.Left)
            {
                x = -e.X;
                y = -e.Y;
                mouse = new Point(x, y);
                mouse_down = true;
            }
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Point mouse_position = Control.MousePosition;
                mouse_position.Offset(mouse.X, mouse.Y); // метод OffSet смещает точку point на указанное значение
                Location = mouse_position;
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
            }
        }
        //
        // Ввод только определенных символов в поле "ключ"
        //
        private void KeyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(ChooseCrypt.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) // 8 - backspace
                {
                    e.Handled = true; // отменяет обработку элемента
                }
            }
            if (ChooseCrypt.SelectedIndex == 1)
            {
                char letter = e.KeyChar;
                if ((letter < 'А' || letter > 'я') && letter != '\b' && letter != Convert.ToChar(8)) // \b - как работает?
                {
                    e.Handled = true; // отменяет обработку элемента
                }
            }
        }
        private void ChooseCrypt_SelectedValueChanged(object sender, EventArgs e)
        {
            KeyBox.ReadOnly = false;
        }
        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            if (ChooseCrypt.SelectedIndex == 0)
            {
                if (KeyBox.Text != "")
                {
                    if (int.Parse(KeyBox.Text) > 33)
                    {
                        MessageBox.Show("Too big number!");
                        KeyBox.Clear();
                    }
                }
            }        
        }
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Box2Hide.Visible = true;
            progressBar1.Value = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Box2Hide.Visible = false;
            timer1.Stop();
        }
        //
        // Сменить пользователя
        //
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }
        private void LogoutButton_MouseEnter(object sender, EventArgs e)
        {
            LogoutButton.ForeColor = Color.Blue;
        }
        private void LogoutButton_MouseLeave(object sender, EventArgs e)
        {
            LogoutButton.ForeColor = Color.Black;
        }
        //
    }
}