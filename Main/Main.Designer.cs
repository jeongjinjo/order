namespace WinFormsApp1.Food
{
    partial class Main
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(255, 162);
            button9.Name = "button9";
            button9.Size = new Size(111, 58);
            button9.TabIndex = 1;
            button9.Text = "플랑크톤 버거";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(144, 162);
            button8.Name = "button8";
            button8.Size = new Size(107, 58);
            button8.TabIndex = 2;
            button8.Text = "고래 버거";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(28, 162);
            button7.Name = "button7";
            button7.Size = new Size(112, 58);
            button7.TabIndex = 3;
            button7.Text = "쉬림프 와퍼";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(28, 99);
            button6.Name = "button6";
            button6.Size = new Size(112, 59);
            button6.TabIndex = 4;
            button6.Text = "집게리아 버거";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(144, 99);
            button5.Name = "button5";
            button5.Size = new Size(107, 59);
            button5.TabIndex = 5;
            button5.Text = "게살 버거";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(255, 99);
            button4.Name = "button4";
            button4.Size = new Size(111, 59);
            button4.TabIndex = 6;
            button4.Text = "새우 버거";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(255, 37);
            button3.Name = "button3";
            button3.Size = new Size(111, 58);
            button3.TabIndex = 7;
            button3.Text = "게살 와퍼";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(144, 37);
            button2.Name = "button2";
            button2.Size = new Size(107, 58);
            button2.TabIndex = 8;
            button2.Text = "불고기 와퍼";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(28, 37);
            button1.Name = "button1";
            button1.Size = new Size(112, 58);
            button1.TabIndex = 9;
            button1.Text = "와퍼";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(9, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 263);
            panel1.TabIndex = 10;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Main";
            Size = new Size(418, 334);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
    }
}
