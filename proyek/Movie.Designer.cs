
namespace proyek
{
    partial class Movie
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
            this.label14 = new System.Windows.Forms.Label();
            this.detik = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnBuy = new ePOSOne.btnProduct.Button_WOC();
            this.cbfilm = new System.Windows.Forms.ComboBox();
            this.tbfilm = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.cbJumlah = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 293);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "detik";
            // 
            // detik
            // 
            this.detik.Location = new System.Drawing.Point(218, 290);
            this.detik.Margin = new System.Windows.Forms.Padding(2);
            this.detik.Name = "detik";
            this.detik.Size = new System.Drawing.Size(18, 20);
            this.detik.TabIndex = 67;
            this.detik.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 292);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "menit";
            // 
            // menit
            // 
            this.menit.Location = new System.Drawing.Point(161, 289);
            this.menit.Margin = new System.Windows.Forms.Padding(2);
            this.menit.Name = "menit";
            this.menit.Size = new System.Drawing.Size(18, 20);
            this.menit.TabIndex = 65;
            this.menit.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 293);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "jam";
            // 
            // jam
            // 
            this.jam.Location = new System.Drawing.Point(118, 289);
            this.jam.Margin = new System.Windows.Forms.Padding(2);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(18, 20);
            this.jam.TabIndex = 63;
            this.jam.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Durasi Movie : ";
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.ButtonColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnClear.Location = new System.Drawing.Point(142, 387);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnClear.Size = new System.Drawing.Size(110, 33);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuy.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnBuy.Location = new System.Drawing.Point(23, 387);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnBuy.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnBuy.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBuy.Size = new System.Drawing.Size(110, 33);
            this.btnBuy.TabIndex = 55;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextColor = System.Drawing.Color.White;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbfilm
            // 
            this.cbfilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilm.Enabled = false;
            this.cbfilm.FormattingEnabled = true;
            this.cbfilm.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "Comedy",
            "Drama",
            "Science Fiction ",
            "Thriller",
            "Romance"});
            this.cbfilm.Location = new System.Drawing.Point(118, 312);
            this.cbfilm.Margin = new System.Windows.Forms.Padding(2);
            this.cbfilm.Name = "cbfilm";
            this.cbfilm.Size = new System.Drawing.Size(151, 21);
            this.cbfilm.TabIndex = 54;
            // 
            // tbfilm
            // 
            this.tbfilm.Location = new System.Drawing.Point(119, 264);
            this.tbfilm.Margin = new System.Windows.Forms.Padding(2);
            this.tbfilm.Name = "tbfilm";
            this.tbfilm.Size = new System.Drawing.Size(150, 20);
            this.tbfilm.TabIndex = 53;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(119, 243);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(150, 20);
            this.tbID.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "genre film :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Judul Film :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "ID Film :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(303, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Movie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 193);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnExit.Location = new System.Drawing.Point(555, 387);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnExit.Size = new System.Drawing.Size(56, 33);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Jumlah:";
            // 
            // cbJumlah
            // 
            this.cbJumlah.AllowDrop = true;
            this.cbJumlah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJumlah.FormattingEnabled = true;
            this.cbJumlah.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbJumlah.Location = new System.Drawing.Point(118, 340);
            this.cbJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.cbJumlah.Name = "cbJumlah";
            this.cbJumlah.Size = new System.Drawing.Size(151, 21);
            this.cbJumlah.TabIndex = 70;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(639, 430);
            this.Controls.Add(this.cbJumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.detik);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.cbfilm);
            this.Controls.Add(this.tbfilm);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Movie_FormClosed);
            this.Load += new System.EventHandler(this.Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox detik;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox menit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox jam;
        private System.Windows.Forms.Label label8;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnBuy;
        private System.Windows.Forms.ComboBox cbfilm;
        private System.Windows.Forms.TextBox tbfilm;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbJumlah;
    }
}