using System;
using System.Data;
using System.Drawing;
using System.IO;
 using System.Globalization;
using System.Windows.Forms;
using System.Linq;

namespace prodects_mangement.PL
{
    public partial class FRM_ORDER : Form
    {
        BL.CLS_orders order = new BL.CLS_orders();
        DataTable DT = new DataTable();
        void calculateamount()
        {
            if (txtprics.Text != string.Empty && txtQty.Text != string.Empty)
            {


                txtAmount.Text = (Convert.ToDouble(txtprics.Text) * Convert.ToInt32(txtQty.Text)).ToString();

            }

        }
        void calculateaTmount()
        {
            if (txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            {


                double descont = Convert.ToDouble(txtDiscount.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TOtalamont = Amount - (Amount * (descont / 100));
                txtTotalAmont.Text = TOtalamont.ToString();
            }


        }
        void CreateData()
        {
            txtorderID.Clear();
            txtDescOrder.Clear();
            txtSalesMan.Clear();
            dtOrder.ResetText();
            txtCustmersID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            clearBoxes();
            DT.Clear();
            dgdGridView.DataSource = null;
            txtSumTotal.Clear();
            pbox.Image = null;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnPrint.Enabled = true;

        }
        void CreateDataTable()
        {
            DT.Columns.Add("معرف المنتوج");
            DT.Columns.Add("اسم المنتوج");
            DT.Columns.Add("الثمن");
            DT.Columns.Add("الكمية  ");
            DT.Columns.Add("المبلغ");
            DT.Columns.Add("نسبة الخصم (%)");
            DT.Columns.Add("المبلغ الاجمالي");
            dgdGridView.DataSource = DT;


            //Add Buton column to DataGridViewButtonColumn  
            /*DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "اختيار منتج";
            btn.Text = "البحث";
            btn.UseColumnTextForButtonValue = true;
            dgdGridView.Columns.Insert(0,btn);*/
        }
        void clearBoxes()
        {
            txtIDproducts.Clear();
            txtNameprodect.Clear();
            txtprics.Clear();
            txtQty.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();

            txtTotalAmont.Clear();
            btnbrows.Focus();



        }
        void ResizeDGV()
        {



            try
            {
                this.dgdGridView.RowHeadersWidth = 90;




                // dgdGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;                
                //dgdGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 

                //dgdGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //dgdGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // dgdGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
                // dgdGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
                //dgdGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                this.dgdGridView.Columns[0].Width = 100;
                this.dgdGridView.Columns[1].Width = 100;
                this.dgdGridView.Columns[2].Width = 150;
                this.dgdGridView.Columns[3].Width = 160;
                this.dgdGridView.Columns[4].Width = 123;
                this.dgdGridView.Columns[5].Width = 121;
                this.dgdGridView.Columns[6].Width = 118;
            }
            catch
            {

                return;
            }
        }


        public FRM_ORDER()
        {

            InitializeComponent();
            CreateDataTable();
            ResizeDGV();
            txtSalesMan.Text = Program.salesman;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dtOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtorderID.Text = order.Get_List_OrdersID().Rows[0][0].ToString();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void txtorderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void txtDescOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtorderID.Text = order.Get_List_OrdersID().Rows[0][0].ToString();


            btnNew.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();

            frm.ShowDialog();
            if (frm.dgvcustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("هذا العميل لا يتوفر علي صورة");
                this.txtCustmersID.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
                this.txtFirstName.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = frm.dgvcustomers.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = frm.dgvcustomers.CurrentRow.Cells[4].Value.ToString();
                pbox.Image = null;
                return;
            }
            this.txtCustmersID.Text = frm.dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            this.txtFirstName.Text = frm.dgvcustomers.CurrentRow.Cells[1].Value.ToString();
            this.txtLastName.Text = frm.dgvcustomers.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text = frm.dgvcustomers.CurrentRow.Cells[3].Value.ToString();
            this.txtEmail.Text = frm.dgvcustomers.CurrentRow.Cells[4].Value.ToString();
            byte[] custpicter = (byte[])frm.dgvcustomers.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(custpicter);

            pbox.Image = Image.FromStream(ms);


        }

        private void FRM_ORDER_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSumTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            clearBoxes();
            frm_products_list frm = new frm_products_list();


            frm.ShowDialog();
            txtIDproducts.Clear();
            txtNameprodect.Clear();
            txtprics.Clear();
            txtQty.Clear();
            txtIDproducts.Clear();


            txtIDproducts.Text = frm.dgvprodect.CurrentRow.Cells[0].Value.ToString();
            txtNameprodect.Text = frm.dgvprodect.CurrentRow.Cells[1].Value.ToString();
            txtprics.Text = frm.dgvprodect.CurrentRow.Cells[3].Value.ToString();
            txtQty.Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //منع الكتابة الحروف 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }



        }

        private void txtprics_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Decimalseparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            //منع الكتابة الحروف 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Decimalseparator)
            {
                e.Handled = true;
            }

        }

        private void txtprics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtprics.Text != string.Empty)
            {
                txtQty.Focus();


            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtDiscount.Focus();


            }
        }

        private void txtprics_KeyUp(object sender, KeyEventArgs e)
        {
            calculateamount();
            calculateaTmount();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            calculateamount();
            calculateaTmount();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //منع الكتابة الحروف 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateaTmount();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (order.Verifyqty(txtIDproducts.Text, Convert.ToInt32(txtQty.Text)).Rows.Count > 1)

                {
                    MessageBox.Show("الكمية المدخلة هذا المنتج غير متاحة ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;



                }
                for (int i = 0; i < dgdGridView.Rows.Count - 1; i++)
                {


                    if (dgdGridView.Rows[i].Cells[0].Value.ToString() == txtIDproducts.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;

                    }





                }

                DataRow r = DT.NewRow();
                r[0] = txtIDproducts.Text;
                r[1] = txtNameprodect.Text;
                r[2] = txtprics.Text;
                r[3] = txtQty.Text;
                r[4] = txtAmount.Text;
                r[5] = txtDiscount.Text;
                r[6] = txtTotalAmont.Text;
                DT.Rows.Add(r);
                dgdGridView.DataSource = DT;
                clearBoxes();

                txtSumTotal.Text =
                    (from DataGridViewRow row in dgdGridView.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();



                //double[] array = new double[dgdGridView.RowCount];
                //for (int i = 0; i < dgdGridView.RowCount; i++)
                //{
                //    array[i] = Convert.ToDouble(dgdGridView.CurrentRow.Cells[6].Value.ToString());
                //}
                //txtSumTotal.Text = array.Sum().ToString();



            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgdGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                txtIDproducts.Text = this.dgdGridView.CurrentRow.Cells[0].Value.ToString();
                txtNameprodect.Text = this.dgdGridView.CurrentRow.Cells[1].Value.ToString();
                txtprics.Text = this.dgdGridView.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = this.dgdGridView.CurrentRow.Cells[3].Value.ToString();
                txtAmount.Text = this.dgdGridView.CurrentRow.Cells[4].Value.ToString();
                txtDiscount.Text = this.dgdGridView.CurrentRow.Cells[5].Value.ToString();
                txtAmount.Text = this.dgdGridView.CurrentRow.Cells[6].Value.ToString();
                dgdGridView.Rows.RemoveAt(dgdGridView.CurrentRow.Index);
                txtQty.Focus();
            }
            catch
            {

                return;
            }
        }

        private void dgdGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotal.Text =
                    (from DataGridViewRow row in dgdGridView.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();


        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgdGridView_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgdGridView.Rows.RemoveAt(dgdGridView.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.Clear();
            dgdGridView.Refresh();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtCustmersID.Text == string.Empty)
            {
                MessageBox.Show("رجاء قم باختيار عميل اولا", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustmersID.Focus();
                return;
            }
            if (txtDescOrder.Text == string.Empty)
            {
                MessageBox.Show("رجاء قم بكتابة تفاصيل فاتورة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescOrder.Focus();
                return;
            }

            if (dgdGridView.Rows.Count < 1)
            {
                MessageBox.Show("رجاء قم بادخال  معلومات بیع", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescOrder.Focus();
                return;
            }


            else
            {



                //if (txtorderID.Text == string.Empty || txtCustmersID.Text == string.Empty || dgdGridView.Rows.Count < 1 || txtDescOrder.Text == string.Empty)
                //{
                //    MessageBox.Show("ينبغي تسجيل المهمة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}




                order.Add_Orders(Convert.ToInt32(txtorderID.Text), dtOrder.Value, Convert.ToInt32(txtCustmersID.Text), txtDescOrder.Text, txtSalesMan.Text);
                MessageBox.Show("تمت عملية الحفظ بنجاح ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CreateData();
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {


            Cursor.Current = Cursors.WaitCursor;

            int OrderID = Convert.ToInt32(order.Get_List_Orders_for_print().Rows[0][0]);

            Rpt.RTP_ORDER reoprt_order = new Rpt.RTP_ORDER();

            Rpt.FRM_RPT_prodects frm = new Rpt.FRM_RPT_prodects();

            reoprt_order.SetDataSource(order.GetOrderDETALIS(OrderID));

            frm.crystalReportViewer2.ReportSource = reoprt_order;

            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
            //int order_ID =Convert.ToInt32( order.Get_List_Orders_for_print().Rows[0][0]);
            //Rpt.RTP_ORDER report = new Rpt.RTP_ORDER();
            //Rpt.FRM_RPT_prodects frm = new Rpt.FRM_RPT_prodects();
            //report.SetDataSource(order.GetOrderDETALIS(order_ID));
            //frm.crystalReportViewer2.ReportSource = report;
            //frm.ShowDialog();
        }
    }

}
