
namespace proyek
{
    partial class TestingGround
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingGround));
            this.roundPanel1 = new RoundPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.roundPanel1.Location = new System.Drawing.Point(12, 12);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radious = 25;
            this.roundPanel1.Size = new System.Drawing.Size(214, 178);
            this.roundPanel1.TabIndex = 0;
            this.roundPanel1.TabStop = false;
            this.roundPanel1.Text = "roundPanel1";
            this.roundPanel1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.roundPanel1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.roundPanel1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(191)))), ((int)(((byte)(177)))));
            this.roundPanel1.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent90;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(330, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 164);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC1.Image = ((System.Drawing.Image)(resources.GetObject("button_WOC1.Image")));
            this.button_WOC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_WOC1.Location = new System.Drawing.Point(12, 258);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(470, 164);
            this.button_WOC1.TabIndex = 2;
            this.button_WOC1.Text = "button_WOC1";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // TestingGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.button_WOC1);
            this.Name = "TestingGround";
            this.Text = "TestingGround";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel roundPanel1;
        private System.Windows.Forms.Button button1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}