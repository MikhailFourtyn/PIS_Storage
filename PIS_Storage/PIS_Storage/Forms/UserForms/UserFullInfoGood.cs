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

namespace PIS_Storage.Forms.UserForms
{
    public partial class UserFullInfoGood : Form
    {
        public UserFullInfoGood(int goodId)
        {
            InitializeComponent();

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                Good view = db.Goods.SingleOrDefault(v => v.GoodId == goodId);

                if(view != null)
                {
                    labelName.Text = "Наименование товара: " + view.Name;
                    labelType.Text = "Тип товара: " + view.GoodType.ToString();
                    labelPrice.Text = "Цена товара: " + view.Price.ToString();
                    if (view.Amount != 0)
                        labelAmount.Text = "Количество товара на складе:  " + view.Amount.ToString();
                    else
                        labelAmount.Text = "Товара нет в наличии";

                    // В случае отсутствия фото - заглушка
                    if (view.PhotoPath == null)
                        pictureBoxImage.Image = Properties.Resources.noImage;
                    else
                        pictureBoxImage.ImageLocation = view.PhotoPath;
                }
                else
                {
                    // view == null

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
