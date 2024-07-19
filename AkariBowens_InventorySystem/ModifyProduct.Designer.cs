namespace AkariBowens_InventorySystem
{
    partial class ModifyProduct
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
            this.assocPartsGridView = new System.Windows.Forms.DataGridView();
            this.allPartsGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.assocPartsLabel = new System.Windows.Forms.Label();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.minBoxLabel = new System.Windows.Forms.Label();
            this.maxBoxLabel = new System.Windows.Forms.Label();
            this.priceCostBoxLabel = new System.Windows.Forms.Label();
            this.inventoryBoxLabel = new System.Windows.Forms.Label();
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.idBoxLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assocPartsGridView
            // 
            this.assocPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assocPartsGridView.Location = new System.Drawing.Point(450, 310);
            this.assocPartsGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assocPartsGridView.Name = "assocPartsGridView";
            this.assocPartsGridView.RowHeadersWidth = 62;
            this.assocPartsGridView.RowTemplate.Height = 28;
            this.assocPartsGridView.Size = new System.Drawing.Size(475, 135);
            this.assocPartsGridView.TabIndex = 84;
            this.assocPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assocPartsGridView_CellContentClick);
            this.assocPartsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.assocPartsDGVBindingComplete);
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(450, 90);
            this.allPartsGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.RowHeadersWidth = 62;
            this.allPartsGridView.RowTemplate.Height = 28;
            this.allPartsGridView.Size = new System.Drawing.Size(475, 135);
            this.allPartsGridView.TabIndex = 83;
            this.allPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsGridView_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(845, 460);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(62, 30);
            this.deleteButton.TabIndex = 82;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(845, 505);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 31);
            this.cancelButton.TabIndex = 81;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(760, 505);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(62, 31);
            this.saveButton.TabIndex = 80;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(690, 51);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(220, 25);
            this.searchTextBox.TabIndex = 79;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchButton.Location = new System.Drawing.Point(610, 50);
            this.addProductSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(72, 30);
            this.addProductSearchButton.TabIndex = 78;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(45, 40);
            this.modifyProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(216, 32);
            this.modifyProductLabel.TabIndex = 77;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.assocPartsLabel.Location = new System.Drawing.Point(448, 280);
            this.assocPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(203, 16);
            this.assocPartsLabel.TabIndex = 76;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.allPartsLabel.Location = new System.Drawing.Point(448, 60);
            this.allPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(115, 16);
            this.allPartsLabel.TabIndex = 75;
            this.allPartsLabel.Text = "All candidate Parts";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(845, 240);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 31);
            this.addButton.TabIndex = 74;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minBoxLabel
            // 
            this.minBoxLabel.AutoSize = true;
            this.minBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBoxLabel.Location = new System.Drawing.Point(210, 350);
            this.minBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minBoxLabel.Name = "minBoxLabel";
            this.minBoxLabel.Size = new System.Drawing.Size(36, 19);
            this.minBoxLabel.TabIndex = 73;
            this.minBoxLabel.Text = "Min";
            // 
            // maxBoxLabel
            // 
            this.maxBoxLabel.AutoSize = true;
            this.maxBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBoxLabel.Location = new System.Drawing.Point(50, 350);
            this.maxBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxBoxLabel.Name = "maxBoxLabel";
            this.maxBoxLabel.Size = new System.Drawing.Size(38, 19);
            this.maxBoxLabel.TabIndex = 72;
            this.maxBoxLabel.Text = "Max";
            // 
            // priceCostBoxLabel
            // 
            this.priceCostBoxLabel.AutoSize = true;
            this.priceCostBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCostBoxLabel.Location = new System.Drawing.Point(50, 300);
            this.priceCostBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceCostBoxLabel.Name = "priceCostBoxLabel";
            this.priceCostBoxLabel.Size = new System.Drawing.Size(43, 19);
            this.priceCostBoxLabel.TabIndex = 71;
            this.priceCostBoxLabel.Text = "Price";
            // 
            // inventoryBoxLabel
            // 
            this.inventoryBoxLabel.AutoSize = true;
            this.inventoryBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBoxLabel.Location = new System.Drawing.Point(50, 250);
            this.inventoryBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryBoxLabel.Name = "inventoryBoxLabel";
            this.inventoryBoxLabel.Size = new System.Drawing.Size(75, 19);
            this.inventoryBoxLabel.TabIndex = 70;
            this.inventoryBoxLabel.Text = "Inventory";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBoxLabel.Location = new System.Drawing.Point(50, 200);
            this.nameBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(51, 19);
            this.nameBoxLabel.TabIndex = 69;
            this.nameBoxLabel.Text = "Name";
            // 
            // idBoxLabel
            // 
            this.idBoxLabel.AutoSize = true;
            this.idBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBoxLabel.Location = new System.Drawing.Point(50, 150);
            this.idBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idBoxLabel.Name = "idBoxLabel";
            this.idBoxLabel.Size = new System.Drawing.Size(24, 19);
            this.idBoxLabel.TabIndex = 68;
            this.idBoxLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(257, 340);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(95, 29);
            this.minTextBox.TabIndex = 67;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(101, 340);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(95, 29);
            this.maxTextBox.TabIndex = 66;
            // 
            // priceCostTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(151, 290);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceCostTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(155, 29);
            this.priceTextBox.TabIndex = 65;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTextBox.Location = new System.Drawing.Point(151, 240);
            this.InventoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(155, 29);
            this.InventoryTextBox.TabIndex = 64;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(151, 190);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 29);
            this.nameTextBox.TabIndex = 63;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(151, 140);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(155, 29);
            this.idTextBox.TabIndex = 62;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 571);
            this.Controls.Add(this.assocPartsGridView);
            this.Controls.Add(this.allPartsGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addProductSearchButton);
            this.Controls.Add(this.modifyProductLabel);
            this.Controls.Add(this.assocPartsLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.minBoxLabel);
            this.Controls.Add(this.maxBoxLabel);
            this.Controls.Add(this.priceCostBoxLabel);
            this.Controls.Add(this.inventoryBoxLabel);
            this.Controls.Add(this.nameBoxLabel);
            this.Controls.Add(this.idBoxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assocPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assocPartsGridView;
        private System.Windows.Forms.DataGridView allPartsGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addProductSearchButton;
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label assocPartsLabel;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label minBoxLabel;
        private System.Windows.Forms.Label maxBoxLabel;
        private System.Windows.Forms.Label priceCostBoxLabel;
        private System.Windows.Forms.Label inventoryBoxLabel;
        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.Label idBoxLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}