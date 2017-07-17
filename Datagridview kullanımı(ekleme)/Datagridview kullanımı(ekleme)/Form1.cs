using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview_kullanımı_ekleme_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = "sinan";//0. satırın 1.hücresinin değeri = sinan
            dataGridView1.Rows[i].Cells[1].Value = "acar";//0. satırın 2.hücresinin değeri = acar
            dataGridView1.Rows[i].Cells[2].Value = "16";//0.satırın 3.hücresinin değeri = 16
            //2. satırın değerlerini textboxlardan alması için;
            i = 1;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //datagridwievde 3 tane kolon olsun diyoruz.
            dataGridView1.ColumnCount = 3;
            //kolonlara isim veriyoruz.
            dataGridView1.Columns[0].Name = "Ad";
            dataGridView1.Columns[1].Name = "Soyad";
            dataGridView1.Columns[2].Name = "yaş";
        }
    }
}
