using OfficeLogistics.officelogisticsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeLogistics
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
        }

        public int idUser = 0;

        int count = 0;
        int role = 0;

        public void LogIn(string login, string password)
        {
            DateTime dt = DateTime.Now;
            string timeString = dt.ToLongTimeString();

            string log, pass;

            log = login;
            pass = password;

            // Init simulation adapters

            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            officelogisticsDataSet.UsersDataTable dataUsers = usersTableAdapter.GetData();

            var filter = dataUsers.Where(rec => rec.Login == log && rec.Password == pass);

            if (filter.Count() == 0)
            {
                count++;
                Blocker(count);
            }

            try
            {
                int idRole = Convert.ToInt32(filter.ElementAt(0).Role); // находит роль в фильтре
                role = idRole;

                idUser = filter.ElementAt(0).ID;
            }
            catch
            {
                MessageBox.Show("Ошибка в истории авторизации");
            }

            roleSender(role);
        }

        public void roleSender(int roles)
        {
            roles = role;

            if (role == 1)
            {
                AdminPanel adminPanel = new AdminPanel(idUser);
                adminPanel.Show();
            }
            else
            {
                if (role == 2)
                {
                    Shelfs shelfs = new Shelfs(idUser);
                    shelfs.Show();
                }
            }
        }

        private void goAuth_Click(object sender, EventArgs e)
        {
            LogIn(log.Text, pass.Text);
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                pass.PasswordChar = '\0';
            }
            else
            {
                pass.PasswordChar = '*';
            }
        }

        private void Blocker(int mistakes)
        {
            if (mistakes == 3)
            {
                log.Enabled = false;
                pass.Enabled = false;
                goAuth.Enabled = false;

                Thread.Sleep(15000);

                log.Enabled = true;
                pass.Enabled = true;
                goAuth.Enabled = true;
            }

            if (mistakes == 4)
            {
                log.Enabled = false;
                pass.Enabled = false;
                goAuth.Enabled = false;

                Thread.Sleep(20000);

                log.Enabled = true;
                pass.Enabled = true;
                goAuth.Enabled = true;
            }

            if (mistakes == 5)
            {
                MessageBox.Show("Вы превысили допустимый лимит попыток входа, текущая сессия будет завершена", "OfficeLogistics", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
