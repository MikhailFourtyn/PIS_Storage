using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIS_Storage.Forms.ManagerForms;

namespace PIS_Storage
{
    public partial class ManagerStartScreen : Form
    {
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public ManagerStartScreen()
        {
            InitializeComponent();

            InitFormParams();
        }

        private void buttonShowGoodList_Click(object sender, EventArgs e)
        {
            Forms.AdminForms.AdminGoodList goodList = new Forms.AdminForms.AdminGoodList();
            goodList.ShowDialog();
        }

        private void buttonShowOrderList_Click(object sender, EventArgs e)
        {
            ManagerOrderList orderList = new ManagerOrderList();
            orderList.ShowDialog();
        }
    }
}
