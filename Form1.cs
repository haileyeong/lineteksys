namespace myproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ���� ���α׷� �ۼ�
            label1.Text = "C# ���α׷���";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ���� ���α׷� �ۼ�
            label1.ResetText();
        }
    }
}
