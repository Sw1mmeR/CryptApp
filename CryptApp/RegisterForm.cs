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

namespace CryptApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        // Регистрация пользователя
        private void RegisterButton_Click(object sender, EventArgs e)
        {            
            string login = LoginField.Text;
            string data = login + ' ' + PassField.Text;

            FileStream DataBase = new FileStream(DataSender.MainDir + ":\\DataBase\\DataDir\\DataBase.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader data_reader = new StreamReader(DataBase);
            StreamWriter data_writer = new StreamWriter(DataBase);

            bool data_checker = false;
            while (!data_reader.EndOfStream)
            {
                string fileLogin = data_reader.ReadLine().Split(' ')[0];
                if (login == fileLogin)
                {
                    data_checker = false;
                    break;
                }
                if (login != fileLogin)
                {
                    data_checker = true;
                }
            }
            if (data_checker == false)
            {
                MessageBox.Show("This login already exists!", "Information");
            }
            else
            {
                data_writer.Write('\n' + data);
                MessageBox.Show("You have successfully registered!", "Information");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            data_writer.Close();

            string path2create = DataSender.MainDir + $@":\DataBase\UserDir\{login}";
            string directory = Path.GetDirectoryName(path2create);

            string path_login = $@"{login}";
            DirectoryInfo UserDir = new DirectoryInfo(directory);
            UserDir.CreateSubdirectory(path_login);
            UserDir.CreateSubdirectory(path_login + "\\Encoded");
            UserDir.CreateSubdirectory(path_login + "\\Decoded");
        }
        //
        // Оформление окна
        //
        //
        // Выход из окна
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        //Перемещение окна
        //
        private Point mouse;
        private bool mouse_down = false;

        private void TopOfRegisterForm_MouseDown(object sender, MouseEventArgs e)
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
        private void TopOfRegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Point mouse_position = Control.MousePosition;
                mouse_position.Offset(mouse.X, mouse.Y); // метод OffSet смещает точку point на указанное значение
                Location = mouse_position;
            }
        }
        private void TopOfRegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
            }
        }
        //
        //
        // Показать пароль
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
        //
        // Переход к окну входа
        private void Go2Log_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void Go2Log_MouseMove(object sender, MouseEventArgs e)
        {
            Go2Log.ForeColor = Color.Blue;
        }
        private void Go2Log_MouseLeave(object sender, EventArgs e)
        {
            Go2Log.ForeColor = Color.Black;
        }
        //
        // Галочки рядом с полями для ввода данных
        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            bool login_checker = LoginChecker();
            if ((!(LoginField.Text == string.Empty)) && (login_checker == true))
            {
                LoginTick.Visible = true;
            }
            if ((LoginField.Text == string.Empty) || (login_checker == false))
            {
                LoginTick.Visible = false;
            }
            if (LoginField.Text == "")
            {
                LoginTick.Visible = false;
                PassTick.Visible = false;
                RepeatPassTick.Visible = false;

                PassField.Clear();
                RepeatPassField.Clear();
            }
        }
        private void RegPassField_TextChanged(object sender, EventArgs e)
        {
            string pass = PassField.Text;

            if (!(pass == string.Empty))
            {
                PassTick.Visible = true;
                RepeatPassField.BackColor = Color.White;
            }
            if ((pass == string.Empty) || (pass != RepeatPassField.Text))
            {
                RepeatPassTick.Visible = false;
                RepeatPassField.BackColor = Color.FromArgb(233, 93, 110);
            }
            if (pass == RepeatPassField.Text)
            {
                RepeatPassTick.Visible = true;
                RepeatPassField.BackColor = Color.White;
            }
            //for bar
            if (pass == string.Empty)
            {
                PassBar.Value = 0;
            }

            if ((pass.Length >= 3) && (pass.Length < 6))
            {
                PassBar.Value = 3;
            }
            if ((pass.Length >= 6) && (pass.Length < 9))
            {
                PassBar.Value = 6;
            }
            if ((pass.Length >= 9) && (pass.Length < 12))
            {
                PassBar.Value = 9;
            }
            if (pass.Length == 12)
            {
                PassBar.Value = 12;
            }
        }
        // Progress bar
        private void PassField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pass = PassField.Text;
            
            if (pass != string.Empty)
            {                
                if (e.KeyChar == (char)Keys.Back)
                {
                    PassBar.Value--;
                }
            }
        }
        //
        private void RepeatPassField_TextChanged(object sender, EventArgs e)
        {
            string pass = PassField.Text;
            string rep_pass = RepeatPassField.Text;

            if ((rep_pass == pass) && (!(rep_pass == string.Empty)))
            {
                RepeatPassTick.Visible = true;
                RepeatPassField.BackColor = Color.White;
            }
            if (rep_pass == string.Empty)
            {            
                RepeatPassTick.Visible = false;
                RepeatPassField.BackColor = Color.FromArgb(233, 93, 110);
            }
            if (rep_pass != pass)
            {
                RepeatPassTick.Visible = false;
                RepeatPassField.BackColor = Color.FromArgb(233, 93, 110);
            }
        }
        //
        // Видимость кнопки регистрации
        private void LoginTick_VisibleChanged(object sender, EventArgs e)
        {
            if (LoginTick.Visible == false)
            {
                RegisterButton.Visible = false;
                LoginField.BackColor = Color.FromArgb(233, 93, 110);
            }
            else
            {
                LoginField.BackColor = Color.White;
            }

            string login = LoginField.Text;
            if (login == "")
            {
                LoginField.BackColor = Color.White;
            }
            if ((LoginTick.Visible == true) && (PassTick.Visible == true) && (RepeatPassTick.Visible == true))
            {
                RegisterButton.Visible = true;
                LoginField.BackColor = Color.White;
            }
        }
        private void PassTick_VisibleChanged(object sender, EventArgs e)
        {
            if (PassTick.Visible == false)
            {
                RegisterButton.Visible = false;
            }
            if ((LoginTick.Visible == true) && (PassTick.Visible == true) && (RepeatPassTick.Visible == true))
            {
                RegisterButton.Visible = true;
            }
        }
        private void RepeatPassTick_VisibleChanged(object sender, EventArgs e)
        {
            if (RepeatPassTick.Visible == false)
            {
                RegisterButton.Visible = false;
            }
            if ((LoginTick.Visible == true) && (PassTick.Visible == true) && (RepeatPassTick.Visible == true))
            {
                RegisterButton.Visible = true;
            }
        }
        //
        // Проверка на наличие логина в базе данных
        private bool LoginChecker()
        {
            string login = LoginField.Text;

            FileStream DataBase = new FileStream(DataSender.MainDir + ":\\DataBase\\DataDir\\DataBase.txt", FileMode.Open);
            StreamReader data_reader = new StreamReader(DataBase);

            bool login_checker = false;

            while (!data_reader.EndOfStream)
            {
                string fileLogin = data_reader.ReadLine().Split(' ')[0];

                if (login != fileLogin)
                {
                    login_checker = true;
                }
                if (login == fileLogin)
                {
                    login_checker = false;
                    break;
                }
            }
            data_reader.Close();
            return (login_checker);
        }
        //
    }
}
