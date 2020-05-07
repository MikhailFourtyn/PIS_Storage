﻿using System;
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

        bool checkTextboxes(ref string userLogin, ref string userPassword)
        {
            bool res = true;

            if (userLogin.Length < 5)
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

            if (userPassword.Length < 5)
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

            return res;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string userLogin = textBoxLogin.Text;
            string userPassword = textBoxPassword.Text;

            // Проверка допустимой заполненности всех полей
            bool loginTextboxesValid = checkTextboxes(ref userLogin, ref userPassword);

            if(loginTextboxesValid)
            {
                using (var db = new PIS_DbContext())
                {
                    List<User> currUserList = (from user in db.Users
                                           where user.Login == userLogin
                                           select user).ToList();

                    // Пользователь с данным логином не найден => его не существует
                    if(currUserList.Count == 0)
                    {
                        labelLoginLen.Text = "Пользователь с данным логином не существует!";
                        labelLoginLen.ForeColor = Color.Crimson;
                    }
                    else
                    {
                        User currentUser = currUserList.First<User>();

                        if (currentUser.Password == userPassword)
                        {
                            // Заполнение текущего пользователя
                            CurrentUser current = new CurrentUser(currentUser);

                            // Переход на начальный экран пользователя

                            Hide();
                            switch (currentUser.Status)
                            {
                                // Пользователь
                                case 0:
                                    {
                                        UserStartScreen uStartScreen = new UserStartScreen();
                                        uStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }

                                // Менеджер
                                case 1:
                                    {
                                        ManagerStartScreen mStartScreen = new ManagerStartScreen();
                                        mStartScreen.ShowDialog();
                                        Close();
                                        break;
                                    }

                                // Администратор
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
