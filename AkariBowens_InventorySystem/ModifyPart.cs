﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class ModifyPartScreen : Form
    {

        string addPartName;
        int addPartInv;
        double addPartPrice;
        int addPartMin;
        int addPartMax;
        public ModifyPartScreen()
        {
            InitializeComponent();
            
        }
    

        private void addPartCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

            // Disables ability to edit ID field
            idTextBox.Enabled = false;

            // Pre-populates fields
            idTextBox.Text = Inventory.SelectedPart.PartID.ToString();
            nameTextBox.Text = Inventory.SelectedPart.Name.ToString();
            InventoryTextBox.Text = Inventory.SelectedPart.InStock.ToString();
            priceTextBox.Text = Inventory.SelectedPart.Price.ToString();
            maxTextBox.Text = Inventory.SelectedPart.Max.ToString();
            minTextBox.Text = Inventory.SelectedPart.Min.ToString();

            // Detects whether Part is InHouse or Outsourced
            if (Inventory.SelectedPart is InHouse)
            {
                InHouse tempPart = (InHouse)Inventory.SelectedPart;
                inHouseRadioButton.Checked = true;

                varAddPartLabel.Text = "Machine ID";
                varInputTextBox.Text = tempPart.InHouseID.ToString();
            }
            else 
            {
                Outsourced tempPart = (Outsourced)Inventory.SelectedPart;
                outsourcedRadioButton.Checked = true;

                varAddPartLabel.Text = "Company Name";
                varInputTextBox.Text = tempPart.Company.ToString();
            }

            modifyPartSave.Enabled = false;
        }

        private bool textBoxesAreValid()
        {
            return (!string.IsNullOrWhiteSpace(nameTextBox.Text)
                && int.TryParse(InventoryTextBox.Text, out addPartInv)
                && double.TryParse(priceTextBox.Text, out addPartPrice)
                && int.TryParse(minTextBox.Text, out addPartMin)
                && int.TryParse(maxTextBox.Text, out addPartMax));
        }

        private void toggleSaveButton()
        {
            if (textBoxesAreValid())
            {
                modifyPartSave.Enabled = true;
            }
        }

        private void addPartSave_Click(object sender, EventArgs e)
        {

            if (addPartMin > addPartMax)
            { 
                MessageBox.Show("Minimum must be less than Maximum.");
                maxTextBox.BackColor = Color.Tomato;
                minTextBox.BackColor = Color.Tomato;
            }

            if (addPartInv < addPartMin || addPartInv > addPartMax)
            {
                MessageBox.Show("Inventory must be within min/max range.");
                InventoryTextBox.BackColor = Color.Tomato;   
            }

            bool inputsAreValid()
            {
                return (addPartMin <= addPartInv) && (addPartMax >= addPartInv) && (addPartMin < addPartMax);
            }

            if (textBoxesAreValid() && inputsAreValid())
            {
                if (varInputTextBox.Text != null && varInputTextBox.Text != "")
                {
                    if (inHouseRadioButton.Checked == true)
                    {

                        int addPartMachineID;
                        if (int.TryParse(varInputTextBox.Text, out addPartMachineID))
                        {
                            MessageBox.Show("Converting " + varInputTextBox.Text + "...\n");
                            InHouse NewPart = new InHouse(Inventory.GlobalPartID++, addPartName,addPartInv,addPartPrice, addPartMin, addPartMax, addPartMachineID);
                            
                            Inventory.UpdatePart(Inventory.SelectedPartIndex, NewPart);
                            Close();
                        }
                        else
                        {
                            // Change these to message boxes on product and part
                            MessageBox.Show("Input " + varInputTextBox.Text + " not an int\n");
                            varInputTextBox.BackColor = Color.Red;
                        }
                    } 
                    
                    if (outsourcedRadioButton.Checked == true)
                    {
                        string addPartCompanyName = varInputTextBox.Text;
                        Outsourced NewPart = new Outsourced(Inventory.GlobalPartID++, addPartName, addPartInv, addPartPrice, addPartMin, addPartMax, addPartCompanyName);
                        Inventory.UpdatePart(Inventory.SelectedPartIndex, NewPart);
                        Close();
                    }

                }  
            } 
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
          
            // when checked, part is InHouse and the textbox is Machine ID
            if (inHouseRadioButton.Checked == true)
            {
                varAddPartLabel.Text = "Machine ID";
                toggleSaveButton();
            }
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // when checked, part is InHouse and the textbox is Company Name
            if (outsourcedRadioButton.Checked == true)
            { 
                varAddPartLabel.Text = "Company Name";
                toggleSaveButton();
            }
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if max input is an integer
            if (int.TryParse(minTextBox.Text, out addPartMin) && minTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addPartMin + " ...");
                toggleSaveButton();
            }
            else if (minTextBox.Text != "")
            {
                MessageBox.Show("Minimum: '" + minTextBox.Text + "' must be a number!");
                minTextBox.BackColor = Color.Tomato;
                minTextBox.Clear();
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if min input is an integer
            if (int.TryParse(maxTextBox.Text, out addPartMax) && maxTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addPartMax + "...");
                toggleSaveButton();
            }
            else if (maxTextBox.Text != "")
            {
                MessageBox.Show("Maximum: '" + maxTextBox.Text + "' must be a number!");
                maxTextBox.BackColor = Color.Tomato;
                maxTextBox.Clear();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if partPrice input is a double
            if (double.TryParse(priceTextBox.Text, out addPartPrice) && priceTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addPartPrice + "...");
                toggleSaveButton();
            }
            else if (priceTextBox.Text != "")
            {
                MessageBox.Show("Price: '" + priceTextBox.Text + "' must be a decimal!");
                priceTextBox.BackColor = Color.Tomato;
                priceTextBox.Clear();
            }
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            //Checks if InventoryTextBox is an integer 
            if (int.TryParse(InventoryTextBox.Text, out addPartInv))
            {
                Console.WriteLine("Converting " + addPartInv + " ...");
                toggleSaveButton();
            }
            else if (InventoryTextBox.Text != "")
            {
                MessageBox.Show("Inventory: '" + InventoryTextBox.Text + "' must be a number!");
                InventoryTextBox.BackColor = Color.Red;
                InventoryTextBox.Clear();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //If nameTextBox input is null, empty, or whitespace its color changes 
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                nameTextBox.BackColor = Color.Tomato;
            }
            else
            {
                toggleSaveButton();
                nameTextBox.BackColor = Color.White;
                addPartName = nameTextBox.Text;
            }
        }
    }
}
