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
    public partial class frm_products_list : Form
    {
        BL.cls_prodect prd = new BL.cls_prodect();
        public frm_products_list()
        {
            InitializeComponent();

            this.dgvprodect.DataSource = prd.Get_aLL_prodects();
        }

        private void dgvprodect_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
