using System;
using System.Drawing;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        string[] m = new string[999];
        int aa,bb,cc = 0;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //指定輸入區為白色
            textBox1.BackColor = Color.White;
        }
        //清除建AC
        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            aa = 0;
            bb = 0;
            cc = 0;
            i = 0;
            textBox2.Text = "aa=" + aa + "\r\nbb=" + bb + "\r\ncc=" + cc + "\r\nm=" + m + "\r\ni=" + i;
        }
        //數字鍵
        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
            bb = Int32.Parse(textBox1.Text);
            textBox2.Text = "aa=" + aa + "\r\nbb=" + bb + "\r\ncc=" + cc + "\r\nm=" + m + "\r\ni=" + i;

        }
        // 小數點
        private void Button11_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Text.ToString().IndexOf(".") == -1)
            {
                textBox1.Text += b.Text;
            }
        }

        // =鍵 途中之計算
        private void Button17_Click(object sender, EventArgs e)
        {

        }
        // +-*/鍵
        private void Button13_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;  
            m[i] = mb.Text;
            //Button17_Click(sender, e);
            Pro();
            
            textBox2.Text = "aa=" + aa + "\r\nbb=" + bb + "\r\ncc=" + cc + "\r\nm=" + m + "\r\ni=" + i;
        }
        private void Pro()
        {
            if (cc == 0 && i <= 1)
            {
                if (i == 0)
                {
                    aa = bb;
                    bb = 0;
                    textBox1.Text = "";
                }
                if (i == 1)
                {
                    switch (m[i - 1])
                    {
                        case "+":
                            cc = aa + bb;
                            break;
                        case "-":
                            cc = aa - bb;
                            break;
                        case "*":
                            cc = aa * bb;
                            break;
                        case "/":
                            cc = aa / bb;
                            break;
                    }
                    textBox1.Text = cc.ToString();
                }
            }
            else
            {
                switch (m[i - 1])
                {
                    case "+":
                        cc += bb;
                        break;
                    case "-":
                        cc -= bb;
                        break;
                    case "*":
                        cc *= bb;
                        break;
                    case "/":
                        cc /= bb;
                        break;
                    case "=":
                        switch (m[i-2])
                        {
                            case "+":
                                cc += bb;
                                break;
                            case "-":
                                cc -= bb;
                                break;
                            case "*":
                                cc *= bb;
                                break;
                            case "/":
                                cc /= bb;
                                break;
                        }
                        i--;
                        break;
                }
                textBox1.Text = cc.ToString();
            }
            i++;
            //textBox1.Text = cc.ToString();
            textBox2.Text = "aa=" + aa + "\r\nbb=" + bb + "\r\ncc=" + cc + "\r\nm=" + m[i] + "\r\ni=" + i;
        }
    }
}
