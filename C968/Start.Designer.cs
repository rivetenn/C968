using System.Diagnostics;

namespace C968
{
    partial class Start
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            PartsSearch = new Button();
            ProdSearch = new Button();
            PartsGridView = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            PartName = new DataGridViewTextBoxColumn();
            PartPrice = new DataGridViewTextBoxColumn();
            Partinstock = new DataGridViewTextBoxColumn();
            PartMin = new DataGridViewTextBoxColumn();
            PartMax = new DataGridViewTextBoxColumn();
            PartMID = new DataGridViewTextBoxColumn();
            PartCN = new DataGridViewTextBoxColumn();
            ProdGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdGridView).BeginInit();
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
            AddPartButton.Location = new Point(325, 347);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(75, 23);
            AddPartButton.TabIndex = 1;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // ModifyPB
            // 
            ModifyPB.Location = new Point(406, 347);
            ModifyPB.Name = "ModifyPB";
            ModifyPB.Size = new Size(75, 23);
            ModifyPB.TabIndex = 2;
            ModifyPB.Text = "Modify";
            ModifyPB.UseVisualStyleBackColor = true;
            ModifyPB.Click += ModifyPB_Click;
            // 
            // DPartsB
            // 
            DPartsB.Location = new Point(487, 347);
            DPartsB.Name = "DPartsB";
            DPartsB.Size = new Size(75, 23);
            DPartsB.TabIndex = 3;
            DPartsB.Text = "Delete";
            DPartsB.UseVisualStyleBackColor = true;
            DPartsB.Click += DPartsB_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(994, 416);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // DProdB
            // 
            DProdB.Location = new Point(994, 347);
            DProdB.Name = "DProdB";
            DProdB.Size = new Size(75, 23);
            DProdB.TabIndex = 7;
            DProdB.Text = "Delete";
            DProdB.UseVisualStyleBackColor = true;
            DProdB.Click += DProdB_Click;
            // 
            // MProB
            // 
            MProB.Location = new Point(913, 347);
            MProB.Name = "MProB";
            MProB.Size = new Size(75, 23);
            MProB.TabIndex = 6;
            MProB.Text = "Modify";
            MProB.UseVisualStyleBackColor = true;
            MProB.Click += MProB_Click;
            // 
            // AddProductsButton
            // 
            AddProductsButton.Location = new Point(832, 347);
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
            label2.Location = new Point(17, 91);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "Parts";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(636, 90);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Products";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(938, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 13;
            // 
            // PartsSearch
            // 
            PartsSearch.Location = new Point(353, 87);
            PartsSearch.Name = "PartsSearch";
            PartsSearch.Size = new Size(75, 23);
            PartsSearch.TabIndex = 14;
            PartsSearch.Text = "Search";
            PartsSearch.UseVisualStyleBackColor = true;
            // 
            // ProdSearch
            // 
            ProdSearch.Location = new Point(857, 83);
            ProdSearch.Name = "ProdSearch";
            ProdSearch.Size = new Size(75, 23);
            ProdSearch.TabIndex = 15;
            ProdSearch.Text = "Search";
            ProdSearch.UseVisualStyleBackColor = true;
            ProdSearch.Click += ProdSearch_Click;
            // 
            // PartsGridView
            // 
            PartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGridView.Columns.AddRange(new DataGridViewColumn[] { PartID, PartName, PartPrice, Partinstock, PartMin, PartMax, PartMID, PartCN });
            PartsGridView.Location = new Point(17, 125);
            PartsGridView.Name = "PartsGridView";
            PartsGridView.Size = new Size(545, 204);
            PartsGridView.TabIndex = 18;
            // 
            // PartID
            // 
            PartID.DataPropertyName = "PartID";
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            // 
            // PartName
            // 
            PartName.DataPropertyName = "PartName";
            PartName.HeaderText = "Name";
            PartName.Name = "PartName";
            // 
            // PartPrice
            // 
            PartPrice.DataPropertyName = "PartPrice";
            PartPrice.HeaderText = "Price";
            PartPrice.Name = "PartPrice";
            // 
            // Partinstock
            // 
            Partinstock.DataPropertyName = "Partinstock";
            Partinstock.HeaderText = "InStock";
            Partinstock.Name = "Partinstock";
            // 
            // PartMin
            // 
            PartMin.DataPropertyName = "PartMin";
            PartMin.HeaderText = "Min";
            PartMin.Name = "PartMin";
            // 
            // PartMax
            // 
            PartMax.DataPropertyName = "PartMax";
            PartMax.HeaderText = "Max";
            PartMax.Name = "PartMax";
            // 
            // PartMID
            // 
            PartMID.DataPropertyName = "PartMID";
            PartMID.HeaderText = "Machine ID";
            PartMID.Name = "PartMID";
            // 
            // PartCN
            // 
            PartCN.DataPropertyName = "PartCN";
            PartCN.HeaderText = "Company Name";
            PartCN.Name = "PartCN";
            // 
            // ProdGridView
            // 
            ProdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdGridView.Location = new Point(636, 125);
            ProdGridView.Name = "ProdGridView";
            ProdGridView.Size = new Size(433, 204);
            ProdGridView.TabIndex = 19;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 450);
            Controls.Add(ProdGridView);
            Controls.Add(PartsGridView);
            Controls.Add(ProdSearch);
            Controls.Add(PartsSearch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DProdB);
            Controls.Add(MProB);
            Controls.Add(AddProductsButton);
            Controls.Add(Exit);
            Controls.Add(DPartsB);
            Controls.Add(ModifyPB);
            Controls.Add(AddPartButton);
            Controls.Add(label1);
            Name = "Start";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdGridView).BeginInit();

            ResumeLayout(false);
            PerformLayout();

            Load += StartUp;
            PartsSearch.Click += PartsSearch_Click;
            ProdSearch.Click += ProdSearch_Click;
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
        private Label label3;
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
            if (PartsGridView.CurrentRow != null)
            {
                ModifyPart newform = new ModifyPart();
                Part ModPart = PartsGridView.CurrentRow.DataBoundItem as Part;
                newform.Taker = ModPart;
                newform.rowIndex = PartsGridView.CurrentCell.RowIndex;
                newform.ShowDialog();
            }
        }
        private void MProB_Click(object sender, EventArgs e)
        {
            AddProduct newform = new AddProduct();
            Product ModProduct = ProdGridView.CurrentRow.DataBoundItem as Product;
            newform.Taker = ModProduct;
            newform.rowIndex = ProdGridView.CurrentCell.RowIndex;
            newform.ShowDialog();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DPartsB_Click(object sender, EventArgs e){
            Inventory.deletePart(PartsGridView.CurrentRow.DataBoundItem as Part);
        }
        private void DProdB_Click(object sender, EventArgs e)
        {
            Inventory.removeProduct(ProdGridView.CurrentRow.DataBoundItem as Product);
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            AddProduct newform = new AddProduct();
            newform.ShowDialog();
        }
        private void ProdSearch_Click(object sender, EventArgs e)
        {
            Product search;
            try { 
                search = Inventory.lookupProduct(int.Parse(textBox2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }
            if (search != null)
            {
                foreach (DataGridViewRow row in ProdGridView.Rows)
                {
                    if (row.DataBoundItem is Product prod && prod.ProductID == search.ProductID)
                    {
                        row.Selected = true;
                        PartsGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
        private void PartsSearch_Click(object sender, EventArgs e)
        {
            Part search;
            try
            {
                search = Inventory.lookupPart(int.Parse(textBox1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Part ID.");
                return;
            }
            if (search != null)
            {
                foreach (DataGridViewRow row in PartsGridView.Rows)
                {
                    if (row.DataBoundItem is Part part && part.PartID == search.PartID)
                    {
                        row.Selected = true;
                        PartsGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
        private void ThisThing(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PartsGridView.Columns[e.ColumnIndex].Name == "PartMID")
            {
                var part = PartsGridView.Rows[e.RowIndex].DataBoundItem as Part;
                if (part is Inhouse MID)
                    e.Value = MID.PartMID;
            }
            else if (PartsGridView.Columns[e.ColumnIndex].Name == "PartCN")
            {
                var part = PartsGridView.Rows[e.RowIndex].DataBoundItem as Part;
                if (part is Outsourced CN)
                    e.Value = CN.PartCN;
            }
        }


        private void StartUp(object sender, EventArgs e)
        {
            PartsGridView.AutoGenerateColumns = false;
            PartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsGridView.MultiSelect = false;
            ProdGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdGridView.MultiSelect = false;


            Inventory.AllParts.Add(new Inhouse("Part A", 10, 5, 1, 20, 1001));
            Inventory.AllParts.Add(new Outsourced("Part B", 10, 5, 1, 20, "Compy"));
            Inventory.AllParts.Add(new Outsourced("Part C", 10, 7, 1, 20, "Place"));
            Inventory.AllParts.Add(new Outsourced("Part D", 12, 5, 1, 20, "Place"));
            Inventory.AllParts.Add(new Outsourced("Part E", 15, 8, 1, 20, "Compy"));
            Inventory.AllParts.Add(new Inhouse("Part F", 3, 5, 1, 20, 757));
            Inventory.AllParts.Add(new Inhouse("Part G", 1, 5, 1, 20, 112));
            Inventory.AllParts.Add(new Inhouse("Part H", 4, 5, 1, 20, 12));
            Inventory.Products.Add(new Product("Thing1", 3, 5, 1, 20));
            Inventory.Products.Add(new Product("Thing2", 1, 5, 1, 20));
            Inventory.Products.Add(new Product("Thing3", 4, 5, 1, 20));

            PartsGridView.DataSource = Inventory.AllParts;
            ProdGridView.DataSource = Inventory.Products;

            PartsGridView.CellFormatting += ThisThing;

        }

        public DataGridViewTextBoxColumn PartID;
        public DataGridViewTextBoxColumn PartName;
        public DataGridViewTextBoxColumn PartPrice;
        public DataGridViewTextBoxColumn Partinstock;
        public DataGridViewTextBoxColumn PartMin;
        public DataGridViewTextBoxColumn PartMax;
        public DataGridViewTextBoxColumn PartMID;
        public DataGridViewTextBoxColumn PartCN;
        public DataGridView PartsGridView;
        public DataGridView ProdGridView;
    }
}
