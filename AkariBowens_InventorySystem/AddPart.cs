using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class AddPartScreen : Form
    {
        private string addPartName;
                //= nameTextBox.Text;
        private int addPartInv;
        private double addPartPrice;
        private int addPartMax;
        private int addPartMin;
        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void AddPartCancelButton(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void addPartScreen_Load(object sender, EventArgs e)
        {
            // starts with one or the other checked
            outsourcedRadioButton.Checked = true;
            idTextBox.Enabled = false;
            addPartSave.Enabled = false;
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
                addPartSave.Enabled = true;
            }
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
                if (varInputTextBox.Text != null && varInputTextBox.Text != "" )
                {
                    if (inHouseRadioButton.Checked == true)
                    {
                        int addPartMachineID;
                        if (int.TryParse(varInputTextBox.Text, out addPartMachineID))
                        {
                            Console.WriteLine("Converting " + varInputTextBox.Text + "...\n");

                            InHouse NewPart = new InHouse(Inventory.GlobalPartID++, addPartName, addPartInv, addPartPrice, addPartMax, addPartMin, addPartMachineID);
                            Inventory.addPart(NewPart);
                            Close();
                        }
                        else
                        {
                            // Change these to message boxes on product and part
                            Console.WriteLine("Input " + varInputTextBox.Text + " not an int\n");
                            varInputTextBox.BackColor = Color.Red;
                            return;
                        }

                    }

                    if (outsourcedRadioButton.Checked == true)
                    {
                        string addPartCompanyName = varInputTextBox.Text;
                        Outsourced NewPart = new Outsourced(Inventory.GlobalPartID++, addPartName, addPartInv, addPartPrice, addPartMax, addPartMin, addPartCompanyName);
                      
                        Inventory.addPart(NewPart);
                        Close();
                    }
                }

            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
