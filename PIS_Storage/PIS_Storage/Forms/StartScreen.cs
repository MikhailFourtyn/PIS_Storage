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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            OpenFileDialog ofd = new OpenFileDialog();

            pictureBox1.Image = Properties.Resources.storage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            Close();
        }
    }
}
