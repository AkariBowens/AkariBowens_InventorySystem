using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class AddProductScreen : Form
    {
        
        public AddProductScreen()
        { 
            InitializeComponent();
        }

        private void addProductScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Confirmation
            Close();
        }

        private void allPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProductScreen_Load(object sender, EventArgs e)
        {

            // ----- All Parts ----- //

            // Sets allPartsGridView source
            allPartsGridView.DataSource = Inventory.AllParts;

            // Highlights full row on selection
            allPartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Makes DataGridView read only
            allPartsGridView.ReadOnly = true;

            // Makes DataGridView single-select
            allPartsGridView.MultiSelect = false;

            // Removes empty bottom row
            allPartsGridView.AllowUserToAddRows = false;

            // ----- Associated Parts ----- //

            
            BindingList<Part> currentPartsAssociated = Inventory.TempProduct.AssociatedParts;
            assocPartsGridView.DataSource = currentPartsAssociated;

            // Highlights full row on selection
            assocPartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Makes DataGridView read only
            assocPartsGridView.ReadOnly = true;

            // Makes DataGridView single-select
            assocPartsGridView.MultiSelect = false;

            // Removes empty bottom row
            assocPartsGridView.AllowUserToAddRows = false;


            // Disables ID textbox
            idTextBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        { 
            int isValid = 0;

            string addProductName = nameTextBox.Text;
            // Inventory.TempProduct.Name = addProductName;

            // Checks if inventory input is an int
            int addProductInv;
            if (int.TryParse(InventoryTextBox.Text, out addProductInv))
            {
                Console.WriteLine("Converting " + addProductInv + " ...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Inventory " + InventoryTextBox.Text + " not an integer");

                MessageBox.Show("Inventory: '" + InventoryTextBox.Text + "' must be a number!");
                InventoryTextBox.BackColor = Color.Red;
            }

            // Checks if partPrice input is a decimal
            double addProductPrice;
            if (double.TryParse(priceTextBox.Text, out addProductPrice))
            {
                Console.WriteLine("Converting " + addProductPrice + "...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Price: " + priceTextBox.Text + " not a decimal");

                MessageBox.Show("Price: '" + priceTextBox.Text + "' must be a decimal!");
                priceTextBox.BackColor = Color.Red;
            }

            // Make sure part is an int
            int addProductMin;
            if (int.TryParse(minTextBox.Text, out addProductMin))
            {
                Console.WriteLine("Converting " + addProductMin + " ...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Minimum " + minTextBox.Text + " not an int");

                MessageBox.Show("Minimum: '" + minTextBox.Text + "' must be a number!");
                minTextBox.BackColor = Color.Red;
            }

            // Checks if partPrice input is an int
            int addProductMax;
            if (int.TryParse(maxTextBox.Text, out addProductMax))
            {
                Console.WriteLine("Converting " + addProductMax + "...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Maximum " + maxTextBox.Text + " not an int");

                MessageBox.Show("Maximum: '" + maxTextBox.Text + "' must be a number!");
                maxTextBox.BackColor = Color.Red;
            }

            if (addProductMin > addProductMax)
            {
                isValid--;
                MessageBox.Show("Minimun must be less than Maximum");
                maxTextBox.BackColor = Color.Tomato;
                minTextBox.BackColor = Color.Tomato;
            }

            Product NewProduct = new Product(Inventory.GlobalProductID++, addProductName, addProductInv, addProductPrice, addProductMin, addProductMax);

            for (int i = 0; i < Inventory.TempProduct.AssociatedParts.Count; i++)
            {
                //NewProduct.AssociatedParts.Add(Inventory.TempProduct.AssociatedParts[i]);
                NewProduct.addAssociatedPart(Inventory.TempProduct.AssociatedParts[i]);
            }

            if (addProductMin > addProductMax)
            {
                isValid--;
                MessageBox.Show("Minimum must be less than Maximum.");
                maxTextBox.BackColor = Color.Tomato;
                minTextBox.BackColor = Color.Tomato;
            }

            if (addProductInv < addProductMin || addProductInv > addProductMax)
            {
                isValid--;
                MessageBox.Show("Inventory must be within min/max range.");
                InventoryTextBox.BackColor = Color.Tomato;
            }

            if (isValid == 4)
            {
                Console.WriteLine("Associated Parts: " + NewProduct.AssociatedParts.Count);
                Inventory.addProduct(NewProduct);
                Close();
            }
        }

        private void addAssocPartButton_Click(object sender, EventArgs e)
        {
            if (allPartsGridView.CurrentRow.Selected)
            { 
                Part currentPart = Inventory.LookupPart(allPartsGridView.CurrentRow.Index);
                Inventory.TempProduct.addAssociatedPart(currentPart);
                allPartsGridView.ClearSelection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!assocPartsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part!");
            }
            
            DialogResult = MessageBox.Show("Are you sure you want to remove this?", "Remove Part", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                Inventory.TempProduct.removeAssociatedPart(assocPartsGridView.CurrentRow.Index);
                allPartsGridView.ClearSelection();
            }
        }

        private void assocPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assocPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            assocPartsGridView.ClearSelection();
        }

        private void priceCostBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingList<Part> TempPartsList = new BindingList<Part>();
            allPartsGridView.ClearSelection();
            bool partFound = false;

            // 
            if (searchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    // Searches Names of Parts in AllParts
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchTextBox.Text.ToUpper()))
                    {
                        TempPartsList.Add(Inventory.AllParts[i]);
                        partFound = true;
                    }
                }
                if (partFound)
                {
                    allPartsGridView.DataSource = TempPartsList;
                }
            }

            
            // When a part is not found 
            if (!partFound)
            {
                // Clears text input when a part is not found and the searchbar is not empty
                if (searchTextBox.Text != "")
                {
                    MessageBox.Show("Nothing Found.");
                    searchTextBox.Clear();

                }
                else
                {
                    allPartsGridView.DataSource = Inventory.AllParts;
                }

            }
        }
    }
}
