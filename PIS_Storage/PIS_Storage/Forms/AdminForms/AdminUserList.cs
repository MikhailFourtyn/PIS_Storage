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
    
    public partial class AdminUserList : Form
    {
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }

        // Настройка отображения таблицы
        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;
        }
        public AdminUserList()
        {
            InitializeComponent();

            InitFormParams();

            SetupDataGridView();

            using (var db = new PIS_DbContext())
            {
                ReloadDataGridView();

            }
        }

        public void ReloadDataGridView()
        {
            using (var db = new PIS_DbContext())
            {
                db.Users.Load();

                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();

                dataGridView1.DataSource = db.Users.Local.ToBindingList();

                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    /*
                    if (r.Cells[4].Value.ToString() == "0")
                        r.Cells[4].Value = "Пользователь";
                    if (r.Cells[4].Value.ToString() == "1")
                        r.Cells[4].Value = "Менеджер";
                    if (r.Cells[4].Value.ToString() == "2")
                        r.Cells[4].Value = "Администратор";
                        */
                }
            }
        }


        private void buttonUpdateDataGridView_Click(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Запрет на удаление администратора
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString() != "2" && dataGridView1.CurrentRow.Cells[4].Value.ToString() != "Администратор")
            {
                using (var db = new PIS_DbContext())
                {
                    int idToDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    User user = db.Users.SingleOrDefault(g => g.UserId == idToDelete);
                    if (user != null)
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                        ReloadDataGridView();
                    }
                }
            }
        }

        private void buttonViewFull_Click(object sender, EventArgs e)
        {
            object val = dataGridView1.CurrentRow.Cells[0].Value;
            if (val != null)
            {
                int userId = Convert.ToInt32(val);
                AdminFullInfoUser fullViewForm = new AdminFullInfoUser(userId);
                fullViewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с пользователем для получения подробной информации!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
