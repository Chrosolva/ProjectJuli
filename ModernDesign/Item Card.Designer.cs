namespace ModernDesign
{
    partial class Item_Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Card));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.lblNama = new Guna.UI.WinForms.GunaLabel();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.lblPrice = new Guna.UI.WinForms.GunaLabel();
            this.CardImage = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.gunaPanel1.Size = new System.Drawing.Size(240, 320);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Controls.Add(this.lblDesc);
            this.gunaPanel2.Controls.Add(this.lblPrice);
            this.gunaPanel2.Controls.Add(this.CardImage);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(234, 314);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.DarkRed;
            this.gunaPanel3.Controls.Add(this.lblNama);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(232, 31);
            this.gunaPanel3.TabIndex = 8;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblNama.Location = new System.Drawing.Point(3, 6);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(66, 15);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama Item";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDesc.Location = new System.Drawing.Point(15, 277);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(59, 15);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Item Desc";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.Location = new System.Drawing.Point(15, 251);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CardImage
            // 
            this.CardImage.BaseColor = System.Drawing.Color.White;
            this.CardImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CardImage.ErrorImage")));
            this.CardImage.Image = ((System.Drawing.Image)(resources.GetObject("CardImage.Image")));
            this.CardImage.Location = new System.Drawing.Point(18, 53);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(190, 180);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardImage.TabIndex = 5;
            this.CardImage.TabStop = false;
            this.CardImage.UseTransfarantBackground = false;
            // 
            // Item_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gunaPanel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "Item_Card";
            this.Size = new System.Drawing.Size(240, 320);
            this.Load += new System.EventHandler(this.Item_Card_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel lblNama;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private Guna.UI.WinForms.GunaLabel lblPrice;
        private Guna.UI.WinForms.GunaCirclePictureBox CardImage;
    }
}
