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
            bool invalidLoginLen = false;
            bool invalidPasswordLen = false;
            bool loginNotExisting = false;
            bool wrongPassword = false;

            // Ввод логина и пароля в переменные

            string inputLogin;
            string inputPassword;

            // Проверка длин логина и пароля

            if (!invalidLoginLen && !invalidPasswordLen)
            {
                // Проверка совпадения логина с полем User.Name. 
                // Совпадение => получаем id. Не было совпадения => выводим ошибку
                // Проверка совпадения пароля с полем User.Password

                // Все в порядке - отключаем поле ошибок

                panelErrors.Enabled = false;

                // Заполнение полей Login и Password текущего юзера

                // 
            }
            else
            {
                
            }
            

        }

    }
}
