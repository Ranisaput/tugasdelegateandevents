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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;Calculator calculator = new Calculator();
            calculator.handler += tampilan;
            calculator.ShowDialog();

        }

       private void tampilan(int nilaiA, int nilaiB, int hasil, string simbol, string operasihitung)
        {
            listBox1.Items.Add(string.Format("Hasil {0} {1} {2} {3} = {4}", operasihitung, nilaiA, simbol, nilaiB, hasil));
        }
    }
}
