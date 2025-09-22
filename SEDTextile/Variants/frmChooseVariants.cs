using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEDTextileBusiness;

namespace SEDTextile.Variants
{
    
    public partial class frmChooseVariants : Form
    {
        public event Action<SortedSet<int>> OnChoose;
        SortedSet<int> _IDsOfChosenVariants;
        
        public frmChooseVariants(SortedSet<int> ChosenVariantsIDs=null)
        {
            InitializeComponent();
            ctrMyDataGridView1.MultiSelect = true;
            ctrMyDataGridView1.withCheckBoxColumn = true;
            _IDsOfChosenVariants = ChosenVariantsIDs;
        }

        private void frmChooseVariants_Load(object sender, EventArgs e)
        {
            ctrMyDataGridView1.DataSource = clsVariant.GetAllVariants();
            ctrMyDataGridView1.CheckRows(_IDsOfChosenVariants);



        }

        private void btnChooseVariants_Click(object sender, EventArgs e)
        {
            OnChoose?.Invoke(ctrMyDataGridView1.getIDsOfCheckedRows());
            this.Close();
        }

        void OnAddNewVariantsChildFormClose(object sender, FormClosedEventArgs e)
        {
            frmChooseVariants_Load(null,null);
        }
        private void btnAddVariants_Click(object sender, EventArgs e)
        {
            frmAddNewVariants frm = new frmAddNewVariants();
            frm.FormClosed +=  OnAddNewVariantsChildFormClose;
            frm.ShowDialog();   

        }

        private void ctrMyDataGridView1_Load(object sender, EventArgs e)
        {

        }
    }
}
