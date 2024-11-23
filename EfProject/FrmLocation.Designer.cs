namespace EfProject
{
    partial class FrmLocation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIdEdit = new System.Windows.Forms.TextBox();
            this.tbxLocationId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbxRehber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 336);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetById.Location = new System.Drawing.Point(112, 367);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(134, 26);
            this.btnGetById.TabIndex = 19;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(112, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 26);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(112, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 26);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(112, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 26);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.IndianRed;
            this.btnList.Location = new System.Drawing.Point(112, 239);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(134, 26);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(112, 108);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(134, 20);
            this.tbxCountry.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ülke";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(112, 82);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(134, 20);
            this.tbxCity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şehir";
            // 
            // tbxIdEdit
            // 
            this.tbxIdEdit.Location = new System.Drawing.Point(181, 56);
            this.tbxIdEdit.Name = "tbxIdEdit";
            this.tbxIdEdit.Size = new System.Drawing.Size(65, 20);
            this.tbxIdEdit.TabIndex = 20;
            // 
            // tbxLocationId
            // 
            this.tbxLocationId.Location = new System.Drawing.Point(112, 56);
            this.tbxLocationId.Name = "tbxLocationId";
            this.tbxLocationId.ReadOnly = true;
            this.tbxLocationId.Size = new System.Drawing.Size(65, 20);
            this.tbxLocationId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kapasite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(112, 160);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(134, 20);
            this.tbxPrice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gün Gece";
            // 
            // tbxDay
            // 
            this.tbxDay.Location = new System.Drawing.Point(112, 186);
            this.tbxDay.Name = "tbxDay";
            this.tbxDay.Size = new System.Drawing.Size(134, 20);
            this.tbxDay.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rehber";
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(112, 135);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(134, 20);
            this.numCapacity.TabIndex = 23;
            // 
            // cbxRehber
            // 
            this.cbxRehber.FormattingEnabled = true;
            this.cbxRehber.Location = new System.Drawing.Point(112, 212);
            this.cbxRehber.Name = "cbxRehber";
            this.cbxRehber.Size = new System.Drawing.Size(134, 21);
            this.cbxRehber.TabIndex = 24;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.cbxRehber);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIdEdit);
            this.Controls.Add(this.tbxLocationId);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIdEdit;
        private System.Windows.Forms.TextBox tbxLocationId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.ComboBox cbxRehber;
    }
}