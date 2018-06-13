namespace beitimu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbAnswer = new System.Windows.Forms.CheckBox();
            this.cbQuestion = new System.Windows.Forms.CheckBox();
            this.cbShowID = new System.Windows.Forms.CheckBox();
            this.cbReview = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(71, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "单选题";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(71, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "填空题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(71, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "简答题";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(71, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "多选题";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbAnswer
            // 
            this.cbAnswer.AutoSize = true;
            this.cbAnswer.Location = new System.Drawing.Point(506, 385);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(72, 16);
            this.cbAnswer.TabIndex = 4;
            this.cbAnswer.Text = "答案随机";
            this.cbAnswer.UseVisualStyleBackColor = true;
            // 
            // cbQuestion
            // 
            this.cbQuestion.AutoSize = true;
            this.cbQuestion.Location = new System.Drawing.Point(380, 385);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(72, 16);
            this.cbQuestion.TabIndex = 5;
            this.cbQuestion.Text = "题目随机";
            this.cbQuestion.UseVisualStyleBackColor = true;
            // 
            // cbShowID
            // 
            this.cbShowID.AutoSize = true;
            this.cbShowID.Checked = true;
            this.cbShowID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowID.Location = new System.Drawing.Point(380, 354);
            this.cbShowID.Name = "cbShowID";
            this.cbShowID.Size = new System.Drawing.Size(96, 16);
            this.cbShowID.TabIndex = 6;
            this.cbShowID.Text = "显示题目编号";
            this.cbShowID.UseVisualStyleBackColor = true;
            // 
            // cbReview
            // 
            this.cbReview.AutoSize = true;
            this.cbReview.Location = new System.Drawing.Point(506, 354);
            this.cbReview.Name = "cbReview";
            this.cbReview.Size = new System.Drawing.Size(72, 16);
            this.cbReview.TabIndex = 7;
            this.cbReview.Text = "复习模式";
            this.cbReview.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 422);
            this.Controls.Add(this.cbReview);
            this.Controls.Add(this.cbShowID);
            this.Controls.Add(this.cbQuestion);
            this.Controls.Add(this.cbAnswer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "菜单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbAnswer;
        private System.Windows.Forms.CheckBox cbQuestion;
        private System.Windows.Forms.CheckBox cbShowID;
        private System.Windows.Forms.CheckBox cbReview;
    }
}