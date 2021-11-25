using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace prodects_mangement.PL
{
    public partial class frm_Customers : Form
    {
        BL.Cls_cusromer cust = new BL.Cls_cusromer();
        int ID,position;
        public frm_Customers()
        {
            InitializeComponent();

            this.dglist.DataSource = cust.GET_Allcustomer();
            dglist.Columns[0].Visible = false;
            dglist.Columns[5].Visible = false;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void btn_last_Click(object sender, EventArgs e)
        {
            position = cust.GET_Allcustomer().Rows.Count - 1;
            Navigete(position );
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images File |*.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            txt_firname.Clear();
            txt_LasName.Clear();

            text_phon.Clear();
            text_email.Clear();
            txt_firname.Focus();
            pbox.Image = null;
            btnAdd.Enabled = true;
            bt_new.Enabled = false;
        }










        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                {
                    byte[] Picture;
                    if (pbox.Image == null)
                    {
                        Picture = new byte[0];
                        cust.ADD_customer(txt_firname.Text, txt_LasName.Text, text_phon.Text, text_email.Text, Picture, "without_image");

                        MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dglist.DataSource = cust.GET_Allcustomer();

                    }
                    else
                    {

                        MemoryStream ms = new MemoryStream();
                        pbox.Image.Save(ms, pbox.Image.RawFormat);
                        Picture = ms.ToArray();
                        cust.ADD_customer(txt_firname.Text, txt_LasName.Text, text_phon.Text, text_email.Text, Picture, "with_image");
                        MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dglist.DataSource = cust.GET_Allcustomer();

                    }
                }
            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                bt_new.Enabled = true;
            }

        }

        private void txt_LasName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_firname_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txt_LasName.Focus();
            }
        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pbox.Image = null;
                ID = Convert.ToInt32(dglist.CurrentRow.Cells[0].Value);
                this.txt_firname.Text = dglist.CurrentRow.Cells[1].Value.ToString();
                this.txt_LasName.Text = dglist.CurrentRow.Cells[2].Value.ToString();
                this.text_phon.Text = dglist.CurrentRow.Cells[3].Value.ToString();
                this.text_email.Text = dglist.CurrentRow.Cells[4].Value.ToString();


                byte[] picters = (byte[])dglist.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picters);
                pbox.Image = Image.FromStream(ms);

            }


            catch
            {

                return;
            }



        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("العميل المراد  تعديله غير موجود");
                    return;
                }

                {
                    byte[] Picture;
                    if (pbox.Image == null)
                    {
                        Picture = new byte[0];
                        cust.Edit_customer(txt_firname.Text, txt_LasName.Text, text_phon.Text, text_email.Text, Picture, "without_image", ID);

                        MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dglist.DataSource = cust.GET_Allcustomer();

                    }
                    else
                    {

                        MemoryStream ms = new MemoryStream();
                        pbox.Image.Save(ms, pbox.Image.RawFormat);
                        Picture = ms.ToArray();
                        cust.Edit_customer(txt_firname.Text, txt_LasName.Text, text_phon.Text, text_email.Text, Picture, "with_image", ID);
                        MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.dglist.DataSource = cust.GET_Allcustomer();

                    }
                }
            }
            catch
            {
                return;
            }

        }

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("العميل المراد  حذفه غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد فعلا الحذف العميل ؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                cust.Delete_cutomer(ID);
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dglist.DataSource = cust.GET_Allcustomer();
             


            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dglist.DataSource = cust.Search_customer(textserch.Text);
        }

        private void bte_shrch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape )
            {
                button1_Click(sender, e);
            }
        }
        void Navigete(int index)
        {
            try
            {

           
               pbox.Image = null;
               DataTable DT = cust.GET_Allcustomer();
                ID=Convert.ToInt32(DT.Rows[index][0])  ;  
               txt_firname.Text = DT.Rows[index][1].ToString();
               txt_LasName.Text = DT.Rows[index][2].ToString();
                text_phon.Text = DT.Rows[index][3].ToString();
                text_email.Text = DT.Rows[index][4].ToString();
                byte[] picters = (byte[])DT.Rows[index][5];
                MemoryStream ms = new MemoryStream(picters);
                pbox.Image = Image.FromStream(ms);


            }
            catch 
            {

                return;
            }


        }

        private void btn_previoes_Click(object sender, EventArgs e)
        {
            if (position==0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            position -= 1;
            Navigete(position);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (position == cust.GET_Allcustomer().Rows.Count - 1) ;
            {
                MessageBox.Show("هذا اخر عنصر");
                return;
            }
            position += 1;
            Navigete(position);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            Navigete(0);
        }
    }
}

 




