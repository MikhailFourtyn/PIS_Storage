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

namespace PIS_Storage
{
    public partial class GoodList : Form
    {

        public GoodList()
        {
            InitializeComponent();

            

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();

                int goodTableLen = db.Goods.Count();

                SetupDataGridView();

                // Установление таблицы Goods источником данных для отображения
                dataGridView1.DataSource = db.Goods.Local.ToBindingList();

                

                //PopulateDataGridView(ref strDataTable)
            }
        }
        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;
        }

        private void PopulateDataGridView(ref List<List<string>> strDataTable)
        {

        }
    }
}
