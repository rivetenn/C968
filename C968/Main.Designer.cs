namespace C968
{
    partial class Main
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // button1
            // 
            button1.Location = new Point(116, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(197, 346);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(278, 346);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(682, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(682, 346);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(601, 346);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "Modify";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(520, 346);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 5;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 85);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Parts";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(17, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(336, 214);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 85);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Products";
            label3.Click += label3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(421, 115);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(336, 214);
            listBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(629, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 13;
            // 
            // button8
            // 
            button8.Location = new Point(144, 86);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 14;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(548, 86);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 15;
            button9.Text = "Search";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button8;
        private Button button9;
    }
}
