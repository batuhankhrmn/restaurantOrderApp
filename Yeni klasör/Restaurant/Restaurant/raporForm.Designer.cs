namespace Restaurant
{
    partial class raporForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblEarning = new Label();
            lblProductSell = new Label();
            lblMostSelling = new Label();
            label5 = new Label();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 0;
            label1.Text = "Gün Sonu Raporları";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "Toplam Ciro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 2;
            label3.Text = "Toplam Satılan Ürün Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(193, 25);
            label4.TabIndex = 3;
            label4.Text = "En Çok Satan Ürünler";
            // 
            // lblEarning
            // 
            lblEarning.AutoSize = true;
            lblEarning.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEarning.Location = new Point(148, 94);
            lblEarning.Name = "lblEarning";
            lblEarning.Size = new Size(57, 21);
            lblEarning.TabIndex = 4;
            lblEarning.Text = "label5";
            // 
            // lblProductSell
            // 
            lblProductSell.AutoSize = true;
            lblProductSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblProductSell.Location = new Point(255, 146);
            lblProductSell.Name = "lblProductSell";
            lblProductSell.Size = new Size(57, 21);
            lblProductSell.TabIndex = 5;
            lblProductSell.Text = "label5";
            // 
            // lblMostSelling
            // 
            lblMostSelling.AutoSize = true;
            lblMostSelling.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMostSelling.Location = new Point(69, 240);
            lblMostSelling.Name = "lblMostSelling";
            lblMostSelling.Size = new Size(57, 21);
            lblMostSelling.TabIndex = 6;
            lblMostSelling.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(422, 17);
            label5.Name = "label5";
            label5.Size = new Size(346, 32);
            label5.TabIndex = 7;
            label5.Text = "Satılan Bütün Ürünlerin Bilgisi";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(406, 52);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(382, 386);
            dgvProducts.TabIndex = 8;
            // 
            // raporForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(label5);
            Controls.Add(lblMostSelling);
            Controls.Add(lblProductSell);
            Controls.Add(lblEarning);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "raporForm";
            Text = "raporForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblEarning;
        private Label lblProductSell;
        private Label lblMostSelling;
        private Label label5;
        private DataGridView dgvProducts;
    }
}