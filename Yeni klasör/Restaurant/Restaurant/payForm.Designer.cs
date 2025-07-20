namespace Restaurant
{
    partial class payForm
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
            lblMasaAdi = new Label();
            lblToplamTutar = new Label();
            btnConfirm = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 50);
            label1.TabIndex = 0;
            label1.Text = "Ödeme Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Masa Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(24, 183);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 2;
            label3.Text = "Fiyat";
            // 
            // lblMasaAdi
            // 
            lblMasaAdi.AutoSize = true;
            lblMasaAdi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMasaAdi.Location = new Point(175, 99);
            lblMasaAdi.Name = "lblMasaAdi";
            lblMasaAdi.Size = new Size(0, 25);
            lblMasaAdi.TabIndex = 3;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(163, 183);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 32);
            lblToplamTutar.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnConfirm.Location = new Point(565, 277);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(184, 130);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "ÖDEME ALINDI";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(504, 200);
            label4.Name = "label4";
            label4.Size = new Size(284, 64);
            label4.TabIndex = 6;
            label4.Text = "Ödeme alındıktan sonra \r\nlütfen butona tıklayınız.\r\n";
            // 
            // payForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnConfirm);
            Controls.Add(lblToplamTutar);
            Controls.Add(lblMasaAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "payForm";
            Text = "payForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMasaAdi;
        private Label lblToplamTutar;
        private Button btnConfirm;
        private Label label4;
    }
}