namespace C968
{
    partial class AddParts
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
            RadHouse = new RadioButton();
            Radout = new RadioButton();
            TextID = new TextBox();
            TextName = new TextBox();
            TextMin = new TextBox();
            TextInv = new TextBox();
            TextVaried = new TextBox();
            textMax = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LabelChange = new Label();
            SaveB = new Button();
            CancelB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // RadHouse
            // 
            RadHouse.AutoSize = true;
            RadHouse.Location = new Point(76, 66);
            RadHouse.Name = "RadHouse";
            RadHouse.Size = new Size(74, 19);
            RadHouse.TabIndex = 1;
            RadHouse.TabStop = true;
            RadHouse.Text = "In-House";
            RadHouse.UseVisualStyleBackColor = true;
            // 
            // Radout
            // 
            Radout.AutoSize = true;
            Radout.Location = new Point(175, 66);
            Radout.Name = "Radout";
            Radout.Size = new Size(88, 19);
            Radout.TabIndex = 2;
            Radout.TabStop = true;
            Radout.Text = "OutSourced";
            Radout.UseVisualStyleBackColor = true;
            // 
            // TextID
            // 
            TextID.Location = new Point(113, 108);
            TextID.Name = "TextID";
            TextID.Size = new Size(100, 23);
            TextID.TabIndex = 3;
            // 
            // TextName
            // 
            TextName.Location = new Point(113, 152);
            TextName.Name = "TextName";
            TextName.Size = new Size(100, 23);
            TextName.TabIndex = 4;
            // 
            // TextMin
            // 
            TextMin.Location = new Point(113, 240);
            TextMin.Name = "TextMin";
            TextMin.Size = new Size(72, 23);
            TextMin.TabIndex = 5;
            // 
            // TextInv
            // 
            TextInv.Location = new Point(113, 196);
            TextInv.Name = "TextInv";
            TextInv.Size = new Size(100, 23);
            TextInv.TabIndex = 6;
            // 
            // TextVaried
            // 
            TextVaried.Location = new Point(113, 284);
            TextVaried.Name = "TextVaried";
            TextVaried.Size = new Size(100, 23);
            TextVaried.TabIndex = 7;
            // 
            // textMax
            // 
            textMax.Location = new Point(252, 240);
            textMax.Name = "textMax";
            textMax.Size = new Size(72, 23);
            textMax.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 116);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 9;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 160);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 204);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 248);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 12;
            label5.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 248);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 13;
            label6.Text = "Max";
            // 
            // LabelChange
            // 
            LabelChange.AutoSize = true;
            LabelChange.Location = new Point(55, 292);
            LabelChange.Name = "LabelChange";
            LabelChange.Size = new Size(38, 15);
            LabelChange.TabIndex = 14;
            LabelChange.Text = "label7";
            // 
            // SaveB
            // 
            SaveB.Location = new Point(164, 379);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(75, 23);
            SaveB.TabIndex = 15;
            SaveB.Text = "Save";
            SaveB.UseVisualStyleBackColor = true;
            // 
            // CancelB
            // 
            CancelB.Location = new Point(276, 379);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 16;
            CancelB.Text = "Cancel";
            CancelB.UseVisualStyleBackColor = true;
            CancelB.Click += CancelB_Click;
            // 
            // AddParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 424);
            Controls.Add(CancelB);
            Controls.Add(SaveB);
            Controls.Add(LabelChange);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textMax);
            Controls.Add(TextVaried);
            Controls.Add(TextInv);
            Controls.Add(TextMin);
            Controls.Add(TextName);
            Controls.Add(TextID);
            Controls.Add(Radout);
            Controls.Add(RadHouse);
            Controls.Add(label1);
            Name = "AddParts";
            Text = "Add Parts";
            Load += AddParts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void CancelB_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private RadioButton RadHouse;
        private RadioButton Radout;
        private TextBox TextID;
        private TextBox TextName;
        private TextBox TextMin;
        private TextBox TextInv;
        private TextBox TextVaried;
        private TextBox textMax;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LabelChange;
        private Button SaveB;
        private Button CancelB;


        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}