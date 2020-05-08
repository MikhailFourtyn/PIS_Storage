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
    public partial class AdminFullInfoGood : Form
    {
        private int currGoodId;
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public AdminFullInfoGood(int goodId)
        {
            InitializeComponent();

            InitFormParams();

            currGoodId = goodId;

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                Good goodOnView = db.Goods.SingleOrDefault(v => v.GoodId == goodId);

                if (goodOnView != null)
                {
                    textBoxName.Text = goodOnView.Name;
                    labelType.Text = goodOnView.GoodType.ToString();
                    textBoxPrice.Text = goodOnView.Price.ToString();
                    textBoxAmount.Text = goodOnView.Amount.ToString();
                    // В случае отсутствия фото - заглушка
                    if (goodOnView.PhotoPath == null)
                        pictureBoxImage.Image = Properties.Resources.noImage;
                    else
                        pictureBoxImage.ImageLocation = goodOnView.PhotoPath;
                }
            }

            InitElementsForViewing();
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBoxImage.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Возвращение на форму просмотра товаров
            Close();
        }

        private void buttonEditType_Click(object sender, EventArgs e)
        {
            comboBoxType.Enabled = true;
            textBoxName.ReadOnly = false;
            textBoxAmount.ReadOnly = false;
            textBoxPrice.ReadOnly = false;
        }
        private void InitElementsForViewing()
        {
            textBoxName.ReadOnly = true;
            textBoxAmount.ReadOnly = true;
            textBoxPrice.ReadOnly = true;

            // Отключаем для редактирования. Для просмотра типа используем label
            comboBoxType.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                Good goodOnView = db.Goods.SingleOrDefault(v => v.GoodId == currGoodId);
                if(goodOnView != null)
                {
                    goodOnView.Amount = Convert.ToInt16(textBoxAmount.Text);
                    goodOnView.GoodTypeId = ((GoodType)comboBoxType.SelectedItem).GoodTypeId;
                    goodOnView.Name = textBoxName.Text;
                    goodOnView.PhotoPath = pictureBoxImage.ImageLocation;

                    db.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
