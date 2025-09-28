using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR1._1_C_
{
    public partial class AddClothes : Form
    {

        public Clothes newOne { get; set; }
        public AddClothes()
        {
            newOne = new Clothes();
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string vid = VIEW.Text;
            string color = COLOR.Text;
            string size = SIZE.Text;
            string brand = BREND.Text;
            string country =COUNTRY.Text;
            string decor = DECOR.Text;
            string season = SEASON.Text;
            double cost =double.Parse(COST.Text);

            if (vid == "" || color == "" || size == "" || brand == "" || country == "" || decor == "" || season == "" || cost == 0)
            {
                MessageBox.Show("Введіть дані");
            }
          
            else
            {
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];

                if (mainForm != null)
                {
                    mainForm.AddRowToDataGrid(vid, color, size, brand, country, decor, season, cost);
                }

                this.Close();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void COST_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddClothes_Load(object sender, EventArgs e)
        {

        }
    }
}
