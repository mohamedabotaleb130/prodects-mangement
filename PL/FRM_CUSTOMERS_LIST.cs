using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodects_mangement.PL
{
   
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.Cls_cusromer cudt = new BL.Cls_cusromer();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.dgvcustomers.DataSource = cudt.GET_Allcustomer();
            this.dgvcustomers.Columns[0].Visible = false;   
            this.dgvcustomers.Columns[5].Visible = false;

        }

        private void dgvcustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
