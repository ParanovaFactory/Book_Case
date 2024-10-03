namespace Bookcase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RbUsed = new System.Windows.Forms.RadioButton();
            this.RbNew = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(104, 44);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(173, 26);
            this.TxtName.TabIndex = 2;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(104, 76);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(173, 26);
            this.TxtAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // TxtPage
            // 
            this.TxtPage.Location = new System.Drawing.Point(104, 108);
            this.TxtPage.Name = "TxtPage";
            this.TxtPage.Size = new System.Drawing.Size(173, 26);
            this.TxtPage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Page";
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "",
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Biyografi",
            "Çizgi Roman",
            "Deneme",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gençlik",
            "Gezi",
            "Hikaye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi - Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Mizah",
            "Öykü",
            "Polisiye",
            "Psikoloji",
            "Resimli Öykü",
            "Roman",
            "Sağlık",
            "Sanat - Tasarım",
            "Sanat- Müzik",
            "Sinema Tarihi",
            "Söyleşi",
            "Şiir",
            "Tarih",
            "Tiyatro",
            "Yemek Kitapları"});
            this.CmbType.Location = new System.Drawing.Point(104, 141);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(173, 28);
            this.CmbType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // RbUsed
            // 
            this.RbUsed.AutoSize = true;
            this.RbUsed.ForeColor = System.Drawing.Color.White;
            this.RbUsed.Location = new System.Drawing.Point(104, 175);
            this.RbUsed.Name = "RbUsed";
            this.RbUsed.Size = new System.Drawing.Size(65, 24);
            this.RbUsed.TabIndex = 9;
            this.RbUsed.TabStop = true;
            this.RbUsed.Text = "Used";
            this.RbUsed.UseVisualStyleBackColor = true;
            this.RbUsed.CheckedChanged += new System.EventHandler(this.RbUsed_CheckedChanged);
            // 
            // RbNew
            // 
            this.RbNew.AutoSize = true;
            this.RbNew.ForeColor = System.Drawing.Color.White;
            this.RbNew.Location = new System.Drawing.Point(219, 175);
            this.RbNew.Name = "RbNew";
            this.RbNew.Size = new System.Drawing.Size(58, 24);
            this.RbNew.TabIndex = 10;
            this.RbNew.TabStop = true;
            this.RbNew.Text = "New";
            this.RbNew.UseVisualStyleBackColor = true;
            this.RbNew.CheckedChanged += new System.EventHandler(this.RbNew_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(104, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(173, 26);
            this.TxtId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Book Id";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(309, 12);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(149, 37);
            this.BtnList.TabIndex = 14;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(309, 55);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(149, 37);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(309, 98);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(149, 37);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelate
            // 
            this.BtnDelate.Location = new System.Drawing.Point(309, 141);
            this.BtnDelate.Name = "BtnDelate";
            this.BtnDelate.Size = new System.Drawing.Size(149, 37);
            this.BtnDelate.TabIndex = 17;
            this.BtnDelate.Text = "Delate";
            this.BtnDelate.UseVisualStyleBackColor = true;
            this.BtnDelate.Click += new System.EventHandler(this.BtnDelate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(18, 212);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(56, 20);
            this.LblStatus.TabIndex = 19;
            this.LblStatus.Text = "Status";
            this.LblStatus.Visible = false;
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(585, 203);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(173, 26);
            this.TxtBookName.TabIndex = 21;
            this.TxtBookName.TextChanged += new System.EventHandler(this.TxtBookName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(487, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Book Name";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(310, 184);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(149, 37);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(770, 476);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtBookName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDelate);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RbNew);
            this.Controls.Add(this.RbUsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.TxtPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbUsed;
        private System.Windows.Forms.RadioButton RbNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSearch;
    }
}

