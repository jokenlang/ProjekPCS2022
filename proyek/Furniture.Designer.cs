namespace proyek
{
    partial class Furniture
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
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnDelete = new ePOSOne.btnProduct.Button_WOC();
            this.btnUpdate = new ePOSOne.btnProduct.Button_WOC();
            this.btnInsert = new ePOSOne.btnProduct.Button_WOC();
            this.btnBack = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.ButtonColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(434, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnClear.Size = new System.Drawing.Size(115, 41);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.ButtonColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(292, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDelete.Size = new System.Drawing.Size(127, 41);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.ButtonColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(149, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnUpdate.Size = new System.Drawing.Size(123, 41);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BorderColor = System.Drawing.Color.Silver;
            this.btnInsert.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(8, 398);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnInsert.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnInsert.Size = new System.Drawing.Size(124, 41);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BorderColor = System.Drawing.Color.Silver;
            this.btnBack.ButtonColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(627, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnBack.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Furniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Furniture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Furniture_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnDelete;
        private ePOSOne.btnProduct.Button_WOC btnUpdate;
        private ePOSOne.btnProduct.Button_WOC btnInsert;
        private ePOSOne.btnProduct.Button_WOC btnBack;
    }
}