using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 restaurant = new Form1();
            Form2 mainmenu = new Form2();
            if (txbx1.Text == string.Empty)
            {
                MessageBox.Show("Трябва да въведеш брой хора!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtn1.Checked == false && rbtn2.Checked == false)
            {
                MessageBox.Show("Трябва да избереш маса за пушачи или непушачи!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtn3.Checked == false && rbtn4.Checked == false)
            {
                MessageBox.Show("Трябва да избереш в брой или с карта!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mainmenu.Show();
                restaurant.Hide();
            }
        }
    }
}
