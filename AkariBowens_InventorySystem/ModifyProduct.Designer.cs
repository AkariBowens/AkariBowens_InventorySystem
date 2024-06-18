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
            this.priceCostTextBox = new System.Windows.Forms.TextBox();
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
            this.assocPartsGridView.Location = new System.Drawing.Point(672, 469);
            this.assocPartsGridView.Name = "assocPartsGridView";
            this.assocPartsGridView.RowHeadersWidth = 62;
            this.assocPartsGridView.RowTemplate.Height = 28;
            this.assocPartsGridView.Size = new System.Drawing.Size(713, 194);
            this.assocPartsGridView.TabIndex = 84;
            this.assocPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assocPartsGridView_CellContentClick);
            this.assocPartsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.assocPartsDGVBindingComplete);
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(672, 135);
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.RowHeadersWidth = 62;
            this.allPartsGridView.RowTemplate.Height = 28;
            this.allPartsGridView.Size = new System.Drawing.Size(713, 194);
            this.allPartsGridView.TabIndex = 83;
            this.allPartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsGridView_CellContentClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1264, 700);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 47);
            this.deleteButton.TabIndex = 82;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1264, 769);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 47);
            this.cancelButton.TabIndex = 81;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1142, 769);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 47);
            this.saveButton.TabIndex = 80;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1057, 73);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(328, 26);
            this.searchTextBox.TabIndex = 79;
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Location = new System.Drawing.Point(936, 69);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(91, 35);
            this.addProductSearchButton.TabIndex = 78;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductLabel.Location = new System.Drawing.Point(63, 58);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(187, 29);
            this.modifyProductLabel.TabIndex = 77;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // assocPartsLabel
            // 
            this.assocPartsLabel.AutoSize = true;
            this.assocPartsLabel.Location = new System.Drawing.Point(668, 414);
            this.assocPartsLabel.Name = "assocPartsLabel";
            this.assocPartsLabel.Size = new System.Drawing.Size(249, 20);
            this.assocPartsLabel.TabIndex = 76;
            this.assocPartsLabel.Text = "Parts Associated with this Product";
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Location = new System.Drawing.Point(668, 80);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(141, 20);
            this.allPartsLabel.TabIndex = 75;
            this.allPartsLabel.Text = "All candidate Parts";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1264, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 47);
            this.addButton.TabIndex = 74;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minBoxLabel
            // 
            this.minBoxLabel.AutoSize = true;
            this.minBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBoxLabel.Location = new System.Drawing.Point(344, 551);
            this.minBoxLabel.Name = "minBoxLabel";
            this.minBoxLabel.Size = new System.Drawing.Size(44, 25);
            this.minBoxLabel.TabIndex = 73;
            this.minBoxLabel.Text = "Min";
            // 
            // maxBoxLabel
            // 
            this.maxBoxLabel.AutoSize = true;
            this.maxBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBoxLabel.Location = new System.Drawing.Point(63, 552);
            this.maxBoxLabel.Name = "maxBoxLabel";
            this.maxBoxLabel.Size = new System.Drawing.Size(50, 25);
            this.maxBoxLabel.TabIndex = 72;
            this.maxBoxLabel.Text = "Max";
            // 
            // priceCostBoxLabel
            // 
            this.priceCostBoxLabel.AutoSize = true;
            this.priceCostBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCostBoxLabel.Location = new System.Drawing.Point(63, 469);
            this.priceCostBoxLabel.Name = "priceCostBoxLabel";
            this.priceCostBoxLabel.Size = new System.Drawing.Size(113, 25);
            this.priceCostBoxLabel.TabIndex = 71;
            this.priceCostBoxLabel.Text = "Price / Cost";
            // 
            // inventoryBoxLabel
            // 
            this.inventoryBoxLabel.AutoSize = true;
            this.inventoryBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBoxLabel.Location = new System.Drawing.Point(63, 375);
            this.inventoryBoxLabel.Name = "inventoryBoxLabel";
            this.inventoryBoxLabel.Size = new System.Drawing.Size(92, 25);
            this.inventoryBoxLabel.TabIndex = 70;
            this.inventoryBoxLabel.Text = "Inventory";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBoxLabel.Location = new System.Drawing.Point(63, 298);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(64, 25);
            this.nameBoxLabel.TabIndex = 69;
            this.nameBoxLabel.Text = "Name";
            // 
            // idBoxLabel
            // 
            this.idBoxLabel.AutoSize = true;
            this.idBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBoxLabel.Location = new System.Drawing.Point(63, 231);
            this.idBoxLabel.Name = "idBoxLabel";
            this.idBoxLabel.Size = new System.Drawing.Size(31, 25);
            this.idBoxLabel.TabIndex = 68;
            this.idBoxLabel.Text = "ID";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(410, 552);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(140, 26);
            this.minTextBox.TabIndex = 67;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(151, 552);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(140, 26);
            this.maxTextBox.TabIndex = 66;
            // 
            // priceCostTextBox
            // 
            this.priceCostTextBox.Location = new System.Drawing.Point(217, 469);
            this.priceCostTextBox.Name = "priceCostTextBox";
            this.priceCostTextBox.Size = new System.Drawing.Size(230, 26);
            this.priceCostTextBox.TabIndex = 65;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(217, 375);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(230, 26);
            this.InventoryTextBox.TabIndex = 64;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(217, 298);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 26);
            this.nameTextBox.TabIndex = 63;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(217, 231);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 26);
            this.idTextBox.TabIndex = 62;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 874);
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
            this.Controls.Add(this.priceCostTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
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
        private System.Windows.Forms.TextBox priceCostTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}