using System;
using System.Drawing;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        string[] m = new string[999];
        string formula;
        double oneNum,twoNum,ansNum = 0;
        int counter = 0;
        bool first,keepGoing = true;

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
        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            oneNum = 0;
            twoNum = 0;
            ansNum = 0;
            int i = counter;
            for(counter = 0; counter < i; counter++)
            {
                m[counter] = "";
            }
            counter = 0;
            first = true;
            textBox2.Text = "oneNum=" + oneNum + "\r\ntwoNum=" + twoNum + "\r\nansNum=" + ansNum + "\r\nm=" + m[counter] + "\r\ncounter=" + counter;
        }

        //數字鍵
        private void Number_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
            textBox3.Text += b.Text;
            twoNum = double.Parse(textBox1.Text);
            textBox2.Text = "oneNum=" + oneNum + "\r\ntwoNum=" + twoNum + "\r\nansNum=" + ansNum + "\r\nm=" + "輸入數字中..." + "\r\ncounter=" + counter;
        }

        // 小數點
        private void Point_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (textBox1.Text.ToString().IndexOf(".") == -1)
            {
                textBox1.Text += b.Text;
            }
        }

        // =按鍵
        private void Equal_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;
            m[counter] = mb.Text;
            textBox3.Text += mb.Text;
            Pro();
            counter--;
            textBox1.Text = ansNum.ToString();
            textBox3.Text += ansNum;
            keepGoing = false;
        }

        // +-*/按鍵
        private void Symbol_Click(object sender, EventArgs e)
        {
            Button mb = sender as Button;  
            m[counter] = mb.Text;
            textBox3.Text += mb.Text;
            if(oneNum == 0)
            {
                oneNum = twoNum;
                twoNum = 0;
                counter++;
                first = true;
            }
            else if (keepGoing == false)
            {
                counter++;
            }
            else
            {
                Pro();
            }
            keepGoing = true;
            textBox1.Text = "";
            textBox2.Text = "oneNum=" + oneNum + "\r\ntwoNum=" + twoNum + "\r\nansNum=" + ansNum + "\r\nm=" + m[counter-1] + "\r\ncounter=" + counter;
        }

        //計算
        private void Pro()
        {
            if (first == true)
            {
                switch (m[counter-1])
                {
                    case "+":
                        ansNum = oneNum + twoNum;
                        break;
                    case "-":
                        ansNum = oneNum - twoNum;
                        break;
                    case "*":
                        ansNum = oneNum * twoNum;
                        break;
                    case "/":
                        ansNum = oneNum / twoNum;
                        break;
                }
                textBox1.Text = "";
                first = false;
            }
            else
            {
                switch (m[counter-1])
                {
                    case "+":
                        ansNum += twoNum;
                        break;
                    case "-":
                        ansNum -= twoNum;
                        break;
                    case "*":
                        ansNum *= twoNum;
                        break;
                    case "/":
                        ansNum /= twoNum;
                        break;
                }
                textBox1.Text = ansNum.ToString();
            }
            counter ++;
            textBox2.Text = "oneNum=" + oneNum + "\r\ntwoNum=" + twoNum + "\r\nansNum=" + ansNum + "\r\nm=" + m[counter-2] + "\r\ncounter=" + counter;
        }
    }
}