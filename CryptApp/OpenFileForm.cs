using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApp
{
    public partial class OpenFileForm : Form
    {
        public OpenFileForm()
        {
            InitializeComponent();
        }
        //
        //Загрузка списка файлов в listbox
        //
        private void OpenFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                string path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login;
                FileBox.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(path);

                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo current_dir in dirs)
                {
                    FileBox.Items.Add(current_dir);
                }

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo current_file in files)
                {
                    FileBox.Items.Add(current_file);
                }
            }
            catch
            {
                MessageBox.Show("Failed to open file\nError code: 3", "BatCrypt: Error");
            }
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
        // Открываем папки
        //
        private static string dir_path;
        private void FileBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FileBox.SelectedItems.Count != 0)
            {
                if (Path.GetExtension((DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login +
                "\\Encoded\\" + FileBox.SelectedItem.ToString())) == "")
                {
                    dir_path = FileBox.SelectedItem.ToString();

                    DirectoryInfo dir = new DirectoryInfo(Path.Combine(DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login, FileBox.SelectedItem.ToString()));

                    FileBox.Items.Clear();

                    DirectoryInfo[] dirs = dir.GetDirectories();

                    foreach (DirectoryInfo current_dir in dirs)
                    {
                        FileBox.Items.Add(current_dir);
                    }

                    FileInfo[] files = dir.GetFiles();

                    foreach (FileInfo current_file in files)
                    {
                        FileBox.Items.Add(current_file);
                    }
                }
            }
        }    
        private void BackButton_Click(object sender, EventArgs e)
        {
            string path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login;
            FileBox.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(path);

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo current_dir in dirs)
            {
                FileBox.Items.Add(current_dir);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo current_file in files)
            {
                FileBox.Items.Add(current_file);
            }
        }
        //
        // Выбор файла
        //
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (FileBox.SelectedItems.Count != 0)
            {
                if (Path.GetExtension((DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\" 
                    + FileBox.SelectedItem.ToString())) != "") //Выполнить только если есть расширение
                {
                    if (dir_path != "")
                    {
                        string path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\" +
                        "\\" + dir_path + "\\" + FileBox.SelectedItem.ToString();
                        dir_path = "";
                        string s = File.ReadAllText(path);
                        DataSender.Text = s;

                        this.Close();
                    }
                }                
            }
        }
        //
        // Удаление файла
        //
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure?",
            "File manager",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                if (Path.GetExtension((DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\"
                  + FileBox.SelectedItem.ToString())) != "") //Выполнить только если есть расширение
                {
                    if (dir_path != "")
                    {
                        string path = DataSender.MainDir + ":\\DataBase\\UserDir\\" + DataSender.Login + "\\" +
                        "\\" + dir_path + "\\" + FileBox.SelectedItem.ToString();
                        dir_path = "";
                        File.Delete(path);

                        MessageBox.Show("File deleted!", "BatCrypt: File manager");
                    }
                }
            }            
        }
        // 
        // Выход из окна
        //
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}