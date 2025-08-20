using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            // 실행 프로그램 작성
            int iValue = 100;
            lblResult.Text = iValue.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            // 실행 프로그램 작성
            double dValue = 11.01;
            lblResult.Text = dValue.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            // 실행 프로그램 작성
            string sValue = "C# 프로그래밍 기초";
            lblResult.Text = sValue;
        }
    }
}
