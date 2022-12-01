using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbSzam.Text) > 4)
            {
                int szam = Convert.ToInt32(tbSzam.Text);
                szam--;
                tbSzam.Text = szam + "";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbSzam.Text) < 9)
            {
                int szam = Convert.ToInt32(tbSzam.Text);
                szam++;
                tbSzam.Text = szam + "";
            }
        }

        private void tbKezdo_TextChanged(object sender, EventArgs e)
        {
            lblHossz.Text = "Hossz: " + tbKezdo.TextLength;
        }

        private void btnEll_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbSzam.Text) * Convert.ToInt32(tbSzam.Text) == tbKezdo.TextLength)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            } 
            else if (Convert.ToInt32(tbSzam.Text) * Convert.ToInt32(tbSzam.Text) - tbKezdo.TextLength > 0)
            {
                MessageBox.Show("A feladvány rövid: kell még " + (Convert.ToInt32(tbSzam.Text) * Convert.ToInt32(tbSzam.Text) - tbKezdo.TextLength) + " számjegy!");
            } 
            else
            {
                MessageBox.Show("A feladvány hosszú: törlendő " + (tbKezdo.TextLength - Convert.ToInt32(tbSzam.Text) * Convert.ToInt32(tbSzam.Text)) + " számjegy!");
            }
        }
    }
}
