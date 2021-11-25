using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodects_mangement.PL
{
    public partial class ADD_Prodect : Form
    {
        public string state = "add";



        BL.cls_prodect prd = new BL.cls_prodect();

        public ADD_Prodect()
        {
            InitializeComponent();

            CmbCategories.DataSource = prd.Get_ALL_Categres();
            CmbCategories.DisplayMember = "DESCRIPTION_CAT";
            CmbCategories.ValueMember = "ID_CAT";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (state == "add")
         {



         MemoryStream ms = new MemoryStream();
         Pbox.Image.Save(ms, Pbox.Image.RawFormat);
           byte[] byteimage = ms.ToArray();
          prd.ADD_Prodect(Convert.ToInt32(CmbCategories.SelectedIndex), textDes.Text
                , textRef.Text, Convert.ToInt32(textQty.Text), textPrics.Text, byteimage);
              MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
          else
           {
              MemoryStream ms = new MemoryStream();
               Pbox.Image.Save(ms, Pbox.Image.RawFormat);
               byte[] byteimage = ms.ToArray();
               prd.UPDATA_prodect(Convert.ToInt32(CmbCategories.SelectedIndex), textDes.Text
                  , textRef.Text, Convert.ToInt32(textQty.Text), textPrics.Text, byteimage);
               MessageBox.Show("تمت التعديل  بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

               

           }

           Frm_PRODUCT.getmain.dataGridView1.DataSource = prd.Get_aLL_prodects();

      }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofe = new OpenFileDialog();
            ofe.Filter = "ملفات الصور |*.JPG; *.PNG; * GIF; *.BMP";
            if (ofe.ShowDialog()==DialogResult.OK)
            {
                Pbox.Image = Image.FromFile(ofe.FileName);
            }
        }

        private void textRef_Validated(object sender, EventArgs e)
        {

            if (state == "add")
            {



                DataTable DT = new DataTable();
                DT = prd.verifyproductID(textRef.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textRef.Focus();
                    textRef.SelectionStart = 0;
                    textRef.SelectionLength = textRef.TextLength;
                }
            }
        }

        private void textRef_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_clos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ADD_Prodect_Load(object sender, EventArgs e)
        {

        }

        private void textPrics_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (state == "add")
            {



                MemoryStream ms = new MemoryStream();
                Pbox.Image.Save(ms, Pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                prd.ADD_Prodect(Convert.ToInt32(CmbCategories.SelectedIndex), textDes.Text
                    , textRef.Text, Convert.ToInt32(textQty.Text), textPrics.Text, byteimage);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Pbox.Image.Save(ms, Pbox.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                prd.UPDATA_prodect(Convert.ToInt32(CmbCategories.SelectedIndex), textDes.Text
                    , textRef.Text, Convert.ToInt32(textQty.Text), textPrics.Text, byteimage);
                MessageBox.Show("تمت التعديل  بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            Frm_PRODUCT.getmain.dataGridView1.DataSource = prd.Get_aLL_prodects();

        }

        private void Pbox_Click(object sender, EventArgs e)
        {

        }
    }
}

