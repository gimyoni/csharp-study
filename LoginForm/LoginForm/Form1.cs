using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "홍길동")
            {
                if (textBox2.Text == "1234")
                {
                    MessageBox.Show("로그인에 성공하였습니다.");
                }
                else
                    MessageBox.Show("로그인에 실패하였습니다.");
            }
            else
                MessageBox.Show("없는 계정입니다");
        }
    }
}
