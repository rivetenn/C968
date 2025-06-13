using System.Globalization;

namespace C968
{
    partial class ModifyPart
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
            CancelB = new Button();
            SaveB = new Button();
            MachLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            MPMax = new TextBox();
            MPVaried = new TextBox();
            MPInv = new TextBox();
            MPMin = new TextBox();
            MPName = new TextBox();
            MPID = new TextBox();
            RBOUT = new RadioButton();
            RBIN = new RadioButton();
            label1 = new Label();
            MPCN = new Label();
            Price = new Label();
            MPPrice = new TextBox();
            SuspendLayout();
            // 
            // CancelB
            // 
            CancelB.Location = new Point(282, 376);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 33;
            CancelB.Text = "Cancel";
            CancelB.UseVisualStyleBackColor = true;
            CancelB.Click += CancelB_Click;
            // 
            // SaveB
            // 
            SaveB.Location = new Point(170, 376);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(75, 23);
            SaveB.TabIndex = 32;
            SaveB.Text = "Save";
            SaveB.UseVisualStyleBackColor = true;
            SaveB.Click += SaveB_Click;
            // 
            // MachLabel
            // 
            MachLabel.AutoSize = true;
            MachLabel.Location = new Point(33, 324);
            MachLabel.Name = "MachLabel";
            MachLabel.Size = new Size(67, 15);
            MachLabel.TabIndex = 31;
            MachLabel.Text = "Machine ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 280);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 30;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 280);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 29;
            label5.Text = "Min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 201);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 28;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 157);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 27;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 113);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 26;
            label2.Text = "ID";
            // 
            // MPMax
            // 
            MPMax.Location = new Point(258, 272);
            MPMax.Name = "MPMax";
            MPMax.Size = new Size(72, 23);
            MPMax.TabIndex = 25;
            // 
            // MPVaried
            // 
            MPVaried.Location = new Point(119, 316);
            MPVaried.Name = "MPVaried";
            MPVaried.Size = new Size(100, 23);
            MPVaried.TabIndex = 24;
            // 
            // MPInv
            // 
            MPInv.Location = new Point(119, 193);
            MPInv.Name = "MPInv";
            MPInv.Size = new Size(100, 23);
            MPInv.TabIndex = 23;
            // 
            // MPMin
            // 
            MPMin.Location = new Point(119, 272);
            MPMin.Name = "MPMin";
            MPMin.Size = new Size(72, 23);
            MPMin.TabIndex = 22;
            // 
            // MPName
            // 
            MPName.Location = new Point(119, 149);
            MPName.Name = "MPName";
            MPName.Size = new Size(100, 23);
            MPName.TabIndex = 21;
            // 
            // MPID
            // 
            MPID.Location = new Point(119, 105);
            MPID.Name = "MPID";
            MPID.Size = new Size(100, 23);
            MPID.TabIndex = 20;
            // 
            // RBOUT
            // 
            RBOUT.AutoSize = true;
            RBOUT.Location = new Point(181, 63);
            RBOUT.Name = "RBOUT";
            RBOUT.Size = new Size(88, 19);
            RBOUT.TabIndex = 19;
            RBOUT.TabStop = true;
            RBOUT.Text = "OutSourced";
            RBOUT.UseVisualStyleBackColor = true;
            // 
            // RBIN
            // 
            RBIN.AutoSize = true;
            RBIN.Location = new Point(82, 63);
            RBIN.Name = "RBIN";
            RBIN.Size = new Size(74, 19);
            RBIN.TabIndex = 18;
            RBIN.TabStop = true;
            RBIN.Text = "In-House";
            RBIN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 17;
            label1.Text = "Add Part";
            // 
            // MPCN
            // 
            MPCN.AutoSize = true;
            MPCN.Location = new Point(6, 324);
            MPCN.Name = "MPCN";
            MPCN.Size = new Size(94, 15);
            MPCN.TabIndex = 34;
            MPCN.Text = "Company Name";
            MPCN.Visible = false;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(61, 241);
            Price.Name = "Price";
            Price.Size = new Size(33, 15);
            Price.TabIndex = 36;
            Price.Text = "Price";
            // 
            // MPPrice
            // 
            MPPrice.Location = new Point(119, 233);
            MPPrice.Name = "MPPrice";
            MPPrice.Size = new Size(100, 23);
            MPPrice.TabIndex = 35;
            MPPrice.TextChanged += textBox1_TextChanged;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 424);
            Controls.Add(Price);
            Controls.Add(MPPrice);
            Controls.Add(MPCN);
            Controls.Add(CancelB);
            Controls.Add(SaveB);
            Controls.Add(MachLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MPMax);
            Controls.Add(MPVaried);
            Controls.Add(MPInv);
            Controls.Add(MPMin);
            Controls.Add(MPName);
            Controls.Add(MPID);
            Controls.Add(RBOUT);
            Controls.Add(RBIN);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Modify Parts";
            Load += GetFromStarter;
            ResumeLayout(false);
            PerformLayout();

            RBIN.CheckedChanged += Radout_Change;
            RBOUT.CheckedChanged += Radout_Change;
        }

        #endregion

        private Button CancelB;
        private Button SaveB;
        private Label MachLabel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox MPMax;
        private TextBox MPVaried;
        private TextBox MPInv;
        private TextBox MPMin;
        private TextBox MPName;
        private TextBox MPID;
        private RadioButton RBOUT;
        private RadioButton RBIN;
        private Label label1;
        private Label MPCN;

        public Part Taker;
        public int rowIndex;


        void GetFromStarter(object sender, EventArgs e)
        {
            MPID.Text = Taker.PartID.ToString();
            MPName.Text = Taker.PartName;
            MPInv.Text = Taker.PartinStock.ToString();
            MPPrice.Text = Taker.PartPrice.ToString();
            MPMin.Text = Taker.PartMin.ToString();
            MPMax.Text = Taker.PartMax.ToString();
            if (Taker is Inhouse inhousePart)
            {
                RBIN.Checked = true;
                MachLabel.Visible = true;
                MPCN.Visible = false;
                MPVaried.Text = inhousePart.PartMID.ToString();
            }
            else if (Taker is Outsourced outsourcedPart)
            {
                RBOUT.Checked = true;
                MachLabel.Visible = false;
                MPCN.Visible = true;
                MPVaried.Text = outsourcedPart.PartCN;
            }
            MPID.ReadOnly = true;
        }
        void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Radout_Change(object sender, EventArgs e)
        {
            if (RBIN.Checked)
            {
                MachLabel.Visible = true;
                MPCN.Visible = false;
            }
            else if (RBOUT.Checked)
            {
                MachLabel.Visible = false;
                MPCN.Visible = true;
            }
        }
        void SaveB_Click(object sender, EventArgs e)
        {
            int min = int.Parse(MPMin.Text);
            int max = int.Parse(MPMax.Text);
            int innit = int.Parse(MPInv.Text);
            if (min > max || innit < min || innit > max)
            {
                Inventory.IncorNum();
            }
            if (RBIN.Checked)
            {
                Inventory.updatePart(rowIndex, new Inhouse(MPName.Text, decimal.Parse(MPPrice.Text), int.Parse(MPInv.Text), 
                    int.Parse(MPMin.Text), int.Parse(MPMax.Text), int.Parse(MPVaried.Text)));
            }
            else
            {
                Inventory.updatePart(rowIndex, new Outsourced(MPName.Text, decimal.Parse(MPPrice.Text), int.Parse(MPInv.Text),
                    int.Parse(MPMin.Text), int.Parse(MPMax.Text), MPVaried.Text));
            }
                this.Close();
        }
        private Label Price;
        private TextBox MPPrice;
    }
}
