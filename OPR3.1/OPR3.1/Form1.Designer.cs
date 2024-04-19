namespace OPR3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            d1x = new TextBox();
            label2 = new Label();
            label3 = new Label();
            d1y = new TextBox();
            label4 = new Label();
            d2y = new TextBox();
            label5 = new Label();
            d2x = new TextBox();
            label6 = new Label();
            label7 = new Label();
            d3y = new TextBox();
            label8 = new Label();
            d3x = new TextBox();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 65);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "вершина 1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // d1x
            // 
            d1x.Location = new Point(156, 62);
            d1x.Name = "d1x";
            d1x.Size = new Size(40, 27);
            d1x.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 65);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 2;
            label2.Text = "x";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 68);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 4;
            label3.Text = "y";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // d1y
            // 
            d1y.Location = new Point(240, 65);
            d1y.Name = "d1y";
            d1y.Size = new Size(40, 27);
            d1y.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 101);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 9;
            label4.Text = "y";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // d2y
            // 
            d2y.Location = new Point(240, 98);
            d2y.Name = "d2y";
            d2y.Size = new Size(40, 27);
            d2y.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 98);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 7;
            label5.Text = "x";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // d2x
            // 
            d2x.Location = new Point(156, 95);
            d2x.Name = "d2x";
            d2x.Size = new Size(40, 27);
            d2x.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 98);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "вершина 2";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 135);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 14;
            label7.Text = "y";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // d3y
            // 
            d3y.Location = new Point(240, 132);
            d3y.Name = "d3y";
            d3y.Size = new Size(40, 27);
            d3y.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 132);
            label8.Name = "label8";
            label8.Size = new Size(16, 20);
            label8.TabIndex = 12;
            label8.Text = "x";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // d3x
            // 
            d3x.Location = new Point(156, 129);
            d3x.Name = "d3x";
            d3x.Size = new Size(40, 27);
            d3x.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 132);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 10;
            label9.Text = "вершина 3";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(115, 178);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 15;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 242);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(d3y);
            Controls.Add(label8);
            Controls.Add(d3x);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(d2y);
            Controls.Add(label5);
            Controls.Add(d2x);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(d1y);
            Controls.Add(label2);
            Controls.Add(d1x);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox d1x;
        private Label label2;
        private Label label3;
        private TextBox d1y;
        private Label label4;
        private TextBox d2y;
        private Label label5;
        private TextBox d2x;
        private Label label6;
        private Label label7;
        private TextBox d3y;
        private Label label8;
        private TextBox d3x;
        private Label label9;
        private Button button1;
    }
}
