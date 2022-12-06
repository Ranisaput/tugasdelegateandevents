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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            operasi();
        }
        public delegate void calculatorClickEvenHandler(int nilaiA, int nilaiB, int hasil, string simbol, string operasihitung);
        public event calculatorClickEvenHandler handler;

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void operasi ()
        {
            comboBox1.Items.Add("Penjualan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.SelectedIndex = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtnilaiA.Text);
            int nilaiB = int.Parse(txtnilaiB.Text);
            int hasil = 0;
            string operasihitung = "";
            string simbol = "";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    hasil = nilaiA + nilaiB;
                    operasihitung = "Penjumlahan";
                    simbol = "+";
                    break;
                case 1:
                    hasil = nilaiA - nilaiB;
                    operasihitung = "Pengurangan";
                    simbol = "-";
                    break;
                case 2:
                    hasil = nilaiA * nilaiB;
                    operasihitung = "Perkalian";
                    simbol = "*";
                    break;
                case 3:
                    hasil = nilaiA / nilaiB;
                    operasihitung = "Pembagian";
                    simbol = ":";
                    break;

            }
            handler(nilaiA, nilaiB, hasil, simbol, operasihitung);
        }

          
            
    }
}
