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
    public partial class AdminGoodList : Form
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
        public AdminGoodList()
        {
            InitializeComponent();

            InitFormParams();

            SetupDataGridView();

            // На запуске формы - просмотр без фильтров. Для включения фильтров отмечается соответствующий checkBox
            EnableFiltersElements(false);

            using (var db = new PIS_DbContext())
            {
                // Подгрузка таблиц для заполнения gridView и comboBox
                db.Goods.Load();
                db.GoodTypes.Load();

                dataGridView1.DataSource = db.Goods.Local.ToBindingList();

                comboBoxByType.DataSource = db.GoodTypes.ToList();
            }
        }

        // Просмотр полной информации о товаре
        private void buttonViewFull_Click(object sender, EventArgs e)
        {
            // Поле GoodId
            object val = dataGridView1.CurrentRow.Cells[0].Value;
            // Проверка, что строка выделена
            if (val != null)
            {
                // Открытие формы просмотра данных о товаре по Id
                int goodId = Convert.ToInt32(val);
                AdminFullInfoGood fullViewForm = new AdminFullInfoGood(goodId);
                fullViewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с товаром для получения подробной информации!");
            }
        }
        // Включение-выключение доступа к элементам фильтров
        void EnableFiltersElements(bool state)
        {
            buttonApplyFilters.Enabled = state;
            comboBoxByAvailable.Enabled = state;
            comboBoxByType.Enabled = state;
        }

        // Добавление товара - открытие формы
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdminAddGood addGoodForm = new AdminAddGood();
            addGoodForm.ShowDialog();
        }

        // Удаление товара
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                using (var db = new PIS_DbContext())
                {
                    // Выбор Id записи, подлежащей удалению
                    int idToDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    // Поиск такой записи
                    Good good = db.Goods.SingleOrDefault(g => g.GoodId == idToDelete);
                    // Если есть, то удаляем
                    if (good != null)
                    {
                        db.Goods.Remove(good);
                        db.SaveChanges();
                    }
                }
            }
        }

        // Отображение полной информации о товаре - открытие формы. Передаем Id выбранного товара
        private void buttonViewFull_Click_1(object sender, EventArgs e)
        {
            int idToShow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            AdminFullInfoGood fullInfo = new AdminFullInfoGood(idToShow);
            fullInfo.ShowDialog();
        }

        // Применить фильтры
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            // Очищаем отображение данных в таблице
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();

            // True - показываем товары, которые есть в наличии
            // False - показываем товары, которых нет в наличии
            bool showAvailable = false;
            if(checkBoxByAvailable.Checked)
            {
                if (comboBoxByAvailable.SelectedItem.ToString() == "В наличии")
                    showAvailable = true;
                if (comboBoxByAvailable.SelectedItem.ToString() == "Не в наличии")
                    showAvailable = false;
            }
            

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                // Выборка товаров. Изначально заполняем всем товарами
                List<Good> goodsToShow = db.Goods.ToList();

                // Затем фильтруем их по наличию
                if (checkBoxByAvailable.Checked)
                {
                    if (showAvailable == true)
                        goodsToShow = goodsToShow.Where(g => g.Amount > 0).ToList();
                    else
                        goodsToShow = goodsToShow.Where(g => g.Amount == 0).ToList();
                }

                // Фильтруем по типу
                if(checkBoxByType.Checked)
                {
                    goodsToShow = goodsToShow.Where(g => g.GoodType.ToString() == comboBoxByType.SelectedItem.ToString()).ToList();
                }

                // После применения фильтров отображаем таблицу
                dataGridView1.DataSource = goodsToShow;
            }
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

        // Кнопка "Назад" - закрыть форму
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Кнопка "Обновить" - перезагрузка таблицы-отображения
        private void buttonUpdateDataGridView_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();
                
                // очищаем отображаемую таблицу
                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();


                // Применение текущих фильтров, если они включены
                if (checkBoxByAvailable.Checked || checkBoxByType.Checked)
                {
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
                else
                {
                    // Если фильтры не включены, отображаем все товары
                    dataGridView1.DataSource = db.Goods.Local.ToBindingList();
                }
            }
        }
        
    }
}
