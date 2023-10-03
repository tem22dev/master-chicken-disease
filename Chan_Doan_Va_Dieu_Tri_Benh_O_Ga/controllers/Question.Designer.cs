
namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    partial class Question
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.btnY = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.labelNumberQuestion = new System.Windows.Forms.Label();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.Gold;
            this.btnY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.Color.White;
            this.btnY.Location = new System.Drawing.Point(650, 339);
            this.btnY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(140, 70);
            this.btnY.TabIndex = 0;
            this.btnY.Text = "Có";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Blue;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(27, 339);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(140, 70);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Không";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // labelNumberQuestion
            // 
            this.labelNumberQuestion.AutoSize = true;
            this.labelNumberQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberQuestion.Location = new System.Drawing.Point(20, 14);
            this.labelNumberQuestion.Name = "labelNumberQuestion";
            this.labelNumberQuestion.Size = new System.Drawing.Size(193, 38);
            this.labelNumberQuestion.TabIndex = 2;
            this.labelNumberQuestion.Text = "Câu hỏi số 1: ";
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BackColor = System.Drawing.Color.White;
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuestion.Location = new System.Drawing.Point(27, 69);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(763, 110);
            this.richTextBoxQuestion.TabIndex = 6;
            this.richTextBoxQuestion.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.labelNumberQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(818, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label labelNumberQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
