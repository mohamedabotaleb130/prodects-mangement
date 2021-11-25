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
    public partial class MAIN : Form
    {

        //single instans
        private static MAIN frm;
        static void frm_formClosed(object sender,FormClosedEventArgs e)
        {

            frm = null;


        }
        public static MAIN getmain
        {
            get
            {
                if (frm==null)
                {
                    frm = new MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }

                return frm;

            }
        }



        public MAIN()
        {
            InitializeComponent();
            if (frm==null)
            {
                frm = this;
            }
            
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.استعادةالنسخةالمحفوظةToolStripMenuItem.Enabled = false;





        }

        private void الدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN frm = new LOGIN();
            frm.ShowDialog();
        }

        private void ادارةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void اضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Prodect frm = new ADD_Prodect();
            frm.ShowDialog();

        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PRODUCT frm = new Frm_PRODUCT();
            frm.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_categories frm = new FRM_categories();
            frm.ShowDialog();

        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Customers frm = new frm_Customers();
            frm.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER frm = new FRM_ORDER();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN frm = new LOGIN();
            frm.ShowDialog();
        }
    }
}
