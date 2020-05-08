﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIS_Storage.Forms.AdminForms;

namespace PIS_Storage
{
    public partial class AdminStartScreen : Form
    {
        private void InitFormParams()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Width = 1280;
            this.Height = 720;
            this.MaximizeBox = false;
        }
        public AdminStartScreen()
        {
            InitializeComponent();

            InitFormParams();
        }

        private void buttonShowGoodList_Click(object sender, EventArgs e)
        {
            AdminGoodList goodList = new AdminGoodList();
            goodList.ShowDialog();
        }

        private void buttonShowUserList_Click(object sender, EventArgs e)
        {
            AdminUserList userList = new AdminUserList();
            userList.ShowDialog();
        }
    }
}
