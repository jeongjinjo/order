namespace WinFormsApp1.Food
{
    partial class Side
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(271, 47);
            button3.Name = "button3";
            button3.Size = new Size(113, 67);
            button3.TabIndex = 7;
            button3.Text = "게살스틱";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(141, 47);
            button2.Name = "button2";
            button2.Size = new Size(124, 67);
            button2.TabIndex = 8;
            button2.Text = "치즈스틱";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 47);
            button1.Name = "button1";
            button1.Size = new Size(123, 67);
            button1.TabIndex = 9;
            button1.Text = "감자튀김";
            button1.UseVisualStyleBackColor = true;
            // 
            // Side
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Side";
            Size = new Size(396, 310);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
    }
}
