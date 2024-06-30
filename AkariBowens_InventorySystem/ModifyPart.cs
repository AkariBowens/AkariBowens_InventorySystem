using System;
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
            // If fields are changed from Inventory.SelectedPart - "Are you sure?"
            Close();
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {

            // Disables ability to edit ID field
            addPartSave.Enabled = false;

            // Pre-populate fields
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
            // bool isValid = false;

            // Validation code here
            // -- do the regular validation, then do the individual ones from 

            int isValid = 0;

            int addPartId;
            if (int.TryParse(idTextBox.Text, out addPartId))
            {
                Console.WriteLine("Converting " + addPartId + " ...");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + idTextBox.Text + " not an int");
                // Add code that highlights incorrectbox
            }

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
            }

            int addPartMachineID = 0;
            string addPartCompanyName = " ";


            // if inhouse/outsourced checked -- cast part as.. -- then from there, grab the value in the varPartBox, validate it, and save declare part 
            // add this part in the if isValid
            // Finish tomorrow - clean up if conditions
            if (isValid == 5)
            {
                if (varInputTextBox.Text != null && varInputTextBox.Text != "")
                {
                    if (inHouseRadioButton.Checked == true)
                    {
                        if (int.TryParse(varInputTextBox.Text, out addPartMachineID))
                        {
                            Console.WriteLine("Converting " + varInputTextBox.Text + "...\n");
                            InHouse NewPart = (InHouse)Inventory.SelectedPart;
                            NewPart.InHouseID = addPartMachineID;

                            Inventory.updatePart(Inventory.SelectedPartIndex, NewPart);
                        }
                        else
                        {
                            // Change these to message boxes on product and part
                            Console.WriteLine("Input " + varInputTextBox.Text + " not an int\n");
                        }

                    } else if (outsourcedRadioButton.Checked == true)
                    {

                       Outsourced NewPart = (Outsourced)Inventory.SelectedPart; 
                       addPartCompanyName = varInputTextBox.Text;
                       NewPart.Company = addPartCompanyName;
                       
                       Inventory.updatePart(Inventory.SelectedPartIndex, NewPart);

                    }

                    addPartSave.Enabled = true;
                }  
                Close();
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
