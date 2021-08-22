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
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private bool is_broken = false;

        private void LoadForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                ProgressBar.Value = 0;
                DirectoryInfo new_data_dir = new DirectoryInfo(DataSender.MainDir + ":\\DataBase\\DataDir");
                DirectoryInfo new_user_dir_encoded = new DirectoryInfo(DataSender.MainDir + ":\\DataBase\\UserDir\\root\\Encoded");
                DirectoryInfo new_user_dir_decoded = new DirectoryInfo(DataSender.MainDir + ":\\DataBase\\UserDir\\root\\Decoded");

                new_data_dir.Create();
                ProgressBar.Value++;//

                new_user_dir_encoded.Create();
                ProgressBar.Value++;//

                new_user_dir_decoded.Create();
                ProgressBar.Value++;//

                FileStream DataBase = new FileStream(DataSender.MainDir + ":\\DataBase\\DataDir\\DataBase.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
                StreamWriter data_writer = new StreamWriter(DataBase);

                data_writer.Write("root password");
                ProgressBar.Value++;//
                data_writer.Close();
            }
            catch
            {
                is_broken = true;
                MessageBox.Show("Exit code: 1", "BatCrypt: Error");
            }
            ProgressBar.Value++;//
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_broken == false)
            {
                timer1.Stop();

                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }
            else
            {
                ProgressBar.Value = 0;
                this.Hide();
            }
        }
        //
        //Перемещение окна
        //
        private Point mouse;
        private bool mouse_down = false;

        private void TopOfLoadForm_MouseDown(object sender, MouseEventArgs e)
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
        private void TopOfLoadForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Point mouse_position = Control.MousePosition;
                mouse_position.Offset(mouse.X, mouse.Y); // метод OffSet смещает точку point на указанное значение
                Location = mouse_position;
            }
        }
        private void TopOfLoadForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse_down = false;
            }
        }
        //
    }
}
