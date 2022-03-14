using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_7
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {           
            listBox1.Items.Clear();            
            Random rand = new Random();          
            for (int i = 0; i < 30; i++)
            {
                Mas[i] = rand.Next((-50), 50);          
            listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            listBox2.Items.Clear();           
            if (Mas[0] > Mas[1]) // чтобы не было выхода за границу
            {
                listBox2.Items.Add("Mas[" + Convert.ToString(0) + "] = " + Mas[0].ToString());
            }
                for (int i = 1; i < 29; i++)
            {
               
                if (Mas[i] > Mas[i + 1] && Mas[i] > Mas[i - 1])
                    listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + Mas[i].ToString());                
            }
            if (Mas[29] > Mas[28]) // чтобы не было выхода за границу
            {
                listBox2.Items.Add("Mas[" + Convert.ToString(29) + "] = " + Mas[29].ToString());
            }
        }

    }
}


