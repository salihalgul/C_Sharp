namespace AdoyaGiris
{
    partial class Form1
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
            this.btn_SQLEkle = new System.Windows.Forms.Button();
            this.btn_TbloGetir = new System.Windows.Forms.Button();
            this.btn_BaglantiKapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SQLEkle
            // 
            this.btn_SQLEkle.Location = new System.Drawing.Point(79, 53);
            this.btn_SQLEkle.Name = "btn_SQLEkle";
            this.btn_SQLEkle.Size = new System.Drawing.Size(142, 76);
            this.btn_SQLEkle.TabIndex = 0;
            this.btn_SQLEkle.Text = "SQL Bağlan";
            this.btn_SQLEkle.UseVisualStyleBackColor = true;
            this.btn_SQLEkle.Click += new System.EventHandler(this.btn_SQLEkle_Click);
            // 
            // btn_TbloGetir
            // 
            this.btn_TbloGetir.Location = new System.Drawing.Point(266, 53);
            this.btn_TbloGetir.Name = "btn_TbloGetir";
            this.btn_TbloGetir.Size = new System.Drawing.Size(142, 76);
            this.btn_TbloGetir.TabIndex = 1;
            this.btn_TbloGetir.Text = "Tablo Getir";
            this.btn_TbloGetir.UseVisualStyleBackColor = true;
            this.btn_TbloGetir.Click += new System.EventHandler(this.btn_TbloGetir_Click);
            // 
            // btn_BaglantiKapat
            // 
            this.btn_BaglantiKapat.Location = new System.Drawing.Point(465, 53);
            this.btn_BaglantiKapat.Name = "btn_BaglantiKapat";
            this.btn_BaglantiKapat.Size = new System.Drawing.Size(142, 76);
            this.btn_BaglantiKapat.TabIndex = 2;
            this.btn_BaglantiKapat.Text = "Bağlantıyı Kapat";
            this.btn_BaglantiKapat.UseVisualStyleBackColor = true;
            this.btn_BaglantiKapat.Click += new System.EventHandler(this.btn_BaglantiKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 272);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_BaglantiKapat);
            this.Controls.Add(this.btn_TbloGetir);
            this.Controls.Add(this.btn_SQLEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SQLEkle;
        private System.Windows.Forms.Button btn_TbloGetir;
        private System.Windows.Forms.Button btn_BaglantiKapat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

