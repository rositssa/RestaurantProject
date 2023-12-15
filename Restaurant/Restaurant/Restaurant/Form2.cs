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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txbx1.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx2.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx3.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx4.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx5.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx6.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx7.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx8.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx9.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx10.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx11.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbx12.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бройка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
