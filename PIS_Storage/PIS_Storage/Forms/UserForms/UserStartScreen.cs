using PIS_Storage.Forms.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Storage
{
    public partial class UserStartScreen : Form
    {
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public UserStartScreen()
        {
            InitializeComponent();

            InitFormParams();
        }

        private void buttonOpenGoodList_Click(object sender, EventArgs e)
        {
            Hide();
            GoodList gList = new GoodList();
            gList.ShowDialog();
            Close();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            UserOrderList orderList = new UserOrderList();
            orderList.ShowDialog();
        }
    }
}
