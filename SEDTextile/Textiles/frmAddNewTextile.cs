using SEDTextile.Variants;
using SEDTextileBusiness;
using SEDTextileDTOs.Textile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEDTextile.Textiles
{
    public partial class frmAddNewTextile : Form
    {
        SortedSet<int> _ChosenVariantsIds;
        
        public frmAddNewTextile()
        {
            InitializeComponent();
           
        }

        private void frmAddNewTextile_Load(object sender, EventArgs e)
        {
           
            mycbFactory.DataSource=clsFactory.FactoryIDWithFactoryNamePairs();
            mycbFabric.DataSource=clsFabricType.FabricTypeIDWithFabricNamePairs();


        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this textile?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            //todo, add validation

            AddTextileDTO dto = new AddTextileDTO()
            {
                Alias = txtAlias.Text.Trim(),
                Code = txtCode.Text.Trim(),
                FabricTypeID = mycbFabric.getSelectedItemID(),
                FactoryID = mycbFactory.getSelectedItemID(),
                BuyingPrice = (float)nudBuyingPrice.Value,
                SellingPrice = (float)nudSellingPrice.Value,
                VariantsIDs = _ChosenVariantsIds
            };
            //todo, change this addnew to non static
            if(clsTextile.AddNew(dto))
                MessageBox.Show("Textile added successfully");
            else
            {
                MessageBox.Show("Failed to add textile");
            }


        }
        void onChildFormClose(object sender, FormClosedEventArgs e)
        {
            
            frmAddNewTextile_Load(null, null);
        }
        
        void OnVariantsChosen(SortedSet<int>ChosenVariantsIDs)
        {
            _ChosenVariantsIds = ChosenVariantsIDs;
            if(_ChosenVariantsIds.Count > 0)
            {
                txtChosenVariantsIDs.Text= string.Join(", ", _ChosenVariantsIds);
                
            }
            else
            {
                txtChosenVariantsIDs.Text = "No variants chosen";
            }
           
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmChooseVariants childForm = new frmChooseVariants(_ChosenVariantsIds);
            childForm.OnChoose += OnVariantsChosen;
            childForm.ShowDialog();

        }
    }
}
