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
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
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

        /*
          Кнопка "" - переход на форму просмотра товаров для администратора 
          У менеджера и администратора совпадают права по работе с товарами (но не пользователями или заказами)
          Кроме того, форма AdminGoodList дает возможность перехода только на другие формы работы с товарами 
                (формы добавления товара и просмотра полной информации о товаре - AdminAddGood и AdminFullInfoGood)
          Поэтому менеджер может пользоваться формами администратора для работы с товарами
         */
        private void buttonShowGoodList_Click(object sender, EventArgs e)
        {
            Forms.AdminForms.AdminGoodList goodList = new Forms.AdminForms.AdminGoodList();
            goodList.ShowDialog();
        }

        // Переход на форму просмотра списка заказов
        private void buttonShowOrderList_Click(object sender, EventArgs e)
        {
            ManagerOrderList orderList = new ManagerOrderList();
            orderList.ShowDialog();
        }
    }
}
