using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int yq=0; yq <10 ; yq++)
            //{
              //  chart1.Series[0].Points.AddXY();
            //}
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
(String.IsNullOrEmpty(tbX2.Text))) { 
                tbY.Text = "Не введено даних!";
            return; }
        double x1 = double.Parse(tbX1.Text);
        double x2 = double.Parse(tbX2.Text);
        double y = Math.Sin(x1) - Math.Pow(x2, 3) + Math.Sqrt(x1) - 1.3 * Math.Pow(x1, 3);
        tbY.Text = y.ToString("0.###");
            if (x1<x2){
                label4.Text =  "Число x1 менше чим x2 " + " Менше число - " + tbX1.Text ;
    }
            else {
                label4.Text = "Число x2 менше чим x1 " + " Менше число - " + tbX2.Text;
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.AddXY(i,y);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
