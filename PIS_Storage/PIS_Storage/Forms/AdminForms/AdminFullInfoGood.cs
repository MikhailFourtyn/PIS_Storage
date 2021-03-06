﻿using System;
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
        // Id товара для отображения
        private int currGoodId;
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        // Настройка элементов для чтения, но не редактирования
        private void InitElementsForViewing()
        {
            textBoxName.ReadOnly = true;
            textBoxAmount.ReadOnly = true;
            textBoxPrice.ReadOnly = true;

            // Отключаем для редактирования. Для просмотра типа используем label
            comboBoxType.Enabled = false;
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

                // Поиск товара по Id
                Good goodOnView = db.Goods.SingleOrDefault(v => v.GoodId == goodId);

                // Если найден, то заполнение элементов для отображения
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
                comboBoxType.DataSource = db.GoodTypes.ToList();
            }

            // Настройка элементов для чтения, но не редактирования
            InitElementsForViewing();
        }

        // Добавление фото через openFileDialog
        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBoxImage.ImageLocation = openFileDialog1.FileName;
        }
        // Кнопка "Назад"
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Возвращение на форму просмотра товаров
            Close();
        }

        // Включение режима изменения товара
        private void buttonEditType_Click(object sender, EventArgs e)
        {
            comboBoxType.Enabled = true;
            textBoxName.ReadOnly = false;
            textBoxAmount.ReadOnly = false;
            textBoxPrice.ReadOnly = false;
        }

        // "Подтвердить изменения" - внедрение изменений в запись
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                // Поиск записи о товаре по имеющемуся Id
                Good goodOnView = db.Goods.SingleOrDefault(v => v.GoodId == currGoodId);
                if(goodOnView != null)
                {
                    goodOnView.Amount = Convert.ToInt16(textBoxAmount.Text);
                    goodOnView.GoodTypeId = ((GoodType)comboBoxType.SelectedItem).GoodTypeId;
                    goodOnView.Name = textBoxName.Text;
                    goodOnView.PhotoPath = pictureBoxImage.ImageLocation;
                    goodOnView.Price = Convert.ToInt32(textBoxPrice.Text);

                    db.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
