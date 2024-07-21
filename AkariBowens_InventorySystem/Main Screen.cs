using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AkariBowens_InventorySystem
{
    public partial class mainScreen : Form
    {

        public mainScreen()
        {
            InitializeComponent();
            
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPartScreen newPartScreen = new AddPartScreen();
            newPartScreen.Show();
        }

        private void applicationExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partsGridView.ClearSelection();
        }
        
        private void productsAddButton_Click(object sender, EventArgs e)
        {
            Inventory.TempProduct = new Product(0, " ", 0, 0, 0, 0);
            AddProductScreen newProductScreen = new AddProductScreen();
            newProductScreen.Show();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            // Shows message box if notheing is selected
            if (partsGridView.CurrentRow == null || !partsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("There is nothing selected!", "Modify Part");
                return;
            }

            // ---------- //

            if (partsGridView.CurrentRow.Selected)
            {
                // Gets index of selected part 
                Inventory.SelectedPart = Inventory.LookupPart(partsGridView.CurrentRow.Index);
                Inventory.SelectedPartIndex = Inventory.AllParts.IndexOf(Inventory.SelectedPart);
            }

            ModifyPartScreen newModifyPartScreen = new ModifyPartScreen();
            newModifyPartScreen.Show();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.CurrentRow == null || !productsGridView.CurrentRow.Selected)
            {
                // Edit wording 
                MessageBox.Show("There is nothing selected!", "Make a selection");
                return;
            }

            // ----------- //

            if (productsGridView.CurrentRow.Selected)
            {
                // Gets index of selected row in product DGV
                Inventory.TempProduct = Inventory.LookupProduct(productsGridView.CurrentRow.Index);
                Inventory.TempProductIndex = Inventory.AllProducts.IndexOf(Inventory.TempProduct);
            }

            ModifyProduct newModifyProductScreen = new ModifyProduct();
            newModifyProductScreen.Show();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            // Sets AllProducts DataSource //
            productsGridView.DataSource = Inventory.AllProducts;

            // Highlights full row on selection
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Makes DataGridView read only
            productsGridView.ReadOnly = true;

            // Makes DataGridView single-select
            productsGridView.MultiSelect = false;

            // Removes empty bottom row
            productsGridView.AllowUserToAddRows = false;

            // ----------------------------------------------//

            // Sets AllParts DataSource //
            partsGridView.DataSource = Inventory.AllParts;

            // Highlights full row on selection
            partsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Makes DataGridView read only
            partsGridView.ReadOnly = true;

            // Makes DataGridView single-select
            partsGridView.MultiSelect = false;

            // Removes empty bottom row
            partsGridView.AllowUserToAddRows = false;
    }

        private void partsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productsGridView.ClearSelection();
            Inventory.SelectedPartIndex = partsGridView.CurrentCell.RowIndex;
        }

        private void partsDGVBindComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Clears default partsGridView bindingComplete selection
            partsGridView.ClearSelection();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            

            if (partsGridView.CurrentRow == null || !partsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("There is nothing selected!", "Part Delete");
                return;
            }
            
            // Grabs index of selected item in partsDGV
            int Index = partsGridView.CurrentCell.RowIndex;
            
            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to delete this?", "Delete Part", MessageBoxButtons.YesNo);
            // Removes indexed item from AllParts list

            if (confirmationResult == DialogResult.Yes)
            {
                if (!Inventory.deletePart(Inventory.AllParts[Index]))
                {
                    MessageBox.Show("Part is associated with a Product!");
                }
            }

            // Resets current selected cell
            partsGridView.ClearSelection();
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            // Clear selection on parts

            if (productsGridView.CurrentRow == null || !productsGridView.CurrentRow.Selected) 
            {
                // Edit wording 
                MessageBox.Show("There is nothing selected!", "Make a selection");
                return; 
            }

            // Grabs index of selected item in productDGV
            int Index = productsGridView.CurrentCell.RowIndex;

            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to delete this?", "Delete Product", MessageBoxButtons.YesNo);
            // Calls removeProduct and removes indexed item from AllProducts list
            if (confirmationResult == DialogResult.Yes)
            {
                if (Inventory.LookupProduct(productsGridView.CurrentRow.Index).AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Product has a part associated with it.");
                } else
                {
                    Inventory.removeProduct(Index);
                }
            }

            // Resets current selected cell to false
            productsGridView.ClearSelection();
        }

        private void partsSearchBar_TextChanged(object sender, EventArgs e)
        {
            // Searches for a string in the names of AllParts
            BindingList<Part> TempPartsList = new BindingList<Part>();
            partsGridView.ClearSelection();
            bool partFound = false;
            
            if (partsSearchBar.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    // Searches Names of Parts in AllParts
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchBar.Text.ToUpper()))
                    {
                        TempPartsList.Add(Inventory.AllParts[i]);
                        partFound = true;
                    }    
                }

                // When a part is found the source for partsDGV changes 
                if (partFound)
                {
                    partsGridView.DataSource = TempPartsList;
                }
                
            }
             
            // When a part is not found 
            if (!partFound)
            {
                // Clears text input when a part is not found and the searchbar is not empty
                if (partsSearchBar.Text != "")
                {
                    MessageBox.Show("Nothing Found.");
                    partsSearchBar.Clear();
                    
                } else
                {
                    partsGridView.DataSource = Inventory.AllParts;
                }

            }

        }

        private void productsSearchBar_TextChanged(object sender, EventArgs e)
        {
            // Search for names of products in AllProducts
            BindingList<Product> TempProductsList = new BindingList<Product>();
            productsGridView.ClearSelection();
            bool productFound = false;

            if (productsSearchBar.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    // Searches Names of Parts in AllParts
                    if (Inventory.AllProducts[i].Name.ToUpper().Contains(productsSearchBar.Text.ToUpper()))
                    {
                        TempProductsList.Add(Inventory.AllProducts[i]);
                        productFound = true;
                    }
                }

                if (productFound)
                {
                    productsGridView.DataSource = TempProductsList;
                }

            }

            // When a part is not found 
            if (!productFound)
            {
                // Clears text input when a part is not found and the searchbar is not empty
                if (productsSearchBar.Text != "")
                {
                    MessageBox.Show("Nothing Found.");
                    productsSearchBar.Clear();
                }
                else
                {
                    productsGridView.DataSource = Inventory.AllProducts;
                }

            }
        }

        private void productsPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsGridView.ClearSelection();
        }
    }
 }

