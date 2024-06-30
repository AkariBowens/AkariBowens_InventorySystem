using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class AddPartScreen : Form
    {

        // Radio buttons apply class "inHouse" or "outsourced"
        // Inventory.addPart();

        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void addPartScreen_Load(object sender, EventArgs e)
        {
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioButton.Checked == true)
            {
                varAddPartLabel.Text = "Machine ID";
            }

        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRadioButton.Checked == true)
            {
                varAddPartLabel.Text = "Company Name";
            }
        }

        private void addPartSave_Click(object sender, EventArgs e)
        {

            // Limit partPrice to two decimal places -- make new variables for new Part 
            int isValid = 0;

            int addPartId;
            if (int.TryParse(idTextBox.Text, out addPartId))
            {
                Console.WriteLine("Converting " + addPartId + " ...\n");
                isValid ++;
                
            }
            else
            {
                Console.WriteLine("Input " + idTextBox.Text + " not an int\n");
            }

            string addPartName = nameTextBox.Text;
            

            // Checks if inventory input is an int
            int addPartInv;
            if (int.TryParse(InventoryTextBox.Text, out addPartInv))
            {
                Console.WriteLine("Converting " + addPartInv + " ...\n");
                isValid ++;
                
            }
            else
            {
                Console.WriteLine("Input " + InventoryTextBox.Text + " not an integer\n");
            }

            // Checks if partPrice input is a decimal
            double addPartPrice;
            if (double.TryParse(priceCostTextBox.Text, out addPartPrice))
            {
                Console.WriteLine("Converting " + addPartPrice + "...\n");
                isValid ++;
               
            }
            else
            {
                Console.WriteLine("Input " + priceCostTextBox.Text + " not a decimal\n");
            }

            // Checks if partMax input is an int
            int addPartMax;
            if (int.TryParse(maxTextBox.Text, out addPartMax))
            {
                Console.WriteLine("Converting " + addPartMax + "...\n");
                isValid ++;
                
            }
            else
            {
                Console.WriteLine("Input " + maxTextBox.Text + " not an \n");
            }

            // Make sure part is (int)
            int addPartMin;
            if (int.TryParse(minTextBox.Text, out addPartMin))
            {
                Console.WriteLine("Converting " + addPartMin + " ...\n");
                isValid ++;
               
            }
            else
            {
                Console.WriteLine("Input " + minTextBox.Text + " not an int\n");
            }

            // Add the inhouse and outsourced validations

           
            
            if (isValid == 5)
            {
                // I need to make sure that one of these is absolutely checked

                if (varInputTextBox.Text != null && varInputTextBox.Text != "")
                {
                    if (inHouseRadioButton.Checked == true)
                    {
                        int addPartMachineID;
                        if (int.TryParse(varInputTextBox.Text, out addPartMachineID))
                        {
                            Console.WriteLine("Converting " + varInputTextBox.Text + "...\n");

                            InHouse NewPart = new InHouse(addPartId, addPartName, addPartInv, addPartPrice, addPartMax, addPartMin, addPartMachineID);
                            Inventory.addPart(NewPart);
                            Close();
                        }
                        else
                        {
                            // Change these to message boxes on product and part
                            Console.WriteLine("Input " + varInputTextBox.Text + " not an int\n");
                            return;
                        }

                    }

                    if (outsourcedRadioButton.Checked == true)
                    {
                        
                        string addPartCompanyName = varInputTextBox.Text;
                        Outsourced NewPart = new Outsourced(addPartId, addPartName, addPartInv, addPartPrice, addPartMax, addPartMin, addPartCompanyName);
                      
                        Inventory.addPart(NewPart);
                        Close();
                    }
                    // Basically make this a bool outside of this entire if statement, so it can be changed within validation, if any change it to false, then it's false
                    addPartSave.Enabled = true;
                }

            }

            // 
            // {
            // if inhouse.checked
            // if (Inventory.SelectedPart.isOutsourced)
            // {
            //        Console.WriteLine(isValid);
            // Inventory.addPart(addPartCreation);
            // Reset SelectedPart
            //       Close();
            //   }
            //    else
            //    {
            //        Console.WriteLine(isValid);
            // Inventory.addPart(outsourcedPartCreation);
            // Reset SelectedPart
            //        Close();
            //    }

            // }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void minBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void varAddPartLabel_Click(object sender, EventArgs e)
        {

        }

        private void machineIDGB_Enter(object sender, EventArgs e)
        {

        }

        private void companyGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
