
namespace BezierCurve
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.koordinat_ciz = new System.Windows.Forms.Button();
            this.kontrol_noktasi_ciz = new System.Windows.Forms.Button();
            this.bezier_ciz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // koordinat_ciz
            // 
            this.koordinat_ciz.Location = new System.Drawing.Point(36, 55);
            this.koordinat_ciz.Name = "koordinat_ciz";
            this.koordinat_ciz.Size = new System.Drawing.Size(140, 40);
            this.koordinat_ciz.TabIndex = 0;
            this.koordinat_ciz.Text = "Koordinat Çiz";
            this.koordinat_ciz.UseVisualStyleBackColor = true;
            this.koordinat_ciz.Click += new System.EventHandler(this.koordinat_ciz_Click);
            // 
            // kontrol_noktasi_ciz
            // 
            this.kontrol_noktasi_ciz.Location = new System.Drawing.Point(36, 111);
            this.kontrol_noktasi_ciz.Name = "kontrol_noktasi_ciz";
            this.kontrol_noktasi_ciz.Size = new System.Drawing.Size(140, 40);
            this.kontrol_noktasi_ciz.TabIndex = 1;
            this.kontrol_noktasi_ciz.Text = "Kontrol Noktalarını Çiz";
            this.kontrol_noktasi_ciz.UseVisualStyleBackColor = true;
            this.kontrol_noktasi_ciz.Click += new System.EventHandler(this.kontrol_noktasi_ciz_Click);
            // 
            // bezier_ciz
            // 
            this.bezier_ciz.Location = new System.Drawing.Point(36, 170);
            this.bezier_ciz.Name = "bezier_ciz";
            this.bezier_ciz.Size = new System.Drawing.Size(140, 40);
            this.bezier_ciz.TabIndex = 2;
            this.bezier_ciz.Text = "Bezier Çiz";
            this.bezier_ciz.UseVisualStyleBackColor = true;
            this.bezier_ciz.Click += new System.EventHandler(this.bezier_ciz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bezier_ciz);
            this.Controls.Add(this.kontrol_noktasi_ciz);
            this.Controls.Add(this.koordinat_ciz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button koordinat_ciz;
        private System.Windows.Forms.Button kontrol_noktasi_ciz;
        private System.Windows.Forms.Button bezier_ciz;
    }
}

