using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class ModifyProduct : Form
    {
        private string addProductName;
        private int addProductInv;
        private double addProductPrice;
        private int addProductMin;
        private int addProductMax;

        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Resets TempProduct
            Inventory.TempProduct = new Product(0, "", 0, 0, 0, 0);
            Close();
        }

        private void assocPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sets assocPartsDGV source 
            // assocPartsGridView.DataSource = Inventory.SelectedProduct.AssociatedParts;
        }

        private void allPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            // ----- ----- Fills DataGridViews ----- ----- //
            
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
            
            var currentPartsAssociated = Inventory.TempProduct.AssociatedParts;
            assocPartsGridView.DataSource = currentPartsAssociated;

            // Highlights full row on selection
            assocPartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Makes DataGridView read only
            assocPartsGridView.ReadOnly = true;

            // Makes DataGridView single-select
            assocPartsGridView.MultiSelect = false;

            // Removes empty bottom row
            assocPartsGridView.AllowUserToAddRows = false;

            // ----- ----- Prefills textboxes ----- ----- //
            idTextBox.Enabled = false;

            idTextBox.Text = Inventory.TempProduct.ProductID.ToString();
            nameTextBox.Text = Inventory.TempProduct.Name.ToString();
            InventoryTextBox.Text = Inventory.TempProduct.InStock.ToString();
            priceTextBox.Text = Inventory.TempProduct.Price.ToString();
            maxTextBox.Text = Inventory.TempProduct.Max.ToString();
            minTextBox.Text = Inventory.TempProduct.Min.ToString();

            saveButton.Enabled = false;
        }
        
        private bool textBoxesAreValid()
        {
            return (!string.IsNullOrEmpty(nameTextBox.Text)
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
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!allPartsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("There is nothing selected!", "Make a selection");
                return;
            }
            Part currentPart = Inventory.AllParts[allPartsGridView.CurrentRow.Index];
            Inventory.TempProduct.addAssociatedPart(currentPart);
            allPartsGridView.ClearSelection();
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

        private void assocPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            assocPartsGridView.ClearSelection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
 

                //Initializes a new product instance with the above variables
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

                bool inputsAreValid()
                {
                    return (addProductMin <= addProductInv) && (addProductMax >= addProductInv) && (addProductMin < addProductMax);
                }

                if (textBoxesAreValid() && inputsAreValid())
                {
                    Console.WriteLine("Associated Parts: " + NewProduct.AssociatedParts.Count + "\n");
                    int ProductIdx = Inventory.TempProductIndex;
                    Inventory.UpdateProduct(ProductIdx, NewProduct);
                    Close();
                }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingList<Part> TempPartsList = new BindingList<Part>();
            allPartsGridView.ClearSelection();
            bool partFound = false;

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
            }
            else
            {
                toggleSaveButton();
                nameTextBox.BackColor = Color.White;
                addProductName = nameTextBox.Text;
            }
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            //If InventoryTextBox input can be converted to an integer its color changes 
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
            else if (maxTextBox.Text != "")
            {
                MessageBox.Show("Maximum: '" + maxTextBox.Text + "' must be a number!");
                maxTextBox.BackColor = Color.Tomato;
                maxTextBox.Clear();
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks if min input is an integer
            if (int.TryParse(minTextBox.Text, out addProductMin) && minTextBox.Text != "")
            {
                Console.WriteLine("Converting " + addProductMin + "...");
                toggleSaveButton();
            }
            else if (maxTextBox.Text != "" )
            {
                 MessageBox.Show("Minimum: '" + minTextBox.Text + "' must be a number!");
                 minTextBox.BackColor = Color.Tomato;
                 minTextBox.Clear();
            }
        }
    }
}
