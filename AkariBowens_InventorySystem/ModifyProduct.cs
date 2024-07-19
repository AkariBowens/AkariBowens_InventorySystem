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
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Create a resetData method, instead of calling this every time
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

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Fills associatedParts on save and only if part is selected
            if (allPartsGridView.CurrentRow.Selected)
            {
                Part currentPart = Inventory.AllParts[allPartsGridView.CurrentRow.Index];
                Inventory.TempProduct.addAssociatedPart(currentPart);
                allPartsGridView.ClearSelection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (assocPartsGridView.CurrentRow.Selected)
            {
                // Part currentPart = Inventory.TempProduct.AssociatedParts[assocPartsGridView.CurrentRow.Index];
                Inventory.TempProduct.removeAssociatedPart(assocPartsGridView.CurrentRow.Index);
                allPartsGridView.ClearSelection();
            }
        }

        private void assocPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            assocPartsGridView.ClearSelection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                
                int isValid = 0;

                string addProductName = nameTextBox.Text;

                // Checks if inventory input is an int
                int addProductInv;
                if (int.TryParse(InventoryTextBox.Text, out addProductInv))
                {
                    Console.WriteLine("Converting " + addProductInv + " ..." + "\n");
                    isValid++;
                    InventoryTextBox.BackColor = Color.White;
                }
                else
                {
                    // Change these to message boxes on product and part
                    Console.WriteLine("Inventory " + InventoryTextBox.Text + " not an integer" + "\n");

                    MessageBox.Show("Inventory: '" + InventoryTextBox.Text + "' must be a number!");
                    InventoryTextBox.BackColor = Color.Red;
                }

                // Checks if partPrice input is a decimal
                double addProductPrice;
                if (double.TryParse(priceTextBox.Text, out addProductPrice))
                {
                    Console.WriteLine("Converting " + addProductPrice + "..." + "\n");
                    isValid++;
                    priceTextBox.BackColor = Color.White;
                }
                else
                {
                    // Change these to message boxes on product and part
                    Console.WriteLine("Price " + priceTextBox.Text + " not a decimal" + "\n");

                    MessageBox.Show("Price: '" + priceTextBox.Text + "' must be a decimal!");
                    priceTextBox.BackColor = Color.Red;
                }

                // Make sure part is an int
                int addProductMin;

                if (int.TryParse(minTextBox.Text, out addProductMin))
                {
                    Console.WriteLine("Converting " + addProductMin + " ..." + "\n");
                    isValid++;
                    minTextBox.BackColor = Color.White;
                }
                else
                {
                    // Change these to message boxes on product and part
                    Console.WriteLine("Minimum " + minTextBox.Text + " not an int" + "\n");

                    MessageBox.Show("Minimum: '" + minTextBox.Text + "' must be a number!");
                    minTextBox.BackColor = Color.Red;
                }

                // Checks if partPrice input is an int
                int addProductMax;
                if (int.TryParse(maxTextBox.Text, out addProductMax))
                {
                    Console.WriteLine("Converting " + addProductMax + "..." + "\n");
                    isValid++;
                    maxTextBox.BackColor = Color.White;
                }
                else
                {
                    // Change these to message boxes on product and part
                    Console.WriteLine("Maximum: " + maxTextBox.Text + " not an int" + "\n");

                    MessageBox.Show("Maximum: '" + maxTextBox.Text + "' must be a number!");
                    maxTextBox.BackColor = Color.Red;
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

                //Initializes a new product instance with the above variables
                Product NewProduct = new Product(Inventory.GlobalProductID++, addProductName, addProductInv, addProductPrice, addProductMin, addProductMax);

                for (int i = 0; i < Inventory.TempProduct.AssociatedParts.Count; i++)
                {
                    NewProduct.AssociatedParts.Add(Inventory.TempProduct.AssociatedParts[i]);
                }

                if (isValid == 4)
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

            // This part is annoying. It pops up at every option, create a while loop?
            // if (!partFound && partsSearchBar.Text != "") 
            if (!partFound)
            {
                MessageBox.Show("Nothing Found.");
                allPartsGridView.DataSource = Inventory.AllParts;
            }
        }
    }
}
