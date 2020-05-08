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
using PIS_Storage.Forms.UserForms;

namespace PIS_Storage
{
    // Форма просмотра товаров пользователем
    public partial class GoodList : Form
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
        public GoodList()
        {
            InitializeComponent();

            InitFormParams();

            SetupDataGridView();

            // На запуске формы - просмотр без фильтров. Для включения фильтров отмечается соответствующий checkBox
            EnableFiltersElements(false);

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                // Заполнение таблицы и comboBox
                dataGridView1.DataSource = db.Goods.Local.ToBindingList();

                comboBoxByType.DataSource = db.GoodTypes.ToList();
            }
        }

        // Переход на форму просмотра подробной информации о товаре
        private void buttonViewFull_Click(object sender, EventArgs e)
        {
            // Если выделена строка, то передаем GoodId в форму. Иначе - отображение ошибки
            object val = dataGridView1.CurrentRow.Cells[0].Value;
            if(val != null)
            {
                int goodId = Convert.ToInt32(val);
                UserFullInfoGood fullViewForm = new UserFullInfoGood(goodId);
                fullViewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с товаром для получения подробной информации!");
            }
        }

        // Переход на форму оформления заказа
        private void buttonArrangeOrder_Click(object sender, EventArgs e)
        {
            // Если выделена строка, то передаем GoodId в форму. Иначе - отображение ошибки
            object val = dataGridView1.CurrentRow.Cells[0].Value;
            if (val != null)
            {
                int goodId = Convert.ToInt32(val);
                ArrangeOrder order = new ArrangeOrder(goodId);
                order.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с товаром для оформления заказа!");
            }
        }

        // Кнопка "Обновить" - перезагрузка таблицы
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                // Очищаем таблицу
                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();

                // Заполняем таблицу
                dataGridView1.DataSource = db.Goods.Local.ToBindingList();
            }
        }

        // Кнопка "Назад" - переход обратно на стартовый экран пользователя
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            UserStartScreen userStart = new UserStartScreen();
            userStart.ShowDialog();
            Close();
        }

        // Кнопка "Применить фильтры"
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();

            // True - показываем товары, которые есть в наличии
            // False - показываем товары, которых нет в наличии
            bool showAvailable = false;
            if (checkBoxByAvailable.Checked)
            {
                if (comboBoxByAvailable.SelectedItem.ToString() == "В наличии")
                    showAvailable = true;
                if (comboBoxByAvailable.SelectedItem.ToString() == "Не в наличии")
                    showAvailable = false;
            }

            using (var db = new PIS_DbContext())
            {
                db.Users.Load();
                db.GoodTypes.Load();

                // Выборка товаров. Изначально заполняем всем товарами
                List<Good> goodsToShow = db.Goods.ToList();

                // Фильтруем по наличию
                if (checkBoxByAvailable.Checked)
                {
                    if (showAvailable == true)
                        goodsToShow = goodsToShow.Where(g => g.Amount > 0).ToList();
                    else
                        goodsToShow = goodsToShow.Where(g => g.Amount == 0).ToList();
                }

                // Фильтруем по типу
                if (checkBoxByType.Checked)
                {
                    goodsToShow = goodsToShow.Where(g => g.GoodType.ToString() == comboBoxByType.SelectedItem.ToString()).ToList();
                }

                // После применения фильтров отображаем таблицу
                dataGridView1.DataSource = goodsToShow;
            }
        }

        // Включение-выключение доступа к элементам фильтров
        void EnableFiltersElements(bool state)
        {
            buttonApplyFilters.Enabled = state;
            comboBoxByAvailable.Enabled = state;
            comboBoxByType.Enabled = state;
        }

        // При клике по любому из checkBox проверям - если хотя бы один из них включен, то включаем доступ к фильтрам
        private void checkBoxByAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByAvailable.Checked || checkBoxByType.Checked)
                EnableFiltersElements(true);
            else
                EnableFiltersElements(false);
        }

        // При клике по любому из checkBox проверям - если хотя бы один из них включен, то включаем доступ к фильтрам
        private void checkBoxByType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByAvailable.Checked || checkBoxByType.Checked)
                EnableFiltersElements(true);
            else
                EnableFiltersElements(false);
        }
    }
}
