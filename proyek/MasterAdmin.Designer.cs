namespace proyek
{
    partial class MasterAdmin
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
            this.btnExit = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbfilm = new System.Windows.Forms.ComboBox();
            this.tbfilm = new System.Windows.Forms.TextBox();
            this.tbIDfilm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsert = new ePOSOne.btnProduct.Button_WOC();
            this.btnUpdate = new ePOSOne.btnProduct.Button_WOC();
            this.btnDelete = new ePOSOne.btnProduct.Button_WOC();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnBeli = new ePOSOne.btnProduct.Button_WOC();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.detik = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.ButtonColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(722, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 237);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // cbfilm
            // 
            this.cbfilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilm.FormattingEnabled = true;
            this.cbfilm.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "Comedy",
            "Drama",
            "Science Fiction ",
            "Thriller",
            "Romance"});
            this.cbfilm.Location = new System.Drawing.Point(140, 388);
            this.cbfilm.Name = "cbfilm";
            this.cbfilm.Size = new System.Drawing.Size(121, 24);
            this.cbfilm.TabIndex = 24;
            // 
            // tbfilm
            // 
            this.tbfilm.Location = new System.Drawing.Point(141, 329);
            this.tbfilm.Name = "tbfilm";
            this.tbfilm.Size = new System.Drawing.Size(101, 22);
            this.tbfilm.TabIndex = 21;
            // 
            // tbIDfilm
            // 
            this.tbIDfilm.Location = new System.Drawing.Point(141, 303);
            this.tbIDfilm.Name = "tbIDfilm";
            this.tbIDfilm.ReadOnly = true;
            this.tbIDfilm.Size = new System.Drawing.Size(101, 22);
            this.tbIDfilm.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "genre film :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Judul Film :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Film :";
            // 
            // btnInsert
            // 
            this.btnInsert.BorderColor = System.Drawing.Color.Silver;
            this.btnInsert.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(39, 480);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnInsert.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnInsert.Size = new System.Drawing.Size(146, 41);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.ButtonColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(202, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnUpdate.Size = new System.Drawing.Size(146, 41);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.ButtonColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(367, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDelete.Size = new System.Drawing.Size(146, 41);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.ButtonColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(529, 479);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnClear.Size = new System.Drawing.Size(146, 41);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.BorderColor = System.Drawing.Color.Silver;
            this.btnBeli.ButtonColor = System.Drawing.Color.Goldenrod;
            this.btnBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.Location = new System.Drawing.Point(651, 304);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnBeli.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnBeli.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBeli.Size = new System.Drawing.Size(146, 41);
            this.btnBeli.TabIndex = 32;
            this.btnBeli.Text = "Furniture";
            this.btnBeli.TextColor = System.Drawing.Color.White;
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "status film :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(134, 420);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 20);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "playing now";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 420);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 20);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "coming soon";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "detik";
            // 
            // detik
            // 
            this.detik.Location = new System.Drawing.Point(273, 361);
            this.detik.Name = "detik";
            this.detik.Size = new System.Drawing.Size(22, 22);
            this.detik.TabIndex = 44;
            this.detik.Text = "0";
            this.detik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detik_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "menit";
            // 
            // menit
            // 
            this.menit.Location = new System.Drawing.Point(197, 360);
            this.menit.Name = "menit";
            this.menit.Size = new System.Drawing.Size(22, 22);
            this.menit.TabIndex = 42;
            this.menit.Text = "0";
            this.menit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menit_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "jam";
            // 
            // jam
            // 
            this.jam.Location = new System.Drawing.Point(140, 360);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(22, 22);
            this.jam.TabIndex = 40;
            this.jam.Text = "0";
            this.jam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jam_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Durasi Movie : ";
            // 
            // MasterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 533);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.detik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbfilm);
            this.Controls.Add(this.tbfilm);
            this.Controls.Add(this.tbIDfilm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "MasterAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MasterAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MasterAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbfilm;
        private System.Windows.Forms.TextBox tbfilm;
        private System.Windows.Forms.TextBox tbIDfilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private ePOSOne.btnProduct.Button_WOC btnInsert;
        private ePOSOne.btnProduct.Button_WOC btnUpdate;
        private ePOSOne.btnProduct.Button_WOC btnDelete;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnBeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox detik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox menit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox jam;
        private System.Windows.Forms.Label label8;
    }
}