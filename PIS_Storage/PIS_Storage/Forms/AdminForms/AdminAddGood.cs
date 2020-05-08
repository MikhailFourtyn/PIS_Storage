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
    public partial class AdminAddGood : Form
    {
        bool addedPhoto = false;
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public AdminAddGood()
        {
            InitializeComponent();
            
            InitFormParams();

            using(var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                comboBoxType.DataSource = db.GoodTypes.ToList();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Возвращение на форму просмотра товаров
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                // Формирование нового товара
                Good goodToAdd = new Good()
                {
                    Name = textBoxName.Text,
                    Amount = Convert.ToInt16(textBoxAmount.Text),
                    GoodTypeId = ((GoodType)comboBoxType.SelectedItem).GoodTypeId,
                    Price = Convert.ToInt16(textBoxPrice.Text)
                };
                if (addedPhoto)
                    goodToAdd.PhotoPath = pictureBoxImage.ImageLocation;
                else
                    goodToAdd.PhotoPath = null;


                // Добавление нового товара в БД и сохранение изменений
                db.Goods.Add(goodToAdd);
                db.SaveChanges();

                // Возвращение на форму просмотра товаров
                Close();
            }
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string initImgLocation = pictureBoxImage.ImageLocation;
            pictureBoxImage.ImageLocation = openFileDialog1.FileName;

            /*
             * Проверка, что пользователь выбрал файл, а не закрыл диалог. 
             * Если файл не изменился, то не заносим путь к картинке-заглушке в поле PhotoPath, 
             * в котором в таком случае должно быть null.
             */
            if (pictureBoxImage.ImageLocation != initImgLocation)
                addedPhoto = true;
        }
    }
}
