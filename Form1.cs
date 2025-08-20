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
            // 실행 프로그램 작성
            label1.Text = "C# 프로그래밍";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 실행 프로그램 작성
            label1.ResetText();
        }
    }
}
