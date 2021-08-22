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

namespace CryptApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //
        // Авторизация
        //
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string data = LoginField.Text + ' ' + PassField.Text;

            FileStream DataBase = new FileStream(DataSender.MainDir + ":\\DataBase\\DataDir\\DataBase.txt", FileMode.Open);
            StreamReader data_reader = new StreamReader(DataBase);
            bool data_checker = false;

            while (!data_reader.EndOfStream)
            {
                if (data == data_reader.ReadLine())
                {
                    data_checker = true;
                    break;
                }
            }
            if (data_checker == true)
            {
                this.Hide();
                DataSender.Login = LoginField.Text;
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!\nPlease, try again.");
            }
            data_reader.Close(); 
        }
        //
        //Перемещение окна
        //
        private Point mouse;
        private bool mouse_down = false;

        private void TopOfLoginForm_MouseDown(object sender, MouseEventArgs e)
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
        private void TopOfLoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Point mouse_position = Control.MousePosition;
                mouse_position.Offset(mouse.X, mouse.Y); // метод OffSet смещает точку point на указанное значение
                Location = mouse_position;
            }
        }
        private void TopOfLoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
            }
        }
        // 
        // Выход из окна
        //
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Red;
        }
        private void ExitButon_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.Black;
        }
        //
        // Переход к окну регистрации
        //
        private void Go2Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
        private void Go2Reg_MouseMove(object sender, MouseEventArgs e)
        {
            Go2Reg.ForeColor = Color.Blue;
        }
        private void Go2Reg_MouseLeave(object sender, EventArgs e)
        {
            Go2Reg.ForeColor = Color.Black;
        }
        //        
        // Показать пароль
        //
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                PassField.UseSystemPasswordChar = false;
            }
            if (!ShowPassword.Checked)
            {
                PassField.UseSystemPasswordChar = true;
            }
        }
        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            if (!(LoginField.Text == string.Empty))
            {
                LoginTick.Visible = true;
            }
            else
            if (LoginField.Text == string.Empty)
            {
                LoginTick.Visible = false;
            }
        }
        private void PassField_TextChanged(object sender, EventArgs e)
        {
            if (!(PassField.Text == string.Empty))
            {
                PassTick.Visible = true;
            }
            else
            if (PassField.Text == string.Empty)
            {
                PassTick.Visible = false;
            }
        }
        //
        // При нажатии enter происходит вызов кнопки Login
        //
        private void PassField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
