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
    }
}
