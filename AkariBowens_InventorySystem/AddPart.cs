using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void addPartScreen_Load(object sender, EventArgs e)
        {
            if (inHouseRadioButton.Checked)
            {
                // Change the text of the label of the Form
                return;
            }
        }

        private void addPartSave_Click(object sender, EventArgs e)
        {

            // Limit partPrice to two decimal places -- make new variables for new Part 
            int isValid = 0;

            int addPartId;
            if (int.TryParse(idTextBox.Text, out addPartId))
            {
                Console.WriteLine("Converting " + addPartId + " ...");
                isValid ++;
            }
            else
            {
                Console.WriteLine("Input " + idTextBox.Text + " not an int");
            }

            string addPartName = nameTextBox.Text;

            // Checks if inventory input is an int
            int addPartInv;
            if (int.TryParse(InventoryTextBox.Text, out addPartInv))
            {
                Console.WriteLine("Converting " + addPartInv + " ...");
                isValid ++;
            }
            else
            {
                Console.WriteLine("Input " + InventoryTextBox.Text + " not an integer");
            }

            // Checks if partPrice input is a decimal
            double addPartPrice;
            if (double.TryParse(priceCostTextBox.Text, out addPartPrice))
            {
                Console.WriteLine("Converting " + addPartPrice + "...");
                isValid ++;
            }
            else
            {
                Console.WriteLine("Input " + priceCostTextBox.Text + " not a decimal");
            }

            // Checks if partPrice input is an int
            int addPartMax;
            if (int.TryParse(maxTextBox.Text, out addPartMax))
            {
                Console.WriteLine("Converting " + addPartMax + "...");
                isValid ++;
            }
            else
            {
                Console.WriteLine("Input " + maxTextBox.Text + " not an int");
            }

            // Make sure part is (int)
            int addPartMin;
            if (int.TryParse(minTextBox.Text, out addPartMin))
            {
                Console.WriteLine("Converting " + addPartMin + " ...");
                isValid ++;
            }
            else
            {
                Console.WriteLine("Input " + minTextBox.Text + " not an int");
            }

            // Creates new Part on "save" and isValid
            Part addPartCreation = new Part(addPartId, addPartName, addPartInv, addPartPrice, addPartMax, addPartMin);

             if (isValid == 5)
             {
                Console.WriteLine(isValid);
                Inventory.addPart(addPartCreation);
                // Reset SelectedPart
                Close();
             }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // radioButton box
            // Calls id generator
            // Make sure part is (int)
           
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

    }
}
