namespace Restaurant
{
    partial class indexForm
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
            btnLog = new Button();
            btnTable = new Button();
            btnProduct = new Button();
            label1 = new Label();
            lblTables = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLog.Location = new Point(671, 12);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(117, 74);
            btnLog.TabIndex = 0;
            btnLog.Text = "Kasa Gün Sonu Raporları";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnTable
            // 
            btnTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTable.Location = new Point(671, 169);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(117, 67);
            btnTable.TabIndex = 1;
            btnTable.Text = "Masalar";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.Location = new Point(671, 92);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(117, 71);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Ürün Yönetimi";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 3;
            label1.Text = "HOŞGELDİNİZ";
            // 
            // lblTables
            // 
            lblTables.AutoSize = true;
            lblTables.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTables.Location = new Point(12, 382);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(236, 30);
            lblTables.TabIndex = 4;
            lblTables.Text = "Şu anda, , masa boştur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(394, 75);
            label3.TabIndex = 5;
            label3.Text = "Restorantımızın Masa Takip, Sipariş Geçmişi, \r\nÜrün Yönetimi Gibi İşlemlerini \r\nBu Uygulama Aracılığıyla Yapabilirsiniz ";
            // 
            // indexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblTables);
            Controls.Add(label1);
            Controls.Add(btnProduct);
            Controls.Add(btnTable);
            Controls.Add(btnLog);
            Name = "indexForm";
            Text = "indexForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLog;
        private Button btnTable;
        private Button btnProduct;
        private Label label1;
        private Label lblTables;
        private Label label3;
    }
}