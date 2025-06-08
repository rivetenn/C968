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
            AddPartButton = new Button();
            ModifyPB = new Button();
            DPartsB = new Button();
            Exit = new Button();
            DProdB = new Button();
            MProB = new Button();
            AddProductsButton = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            PartsSearch = new Button();
            ProdSearch = new Button();
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
            // AddPartButton
            // 
            AddPartButton.Location = new Point(116, 346);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(75, 23);
            AddPartButton.TabIndex = 1;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // ModifyPB
            // 
            ModifyPB.Location = new Point(197, 346);
            ModifyPB.Name = "ModifyPB";
            ModifyPB.Size = new Size(75, 23);
            ModifyPB.TabIndex = 2;
            ModifyPB.Text = "Modify";
            ModifyPB.UseVisualStyleBackColor = true;
            ModifyPB.Click += ModifyPB_Click;
            // 
            // DPartsB
            // 
            DPartsB.Location = new Point(278, 346);
            DPartsB.Name = "DPartsB";
            DPartsB.Size = new Size(75, 23);
            DPartsB.TabIndex = 3;
            DPartsB.Text = "Delete";
            DPartsB.UseVisualStyleBackColor = true;
            DPartsB.Click += DPartsB_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(682, 415);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // DProdB
            // 
            DProdB.Location = new Point(682, 346);
            DProdB.Name = "DProdB";
            DProdB.Size = new Size(75, 23);
            DProdB.TabIndex = 7;
            DProdB.Text = "Delete";
            DProdB.UseVisualStyleBackColor = true;
            DProdB.Click += DProdB_Click;
            // 
            // MProB
            // 
            MProB.Location = new Point(601, 346);
            MProB.Name = "MProB";
            MProB.Size = new Size(75, 23);
            MProB.TabIndex = 6;
            MProB.Text = "Modify";
            MProB.UseVisualStyleBackColor = true;
            MProB.Click += MProB_Click;
            // 
            // AddProductsButton
            // 
            AddProductsButton.Location = new Point(520, 346);
            AddProductsButton.Name = "AddProductsButton";
            AddProductsButton.Size = new Size(75, 23);
            AddProductsButton.TabIndex = 5;
            AddProductsButton.Text = "Add";
            AddProductsButton.UseVisualStyleBackColor = true;
            AddProductsButton.Click += AddProductsButton_Click;
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
            // PartsSearch
            // 
            PartsSearch.Location = new Point(144, 86);
            PartsSearch.Name = "PartsSearch";
            PartsSearch.Size = new Size(75, 23);
            PartsSearch.TabIndex = 14;
            PartsSearch.Text = "Search";
            PartsSearch.UseVisualStyleBackColor = true;
            PartsSearch.Click += PartsSearch_Click;
            // 
            // ProdSearch
            // 
            ProdSearch.Location = new Point(548, 86);
            ProdSearch.Name = "ProdSearch";
            ProdSearch.Size = new Size(75, 23);
            ProdSearch.TabIndex = 15;
            ProdSearch.Text = "Search";
            ProdSearch.UseVisualStyleBackColor = true;
            ProdSearch.Click += ProdSearch_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProdSearch);
            Controls.Add(PartsSearch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(DProdB);
            Controls.Add(MProB);
            Controls.Add(AddProductsButton);
            Controls.Add(Exit);
            Controls.Add(DPartsB);
            Controls.Add(ModifyPB);
            Controls.Add(AddPartButton);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddPartButton;
        private Button ModifyPB;
        private Button DPartsB;
        private Button Exit;
        private Button DProdB;
        private Button MProB;
        private Button AddProductsButton;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button PartsSearch;
        private Button ProdSearch;

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddParts newform = new AddParts();
            newform.ShowDialog();
        }

        private void ModifyPB_Click(object sender, EventArgs e)
        {
            ModifyPart newform = new ModifyPart();
            newform.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DPartsB_Click(object sender, EventArgs e){
            //
        }
        private void DProdB_Click(object sender, EventArgs e)
        {
            //
        }
        private void MProB_Click(object sender, EventArgs e)
        {
            ModifyProduct newform = new ModifyProduct();
            newform.ShowDialog();
        }
        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddProduct newform = new AddProduct();
            newform.ShowDialog();
        }
        private void ProdSearch_Click(object sender, EventArgs e)
        {
            // Search for products
        }
        private void PartsSearch_Click(object sender, EventArgs e)
        {
            // Search for parts
        }

    }
}
