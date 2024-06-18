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
            priceCostTextBox.Text = Inventory.TempProduct.Price.ToString();
            maxTextBox.Text = Inventory.TempProduct.Max.ToString();
            minTextBox.Text = Inventory.TempProduct.Min.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Fills associatedParts on save and only if part is selected
            if (allPartsGridView.CurrentRow.Selected)
            {
                // if associatedparts list is !empty and first add, clear it 
                Part currentPart = Inventory.AllParts[allPartsGridView.CurrentRow.Index];
                Inventory.TempProduct.addAssociatedPart(currentPart);
                allPartsGridView.ClearSelection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (assocPartsGridView.CurrentRow.Selected)
            {
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
            // Saves edited product to inventory
            // Copy data from temp to new object, clear temp, save new obj
            int isValid = 0;

            int addProductId;
            if (int.TryParse(idTextBox.Text, out addProductId))
            {
                Console.WriteLine("Converting " + addProductId + " ...");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + idTextBox.Text + " not an int");
            }

            string addProductName = nameTextBox.Text;
            // Inventory.TempProduct.Name = addProductName;

            // Checks if inventory input is an int
            int addProductInv;
            if (int.TryParse(InventoryTextBox.Text, out addProductInv))
            {
                Console.WriteLine("Converting " + addProductInv + " ..." + "\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + InventoryTextBox.Text + " not an integer" + "\n");
            }

            // Checks if partPrice input is a decimal
            double addProductPrice;
            if (double.TryParse(priceCostTextBox.Text, out addProductPrice))
            {
                Console.WriteLine("Converting " + addProductPrice + "..." + "\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + priceCostTextBox.Text + " not a decimal" + "\n");
            }

            // Make sure part is an int
            int addProductMin;
            if (int.TryParse(minTextBox.Text, out addProductMin))
            {
                Console.WriteLine("Converting " + addProductMin + " ..." + "\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + minTextBox.Text + " not an int" + "\n");
            }

            // Checks if partPrice input is an int
            int addProductMax;
            if (int.TryParse(maxTextBox.Text, out addProductMax))
            {
                Console.WriteLine("Converting " + addProductMax + "..." + "\n");
                isValid++;
            }
            else
            {
                // Change these to message boxes on product and part
                Console.WriteLine("Input " + maxTextBox.Text + " not an int" + "\n");
            }

            //Since we are saving a product to a product, we are savinging the values to the existing product
            Product NewProduct = new Product(addProductId, addProductName, addProductInv, addProductPrice, addProductMin, addProductMax);
            NewProduct.AssociatedParts = Inventory.TempProduct.AssociatedParts;

            if (isValid == 5)
            {
                Console.WriteLine(isValid + "\n");
                Console.WriteLine("Associated Parts: " + NewProduct.AssociatedParts.Count + "\n");
                Console.WriteLine(Inventory.TempProduct + "\n");

                //What if instead of testing all, just test the ones that are different
                int ProductIdx = Inventory.TempProduct.ProdIdx;
                Inventory.UpdateProduct(ProductIdx, NewProduct);
             
                Close();
            }
        }
    }
}
