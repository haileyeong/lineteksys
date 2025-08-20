namespace myproject1
{
    partial class Form2
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
            btnInt = new Button();
            btnDouble = new Button();
            btnString = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnInt
            // 
            btnInt.Location = new Point(102, 79);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(97, 41);
            btnInt.TabIndex = 0;
            btnInt.Text = "정수형 출력";
            btnInt.UseVisualStyleBackColor = true;
            btnInt.Click += btnInt_Click;
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(102, 167);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(97, 41);
            btnDouble.TabIndex = 0;
            btnDouble.Text = "실수형 출력";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnString
            // 
            btnString.Location = new Point(102, 250);
            btnString.Name = "btnString";
            btnString.Size = new Size(97, 41);
            btnString.TabIndex = 0;
            btnString.Text = "문자열 출력";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("한컴 말랑말랑 Bold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblResult.Location = new Point(356, 175);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(46, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "결과";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 404);
            Controls.Add(lblResult);
            Controls.Add(btnString);
            Controls.Add(btnDouble);
            Controls.Add(btnInt);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInt;
        private Button btnDouble;
        private Button btnString;
        private Label lblResult;
    }
}