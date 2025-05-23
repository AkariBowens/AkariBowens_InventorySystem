﻿namespace AkariBowens_InventorySystem
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
            this.assocPartsGridView.Location = new System.Drawing.Point(675, 477);
            this.assocPartsGridView.Name = "assocPartsGridView";
            this.assocPartsGridView.RowHeadersWidth = 62;
            this.assocPartsGridView.RowTemplate.Height = 28;
            this.assocPartsGridView.Size = new System.Drawing.Size(712, 208);
            this.assocPartsGridView.TabIndex = 84;
            this.assocPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assocPartsGridView_CellContentClick);
            this.assocPartsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.assocPartsDGVBindingComplete);
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(675, 138);
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.RowHeadersWidth = 62;
            this.allPartsGridView.RowTemplate.Height = 28;
            this.allPartsGridView.Size = new System.Drawing.Size(712, 208);
            this.allPartsGridView.TabIndex = 83;
            this.allPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsGridView_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1268, 708);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 46);
            this.deleteButton.TabIndex = 82;
            this.deleteButton.Text = "Remove";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(1268, 777);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 48);
            this.cancelButton.TabIndex = 81;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1140, 777);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 48);
            this.saveButton.TabIndex = 80;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(1035, 78);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(328, 33);
            this.searchTextBox.TabIndex = 79;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchButton.Location = new System.Drawing.Point(915, 77);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(108, 46);
            this.addProductSearchButton.TabIndex = 78;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(68, 62);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(315, 48);
            this.modifyProductLabel.TabIndex = 77;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.assocPartsLabel.Location = new System.Drawing.Point(672, 431);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(304, 24);
            this.assocPartsLabel.TabIndex = 76;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.allPartsLabel.Location = new System.Drawing.Point(672, 92);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(172, 24);
            this.allPartsLabel.TabIndex = 75;
            this.allPartsLabel.Text = "All candidate Parts";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(1268, 369);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 48);
            this.addButton.TabIndex = 74;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minBoxLabel
            // 
            this.minBoxLabel.AutoSize = true;
            this.minBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBoxLabel.Location = new System.Drawing.Point(315, 538);
            this.minBoxLabel.Name = "minBoxLabel";
            this.minBoxLabel.Size = new System.Drawing.Size(54, 28);
            this.minBoxLabel.TabIndex = 73;
            this.minBoxLabel.Text = "Min";
            // 
            // maxBoxLabel
            // 
            this.maxBoxLabel.AutoSize = true;
            this.maxBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBoxLabel.Location = new System.Drawing.Point(75, 538);
            this.maxBoxLabel.Name = "maxBoxLabel";
            this.maxBoxLabel.Size = new System.Drawing.Size(57, 28);
            this.maxBoxLabel.TabIndex = 72;
            this.maxBoxLabel.Text = "Max";
            // 
            // priceCostBoxLabel
            // 
            this.priceCostBoxLabel.AutoSize = true;
            this.priceCostBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCostBoxLabel.Location = new System.Drawing.Point(75, 462);
            this.priceCostBoxLabel.Name = "priceCostBoxLabel";
            this.priceCostBoxLabel.Size = new System.Drawing.Size(63, 28);
            this.priceCostBoxLabel.TabIndex = 71;
            this.priceCostBoxLabel.Text = "Price";
            // 
            // inventoryBoxLabel
            // 
            this.inventoryBoxLabel.AutoSize = true;
            this.inventoryBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBoxLabel.Location = new System.Drawing.Point(75, 385);
            this.inventoryBoxLabel.Name = "inventoryBoxLabel";
            this.inventoryBoxLabel.Size = new System.Drawing.Size(113, 28);
            this.inventoryBoxLabel.TabIndex = 70;
            this.inventoryBoxLabel.Text = "Inventory";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBoxLabel.Location = new System.Drawing.Point(75, 308);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(76, 28);
            this.nameBoxLabel.TabIndex = 69;
            this.nameBoxLabel.Text = "Name";
            // 
            // idBoxLabel
            // 
            this.idBoxLabel.AutoSize = true;
            this.idBoxLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBoxLabel.Location = new System.Drawing.Point(75, 231);
            this.idBoxLabel.Name = "idBoxLabel";
            this.idBoxLabel.Size = new System.Drawing.Size(35, 28);
            this.idBoxLabel.TabIndex = 68;
            this.idBoxLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(386, 523);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(140, 39);
            this.minTextBox.TabIndex = 67;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(152, 523);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(140, 39);
            this.maxTextBox.TabIndex = 66;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(226, 446);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(230, 39);
            this.priceTextBox.TabIndex = 65;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTextBox.Location = new System.Drawing.Point(226, 369);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(230, 39);
            this.InventoryTextBox.TabIndex = 64;
            this.InventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(226, 292);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 39);
            this.nameTextBox.TabIndex = 63;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(226, 215);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 39);
            this.idTextBox.TabIndex = 62;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 878);
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