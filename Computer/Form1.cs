using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        string aa;
        string m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        //清除建AC
        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            c = 0;
            textBox2.Text = c.ToString() + "\r\n" +  "\r\n" + "\r\n" + c;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
        }

        // =
        Double c = 0;
        int x = 1;
        private void Button17_Click(object sender, EventArgs e)
        {
            Double a = Double.Parse(aa);
            Double b = Int32.Parse(textBox1.Text);
            //Double c = 0;
            if (c == 0)
            {
                switch (m)
                {
                    case "+":
                        b = 0;
                        c = a + b;
                        break;
                    case "-":
                        b = 0;
                        c = a - b;
                        break;
                    case "*":
                        b = 0;
                        c = a * b;
                        break;
                    case "/":
                        b = 0;
                        c = a / b;
                        break;
                }
                textBox1.Text = c.ToString();
                textBox2.Text = c.ToString() + "\r\n" + a + "\r\n" + b + "\r\n" + c;
            }
            else
            {
                
                switch (m)
                {
                    case "+":
                        c += b;
                        break;
                    case "-":
                        c -= b;
                        break;
                    case "*":
                        c *= b;
                        break;
                    case "/":
                        c /= b;
                        break;
                }
                textBox1.Text = c.ToString();
                textBox2.Text = c.ToString() + "\r\n" + a + "\r\n" + b + "\r\n" + c;
            }

        }
        // +-*/途中計算用
        private void Pro()
        {
            Double a = Double.Parse(aa);
            Double b = Int32.Parse(textBox1.Text);
            if(c == 0)
            {

                switch (m)
                {
                    case "+":
                        b = 0;
                        c = a + b;
                        break;
                    case "-":
                        b = 0;
                        c = a - b;
                        break;
                    case "*":
                        b = 1;
                        c = a * b;
                        break;
                    case "/":
                        b = 1;
                        c = a / b;
                        break;
                }
                textBox2.Text = c.ToString() + "\r\n" + a + "\r\n" + b + "\r\n" + c;
            }
            else
            {
                switch (m)
                {
                    case "+":
                        c += b;
                        break;
                    case "-":
                        c -= b;
                        break;
                    case "*":
                        c *= b;
                        break;
                    case "/":
                        c /= b;
                        break;
                }
                textBox2.Text = c.ToString() + "\r\n" + a + "\r\n" + b + "\r\n" + c;
            }

            
        }
    
        // +
        private void Button13_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;
            m = mb.Text;
            aa = textBox1.Text;
            Pro();
            textBox1.Text = "";
            
        }
        // -
        private void Button14_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;
            m = mb.Text;
            aa = textBox1.Text;
            Pro();
            textBox1.Text = "";
            
        }
        // *
        private void Button15_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;
            m = mb.Text;
            aa = textBox1.Text;
            Pro();
            textBox1.Text = "";
        }
            
        // /
        private void Button16_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;
            m = mb.Text;
            aa = textBox1.Text;
            Pro();
            textBox1.Text = "";
            
        }
        
        
    }
}
