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
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public AdminGoodList()
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
            if (val != null)
            {
                int goodId = Convert.ToInt32(val);
                AdminFullInfoGood fullViewForm = new AdminFullInfoGood(goodId);
                fullViewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку с товаром для получения подробной информации!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AdminAddGood addGoodForm = new AdminAddGood();
            addGoodForm.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                using (var db = new PIS_DbContext())
                {
                    int idToDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Good good = db.Goods.SingleOrDefault(g => g.GoodId == idToDelete);
                    if (good != null)
                    {
                        db.Goods.Remove(good);
                        db.SaveChanges();
                    }
                }
            }
        }

        private void buttonViewFull_Click_1(object sender, EventArgs e)
        {
            int idToShow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            AdminFullInfoGood fullInfo = new AdminFullInfoGood(idToShow);
            fullInfo.ShowDialog();
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

            using(var db = new PIS_DbContext())
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
                if(checkBoxByType.Checked)
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdateDataGridView_Click(object sender, EventArgs e)
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
    }
}
