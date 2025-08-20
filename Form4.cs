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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int Kor = int.Parse(tbKor.Text);
            int Eng = int.Parse(tbEng.Text);
            int Math = int.Parse(tbMath.Text);
            string name = tbName.Text + "님, ";

            int total = Kor + Eng + Math;

            if (total > 250)
            {
                lblResult.Text = name + total.ToString() + "점 입니다. 합격입니다.";
            }
            else
            {
                lblResult.Text = name + total.ToString() + "점 입니다. 불합격입니다.";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
