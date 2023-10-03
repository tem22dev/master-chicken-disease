
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
            this.btnY = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.labelNumberQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.Yellow;
            this.btnY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(553, 27);
            this.btnY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(124, 56);
            this.btnY.TabIndex = 0;
            this.btnY.Text = "Có";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Lime;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(47, 27);
            this.btnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(124, 56);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Không";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // labelNumberQuestion
            // 
            this.labelNumberQuestion.AutoSize = true;
            this.labelNumberQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberQuestion.Location = new System.Drawing.Point(19, 19);
            this.labelNumberQuestion.Name = "labelNumberQuestion";
            this.labelNumberQuestion.Size = new System.Drawing.Size(76, 28);
            this.labelNumberQuestion.TabIndex = 2;
            this.labelNumberQuestion.Text = "Câu 1: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(44, 40, 44, 40);
            this.panel1.Size = new System.Drawing.Size(727, 132);
            this.panel1.TabIndex = 3;
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BackColor = System.Drawing.Color.White;
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQuestion.Location = new System.Drawing.Point(24, 50);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(653, 139);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNumberQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(727, 371);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label labelNumberQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
