using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace prodects_mangement.PL
{
    public partial class Frm_PRODUCT : Form
    {
        private static Frm_PRODUCT frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {

            frm = null;


        }
        public static Frm_PRODUCT getmain
        {
            get
            {
                if (frm == null)
                {
                    frm = new Frm_PRODUCT();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }

                return frm;

            }
        }
        BL.cls_prodect prd = new BL.cls_prodect();
        public Frm_PRODUCT()
        {


            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }

            this.dataGridView1.DataSource = prd.Get_aLL_prodects();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتج ؟", "حذف المنتج", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.deleteprodect(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("تم الحذف المنتج بالنجاح", "تم الحذف المنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dataGridView1.DataSource = prd.Get_aLL_prodects();
                
            }
            else
            {
                MessageBox.Show("تم الغاء عمليةالحذف", "عمليةالحذف ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.Searchproducts(txtsearch.Text);
            this.dataGridView1.DataSource = Dt;

            if (Dt.Rows.Count == 0)
            {
                MessageBox.Show("المنتج غير موجود رجاء اكتب اسم منتوج اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsearch.Focus();
                txtsearch.SelectionStart = 0;
                txtsearch.SelectionLength = txtsearch.TextLength;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_Prodect frm_add = new ADD_Prodect();
            frm_add.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_preview frm = new FRM_preview();
            byte[] img = (byte[])prd.Get_image_products(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           ADD_Prodect frm = new ADD_Prodect();
            frm.textRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textQty.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textPrics.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.CmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتوج : " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            frm.bt_OK.Text = "تحديث";
            frm.state = "update";
            frm.textRef.ReadOnly = true;
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Frm_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rpt.Rpt_all_prodect myreport = new Rpt.Rpt_all_prodect();
            Rpt.FRM_RPT_prodects myform = new Rpt.FRM_RPT_prodects();
            myform.crystalReportViewer2.ReportSource = myreport;
            myform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Rpt.RPT_prd_single myreprt = new Rpt.RPT_prd_single();
            myreprt.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Rpt.FRM_RPT_prodects myform = new Rpt.FRM_RPT_prodects();
            myform.crystalReportViewer2.ReportSource = myreprt;
            myform.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rpt.Rpt_all_prodect myreprt = new Rpt.Rpt_all_prodect();
            //creta Export option
            ExportOptions export = new ExportOptions();

            ExcelFormatOptions exalforamt = new ExcelFormatOptions();
            //create object  for defination 
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            //set the path of destination
            dfoptions.DiskFileName = @"E:\prpdectslist.xls";

            export = myreprt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = exalforamt;
            export.ExportDestinationOptions = dfoptions;

            myreprt.Export();
            MessageBox.Show(" list Exported successfully ! ", "Export",MessageBoxButtons.OK,MessageBoxIcon.Information);

             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم الخروج من البرنامج");
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}

