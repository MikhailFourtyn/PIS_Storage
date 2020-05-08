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

namespace PIS_Storage.Forms.AdminForms
{
    public partial class AdminFullInfoUser : Form
    {
        int currUserId;
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public AdminFullInfoUser(int argUserId)
        {
            InitializeComponent();

            InitFormParams();

            currUserId = argUserId;

            // Отключаем для редактирования. Для просмотра типа используем label
            comboBoxStatus.Enabled = false;

            using (var db = new PIS_DbContext())
            {
                db.Users.Load();

                User userOnView = db.Users.SingleOrDefault(v => v.UserId == currUserId);

                if (userOnView != null)
                {
                    textBoxName.Text = userOnView.Name;
                    textBoxLogin.Text = userOnView.Login;
                    labelStatus.Text = userOnView.StatusToString();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Users.Load();

                User userOnEdit = db.Users.SingleOrDefault(v => v.UserId == currUserId);
                if (userOnEdit != null)
                {
                    userOnEdit.Name = textBoxName.Text;
                    userOnEdit.Login = textBoxLogin.Text;

                    string newStatus = (comboBoxStatus.SelectedItem.ToString());
                    switch(newStatus)
                    {
                        case "Пользователь":
                            userOnEdit.Status = 0;
                            break;
                        case "Менедежер":
                            userOnEdit.Status = 1;
                            break;
                        default:
                            break;
                    }

                    db.SaveChanges();
                    labelStatus.Text = newStatus;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStatus.Enabled = !comboBoxStatus.Enabled;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
