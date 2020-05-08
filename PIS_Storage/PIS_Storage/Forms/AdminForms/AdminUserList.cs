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

        // Перезагружает отображение таблицы
        public void ReloadDataGridView()
        {
            using (var db = new PIS_DbContext())
            {
                db.Users.Load();

                // Очищаем таблицу
                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();

                // Заполняем таблицу
                dataGridView1.DataSource = db.Users.Local.ToBindingList();
            }
        }

        // Кнопка "Обновить" - обновляет таблицу пользователей
        private void buttonUpdateDataGridView_Click(object sender, EventArgs e)
        {
            ReloadDataGridView();
        }

        // Кнопка "Удалить" - удаляет выделенную запись
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Запрет на удаление администратора
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString() != "2" && dataGridView1.CurrentRow.Cells[4].Value.ToString() != "Администратор")
            {
                using (var db = new PIS_DbContext())
                {
                    // Получение UserId
                    int idToDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    // Поиск пользователя
                    User user = db.Users.SingleOrDefault(g => g.UserId == idToDelete);
                    if (user != null)
                    {
                        // Удаление записи
                        db.Users.Remove(user);
                        db.SaveChanges();

                        // Перезагрузка таблицы
                        ReloadDataGridView();
                    }
                }
            }
        }

        // Кнопка "Просмотреть данные о пользователе" - открытие формы с полными данными о пользователе
        private void buttonViewFull_Click(object sender, EventArgs e)
        {
            // Получение UserId
            object val = dataGridView1.CurrentRow.Cells[0].Value;
            if (val != null)
            {
                int userId = Convert.ToInt32(val);

                // Открытие формы
                AdminFullInfoUser fullViewForm = new AdminFullInfoUser(userId);
                fullViewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с пользователем для получения подробной информации!");
            }
        }

        // Кнопка "Назад" - закрытие формы
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
