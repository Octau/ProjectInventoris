using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            SimpleCalculator sc = new SimpleCalculator(Int32.Parse(tb_Angka1.Text), Int32.Parse(tb_Angka2.Text), comboBox1.Text);
            tb_Hasil.Text = sc.hitung().ToString();
        }
    }
}
