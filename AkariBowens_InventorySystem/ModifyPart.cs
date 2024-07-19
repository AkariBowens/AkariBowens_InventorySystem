using System;
using System.Drawing;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class ModifyPartScreen : Form
    {
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

            // Disable ability to edit ID field
            // idTextBox.Enabled = false

            // modifyPartSave.Enabled = false;

            // Pre-populate fields
            idTextBox.Enabled = false;
            idTextBox.Text = Inventory.SelectedPart.PartID.ToString();
            nameTextBox.Text = Inventory.SelectedPart.Name.ToString();
            InventoryTextBox.Text = Inventory.SelectedPart.InStock.ToString();
            priceCostTextBox.Text = Inventory.SelectedPart.Price.ToString();
            maxTextBox.Text = Inventory.SelectedPart.Max.ToString();
            minTextBox.Text = Inventory.SelectedPart.Min.ToString();

            // Detects whether Part is InHouse or Outsourced
            if (Inventory.SelectedPart is InHouse)
            {
                InHouse tempPart = (InHouse)Inventory.SelectedPart;
                inHouseRadioButton.Checked = true;
                Console.WriteLine("True");
                varAddPartLabel.Text = "Machine ID";
                varInputTextBox.Text = tempPart.InHouseID.ToString();
            }
            else 
            {
                Outsourced tempPart = (Outsourced)Inventory.SelectedPart;
                outsourcedRadioButton.Checked = true;
                Console.WriteLine("False");
                varAddPartLabel.Text = "Company Name";
                varInputTextBox.Text = tempPart.Company.ToString();
            }

        }

        private void addPartSave_Click(object sender, EventArgs e)
        {
            
            // ----- Do the changing of types ----- //
            int isValid = 0;

            string addPartName = nameTextBox.Text;
            //if (nameTextBox.)

            int addPartInv;
            if (int.TryParse(InventoryTextBox.Text, out addPartInv))
            {
                Console.WriteLine("Converting " + addPartInv + " ...\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + InventoryTextBox.Text + " not an integer\n");
                InventoryTextBox.BackColor = Color.Tomato;
            }

            double addPartPrice;
            if (double.TryParse(priceCostTextBox.Text, out addPartPrice))
            {
                Console.WriteLine("Converting " + addPartPrice + "...\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + priceCostTextBox.Text + " not a decimal\n");
                priceCostTextBox.BackColor = Color.Tomato;
            }

            // Make sure part is an int
            int addPartMin;
            if (int.TryParse(minTextBox.Text, out addPartMin))
            {
                Console.WriteLine("Converting " + addPartMin + " ...\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + minTextBox.Text + " not an int\n");
                minTextBox.BackColor = Color.Tomato;
            }

            // Checks if partPrice input is an int
            int addPartMax;
            if (int.TryParse(maxTextBox.Text, out addPartMax))
            {
                Console.WriteLine("Converting " + addPartMax + "...\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + maxTextBox.Text + " not an int\n");
                maxTextBox.BackColor = Color.Tomato;
            }

            if (addPartMin > addPartMax)
            {
                isValid--;
                MessageBox.Show("Minimum must be less than Maximum.");
                maxTextBox.BackColor = Color.Tomato;
                minTextBox.BackColor = Color.Tomato;
            }

            if (addPartInv < addPartMin || addPartInv > addPartMax)
            {
                isValid--;
                MessageBox.Show("Inventory must be within min/max range.");
                InventoryTextBox.BackColor = Color.Tomato;   
            }
 
            // Add 
            if (isValid == 4)
            {
                if (varInputTextBox.Text != null && varInputTextBox.Text != "")
                {
                    // if checked == true && current Part == savedPart }else{ make  new part, and run addPart to change the type
                    if (inHouseRadioButton.Checked == true)
                    {

                        int addPartMachineID;
                        if (int.TryParse(varInputTextBox.Text, out addPartMachineID))
                        {
                            Console.WriteLine("Converting " + varInputTextBox.Text + "...\n");
                            InHouse NewPart = new InHouse(Inventory.GlobalPartID++, addPartName,addPartInv,addPartPrice, addPartMin, addPartMax, addPartMachineID);
                            
                            Inventory.UpdatePart(Inventory.SelectedPartIndex, NewPart);
                            Close();
                        }
                        else
                        {
                            // Change these to message boxes on product and part
                            Console.WriteLine("Input " + varInputTextBox.Text + " not an int\n");
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
                    // modifyPartSave.Enabled = true;
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
                // part created as InHouse, pass (Part) data to whichever constructor, then make selected of whichever class
                varAddPartLabel.Text = "Machine ID";
            }
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // when checked, part is InHouse and the textbox is Company Name
            if (outsourcedRadioButton.Checked == true)
            {
                // part created as InHouse, pass (Part) data to whichever constructor, then make selected of whichever class
                varAddPartLabel.Text = "Company Name";   
            }
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
