using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClowderTask.Controller;
using ClowderTask.View.Interfaces;

namespace ClowderTask.View
{
    public partial class HomeView : Form, IHomeView
    {
        public HomeView()
        {
            InitializeComponent();
            var controller = new HomeControl(this);

        }

        public event EventHandler TaskButtonClick;

        private void taskButton_Click(object sender, EventArgs e)
        {
            if (TaskButtonClick != null)
            {
                TaskButtonClick.Invoke(this, EventArgs.Empty);
            }

        }

        public event EventHandler SettingsButtonClick;

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (SettingsButtonClick != null)
            {
                SettingsButtonClick.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ShopButtonClick;

        private void shopButton_Click(object sender, EventArgs e)
        {
            if (ShopButtonClick != null)
            {
                ShopButtonClick.Invoke(this, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
