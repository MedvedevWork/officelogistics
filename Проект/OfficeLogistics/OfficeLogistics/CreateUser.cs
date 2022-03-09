using OfficeLogistics.officelogisticsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeLogistics
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void goCreate_Click(object sender, EventArgs e)
        {
            if (password.Text == confirmpass.Text)
            {
                SignUp(login.Text, password.Text, Convert.ToInt32(role.Text));
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }

        public void SignUp(string login, string password, int roleID)
        {
            string log, pass; 
            int role;

            log = login;
            pass = password;
            role = roleID;

            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Не все поля заполнены"); 
                return;
            }

            int pos = log.IndexOf('@');

            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ @"); 
                return;
            }

            pos = log.IndexOf('.');

            if (pos < 0)
            {
                MessageBox.Show("Вы не указали почту"); 
                return;
            }

            if (pass.Length < 6) // длина пароля
            {
                MessageBox.Show("Password is too short");
                return;
            }

            for (int i = 0; i < pass.Length; i++) // проверка на латиницу
            {
                if (!(Char.IsDigit(pass[i]) || pass[i] >= 'a' && pass[i] <= 'z' || pass[i] >= 'A' && pass[i] <= 'Z'))
                {
                    MessageBox.Show("Пароль должен содержать только латинские символы");
                    return;
                }
            }

            int countNum = 0;

            for (int c = 0; c < pass.Length; c++)
            {
                if (pass[c] >= '0' && pass[c] <= '9')
                {
                    countNum++;
                }
            }

            if (countNum == 0)
            {
                MessageBox.Show("В пароле отсутствует цифра"); 
            }

            string[] servers = new string[5];

            int servercheck = 0;

            servers[0] = "gmail.com";
            servers[1] = "yahoo.com";
            servers[2] = "officelogistics.com";
            servers[3] = "outlook.com";
            servers[4] = "hotmail.com";

            string[] echeck = log.Split('@');

            for (int i = 0; i < 5; i++)
            {
                if (echeck[1] == servers[i])
                {
                    servercheck = 1;
                }
            }

            if (servercheck == 0)
            {
                return;
            }

   
            if (this.role.Text == "Администратор")
            {
                role = 1;
            }
            else
            {
                if (this.role.Text == "Грузчик")
                {
                    role = 2;
                }
                else
                {
                    MessageBox.Show("Роль не была выбрана");
                }
            }

            officelogisticsDataSet.UsersDataTable dataUsers = usersTableAdapter1.GetData();

            try
            {
                usersTableAdapter1.Insert(dataUsers.Count() + 1, login, password, role); // Role 2 porter
                MessageBox.Show("Пользователь добавлен");
            }
            catch
            {
                MessageBox.Show("Проверьте верность введённых данных");
            }
        }
    }
}
