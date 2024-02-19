namespace OrderForm
{
    partial class Main_form
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Btn_Whopper = new Button();
            Btn_Cancel_all = new Button();
            Btn_Cancel_Selection = new Button();
            Btn_Whopper_Js = new Button();
            label1 = new Label();
            Lb_Total_Price = new Label();
            button5 = new Button();
            panel1 = new Panel();
            drink1 = new WinFormsApp1.Food.Drink();
            side1 = new WinFormsApp1.Food.Side();
            main1 = new WinFormsApp1.Food.Main();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.Location = new Point(106, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(296, 219);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "메뉴";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "수량";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "가격";
            columnHeader3.Width = 100;
            // 
            // Btn_Whopper
            // 
            Btn_Whopper.Location = new Point(567, 12);
            Btn_Whopper.Name = "Btn_Whopper";
            Btn_Whopper.Size = new Size(100, 68);
            Btn_Whopper.TabIndex = 1;
            Btn_Whopper.Text = "메인";
            Btn_Whopper.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel_all
            // 
            Btn_Cancel_all.Location = new Point(716, 410);
            Btn_Cancel_all.Name = "Btn_Cancel_all";
            Btn_Cancel_all.Size = new Size(100, 68);
            Btn_Cancel_all.TabIndex = 2;
            Btn_Cancel_all.Text = "전체 취소";
            Btn_Cancel_all.UseVisualStyleBackColor = true;
            Btn_Cancel_all.Click += Btn_Cancel_all_Click;
            // 
            // Btn_Cancel_Selection
            // 
            Btn_Cancel_Selection.Location = new Point(567, 410);
            Btn_Cancel_Selection.Name = "Btn_Cancel_Selection";
            Btn_Cancel_Selection.Size = new Size(100, 68);
            Btn_Cancel_Selection.TabIndex = 3;
            Btn_Cancel_Selection.Text = "선택 취소";
            Btn_Cancel_Selection.UseVisualStyleBackColor = true;
            Btn_Cancel_Selection.Click += Btn_Cancel_Selection_Click;
            // 
            // Btn_Whopper_Js
            // 
            Btn_Whopper_Js.Location = new Point(716, 12);
            Btn_Whopper_Js.Name = "Btn_Whopper_Js";
            Btn_Whopper_Js.RightToLeft = RightToLeft.No;
            Btn_Whopper_Js.Size = new Size(100, 68);
            Btn_Whopper_Js.TabIndex = 4;
            Btn_Whopper_Js.Text = "와퍼 주니어";
            Btn_Whopper_Js.UseVisualStyleBackColor = true;
            Btn_Whopper_Js.Click += Btn_Whopper_Js_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(106, 357);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 5;
            label1.Text = "총 금액";
            // 
            // Lb_Total_Price
            // 
            Lb_Total_Price.AutoSize = true;
            Lb_Total_Price.BackColor = Color.White;
            Lb_Total_Price.BorderStyle = BorderStyle.Fixed3D;
            Lb_Total_Price.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Lb_Total_Price.Location = new Point(252, 357);
            Lb_Total_Price.Name = "Lb_Total_Price";
            Lb_Total_Price.Size = new Size(152, 34);
            Lb_Total_Price.TabIndex = 6;
            Lb_Total_Price.Text = "                 ";
            // 
            // button5
            // 
            button5.Location = new Point(862, 410);
            button5.Name = "button5";
            button5.Size = new Size(100, 68);
            button5.TabIndex = 7;
            button5.Text = "결제";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(drink1);
            panel1.Controls.Add(side1);
            panel1.Controls.Add(main1);
            panel1.Location = new Point(567, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 282);
            panel1.TabIndex = 8;
            // 
            // drink1
            // 
            drink1.Location = new Point(0, 0);
            drink1.Name = "drink1";
            drink1.Size = new Size(398, 320);
            drink1.TabIndex = 2;
            // 
            // side1
            // 
            side1.Location = new Point(0, 0);
            side1.Name = "side1";
            side1.Size = new Size(396, 310);
            side1.TabIndex = 1;
            // 
            // main1
            // 
            main1.Location = new Point(0, -21);
            main1.Name = "main1";
            main1.Size = new Size(418, 334);
            main1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(862, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 68);
            button1.TabIndex = 9;
            button1.Text = "음료";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1067, 568);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(Lb_Total_Price);
            Controls.Add(label1);
            Controls.Add(Btn_Whopper_Js);
            Controls.Add(Btn_Cancel_Selection);
            Controls.Add(Btn_Cancel_all);
            Controls.Add(Btn_Whopper);
            Controls.Add(listView1);
            Name = "Main_form";
            Text = "Main_form";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button Btn_Whopper;
        private Button Btn_Cancel_all;
        private Button Btn_Cancel_Selection;
        private Button Btn_Whopper_Js;
        private Label label1;
        private Label Lb_Total_Price;
        private Button button5;
        private Panel panel1;
        private WinFormsApp1.Food.Drink drink1;
        private WinFormsApp1.Food.Side side1;
        private WinFormsApp1.Food.Main main1;
        private Button button1;
    }
}