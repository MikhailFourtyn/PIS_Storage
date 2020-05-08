using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Storage
{
    public partial class Registration : Form
    {
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public Registration()
        {
            InitializeComponent();

            InitFormParams();
        }

        private void buttonReturnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                string inputName = textBoxName.Text;
                string inputLogin = textBoxLogin.Text;
                string inputPassword = textBoxPassword.Text;
                string inputPassCheck = textBoxPasswordCheck.Text;
                
                // Проверка допустимой заполненности всех полей
                bool loginTextboxesValid = checkTextboxes(ref inputName, ref inputLogin, ref inputPassword, ref inputPassCheck);

                if(loginTextboxesValid)
                {
                    User reg = db.Users.SingleOrDefault(u => u.Login == inputLogin);

                    if (reg != null)
                    {
                        // Пользователь с таким логином уже зарегистрирован
                        labelLoginLen.Text = "Данный логин уже занят! Введите другой";
                        labelLoginLen.ForeColor = Color.Crimson;
                    }
                    else
                    {
                        // Заполнение нового пользователя
                        // Статус по умолчанию - обычный пользователь
                        reg = new User()
                        {
                            Name = inputName,
                            Login = inputLogin,
                            Password = inputPassword,
                            Status = 0
                        };

                        // Занесение нового пользователя в БД
                        db.Users.Add(reg);
                        db.SaveChanges();

                        // Переход на стартовую страницу пользователя
                        Hide();
                        UserStartScreen uStartScreen = new UserStartScreen();
                        uStartScreen.ShowDialog();
                        Close();
                    }
                }
            }
        }

        bool checkTextboxes(ref string name, ref string login, ref string password, ref string passCheck)
        {
            bool res = true;

            if (name.Length < 5)
            {
                labelLoginLen.Text = "Длина 5-80 символов!";
                labelLoginLen.ForeColor = Color.Crimson;
                res = false;
            }
            else
            {
                labelLoginLen.Text = "Длина 5-80 символов";
                labelLoginLen.ForeColor = Color.Black;
            }

            if (login.Length < 5)
            {
                labelLoginLen.Text = "Длина 5-20 символов!";
                labelLoginLen.ForeColor = Color.Crimson;
                res = false;
            }
            else
            {
                labelLoginLen.Text = "Длина 5-20 символов";
                labelLoginLen.ForeColor = Color.Black;
            }

            if (password.Length < 5)
            {
                labelPasswordLen.Text = "Длина 5-20 символов!";
                labelPasswordLen.ForeColor = Color.Crimson;
                res = false;
            }
            else
            {
                labelPasswordLen.Text = "Длина 5-20 символов";
                labelPasswordLen.ForeColor = Color.Black;
            }

            if (passCheck != password)
            {
                labelPasswordLen.Text = "Пароли не совпадают!";
                res = false;
            }
            else
            {
                labelPasswordLen.Text = "";
            }

            return res;
        }
    }
}
