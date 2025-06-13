using System.ComponentModel;
using System.Globalization;

namespace C968
{
    partial class AddProduct
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ProdMax = new TextBox();
            ProdInv = new TextBox();
            ProdMin = new TextBox();
            ProdName = new TextBox();
            label1 = new Label();
            ProdID = new TextBox();
            ProdPrice = new TextBox();
            label7 = new Label();
            SearchB = new Button();
            SearchText = new TextBox();
            label8 = new Label();
            label9 = new Label();
            CancelB = new Button();
            SaveB = new Button();
            DeleteB = new Button();
            AddB = new Button();
            ProdAllParts = new DataGridView();
            ProdAssParts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProdAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdAssParts).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 302);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 42;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 302);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 41;
            label5.Text = "Min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 210);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 40;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 166);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 39;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 122);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 38;
            label2.Text = "ID";
            // 
            // ProdMax
            // 
            ProdMax.Location = new Point(251, 294);
            ProdMax.Name = "ProdMax";
            ProdMax.Size = new Size(72, 23);
            ProdMax.TabIndex = 37;
            // 
            // ProdInv
            // 
            ProdInv.Location = new Point(112, 202);
            ProdInv.Name = "ProdInv";
            ProdInv.Size = new Size(100, 23);
            ProdInv.TabIndex = 36;
            // 
            // ProdMin
            // 
            ProdMin.Location = new Point(112, 294);
            ProdMin.Name = "ProdMin";
            ProdMin.Size = new Size(72, 23);
            ProdMin.TabIndex = 35;
            // 
            // ProdName
            // 
            ProdName.Location = new Point(112, 158);
            ProdName.Name = "ProdName";
            ProdName.Size = new Size(100, 23);
            ProdName.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 31;
            label1.Text = "Add Product";
            // 
            // ProdID
            // 
            ProdID.Location = new Point(112, 114);
            ProdID.Name = "ProdID";
            ProdID.Size = new Size(100, 23);
            ProdID.TabIndex = 43;
            // 
            // ProdPrice
            // 
            ProdPrice.Location = new Point(112, 248);
            ProdPrice.Name = "ProdPrice";
            ProdPrice.Size = new Size(100, 23);
            ProdPrice.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 256);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 45;
            label7.Text = "Price";
            // 
            // SearchB
            // 
            SearchB.Location = new Point(511, 58);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(75, 23);
            SearchB.TabIndex = 47;
            SearchB.Text = "Search";
            SearchB.UseVisualStyleBackColor = true;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(601, 58);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(128, 23);
            SearchText.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(394, 78);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 50;
            label8.Text = "All Parts";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(394, 264);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 51;
            label9.Text = "Associated Parts";
            // 
            // CancelB
            // 
            CancelB.Location = new Point(654, 481);
            CancelB.Name = "CancelB";
            CancelB.Size = new Size(75, 23);
            CancelB.TabIndex = 52;
            CancelB.Text = "Cancel";
            CancelB.UseVisualStyleBackColor = true;
            // 
            // SaveB
            // 
            SaveB.Location = new Point(561, 446);
            SaveB.Name = "SaveB";
            SaveB.Size = new Size(75, 23);
            SaveB.TabIndex = 53;
            SaveB.Text = "Save";
            SaveB.UseVisualStyleBackColor = true;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(654, 446);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(75, 23);
            DeleteB.TabIndex = 54;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = true;
            // 
            // AddB
            // 
            AddB.Location = new Point(654, 256);
            AddB.Name = "AddB";
            AddB.Size = new Size(75, 23);
            AddB.TabIndex = 78;
            AddB.Text = "Add";
            AddB.UseVisualStyleBackColor = true;
            // 
            // ProdAllParts
            // 
            ProdAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdAllParts.Location = new Point(394, 96);
            ProdAllParts.Name = "ProdAllParts";
            ProdAllParts.Size = new Size(335, 150);
            ProdAllParts.TabIndex = 79;
            // 
            // ProdAssParts
            // 
            ProdAssParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdAssParts.Location = new Point(394, 280);
            ProdAssParts.Name = "ProdAssParts";
            ProdAssParts.Size = new Size(335, 150);
            ProdAssParts.TabIndex = 80;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 526);
            Controls.Add(ProdAssParts);
            Controls.Add(ProdAllParts);
            Controls.Add(AddB);
            Controls.Add(DeleteB);
            Controls.Add(SaveB);
            Controls.Add(CancelB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(SearchB);
            Controls.Add(SearchText);
            Controls.Add(label7);
            Controls.Add(ProdPrice);
            Controls.Add(ProdID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProdMax);
            Controls.Add(ProdInv);
            Controls.Add(ProdMin);
            Controls.Add(ProdName);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "Add Products";
            ((System.ComponentModel.ISupportInitialize)ProdAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdAssParts).EndInit();
            ResumeLayout(false);
            PerformLayout();

            SaveB.Click += SaveB_Click;
            CancelB.Click += CancelB_Click;
            Load += StartUp;
            DeleteB.Click += DeleteB_Click;
            AddB.Click += AddB_Click;
        }

        private void SaveB_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox ProdMax;
        private TextBox ProdInv;
        private TextBox ProdMin;
        private TextBox ProdName;
        private Label label1;
        private TextBox ProdID;
        private TextBox ProdPrice;
        private Label label7;
        private Button SearchB;
        private TextBox SearchText;
        private Label label8;
        private Label label9;
        private Button CancelB;
        private Button SaveB;
        private Button DeleteB;
        private Button AddB;
        public DataGridView ProdAllParts;
        public DataGridView ProdAssParts;

        private BindingList<Part> CurrAP = new BindingList<Part>();

        public Product Taker;
        public int rowIndex =-1;

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            int min = int.Parse(ProdMin.Text);
            int max = int.Parse(ProdMax.Text);
            int innit = int.Parse(ProdInv.Text);
            if (min > max || innit < min || innit > max)
            {
                return;
            }

            var product = new Product(
                ProdName.Text, decimal.Parse(ProdPrice.Text), innit, min, max
            );

            foreach (var part in CurrAP)
            {
                product.addAssociatedPart(part);
            }
            if(rowIndex != -1)
            {
                Inventory.updateProduct(rowIndex, product);
                this.Close();
            }
            else
            {
                Inventory.AddProd(product);
            }

            this.Close();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (ProdAllParts.CurrentRow.DataBoundItem is Part selectedPart)
            {
                CurrAP.Add(selectedPart);
            }
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (ProdAssParts.CurrentRow.DataBoundItem is Part selectedPart)
            {
                CurrAP.Remove(selectedPart);
            }
        }
        private void StartUp(object sender, EventArgs e)
        {
            ProdAllParts.DataSource = Inventory.AllParts;
            ProdAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdAllParts.MultiSelect = false;

            if (Taker != null)
            {
                ProdID.Text = Taker.ProductID.ToString();
                ProdName.Text = Taker.Name;
                ProdPrice.Text = Taker.Price.ToString();
                ProdInv.Text = Taker.InStock.ToString();
                ProdMin.Text = Taker.Min.ToString();
                ProdMax.Text = Taker.Max.ToString();
                CurrAP = Taker.AssociatedParts;
            }
            else
            {
                ProdID.Text = Product.AIP.ToString();
            }
               
            ProdID.ReadOnly = true;
            ProdAssParts.DataSource = CurrAP;
            ProdAssParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProdAssParts.MultiSelect = false;

        }
    }
}