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
    // Форма пользователя - оформить заказ
    public partial class ArrangeOrder : Form
    {
        private int _orderedGoodId;

        private Good orderedGood;
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public ArrangeOrder(int goodId)
        {
            InitializeComponent();

            InitFormParams();

            _orderedGoodId = goodId;

            using (var db = new PIS_DbContext())
            {
                db.Goods.Load();
                db.GoodTypes.Load();

                orderedGood = db.Goods.SingleOrDefault(v => v.GoodId == _orderedGoodId);

                if (orderedGood != null)
                {
                    labelName.Text = "Наименование:" + orderedGood.Name;
                    labelType.Text = "Тип товара: " + orderedGood.GoodType.ToString();
                    labelPrice.Text = "Цена: " + orderedGood.Price.ToString();
                    if(orderedGood.Amount != 0)
                        labelAmountInStorage.Text = "Количество товара на складе: " + orderedGood.Amount.ToString();
                    else
                        labelAmountInStorage.Text = "Товара нет в наличии";

                    // В случае отсутствия фото - заглушка
                    if (orderedGood.PhotoPath == null)
                        pictureBoxImage.Image = Properties.Resources.noImage;
                    else
                        pictureBoxImage.ImageLocation = orderedGood.PhotoPath;
                }

            }
        }

        private void buttonArrangeOrder_Click(object sender, EventArgs e)
        {
            int amountToOrder = Convert.ToInt32(textBoxAmount.Text);
            if (amountToOrder > short.MaxValue)
                MessageBox.Show("Введите количество товара в пределах " + short.MaxValue.ToString() + "!");
            else
            {
                using (var db = new PIS_DbContext())
                {
                    if (orderedGood != null)
                    {
                        //Storage chosenGood = db.Storage.SingleOrDefault(s => s.GoodId == _orderedGoodId);
                        if (orderedGood.Amount >= amountToOrder)
                        {
                            Order order = new Order()
                            {
                                Amount = Convert.ToInt16(amountToOrder),
                                GoodId = _orderedGoodId,
                                UserId = CurrentUser.Get().UserId,
                                OrderStatusChangesId = 0
                            };

                            // Изменение записи о товаре в таблице
                            db.Goods.SingleOrDefault(x => x.GoodId == orderedGood.GoodId).Amount -= Convert.ToInt16(amountToOrder);
                            //db.Orders.Find(orderedGood.GoodId).Amount -= Convert.ToInt16(amountToOrder);
                            //orderedGood.Amount -= Convert.ToInt16(amountToOrder);

                            db.Orders.Add(order);
                            db.SaveChanges();

                            // Заказ оформлен. Закрываем форму (и возврат к еще открытой GoodList)
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("На складе нет данного товара в нужном количестве! Введите другое значение");
                        }
                    }

                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
