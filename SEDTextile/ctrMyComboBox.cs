using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTextile
{
    public partial class ctrMyComboBox : UserControl
    {
       
        private Dictionary<int, string> _dataSource;
        public Dictionary<int, string> DataSource { get => _dataSource; set { if (value != null) { _dataSource = value; setDataSource(); }  } }
        public ctrMyComboBox()
        {
            InitializeComponent();
            
        }
        void setDataSource()
        {
            comboBox1.DataSource = new BindingSource(this.DataSource, null);
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
            comboBox1.SelectedIndex = 0;

            // Set up auto-complete
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Populate AutoCompleteCustomSource with dictionary values
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(_dataSource.Values.ToArray());
            comboBox1.AutoCompleteCustomSource = autoComplete;
        }
        public string getSelectedItemText()
        {
            return ((KeyValuePair<int,string>)comboBox1.SelectedItem).Value;
        }
        public int getSelectedItemID()
        {
            return ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Reset()
        {
            comboBox1.SelectedIndex = 0;
            
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
          if(comboBox1.SelectedIndex==-1)
                try
                {
                    comboBox1.SelectedIndex = 0;
                }
                catch 
                {
                    MessageBox.Show("No choices to choose from!");
                }
                
        }
    }
}
