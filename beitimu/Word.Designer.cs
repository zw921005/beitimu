namespace beitimu
{
    partial class Word
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPageIndex = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblquestion.Location = new System.Drawing.Point(12, 9);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(758, 98);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "question";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 503);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(184, 503);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(103, 503);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 32);
            this.btnPrev.TabIndex = 20;
            this.btnPrev.Text = "上一题";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageSize
            // 
            this.lblPageSize.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageSize.Location = new System.Drawing.Point(694, 503);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(51, 28);
            this.lblPageSize.TabIndex = 25;
            this.lblPageSize.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(664, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "/";
            // 
            // lblPageIndex
            // 
            this.lblPageIndex.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageIndex.Location = new System.Drawing.Point(607, 503);
            this.lblPageIndex.Name = "lblPageIndex";
            this.lblPageIndex.Size = new System.Drawing.Size(51, 28);
            this.lblPageIndex.TabIndex = 23;
            this.lblPageIndex.Text = "1";
            // 
            // lblanswer
            // 
            this.lblanswer.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblanswer.Location = new System.Drawing.Point(12, 137);
            this.lblanswer.Multiline = true;
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(593, 126);
            this.lblanswer.TabIndex = 26;
            // 
            // lblresult
            // 
            this.lblresult.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblresult.Location = new System.Drawing.Point(12, 315);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(598, 169);
            this.lblresult.TabIndex = 27;
            this.lblresult.Text = "result";
            // 
            // Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPageIndex);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblquestion);
            this.Name = "Word";
            this.Text = "Word";
            this.Load += new System.EventHandler(this.Word_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPageIndex;
        private System.Windows.Forms.TextBox lblanswer;
        private System.Windows.Forms.Label lblresult;
    }
}