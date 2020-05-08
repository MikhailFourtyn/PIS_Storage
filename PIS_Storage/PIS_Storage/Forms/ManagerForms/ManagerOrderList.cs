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

namespace PIS_Storage.Forms.ManagerForms
{
    public partial class ManagerOrderList : Form
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
        public ManagerOrderList()
        {
            InitializeComponent();

            InitFormParams();

            SetupDataGridView();

            using(var db = new PIS_DbContext())
            {
                db.Orders.Load();
                db.OrderStatusChanges.Load();
                db.Goods.Load();
                db.Users.Load();

                dataGridView1.DataSource = db.Orders.Local.ToBindingList();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Продвинуть (изменить) статус заказа
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[7].Value.ToString() != "Доставлен")
            {
                using (var db = new PIS_DbContext())
                {
                    db.Orders.Load();
                    db.OrderStatusChanges.Load();
                    db.Goods.Load();
                    db.Users.Load();

                    int orderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    Order orderOnUpdate = db.Orders.SingleOrDefault(v => v.OrderId == orderId);
                    OrderStatusChange stat = db.OrderStatusChanges.SingleOrDefault(v => v.OrderId == orderOnUpdate.OrderId);
                    if (stat.OrderStatus < 3)
                    {
                        db.SaveChanges();
                        stat.OrderStatus++;
                    }

                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewFull_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdatedataGridView_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Orders.Load();
                db.Goods.Load();
                db.Users.Load();
                db.OrderStatusChanges.Load();

                dataGridView1.SelectAll();
                dataGridView1.ClearSelection();

                dataGridView1.DataSource = db.Orders.Local.ToBindingList();
            }
        }
    }
}
