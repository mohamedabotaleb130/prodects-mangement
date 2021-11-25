
namespace prodects_mangement.PL
{
    partial class frm_Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IPlpotion = new System.Windows.Forms.Label();
            this.txt_firname = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_phon = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txt_LasName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dglist = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textserch = new System.Windows.Forms.TextBox();
            this.bte_shrch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_edite = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previoes = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IPlpotion);
            this.groupBox1.Controls.Add(this.txt_firname);
            this.groupBox1.Controls.Add(this.text_email);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_phon);
            this.groupBox1.Controls.Add(this.btn_last);
            this.groupBox1.Controls.Add(this.btn_next);
            this.groupBox1.Controls.Add(this.btn_previoes);
            this.groupBox1.Controls.Add(this.txt_LasName);
            this.groupBox1.Controls.Add(this.btn_first);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بیانات العمیل";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // IPlpotion
            // 
            this.IPlpotion.AutoSize = true;
            this.IPlpotion.Location = new System.Drawing.Point(396, 274);
            this.IPlpotion.Name = "IPlpotion";
            this.IPlpotion.Size = new System.Drawing.Size(39, 24);
            this.IPlpotion.TabIndex = 10;
            this.IPlpotion.Text = "7/6";
            // 
            // txt_firname
            // 
            this.txt_firname.Location = new System.Drawing.Point(219, 31);
            this.txt_firname.Multiline = true;
            this.txt_firname.Name = "txt_firname";
            this.txt_firname.Size = new System.Drawing.Size(309, 39);
            this.txt_firname.TabIndex = 1;
            this.txt_firname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_firname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_firname_KeyDown);
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(219, 202);
            this.text_email.Multiline = true;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(309, 39);
            this.text_email.TabIndex = 4;
            this.text_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(537, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاسم الشخصي";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_phon
            // 
            this.text_phon.Location = new System.Drawing.Point(219, 149);
            this.text_phon.Multiline = true;
            this.text_phon.Name = "text_phon";
            this.text_phon.Size = new System.Drawing.Size(309, 39);
            this.text_phon.TabIndex = 3;
            this.text_phon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "130-1304453_computer-icons-check-mark-royalty-free-true-false.png");
            this.imageList2.Images.SetKeyName(1, "408-4088745_red-close-icon-png.png");
            this.imageList2.Images.SetKeyName(2, "9351b548.png");
            this.imageList2.Images.SetKeyName(3, "34471857-printer-icon-green-button-print-sign.jpg");
            this.imageList2.Images.SetKeyName(4, "84069071-arrows-in-circular-motion-set-of-colored-arrow-vector-illustration-isola" +
        "ted-on-white-background.jpg");
            this.imageList2.Images.SetKeyName(5, "88883644-refresh-icon-isolated-on-premium-green-round-button-abstract-illustratio" +
        "n.jpg");
            this.imageList2.Images.SetKeyName(6, "add-icon-png-1.png");
            this.imageList2.Images.SetKeyName(7, "cancel.png");
            this.imageList2.Images.SetKeyName(8, "Custom-Icon-Design-Flatastic-9-Save.ico");
            this.imageList2.Images.SetKeyName(9, "download.jpg");
            this.imageList2.Images.SetKeyName(10, "images (1).png");
            this.imageList2.Images.SetKeyName(11, "images (2).png");
            this.imageList2.Images.SetKeyName(12, "images (3).png");
            this.imageList2.Images.SetKeyName(13, "images (4).png");
            this.imageList2.Images.SetKeyName(14, "images.jpg");
            this.imageList2.Images.SetKeyName(15, "images.png");
            this.imageList2.Images.SetKeyName(16, "kisspng-paper-printing-computer-icons-print-5abd8ef67d1835.5215254315223723425124" +
        ".jpg");
            this.imageList2.Images.SetKeyName(17, "Male-user-add-icon.png");
            this.imageList2.Images.SetKeyName(18, "navigate_right.png");
            this.imageList2.Images.SetKeyName(19, "navigate-left-icon.png");
            this.imageList2.Images.SetKeyName(20, "png-clipart-pdf-computer-icons-adobe-acrobat-algemene-voorwaarden-text-logo.png");
            this.imageList2.Images.SetKeyName(21, "000.png");
            this.imageList2.Images.SetKeyName(22, "212.png");
            this.imageList2.Images.SetKeyName(23, "122932.png");
            this.imageList2.Images.SetKeyName(24, "search-flat.png");
            // 
            // txt_LasName
            // 
            this.txt_LasName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LasName.Location = new System.Drawing.Point(219, 91);
            this.txt_LasName.Multiline = true;
            this.txt_LasName.Name = "txt_LasName";
            this.txt_LasName.Size = new System.Drawing.Size(309, 39);
            this.txt_LasName.TabIndex = 2;
            this.txt_LasName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txt_LasName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LasName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(550, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "الااسم العائلي";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(568, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "رقم الهاتف";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(558, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "بريد إلكتروني";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_edite);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.bt_new);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bte_shrch);
            this.groupBox3.Controls.Add(this.dglist);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textserch);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(717, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 461);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحة جميع العملاء";
            // 
            // dglist
            // 
            this.dglist.AllowUserToAddRows = false;
            this.dglist.AllowUserToDeleteRows = false;
            this.dglist.AllowUserToOrderColumns = true;
            this.dglist.AllowUserToResizeColumns = false;
            this.dglist.AllowUserToResizeRows = false;
            this.dglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglist.Location = new System.Drawing.Point(8, 81);
            this.dglist.MultiSelect = false;
            this.dglist.Name = "dglist";
            this.dglist.ReadOnly = true;
            this.dglist.RowHeadersWidth = 51;
            this.dglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglist.Size = new System.Drawing.Size(615, 371);
            this.dglist.TabIndex = 11;
            this.dglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglist_CellContentClick);
            this.dglist.DoubleClick += new System.EventHandler(this.dglist_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(537, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "ابحث هنا";
            // 
            // textserch
            // 
            this.textserch.Location = new System.Drawing.Point(147, 31);
            this.textserch.Multiline = true;
            this.textserch.Name = "textserch";
            this.textserch.Size = new System.Drawing.Size(368, 38);
            this.textserch.TabIndex = 10;
            this.textserch.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // bte_shrch
            // 
            this.bte_shrch.BackColor = System.Drawing.Color.MistyRose;
            this.bte_shrch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bte_shrch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bte_shrch.ImageIndex = 23;
            this.bte_shrch.ImageList = this.imageList2;
            this.bte_shrch.Location = new System.Drawing.Point(25, 32);
            this.bte_shrch.Name = "bte_shrch";
            this.bte_shrch.Size = new System.Drawing.Size(108, 41);
            this.bte_shrch.TabIndex = 11;
            this.bte_shrch.Text = "موافق";
            this.bte_shrch.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bte_shrch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bte_shrch.UseVisualStyleBackColor = false;
            this.bte_shrch.Click += new System.EventHandler(this.button1_Click);
            this.bte_shrch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bte_shrch_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 14;
            this.btnAdd.ImageList = this.imageList2;
            this.btnAdd.Location = new System.Drawing.Point(396, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.ImageKey = "images (1).png";
            this.btn_close.ImageList = this.imageList2;
            this.btn_close.Location = new System.Drawing.Point(27, 38);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 45);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "الخروج";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_edite
            // 
            this.btn_edite.BackColor = System.Drawing.Color.Khaki;
            this.btn_edite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edite.ImageKey = "84069071-arrows-in-circular-motion-set-of-colored-arrow-vector-illustration-isola" +
    "ted-on-white-background.jpg";
            this.btn_edite.ImageList = this.imageList2;
            this.btn_edite.Location = new System.Drawing.Point(155, 38);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.Size = new System.Drawing.Size(108, 41);
            this.btn_edite.TabIndex = 8;
            this.btn_edite.Text = "تعديل ";
            this.btn_edite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edite.UseVisualStyleBackColor = false;
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightPink;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.ImageKey = "cancel.png";
            this.btn_delete.ImageList = this.imageList2;
            this.btn_delete.Location = new System.Drawing.Point(270, 38);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 41);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_new.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_new.ImageIndex = 6;
            this.bt_new.ImageList = this.imageList2;
            this.bt_new.Location = new System.Drawing.Point(517, 38);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(113, 41);
            this.bt_new.TabIndex = 5;
            this.bt_new.Text = "جديد";
            this.bt_new.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // pbox
            // 
            this.pbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox.Image = global::prodects_mangement.Properties.Resources.avatar_hombre_comentarios2;
            this.pbox.Location = new System.Drawing.Point(6, 16);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(183, 304);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 8;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_last.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_last.ImageKey = "images (4).png";
            this.btn_last.ImageList = this.imageList2;
            this.btn_last.Location = new System.Drawing.Point(219, 267);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(72, 36);
            this.btn_last.TabIndex = 12;
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.ImageKey = "navigate-left-icon.png";
            this.btn_next.ImageList = this.imageList2;
            this.btn_next.Location = new System.Drawing.Point(306, 267);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(72, 36);
            this.btn_next.TabIndex = 11;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previoes
            // 
            this.btn_previoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_previoes.ImageKey = "212.png";
            this.btn_previoes.ImageList = this.imageList2;
            this.btn_previoes.Location = new System.Drawing.Point(480, 271);
            this.btn_previoes.Name = "btn_previoes";
            this.btn_previoes.Size = new System.Drawing.Size(72, 37);
            this.btn_previoes.TabIndex = 10;
            this.btn_previoes.UseVisualStyleBackColor = false;
            this.btn_previoes.Click += new System.EventHandler(this.btn_previoes_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_first.ImageKey = "000.png";
            this.btn_first.ImageList = this.imageList2;
            this.btn_first.Location = new System.Drawing.Point(558, 271);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(72, 37);
            this.btn_first.TabIndex = 9;
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // frm_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة العملاء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LasName;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previoes;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox text_phon;
        private System.Windows.Forms.TextBox txt_firname;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label IPlpotion;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_edite;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bte_shrch;
        private System.Windows.Forms.DataGridView dglist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textserch;
        private System.Windows.Forms.Button btnAdd;
    }
}