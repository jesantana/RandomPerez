using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomPerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 100; i++) 
            {
                listBox1.Items.Add(i);
            }
            listBox1.SelectedIndex = 0;
        }

        public string GetGoles(char result) 
        {
            Random r = new Random(Environment.TickCount);
            int x = 0;
            int y = 0; 
            if (result == 'X') 
            {
               x = r.Next(5);
               y = x; 
            }
            else if (result == '1') 
            {
                x = r.Next(1,5);
                y = r.Next(0, x - 1);
            }
            else if (result == '2')
            {
                y = r.Next(1, 5);
                x = r.Next(0, y - 1);
            }
            else 
            {
                throw new Exception();
            }
            return x.ToString() + "   " + y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedIndex + 1;
            Random r = new Random(Environment.TickCount);
            string cad = "X12";
            richTextBox1.Clear();
            for (int i = 1; i <= count; i++) 
            {
                char res=cad[r.Next(3)];
                richTextBox1.AppendText(res.ToString()+"  "+this.GetGoles(res)+"\n");
            }
        }
    }
}