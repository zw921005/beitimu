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
    public partial class Word : Form
    {
        public bool IsSingle;
        List<wordQuestion> wqs = new List<wordQuestion>();
        int currentQuestion = 0;
        int totalQuestion = 0;
        public bool randomQuestion;
        public bool showID;
        public bool review;

        public Word()
        {
            InitializeComponent();
        }

        private void Word_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName;
                if (IsSingle)
                {
                    this.Text = "简答题";
                    fileName = "data2";
                }
                else
                {
                    this.Text = "填空题";
                    fileName = "data3";
                }
                foreach (string line in System.IO.File.ReadLines("data/" + fileName, System.Text.Encoding.UTF8))
                {
                    wordQuestion wq = new wordQuestion(line);
                    wqs.Add(wq);
                }
                if (randomQuestion)
                {
                    Random rd = new Random();
                    for (int i = 0; i < wqs.Count(); i++)
                    {
                        int index = rd.Next(wqs.Count());
                        wordQuestion temp = wqs[i];
                        wqs[i] = wqs[index];
                        wqs[index] = temp;
                    }
                }
                lblresult.Text = "";
                totalQuestion = wqs.Count();
                lblPageSize.Text = totalQuestion.ToString();
                show(wqs[0]);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        void show(wordQuestion wq)
        {
            if (showID)
            {
                lblquestion.Text = wq.id.ToString() + "." + wq.question;
            }
            else
            {
                lblquestion.Text = wq.question;
            }
            lblanswer.Text = "";
            lblPageIndex.Text = (currentQuestion + 1).ToString();
            if (review)
            {
                lblanswer.Text = wqs[currentQuestion].answer;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            if (currentQuestion == 0)
            {
                currentQuestion = totalQuestion - 1;
            }
            else
            {
                currentQuestion -= 1;
            }
            show(wqs[currentQuestion]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            if (currentQuestion == totalQuestion - 1)
            {
                currentQuestion = 0;
            }
            else
            {
                currentQuestion += 1;
            }
            show(wqs[currentQuestion]);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblresult.Text = wqs[currentQuestion].answer;
        }
    }
}
