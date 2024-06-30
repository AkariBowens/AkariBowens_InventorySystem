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
    public partial class AddProductScreen : Form
    {
        
        public AddProductScreen()
        {
            // add BindingComplete to both DGVs
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

            Inventory.TempProduct.AssociatedParts.Clear();
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

        }

        private void saveButton_Click(object sender, EventArgs e)
        { 
            int isValid = 0;

            int addProductId;
            if (int.TryParse(idTextBox.Text, out addProductId))
            {
                Console.WriteLine("Converting " + addProductId + " ...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Input " + idTextBox.Text + " not an int");
            }

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
                Console.WriteLine("Input " + InventoryTextBox.Text + " not an integer");
            }

            // Checks if partPrice input is a decimal
            double addProductPrice;
            if (double.TryParse(priceCostTextBox.Text, out addProductPrice))
            {
                Console.WriteLine("Converting " + addProductPrice + "...");
                isValid++;
            }
            else
            {
                Console.WriteLine("Input " + priceCostTextBox.Text + " not a decimal");
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
                Console.WriteLine("Input " + minTextBox.Text + " not an int");
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
                Console.WriteLine("Input " + maxTextBox.Text + " not an int");
            }

            Product NewProduct = new Product(addProductId, addProductName, addProductInv, addProductPrice, addProductMin, addProductMax);
            NewProduct.AssociatedParts = Inventory.TempProduct.AssociatedParts;

            if (isValid == 5)
            {
                Console.WriteLine(isValid);
                Console.WriteLine("Associated Parts: " + NewProduct.AssociatedParts.Count);
                Console.WriteLine(Inventory.TempProduct);
                Inventory.addProduct(NewProduct);
                Close();
            }
        }

        private void addAssocPartButton_Click(object sender, EventArgs e)
        {
            if (allPartsGridView.CurrentRow.Selected)
            { 
                // if associatedparts list is !empty and first add, clear it 
                Part currentPart = Inventory.LookupPart(allPartsGridView.CurrentRow.Index);
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

        private void assocPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assocPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            assocPartsGridView.ClearSelection();
        }
    }
}
