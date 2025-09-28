using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LR1._1_C_.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace LR1._1_C_
{

    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
 dataGridView1.DataSource = null;
          
           
        }
        Clothes Clothes;
        private void Form1_Load(object sender, EventArgs e)
        {
            Clothes = new Clothes();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void COLOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SIZE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BREND_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void COUNTRY_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DECOR_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SEASON_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void COST_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
        Clothes.View,
        Clothes.Color,
        Clothes.Size,
        Clothes.Brend,
        Clothes.Country,
        Clothes.Decor,
        Clothes.Season,
        Clothes.Cost
    );
            
            
            BREND.SelectedIndex = -1;
            COUNTRY.SelectedIndex = -1;
            
        }
        void filtrView()
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox[] comboBoxes = { VIEW, COLOR,SIZE,BREND,COUNTRY, DECOR, SEASON };
            System.Windows.Forms.ComboBox selectedComboBox = null;

            

            if (!string.IsNullOrEmpty(Cost.Text))
            {
                FilterByPrice();
                return;
            }
           

            foreach (var cb in comboBoxes)
            {
                if (!string.IsNullOrEmpty(cb.Text)) 
                {
                    if (selectedComboBox != null)
                    {
                        MessageBox.Show("Будь ласка, оберіть значення лише в одному полі фільтрації.");
                        return;
                    }
                    selectedComboBox = cb;
                }
            }

            if (selectedComboBox == null)
            {
                MessageBox.Show("Оберіть хоча б один фільтр.");
                return;
            }

            string filterValue = selectedComboBox.Text.Trim();
            int columnIndex = Array.IndexOf(comboBoxes, selectedComboBox); 
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells[columnIndex].Value;
                    if (cellValue != null && cellValue.ToString() == filterValue)
                    {
                        row.Visible = true;
                        found = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Результатів не знайдено!");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Visible = true;
            }

        }
        private void FilterByPrice()
        {
            if (string.IsNullOrWhiteSpace(Cost.Text))
                return; 

            if (!decimal.TryParse(Cost.Text, out decimal price))
            {
                MessageBox.Show("Введіть коректне число для ціни!");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (decimal.TryParse(row.Cells[7].Value?.ToString(), out decimal rowPrice) && rowPrice <= price)
                    {
                        row.Visible = true;
                        found = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Результатів не знайдено!");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.Visible = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClothes addClothes = new AddClothes();
            
            addClothes.ShowDialog();
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateComboBox();
            UpdateComboBox5();
        }

        private void FillComboBox()
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void OpenForm2()
        {

            AddClothes form2 = new AddClothes();
            form2.Show();
        }



        private void UpdateComboBox()
        {
            VIEW.Items.Clear();

            HashSet<string> uniqueValues = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null) 
                {
                    string value = row.Cells[0].Value.ToString();
                    uniqueValues.Add(value);
                }
            }

            VIEW.Items.AddRange(uniqueValues.ToArray());
        }
        private void UpdateComboBox5()
        {
            DECOR.Items.Clear();

            HashSet<string> uniqueValues1 = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value != null) 
                {
                    string value = row.Cells[5].Value.ToString();
                    uniqueValues1.Add(value);
                }
            }

            DECOR.Items.AddRange(uniqueValues1.ToArray());
        }
        public void AddRowToDataGrid(string vid, string color, string size, string brand, string country, string decor, string season, double price)
        {
            dataGridView1.Rows.Add(vid, color, size, brand, country, decor, season, price);

            
           UpdateComboBox();
            UpdateComboBox5();
            SaveDataToFile("file.txt");
        }
        private void SaveDataToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false)) 
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        List<string> cells = new List<string>();

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                                cells.Add(cell.Value.ToString());
                            else
                                cells.Add("");
                        }

                        string line = string.Join(";", cells); 
                        sw.WriteLine(line);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox selectedComboBox = null;
            System.Windows.Forms.ComboBox[] comboBoxes = { VIEW, COLOR, SIZE, BREND, COUNTRY, DECOR, SEASON};
            foreach (var cb in comboBoxes)
            {
                cb.SelectedIndex = -1;
                cb.Text = "";
            }
            Cost.Text = "";
        }

        private void вивестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
             dataGridView1.Rows.Clear(); 

                string[] lines = File.ReadAllLines("file.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');

                    
                    dataGridView1.Rows.Add(values);
                }
            
        }

        private void зПараметромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c2 = new Clothes("Сукня", "Червона", "S", "Gucci", "Італія", "Бісер", "Літо", 2500);
            MessageBox.Show("Викликано конструктор з параметрами");
            

        }
        Clothes c2;
        private void безПараметраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clothes c1 = new Clothes();
            MessageBox.Show("Викликано конструктор без параметрів");
            

        }

        private void копіюванняToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Clothes c3 = new Clothes(c2);
            MessageBox.Show("Викликано конструктор копіювання");
        }
    }
}
