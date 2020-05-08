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
    public partial class GoodList : Form
    {
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public GoodList()
        {
            InitializeComponent();

            InitFormParams();

            SetupDataGridView();

            buttonApplyFilters.Enabled = false;

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                dataGridView1.DataSource = db.Goods.Local.ToBindingList();

                comboBoxByType.DataSource = db.GoodTypes.ToList();
            }
        }
        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void buttonViewFull_Click(object sender, EventArgs e)
        {
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

        private void buttonArrangeOrder_Click(object sender, EventArgs e)
        {
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();

                dataGridView1.DataSource = db.Goods.Local.ToBindingList();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            UserStartScreen userStart = new UserStartScreen();
            userStart.ShowDialog();
            Close();
        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();

            // True - показываем товары, которые есть в наличии
            // False - показываем товары, которых нет в наличии
            bool showAvailable = false;
            if (comboBoxByAvailable.SelectedItem.ToString() == "В наличии")
                showAvailable = true;

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

        private void checkBoxByAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByAvailable.Checked || checkBoxByType.Checked)
                buttonApplyFilters.Enabled = true;
            else
                buttonApplyFilters.Enabled = false;
        }

        private void checkBoxByType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByAvailable.Checked || checkBoxByType.Checked)
                buttonApplyFilters.Enabled = true;
            else
                buttonApplyFilters.Enabled = false;
        }
    }
}
