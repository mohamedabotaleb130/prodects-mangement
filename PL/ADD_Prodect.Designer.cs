
namespace prodects_mangement.PL
{
    partial class ADD_Prodect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_Prodect));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_clos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pbox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrics = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::prodects_mangement.Properties.Resources.XHVExK2;
            this.groupBox1.Controls.Add(this.bt_OK);
            this.groupBox1.Controls.Add(this.bt_clos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Pbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPrics);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textRef);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(689, 747);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات المنتج";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_OK
            // 
            this.bt_OK.BackColor = System.Drawing.Color.DimGray;
            this.bt_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_OK.ForeColor = System.Drawing.Color.White;
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.ImageKey = "9351b548.png";
            this.bt_OK.ImageList = this.imageList1;
            this.bt_OK.Location = new System.Drawing.Point(181, 650);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(4);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(139, 70);
            this.bt_OK.TabIndex = 17;
            this.bt_OK.Text = "موافق";
            this.bt_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_OK.UseVisualStyleBackColor = false;
            this.bt_OK.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel.png");
            this.imageList1.Images.SetKeyName(1, "Male-user-add-icon.png");
            this.imageList1.Images.SetKeyName(2, "9351b548.png");
            // 
            // bt_clos
            // 
            this.bt_clos.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_clos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_clos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_clos.ForeColor = System.Drawing.Color.White;
            this.bt_clos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clos.ImageKey = "cancel.png";
            this.bt_clos.ImageList = this.imageList1;
            this.bt_clos.Location = new System.Drawing.Point(374, 650);
            this.bt_clos.Margin = new System.Windows.Forms.Padding(4);
            this.bt_clos.Name = "bt_clos";
            this.bt_clos.Size = new System.Drawing.Size(141, 70);
            this.bt_clos.TabIndex = 16;
            this.bt_clos.Text = "الخروج";
            this.bt_clos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_clos.UseVisualStyleBackColor = false;
            this.bt_clos.Click += new System.EventHandler(this.bt_clos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(155, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pbox
            // 
            this.Pbox.BackColor = System.Drawing.Color.Transparent;
            this.Pbox.Image = global::prodects_mangement.Properties.Resources.no_image;
            this.Pbox.Location = new System.Drawing.Point(153, 409);
            this.Pbox.Margin = new System.Windows.Forms.Padding(4);
            this.Pbox.Name = "Pbox";
            this.Pbox.Size = new System.Drawing.Size(381, 128);
            this.Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbox.TabIndex = 13;
            this.Pbox.TabStop = false;
            this.Pbox.Click += new System.EventHandler(this.Pbox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(552, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "صورة المنتج";
            // 
            // textPrics
            // 
            this.textPrics.Location = new System.Drawing.Point(153, 345);
            this.textPrics.Margin = new System.Windows.Forms.Padding(4);
            this.textPrics.Multiline = true;
            this.textPrics.Name = "textPrics";
            this.textPrics.Size = new System.Drawing.Size(380, 30);
            this.textPrics.TabIndex = 3;
            this.textPrics.TextChanged += new System.EventHandler(this.textPrics_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(559, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "الثمن المنتج";
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(153, 278);
            this.textQty.Margin = new System.Windows.Forms.Padding(4);
            this.textQty.Multiline = true;
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(380, 30);
            this.textQty.TabIndex = 2;
            this.textQty.TextChanged += new System.EventHandler(this.textQty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(559, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "الكمية المخزن";
            // 
            // textDes
            // 
            this.textDes.Location = new System.Drawing.Point(153, 176);
            this.textDes.Margin = new System.Windows.Forms.Padding(4);
            this.textDes.Multiline = true;
            this.textDes.Name = "textDes";
            this.textDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDes.Size = new System.Drawing.Size(380, 66);
            this.textDes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(552, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج";
            // 
            // textRef
            // 
            this.textRef.Location = new System.Drawing.Point(153, 116);
            this.textRef.Margin = new System.Windows.Forms.Padding(4);
            this.textRef.Multiline = true;
            this.textRef.Name = "textRef";
            this.textRef.Size = new System.Drawing.Size(380, 30);
            this.textRef.TabIndex = 0;
            this.textRef.TextChanged += new System.EventHandler(this.textRef_TextChanged);
            this.textRef.Validated += new System.EventHandler(this.textRef_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(552, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "معرفة المنتج";
            // 
            // CmbCategories
            // 
            this.CmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategories.FormattingEnabled = true;
            this.CmbCategories.Location = new System.Drawing.Point(153, 59);
            this.CmbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.Size = new System.Drawing.Size(380, 32);
            this.CmbCategories.TabIndex = 0;
            this.CmbCategories.SelectedIndexChanged += new System.EventHandler(this.CmbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج";
            // 
            // ADD_Prodect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::prodects_mangement.Properties.Resources.XHVExK1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(687, 750);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "ADD_Prodect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            this.Load += new System.EventHandler(this.ADD_Prodect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_clos;
        public System.Windows.Forms.ComboBox CmbCategories;
        public System.Windows.Forms.TextBox textDes;
        public System.Windows.Forms.TextBox textRef;
        public System.Windows.Forms.TextBox textQty;
        public System.Windows.Forms.PictureBox Pbox;
        public System.Windows.Forms.TextBox textPrics;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button bt_OK;
    }
}