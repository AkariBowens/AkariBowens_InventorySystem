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
    }
}
