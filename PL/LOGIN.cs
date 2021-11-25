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
    public partial class LOGIN : Form

    {

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.Login(textID.Text, textPWD.Text);

            if (Dt.Rows.Count>0)

            {
                MAIN.getmain.المنتجاتToolStripMenuItem.Enabled = true;
                MAIN.getmain.العملاءToolStripMenuItem.Enabled = true;
                MAIN.getmain.المنتجاتToolStripMenuItem.Enabled = true;
                MAIN.getmain.المستخدمونToolStripMenuItem.Enabled = true;
                MAIN.getmain.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                MAIN.getmain.استعادةالنسخةالمحفوظةToolStripMenuItem.Enabled = true;
                Program.salesman = Dt.Rows[0]["FullName"].ToString();
                this.Close();


                // MessageBox.Show("تم التسجيل بانجاح");
            }

            else
            {
                MessageBox.Show("فشل الدخول ");
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
