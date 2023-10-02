
namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.batdau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // batdau
            // 
            this.batdau.BackColor = System.Drawing.Color.Blue;
            this.batdau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batdau.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batdau.ForeColor = System.Drawing.Color.White;
            this.batdau.Image = ((System.Drawing.Image)(resources.GetObject("batdau.Image")));
            this.batdau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batdau.Location = new System.Drawing.Point(269, 252);
            this.batdau.Name = "batdau";
            this.batdau.Padding = new System.Windows.Forms.Padding(26, 20, 20, 20);
            this.batdau.Size = new System.Drawing.Size(279, 97);
            this.batdau.TabIndex = 3;
            this.batdau.Text = "     BẮT ĐẦU";
            this.batdau.UseVisualStyleBackColor = false;
            this.batdau.Click += new System.EventHandler(this.batdau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHẦN MỀM CHẨN ĐOÁN BỆNH Ở GÀ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batdau);
            this.Name = "Start";
            this.Size = new System.Drawing.Size(818, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button batdau;
        private System.Windows.Forms.Label label1;
    }
}
