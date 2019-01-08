using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Железо и гаджеты", "Кино", "Игры", "Музыка" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == "Железо и гаджеты")
            {
                comboBox2.Items.Add("Процессоры");
                comboBox2.Items.Add("Видеокарты");
                comboBox2.Items.Add("Ноутбуки");
                comboBox2.Items.Add("Смартфоны");
                comboBox2.Items.Add("Телевизоры");
                comboBox2.Items.Add("Наушники");
            }
            else if (comboBox1.SelectedItem == "Кино")
            {
                comboBox2.Items.Add("Анонсы");
                comboBox2.Items.Add("Трейлеры кино");
                comboBox2.Items.Add("Премии");
            }
            else if (comboBox1.SelectedItem == "Игры")
            {
                comboBox2.Items.Add("Игровая индустрия");
                comboBox2.Items.Add("Трейлеры игр");
                comboBox2.Items.Add("Разработка игр");
            }
            else if (comboBox1.SelectedItem == "Музыка")
            {
                comboBox2.Items.Add("Концерты");
                comboBox2.Items.Add("Релизы");
            }

        }
    
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            linkLabel1.Text = "";

            label2.Text = "";
            linkLabel2.Text = "";

            label3.Text = "";
            linkLabel3.Text = "";

            label4.Text = "";
            linkLabel4.Text = "";

            label5.Text = "";
            linkLabel5.Text = "";
            if (comboBox2.SelectedItem == "Процессоры")
            {
                linkLabel1.Text = "";

            }
            else if (comboBox1.SelectedItem == "Видеокарты")
            {
            }
            else if (comboBox1.SelectedItem == "Ноутбуки")
            {
            }
            else if (comboBox1.SelectedItem == "Смартфоны")
            {
            }

        }
    }
}
