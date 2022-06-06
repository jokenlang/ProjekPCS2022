
namespace proyek
{
    partial class Beverage
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
            this.cbJumlah = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfilm = new System.Windows.Forms.TextBox();
            this.tbIDfilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnInsert = new ePOSOne.btnProduct.Button_WOC();
            this.btnExit = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.cbJumlah.Location = new System.Drawing.Point(107, 293);
            this.cbJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.cbJumlah.Name = "cbJumlah";
            this.cbJumlah.Size = new System.Drawing.Size(92, 21);
            this.cbJumlah.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Jumlah:";
            // 
            // tbfilm
            // 
            this.tbfilm.Location = new System.Drawing.Point(108, 269);
            this.tbfilm.Margin = new System.Windows.Forms.Padding(2);
            this.tbfilm.Name = "tbfilm";
            this.tbfilm.Size = new System.Drawing.Size(91, 20);
            this.tbfilm.TabIndex = 78;
            // 
            // tbIDfilm
            // 
            this.tbIDfilm.Location = new System.Drawing.Point(108, 248);
            this.tbIDfilm.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDfilm.Name = "tbIDfilm";
            this.tbIDfilm.ReadOnly = true;
            this.tbIDfilm.Size = new System.Drawing.Size(91, 20);
            this.tbIDfilm.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nama Beverage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "ID Beverage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "Beverage";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 193);
            this.dataGridView1.TabIndex = 72;
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.ButtonColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnClear.Location = new System.Drawing.Point(131, 392);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnClear.Size = new System.Drawing.Size(110, 33);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BorderColor = System.Drawing.Color.Transparent;
            this.btnInsert.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnInsert.Location = new System.Drawing.Point(12, 392);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnInsert.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnInsert.Size = new System.Drawing.Size(110, 33);
            this.btnInsert.TabIndex = 80;
            this.btnInsert.Text = "Buy";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.ButtonColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.btnExit.Location = new System.Drawing.Point(544, 392);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnExit.Size = new System.Drawing.Size(56, 33);
            this.btnExit.TabIndex = 71;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(622, 431);
            this.Controls.Add(this.cbJumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbfilm);
            this.Controls.Add(this.tbIDfilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "Beverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beverage";
            this.Load += new System.EventHandler(this.Beverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJumlah;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnInsert;
        private System.Windows.Forms.TextBox tbfilm;
        private System.Windows.Forms.TextBox tbIDfilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC btnExit;
    }
}