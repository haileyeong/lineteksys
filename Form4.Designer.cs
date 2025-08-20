namespace myproject1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbKor = new TextBox();
            label2 = new Label();
            tbEng = new TextBox();
            label3 = new Label();
            tbMath = new TextBox();
            btnResult = new Button();
            lblResult = new Label();
            label4 = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 169);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "국어";
            // 
            // tbKor
            // 
            tbKor.Location = new Point(150, 163);
            tbKor.Name = "tbKor";
            tbKor.Size = new Size(100, 23);
            tbKor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 171);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "영어";
            // 
            // tbEng
            // 
            tbEng.Location = new Point(350, 166);
            tbEng.Name = "tbEng";
            tbEng.Size = new Size(100, 23);
            tbEng.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 171);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "수학";
            // 
            // tbMath
            // 
            tbMath.Location = new Point(571, 166);
            tbMath.Name = "tbMath";
            tbMath.Size = new Size(100, 23);
            tbMath.TabIndex = 1;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(274, 253);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(250, 71);
            btnResult.TabIndex = 2;
            btnResult.Text = "결과 출력";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(315, 360);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(190, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "버튼을 누르면 결과가 출력됩니다.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 82);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "이름";
            //label4.Click += this.label4_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(350, 77);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnResult);
            Controls.Add(tbMath);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(tbEng);
            Controls.Add(label2);
            Controls.Add(tbKor);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbKor;
        private Label label2;
        private TextBox tbEng;
        private Label label3;
        private TextBox tbMath;
        private Button btnResult;
        private Label lblResult;
        private Label label4;
        private TextBox tbName;
    }
}