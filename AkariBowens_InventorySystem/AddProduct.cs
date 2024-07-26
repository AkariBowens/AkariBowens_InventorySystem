using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class AddProductScreen : Form
    {
        private string addProductName;
        private int addProductInv;
        private double addProductPrice;
        private int addProductMin;
        private int addProductMax;


        public AddProductScreen()
        { 
            InitializeComponent();
        }

        private void addProductScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void allPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool textBoxesAreValid()
        {
            return (!string.IsNullOrWhiteSpace(nameTextBox.Text) 
                && int.TryParse(InventoryTextBox.Text, out addProductInv) 
                && double.TryParse(priceTextBox.Text, out addProductPrice) 
                && int.TryParse(minTextBox.Text, out addProductMin) 
                && int.TryParse(maxTextBox.Text, out addProductMax));
        }

        private void toggleSaveButton()
        {
            if (textBoxesAreValid()) 
            { 
                 saveButton.Enabled = true; 
            } 
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

            // change to the result of toggleSaveButton()
            saveButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        { 
            // Move each validation to it's checkedchange -- make is valid its own property - for for add/modify part/product

            Product NewProduct = new Product(Inventory.GlobalProductID++, addProductName, addProductInv, addProductPrice, addProductMin, addProductMax);

            for (int i = 0; i < Inventory.TempProduct.AssociatedParts.Count; i++)
            {
                NewProduct.addAssociatedPart(Inventory.TempProduct.AssociatedParts[i]);
            }

            if (addProductMin > addProductMax)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                maxTextBox.BackColor = Color.Tomato;
                minTextBox.BackColor = Color.Tomato;
            }

            if (addProductInv < addProductMin || addProductInv > addProductMax)
            {
                MessageBox.Show("Inventory must be within min/max range.");
                InventoryTextBox.BackColor = Color.Tomato;
            }

            bool inputsAreValid() { 
                return (addProductMin <= addProductInv) && (addProductMax >= addProductInv) && (addProductMin < addProductMax); 
            }

            if (textBoxesAreValid() && inputsAreValid())
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
            toggleSaveButton();
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
                toggleSaveButton();
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //If nameTextBox input is null, empty, or whitespace its color changes 
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                nameTextBox.BackColor = Color.Tomato;

            } else
            {
                toggleSaveButton();
                nameTextBox.BackColor = Color.White;
                addProductName = nameTextBox.Text;
            }
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            //Checks if InventoryTextBox is an integer 
            if (int.TryParse(InventoryTextBox.Text, out addProductInv))
            {
                Console.WriteLine("Converting " + addProductInv + " ...");
                toggleSaveButton();
            }
            else if (InventoryTextBox.Text != "")
            {
                MessageBox.Show("Inventory: '" + InventoryTextBox.Text + "' must be a number!");
                InventoryTextBox.BackColor = Color.Red;
                InventoryTextBox.Clear();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if partPrice input is a double
            if (double.TryParse(priceTextBox.Text, out addProductPrice) && priceTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addProductPrice + "...");
                toggleSaveButton();
            }
            else if (priceTextBox.Text != "")
            {
                MessageBox.Show("Price: '" + priceTextBox.Text + "' must be a decimal!");
                priceTextBox.BackColor = Color.Tomato;
                priceTextBox.Clear();
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if min input is an integer
            if (int.TryParse(maxTextBox.Text, out addProductMax) && maxTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addProductMax + "...");
                toggleSaveButton();
            }
            else if (maxTextBox.Text != "" )
            {
                 MessageBox.Show("Maximum: '" + maxTextBox.Text + "' must be a number!");
                 maxTextBox.BackColor = Color.Tomato;
                 maxTextBox.Clear();
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if max input is an integer
            if (int.TryParse(minTextBox.Text, out addProductMin) && minTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addProductMin + " ...");
                toggleSaveButton();
            }
            else if (minTextBox.Text != "")
            {
                MessageBox.Show("Minimum: '" + minTextBox.Text + "' must be a number!");
                minTextBox.BackColor = Color.Tomato;
                minTextBox.Clear();
            }
        }
    }
}
