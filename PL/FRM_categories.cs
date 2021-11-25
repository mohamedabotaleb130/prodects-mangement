using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace prodects_mangement.PL
{
    public partial class FRM_categories : Form
    {

        SqlConnection sqlcon = new SqlConnection("Server=DESKTOP-0PP6E48; Database=product_DB; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;

        SqlCommandBuilder cmdb;


        public FRM_categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'المعرف' ,DESCRIPTION_CAT as 'الصنف' from Categories ", sqlcon);
            da.Fill(dt);
            dg_list.DataSource = dt;
            textID.DataBindings.Add("text", dt, "المعرف");
            textDES.DataBindings.Add("text", dt, "الصنف");

            bmb = this.BindingContext[dt];
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count-1);
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Added successfully", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = false;
            bt_new.Enabled = true;
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            bt_new.Enabled = false;
            btn_add.Enabled = true;

            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            textID.Text = id.ToString();
            textDES.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("deleted successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count-1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position =bmb.Count;
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);

        }

        private void btn_previoes_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            IPlpotion.Text = bmb.Position + "  /  " + (bmb.Count - 1);

        }

        private void btn_printcurrent_Click(object sender, EventArgs e)
        {
            Rpt.SINGLECATEGORY myreprt = new Rpt.SINGLECATEGORY();
            myreprt.SetParameterValue("@ID", this.dg_list.CurrentRow.Cells[0].Value.ToString());

            Rpt.FRM_RPT_prodects myform = new Rpt.FRM_RPT_prodects();
            myform.crystalReportViewer2.ReportSource = myreprt;
            myform.ShowDialog();








            //Rpt.SINGLECATEGORY rpt = new Rpt.SINGLECATEGORY();
            //rpt.SetParameterValue("@ID", this.textID.Text);

            //Rpt.FRM_RPT_prodects myform = new Rpt.FRM_RPT_prodects();
            //myform.crystalReportViewer2.ReportSource = rpt;
            //myform.ShowDialog();


            //
            //Rpt.SINGLECATEGORY rpt = new Rpt.SINGLECATEGORY();
            //Rpt.FRM_RPT_prodects frm = new Rpt.FRM_RPT_prodects();
            //rpt.SetParameterValue("@id", Convert.ToInt32(textID.Text)) ;
            //frm.crystalReportViewer2.ReportSource = rpt;
            //frm.ShowDialog();   

        }

        private void btn_printall_Click(object sender, EventArgs e)
        {
            Rpt.rpt_all_catgris  rpt = new Rpt.rpt_all_catgris();
            Rpt.FRM_RPT_prodects frm = new Rpt.FRM_RPT_prodects();
            rpt.Refresh();
            frm.crystalReportViewer2.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void exportTOpdfall_Click(object sender, EventArgs e)
        {
            Rpt.rpt_all_catgris myreprt = new Rpt.rpt_all_catgris();
            //creta Export option
            ExportOptions export = new ExportOptions();

            PdfFormatOptions pdfforamt = new PdfFormatOptions();
            //create object  for defination 
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            //set the path of destination
            dfoptions.DiskFileName = @"E:\catgrislist.pdf";

            export = myreprt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = pdfforamt;
            export.ExportDestinationOptions = dfoptions;
            myreprt.Refresh();
            myreprt.Export();
            MessageBox.Show(" list Exported successfully ! ", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void exportTOpdfcurrent_Click(object sender, EventArgs e)
        {

            Rpt.SINGLECATEGORY myreprt = new Rpt.SINGLECATEGORY();
            //creta Export option
            ExportOptions export = new ExportOptions();

            PdfFormatOptions pdfforamt = new PdfFormatOptions();
            //create object  for defination 
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            //set the path of destination
            dfoptions.DiskFileName = @"E:\Catgrislists.pdf";

            export = myreprt.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = pdfforamt;
            export.ExportDestinationOptions = dfoptions;
            myreprt.SetParameterValue("@id", Convert.ToInt32(textID.Text));
            
            myreprt.Export();
            MessageBox.Show(" list Exported successfully ! ", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
