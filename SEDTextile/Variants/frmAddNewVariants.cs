using SEDTextileBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTextile.Variants
{
    public partial class frmAddNewVariants : Form
    {
        Panel _parentPanel;
        enum enVariantColumns
        {
            Alias = 0,
            Code = 1
            
        }
        DataTable _dtVariants = new DataTable();
        public frmAddNewVariants()
        {
            InitializeComponent();
            _dtVariants = clsVariant.GetAllVariants();
        }
        public void SetParentPanel(Panel parentPanel)
        {
            this._parentPanel = parentPanel;
        }

        private void btnAddVariants_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Please insert variants to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if(MessageBox.Show($"Are you sure you want to add these variants?\nTotal number of variants to be added is {dataGridView1.RowCount - 1}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (clsVariant.AddNewVariantsTable(ConvertDataGridViewToDataTable(dataGridView1)))
                {
                    MessageBox.Show("Variants added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occured while adding variants", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        DataTable ConvertDataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Add columns based on DataGridView column headers
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Add rows from DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)  // Avoid adding the empty new row
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value ?? DBNull.Value;  // Handle nulls
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string newValue = e.FormattedValue.ToString();

            bool isDuplicateInDataGridView = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Index != e.RowIndex && row.Cells[e.ColumnIndex].Value != null)
                .Any(row => row.Cells[e.ColumnIndex].Value.ToString() == newValue);

            bool isDuplicateInDataBase = _dtVariants.AsEnumerable()
                .Select(x => x.Field<string>(((enVariantColumns)e.ColumnIndex).ToString()))
                .ToList()
                .Contains(newValue);

            if (isDuplicateInDataGridView)
            {
                MessageBox.Show($@"Duplicate value ""{newValue}"" found! Please enter a unique value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            if (isDuplicateInDataBase) 
            {
                MessageBox.Show($@"{(enVariantColumns)e.ColumnIndex} with value ""{newValue}"" already exists! Please enter a unique value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            e.Cancel = false;


        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (dataGridView1.SelectedCells.Count > 0) // Ensure a cell is selected
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex; // Get the row index of the selected cell

                    if (!dataGridView1.Rows[rowIndex].IsNewRow) // Prevent deletion of the new row
                    {
                        dataGridView1.Rows.RemoveAt(rowIndex); // Delete the entire row
                    } 
                }
                e.Handled = true; // Prevent default behavior
            }

            
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Get the row being validated
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }
            
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                  
                    e.Cancel = true;

                    MessageBox.Show("All cells in the row must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return; 
                }
               
            }
        }

        private void frmAddNewVariants_Load(object sender, EventArgs e)
        { 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                // Remove any existing KeyPress event handler to prevent duplicates
                textBox.KeyPress -= TextBox_KeyPress;

                // Add the KeyPress event handler
                textBox.KeyPress += TextBox_KeyPress;
            }


        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsUpper(e.KeyChar))
            {
                // Convert uppercase to lowercase
                e.KeyChar = char.ToLower(e.KeyChar);
            }
        }
    }
}
