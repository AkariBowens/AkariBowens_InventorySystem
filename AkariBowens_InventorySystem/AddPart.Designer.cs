namespace AkariBowens_InventorySystem
{
    partial class AddPartScreen
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
            this.addPartCancel = new System.Windows.Forms.Button();
            this.addPartSave = new System.Windows.Forms.Button();
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartLabel = new System.Windows.Forms.Label();
            this.priceCostTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.idBoxLabel = new System.Windows.Forms.Label();
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.inventoryBoxLabel = new System.Windows.Forms.Label();
            this.priceCostBoxLabel = new System.Windows.Forms.Label();
            this.maxBoxLabel = new System.Windows.Forms.Label();
            this.minBoxLabel = new System.Windows.Forms.Label();
            this.addPartGroupBox = new System.Windows.Forms.GroupBox();
            this.machineIDBoxLabel = new System.Windows.Forms.Label();
            this.varAddPartLabel = new System.Windows.Forms.Label();
            this.companyGB = new System.Windows.Forms.GroupBox();
            this.machineIDGB = new System.Windows.Forms.GroupBox();
            this.machineIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartGroupBox.SuspendLayout();
            this.companyGB.SuspendLayout();
            this.machineIDGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartCancel
            // 
            this.addPartCancel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartCancel.Location = new System.Drawing.Point(565, 670);
            this.addPartCancel.Name = "addPartCancel";
            this.addPartCancel.Size = new System.Drawing.Size(148, 64);
            this.addPartCancel.TabIndex = 0;
            this.addPartCancel.Text = "Cancel";
            this.addPartCancel.UseVisualStyleBackColor = true;
            this.addPartCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPartSave
            // 
            this.addPartSave.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartSave.Location = new System.Drawing.Point(382, 670);
            this.addPartSave.Name = "addPartSave";
            this.addPartSave.Size = new System.Drawing.Size(148, 64);
            this.addPartSave.TabIndex = 1;
            this.addPartSave.Text = "Save";
            this.addPartSave.UseVisualStyleBackColor = true;
            this.addPartSave.Click += new System.EventHandler(this.addPartSave_Click);
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseRadioButton.Location = new System.Drawing.Point(7, 14);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(114, 28);
            this.inHouseRadioButton.TabIndex = 2;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRadioButton.Location = new System.Drawing.Point(138, 14);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(137, 28);
            this.outsourcedRadioButton.TabIndex = 3;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(237, 171);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(255, 34);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(237, 241);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 34);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTextBox.Location = new System.Drawing.Point(237, 322);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(255, 34);
            this.InventoryTextBox.TabIndex = 6;
            this.InventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(37, 41);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(151, 38);
            this.addPartLabel.TabIndex = 7;
            this.addPartLabel.Text = "Add Part";
            // 
            // priceCostTextBox
            // 
            this.priceCostTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCostTextBox.Location = new System.Drawing.Point(237, 399);
            this.priceCostTextBox.Name = "priceCostTextBox";
            this.priceCostTextBox.Size = new System.Drawing.Size(255, 34);
            this.priceCostTextBox.TabIndex = 8;
            this.priceCostTextBox.TextChanged += new System.EventHandler(this.priceCostTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(238, 473);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(155, 34);
            this.maxTextBox.TabIndex = 9;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTextBox.Location = new System.Drawing.Point(519, 473);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(155, 34);
            this.minTextBox.TabIndex = 10;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTextBox.Location = new System.Drawing.Point(164, 12);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(255, 34);
            this.companyNameTextBox.TabIndex = 11;
            this.companyNameTextBox.TextChanged += new System.EventHandler(this.companyNameTextBox_TextChanged);
            // 
            // idBoxLabel
            // 
            this.idBoxLabel.AutoSize = true;
            this.idBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBoxLabel.Location = new System.Drawing.Point(203, 176);
            this.idBoxLabel.Name = "idBoxLabel";
            this.idBoxLabel.Size = new System.Drawing.Size(29, 24);
            this.idBoxLabel.TabIndex = 12;
            this.idBoxLabel.Text = "ID";
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBoxLabel.Location = new System.Drawing.Point(169, 247);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(62, 24);
            this.nameBoxLabel.TabIndex = 13;
            this.nameBoxLabel.Text = "Name";
            // 
            // inventoryBoxLabel
            // 
            this.inventoryBoxLabel.AutoSize = true;
            this.inventoryBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBoxLabel.Location = new System.Drawing.Point(138, 327);
            this.inventoryBoxLabel.Name = "inventoryBoxLabel";
            this.inventoryBoxLabel.Size = new System.Drawing.Size(93, 24);
            this.inventoryBoxLabel.TabIndex = 14;
            this.inventoryBoxLabel.Text = "Inventory";
            // 
            // priceCostBoxLabel
            // 
            this.priceCostBoxLabel.AutoSize = true;
            this.priceCostBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceCostBoxLabel.Location = new System.Drawing.Point(121, 404);
            this.priceCostBoxLabel.Name = "priceCostBoxLabel";
            this.priceCostBoxLabel.Size = new System.Drawing.Size(109, 24);
            this.priceCostBoxLabel.TabIndex = 15;
            this.priceCostBoxLabel.Text = "Price / Cost";
            // 
            // maxBoxLabel
            // 
            this.maxBoxLabel.AutoSize = true;
            this.maxBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBoxLabel.Location = new System.Drawing.Point(184, 478);
            this.maxBoxLabel.Name = "maxBoxLabel";
            this.maxBoxLabel.Size = new System.Drawing.Size(47, 24);
            this.maxBoxLabel.TabIndex = 16;
            this.maxBoxLabel.Text = "Max";
            // 
            // minBoxLabel
            // 
            this.minBoxLabel.AutoSize = true;
            this.minBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBoxLabel.Location = new System.Drawing.Point(469, 478);
            this.minBoxLabel.Name = "minBoxLabel";
            this.minBoxLabel.Size = new System.Drawing.Size(44, 24);
            this.minBoxLabel.TabIndex = 17;
            this.minBoxLabel.Text = "Min";
            this.minBoxLabel.Click += new System.EventHandler(this.minBoxLabel_Click);
            // 
            // addPartGroupBox
            // 
            this.addPartGroupBox.Controls.Add(this.outsourcedRadioButton);
            this.addPartGroupBox.Controls.Add(this.inHouseRadioButton);
            this.addPartGroupBox.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartGroupBox.Location = new System.Drawing.Point(259, 59);
            this.addPartGroupBox.Name = "addPartGroupBox";
            this.addPartGroupBox.Size = new System.Drawing.Size(276, 44);
            this.addPartGroupBox.TabIndex = 19;
            this.addPartGroupBox.TabStop = false;
            this.addPartGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // machineIDBoxLabel
            // 
            this.machineIDBoxLabel.AutoSize = true;
            this.machineIDBoxLabel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIDBoxLabel.Location = new System.Drawing.Point(51, 19);
            this.machineIDBoxLabel.Name = "machineIDBoxLabel";
            this.machineIDBoxLabel.Size = new System.Drawing.Size(108, 24);
            this.machineIDBoxLabel.TabIndex = 18;
            this.machineIDBoxLabel.Text = "Machine ID";
            this.machineIDBoxLabel.Visible = false;
            // 
            // varAddPartLabel
            // 
            this.varAddPartLabel.AutoSize = true;
            this.varAddPartLabel.Font = new System.Drawing.Font("Gadugi", 10F);
            this.varAddPartLabel.Location = new System.Drawing.Point(8, 16);
            this.varAddPartLabel.Name = "varAddPartLabel";
            this.varAddPartLabel.Size = new System.Drawing.Size(151, 24);
            this.varAddPartLabel.TabIndex = 20;
            this.varAddPartLabel.Text = "Company Name";
            this.varAddPartLabel.Click += new System.EventHandler(this.varAddPartLabel_Click);
            // 
            // companyGB
            // 
            this.companyGB.Controls.Add(this.machineIDGB);
            this.companyGB.Controls.Add(this.companyNameTextBox);
            this.companyGB.Controls.Add(this.varAddPartLabel);
            this.companyGB.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyGB.Location = new System.Drawing.Point(73, 539);
            this.companyGB.Name = "companyGB";
            this.companyGB.Size = new System.Drawing.Size(419, 46);
            this.companyGB.TabIndex = 21;
            this.companyGB.TabStop = false;
            this.companyGB.Visible = false;
            // 
            // machineIDGB
            // 
            this.machineIDGB.Controls.Add(this.machineIDTextBox);
            this.machineIDGB.Controls.Add(this.machineIDBoxLabel);
            this.machineIDGB.Font = new System.Drawing.Font("Gadugi", 10F);
            this.machineIDGB.Location = new System.Drawing.Point(0, 0);
            this.machineIDGB.Name = "machineIDGB";
            this.machineIDGB.Size = new System.Drawing.Size(419, 46);
            this.machineIDGB.TabIndex = 22;
            this.machineIDGB.TabStop = false;
            this.machineIDGB.Enter += new System.EventHandler(this.machineIDGB_Enter);
            // 
            // machineIDTextBox
            // 
            this.machineIDTextBox.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIDTextBox.Location = new System.Drawing.Point(164, 12);
            this.machineIDTextBox.Name = "machineIDTextBox";
            this.machineIDTextBox.Size = new System.Drawing.Size(255, 34);
            this.machineIDTextBox.TabIndex = 19;
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 803);
            this.Controls.Add(this.companyGB);
            this.Controls.Add(this.addPartGroupBox);
            this.Controls.Add(this.minBoxLabel);
            this.Controls.Add(this.maxBoxLabel);
            this.Controls.Add(this.priceCostBoxLabel);
            this.Controls.Add(this.inventoryBoxLabel);
            this.Controls.Add(this.nameBoxLabel);
            this.Controls.Add(this.idBoxLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceCostTextBox);
            this.Controls.Add(this.addPartLabel);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addPartSave);
            this.Controls.Add(this.addPartCancel);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.addPartScreen_Load);
            this.addPartGroupBox.ResumeLayout(false);
            this.addPartGroupBox.PerformLayout();
            this.companyGB.ResumeLayout(false);
            this.companyGB.PerformLayout();
            this.machineIDGB.ResumeLayout(false);
            this.machineIDGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartCancel;
        private System.Windows.Forms.Button addPartSave;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.TextBox priceCostTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label idBoxLabel;
        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.Label inventoryBoxLabel;
        private System.Windows.Forms.Label priceCostBoxLabel;
        private System.Windows.Forms.Label maxBoxLabel;
        private System.Windows.Forms.Label minBoxLabel;
        private System.Windows.Forms.GroupBox addPartGroupBox;
        private System.Windows.Forms.Label machineIDBoxLabel;
        private System.Windows.Forms.Label varAddPartLabel;
        private System.Windows.Forms.GroupBox companyGB;
        private System.Windows.Forms.GroupBox machineIDGB;
        private System.Windows.Forms.TextBox machineIDTextBox;
    }
}