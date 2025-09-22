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
    public partial class frmTextileVariants : Form
    {
        int _textileID;
        public frmTextileVariants(int TextileID)
        {
            InitializeComponent();
            _textileID =TextileID ;
        }

        private void frmVariants_Load(object sender, EventArgs e)
        {
            label1.Text = _textileID.ToString();
        
        }
    }
}
