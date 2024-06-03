using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
        
        }
        
        // Change to products
        private void propertiesAddButton_Click(object sender, EventArgs e)
        {
            AddProductScreen newProductScreen = new AddProductScreen();
            newProductScreen.Show();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            // only executes if (currentRow.Selected) - prefill values on modify screen with selected
            if (partsGridView.CurrentRow == null || !partsGridView.CurrentRow.Selected)
            {
                // Edit wording 
                MessageBox.Show("There is nothing selected!", "Make a selection");
                return;
            }

            // 
            // ---------- //

            if (partsGridView.CurrentRow.Selected)
            {
                int Index = partsGridView.CurrentCell.RowIndex;
                //List<string> newList = new List<string>();
                // Part TempPart = new Part(Inventory.LookupPart(Index));
                // Inventory.lookupPart(Index);
                Inventory.SelectedPart = Inventory.LookupPart(Index);
  
            }

            ModifyPartScreen newModifyPartScreen = new ModifyPartScreen();
            newModifyPartScreen.Show();
        }

        private void propertiesModifyButton_Click(object sender, EventArgs e)
        {
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


            // ----- //
            // public static int partsIndex;
    }

        private void partsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // int Index = partsGridView.CurrentRow.Index;
            // public static List<string> newList { get; set; } = new List<string>();

            // Part.SelectedPartID = partsGridView.Columns[Index].Cells[0].Value;
         
            
               
             //newList.Append(partsGridView.Rows[Index].Cells[i].Value.ToString());
                // Console.WriteLine(newList);

            

            

        }

        private void partsDGVBindComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Clears default partsGridView bindingComplete selection
            partsGridView.ClearSelection();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            // Clear selection on products

            if (partsGridView.CurrentRow == null || !partsGridView.CurrentRow.Selected)
            {
                // Edit wording 
                MessageBox.Show("There is nothing selected!", "Make a selection");
                return;
            }
            

            // Grabs index of selected item in partsDGV
            int Index = partsGridView.CurrentCell.RowIndex;
            // Console.WriteLine();
            // use this and find the part and pass it to the method

            // Removes indexed item from AllParts list
            // - grab part data from currentcell
            Inventory.deletePart(Inventory.AllParts[Index]);

            // Resets current selected cell == null
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

            partsGridView.ClearSelection();
            // Grabs index of selected item in productDGV
            int Index = productsGridView.CurrentCell.RowIndex;

            // Calls removeProduct and removes indexed item from AllProducts list
            Inventory.removeProduct(Index);

            // Resets current selected cell == null
            productsGridView.ClearSelection();
        }

        private void partsSearchBar_TextChanged(object sender, EventArgs e)
        {
            // Search for character in list - continue within that list, so it never exits the loop
            // option to filter by specific param. i.e. name, price, id
            // have a reset button to return to original list

            // connect all of this to only search when "searchButton" is pressed
            BindingList<Part> TempPartsList = new BindingList<Part>();
            partsGridView.ClearSelection();
            bool partFound = false;

            // int rowIndex;
            // if (Int32.TryParse(partsSearchBar.Text, out rowIndex))
            // {
                // Inventory.lookupPart(rowIndex);
            // } 

            // if part is a num then else v
            if (partsSearchBar.Text != "")
            {
                // this is where the switch statement would be placed -- While loop
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    // lookUp part would go here - Inventory.lookupPart(Index).Contains(partsSearchBar.Text.ToUpper()))
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partsSearchBar.Text.ToUpper()))
                    {
                        TempPartsList.Add(Inventory.AllParts[i]);
                        partFound = true;
                    }
                    
                }
                if (partFound)
                {
                    partsGridView.DataSource = TempPartsList;
                }
                
                // Inventory.lookupPart(Index);
                
            }

            // This part is annoying. It pops up at every option, create a while loop?
            // if (!partFound && partsSearchBar.Text != "") 
            if (!partFound)
            {
                MessageBox.Show("Nothing Found.");
                partsGridView.DataSource = Inventory.AllParts;
            }

            // Put a reset next to search bar or put "RESET" in search bar


            // ----- After I put it in lookUpPart() ----- //
            // if (partsGridView.CurrentCell.Selected)
            // Part CurrentPart = new Part(partsGridView.CurrentCell) 
            // int Index = partsGridView.CurrentCell.RowIndex;
            // Inventory.lookUpPart(Index, CurrentPart)
            // 
        }

        private void productsSearchBar_TextChanged(object sender, EventArgs e)
        {
            // Search for character in list - continue within that list, so it never exits the loop
            // option to filter by specific param. i.e. name, price, id
            // have a reset button to return to original list

            // connect all of this to only search when "searchButton" is pressed
            BindingList<Product> TempProductsList = new BindingList<Product>();
            productsGridView.ClearSelection();
            bool productFound = false;

            if (productsSearchBar.Text != "")
            {
                // this is where the switch statement would be placed -- While loop
                for (int i = 0; i < Inventory.AllProducts.Count; i++)
                {

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

            // This part is annoying. It pops up at every option, create a while loop?
            // if (!productFound && productsSearchBar.Text != "") 
            if (!productFound)
            {
                MessageBox.Show("Nothing Found.");
                productsGridView.DataSource = Inventory.AllProducts;
            }
        }

        // private void productsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
            // Clears default productsGridView bindingComplete selection
            
        // }

        private void productsPartsDGVBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsGridView.ClearSelection();
        }
    }
 }

