using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Storage
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Hide();
            Registration reg = new Registration();
            reg.ShowDialog();
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            GoodList auth = new GoodList();
            auth.ShowDialog();
            Close();
        }

        bool checkErrors(ref bool invalidLoginLen, ref bool invalidPasswordLen, ref bool loginNotExisting, ref bool wrongPassword)
        {
            bool res = false;



            return res;
        }

        private void showErrors(bool invalidLoginLen, bool invalidPasswordLen, bool loginNotExisting, bool wrongPassword)
        {
            string errorMsgLoginInvalid = "Логин должен быть длиной 5-30 символов!";
            string errorMsgPasswordInvalid = "Пароль должен быть длиной 5-20 символов!";
            string errorMsgLoginNotExisting = "Пользователь с данным логином не существует!";
            string errorMsgWrongPassword = "Неверный пароль!";
            string errorMsgFull = "";

            panelErrors.Enabled = true;



            if (invalidLoginLen && invalidPasswordLen)
                errorMsgFull += errorMsgLoginInvalid + '\n' + errorMsgPasswordInvalid;
            else
            {
                if (invalidLoginLen)
                    errorMsgFull = errorMsgLoginInvalid;
                if (invalidPasswordLen)
                    errorMsgFull = errorMsgPasswordInvalid;
            }
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            String userLogin = textBoxLogin.Text;
            String userPassword = textBoxPassword.Text;

            bool loginTextboxesValid = true;

            if(userLogin.Length < 5)
            {
                labelLoginLen.Text = "Длина 5-20 символов!";
                labelLoginLen.ForeColor = Color.Crimson;
                loginTextboxesValid = false;
            }
            else
            {
                labelLoginLen.Text = "Длина 5-20 символов";
                labelLoginLen.ForeColor = Color.Black;
            }

            if(userPassword.Length < 5)
            {
                labelPasswordLen.Text = "Длина 5-20 символов!";
                labelPasswordLen.ForeColor = Color.Crimson;
                loginTextboxesValid = false;
            }
            else 
            {
                labelPasswordLen.Text = "Длина 5-20 символов";
                labelPasswordLen.ForeColor = Color.Black;
            }

            if(loginTextboxesValid)
            {
                using (var db = new PIS_DbContext())
                {
                    List<User> currUser = (from user in db.Users
                                           where user.Login == userLogin
                                           select user).ToList();
                    if(currUser.Count == 0)
                    {
                        labelLoginLen.Text = "Пользователь с данным логином не существует!";
                        labelLoginLen.ForeColor = Color.Crimson;
                    }
                    else
                    {
                        User currentUser = currUser.First<User>();

                        if (currentUser.Password == userPassword)
                        {
                            // singleton.currentuser = currentuser;

                            // Переход на начальный экран

                            Hide();
                            switch (currentUser.Status)
                            {
                                case 0:
                                    {
                                        UserStartScreen uStartScreen = new UserStartScreen();
                                        uStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }

                                case 1:
                                    {
                                        ManagerStartScreen mStartScreen = new ManagerStartScreen();
                                        mStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }
                                case 2:
                                    {
                                        AdminStartScreen aStartScreen = new AdminStartScreen();
                                        aStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }
                                default:
                                    {
                                        UserStartScreen uStartScreen = new UserStartScreen();
                                        uStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            labelPasswordLen.Text = "Неверный пароль!";
                            labelPasswordLen.ForeColor = Color.Crimson;
                        }
                    }
                }
            }
        }

    }
}
