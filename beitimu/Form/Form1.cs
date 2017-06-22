using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace beitimu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single frm = new Single() { IsSingle = true,review=cbReview.Checked,showID=cbShowID.Checked, randomAnswer = cbAnswer.Checked, randomQuestion = cbQuestion.Checked };
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single frm = new Single() { IsSingle = false, review = cbReview.Checked, showID = cbShowID.Checked, randomAnswer = cbAnswer.Checked, randomQuestion = cbQuestion.Checked };
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Word frm = new Word() { IsSingle = true, review = cbReview.Checked, showID = cbShowID.Checked, randomQuestion = cbQuestion.Checked };
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Word frm = new Word() { IsSingle = false, review = cbReview.Checked, showID = cbShowID.Checked, randomQuestion = cbQuestion.Checked };
            frm.Show();
        }
    }
}
