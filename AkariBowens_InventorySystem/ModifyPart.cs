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
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen()
        {
            InitializeComponent();
        }
    

        private void addPartCancel_Click(object sender, EventArgs e)
        {
            // If fields are changed from Inventory.SelectedPart - "Are you sure?"
            Close();
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {
           // Loop the different properties of ModifyPartScreen and fill from Inventory.SelectedPart
            addPartSave.Enabled = false;

            // Pre-populate fields
            idTextBox.Text = Inventory.SelectedPart.PartID.ToString();
            nameTextBox.Text = Inventory.SelectedPart.Name.ToString();
            InventoryTextBox.Text = Inventory.SelectedPart.InStock.ToString();
            priceCostTextBox.Text = Inventory.SelectedPart.Price.ToString();
            maxTextBox.Text = Inventory.SelectedPart.Max.ToString();
            minTextBox.Text = Inventory.SelectedPart.Min.ToString();

            // MachineID or CompanyName
        }

        private void addPartSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            
            // Validation code here
            
            if (isValid == true)
            {
                addPartSave.Enabled =  true;
                // Inventory.updatePart(<Part>);
                Close();
            } 
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
