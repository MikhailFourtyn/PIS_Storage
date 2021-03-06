﻿using System;
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
    public partial class StartScreen : Form
    {
        // Инициализация параметров формы - размера, возможности растягивать и стартового положения на экране
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }

        public StartScreen()
        {
            InitializeComponent();

            InitFormParams();

            pictureBox1.Image = Properties.Resources.storage;
        }

        // Кнопка "Перейти к окну авторизации"
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            Close();
        }
    }
}
