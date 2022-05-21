using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSE
{
    public partial class StatisticsScreen : Form
    {
        public StatisticsScreen()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
            this.Close();
        }
    }
}
