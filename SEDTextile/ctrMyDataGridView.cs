
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTextile
{
    public partial class ctrMyDataGridView : UserControl
    {
        public event EventHandler<DataGridViewRowStateChangedEventArgs> OnRowStateChanged;

        public event Action<int> OnContextMenuItemSelected;
        public event Action<int> OnContextMenuOpening;
        public event Action<int> OnRowClicked;
        private bool _withCheckBoxColumn;

        SortedSet<int> IDsOfCheckedRows = new SortedSet<int>();

        

        public DataTable DataSource
        {
            get => (DataTable)dataGridView1.DataSource;
            set { if (value != null) setDataSource(value); else dataGridView1.DataSource = null; }
        }
        public bool MultiSelect
        {
            get => dataGridView1.MultiSelect;
            set => dataGridView1.MultiSelect = value;
        }
        private int IDColumnIndex=0;

        public bool withCheckBoxColumn
        {
            get => _withCheckBoxColumn;
            set
            {
                _withCheckBoxColumn = value;
                if (_withCheckBoxColumn)
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    IDColumnIndex = 1;
                    chk.HeaderText = "Choose";
                    chk.Name = "chk";
                    dataGridView1.Columns.Insert(0, chk);
                }
                else
                {
                    IDColumnIndex = 0;
                    if (dataGridView1.Columns.Count == 0)
                        return;
                    if (dataGridView1.Columns[0] is DataGridViewCheckBoxColumn)
                        dataGridView1.Columns.RemoveAt(0);
                }
            }
        }
        


        public ctrMyDataGridView()
        {
            InitializeComponent();
            this.Enabled = dataGridView1.DataSource != null;
            dataGridView1.RowStateChanged += OnDataGridRowStateChanged;
            
        }

        private void OnDataGridRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Displayed)
                return;
            OnRowStateChanged?.Invoke(sender,e);
            lblCount.Text = dataGridView1.RowCount.ToString();
        }

        void FillcbFilterBy()
        {
            cbFilterBy.Items.Clear();
            DataTable dt = DataSource;
            foreach (DataColumn col in dt.Columns)
            {
                cbFilterBy.Items.Add(col.ColumnName);
            }
            cbFilterBy.SelectedIndex = 0;

        }
        
        private void ctrMyDataGridView_Load(object sender, EventArgs e)
        {

        }
        private void CustomizeDataGridViewUsingBaseStyle()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }
            dataGridView1.BackgroundColor = Color.White;
        }
        public void FilterRowByItemID(int itemID)
        {
            txtFilter.Clear();
            txtFilter.Text = itemID.ToString();
            OnRowClicked?.Invoke(itemID);
        }
        
        void setDataSource(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            CustomizeDataGridViewUsingBaseStyle();
            FillcbFilterBy();
            SetCheckBoxColumnAbilityToModify();
            
            
        }
        void SetCheckBoxColumnAbilityToModify()
        {
         
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column is DataGridViewCheckBoxColumn)
                    continue;
                column.ReadOnly = true;
            }
        }
        public void CheckRows(SortedSet<int> IDsOfRowsToBeChecked)
        {
           
            if (IDsOfRowsToBeChecked == null || !withCheckBoxColumn)
                return;

            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (IDsOfRowsToBeChecked.Contains((int)gridRow.Cells[IDColumnIndex].Value))
                {
                    gridRow.Cells[0].Value = true;
                }
            }

        }
        public void setContextMenuStrip(ToolStripItem[] items)
        {
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.AddRange(items);

        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool IsSelectedFilterNumeric()
        {
            try
            {
                var ColumnType = dataGridView1.Columns[cbFilterBy.SelectedItem.ToString()].ValueType;
                return ColumnType == typeof(int) || ColumnType == typeof(long) ||
              ColumnType == typeof(float) || ColumnType == typeof(double) ||
              ColumnType == typeof(decimal);


            }
            catch
            {
                throw new Exception("Problem in isSelectedFilterNumeric()");
            }

        }
        
       
        void DataGridViewRowFilter(string FilterExpression)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = FilterExpression;

            if (withCheckBoxColumn)
                RestoreCheckedRows();

            dataGridView1.ClearSelection();



        }

        void RestoreCheckedRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (IDsOfCheckedRows.Contains((int)row.Cells[IDColumnIndex].Value))
                    row.Cells[0].Value = true;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterExpression = "";
            if (txtFilter.Text != "")
            {
                if (IsSelectedFilterNumeric())
                    FilterExpression = $"[{cbFilterBy.SelectedItem.ToString()}] = {txtFilter.Text}";
                else
                    FilterExpression = $"[{cbFilterBy.SelectedItem.ToString()}] like '%{txtFilter.Text}%'";

            }
            DataGridViewRowFilter(FilterExpression);
            

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            DataGridViewRowFilter("");

        }

        public void SelectFirstRecord()
        {
            if (dataGridView1.RowCount > 0)
                OnRowClicked?.Invoke((int)dataGridView1.Rows[0].Cells[IDColumnIndex].Value);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSelectedFilterNumeric())
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OnContextMenuItemSelected?.Invoke((int)dataGridView1.CurrentRow.Cells[IDColumnIndex].Value);
        }

        public SortedSet<int> getIDsOfCheckedRows()
        {
            return IDsOfCheckedRows;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (contextMenuStrip1.Items.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            OnContextMenuOpening?.Invoke((int)dataGridView1.CurrentRow.Cells[IDColumnIndex].Value);
               

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (withCheckBoxColumn && e.ColumnIndex == 0)
            {
                bool IsChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (IsChecked)
                    IDsOfCheckedRows.Add((int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                else
                    IDsOfCheckedRows.Remove((int)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex ==-1 || e.ColumnIndex == -1)//for header click
                return;

            int IDOfClickedRow = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[IDColumnIndex].Value.ToString());
           
            OnRowClicked?.Invoke(IDOfClickedRow);
        }
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            
                this.Enabled= dataGridView1.DataSource != null;
           
        }
    }
}
