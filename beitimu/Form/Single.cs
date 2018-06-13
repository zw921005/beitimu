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
    public partial class Single : Form
    {
        public bool IsSingle;
        List<SelectQuestion> sqs = new List<SelectQuestion>();
        int currentQuestion = 0;
        int totalQuestion = 0;
        bool[] answer = new bool[6];
        public bool randomAnswer;
        public bool randomQuestion;
        public bool showID;
        public bool review;

        public Single()
        {
            InitializeComponent();
        }

        private void Single_Load(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                string fileName;
                if (IsSingle)
                {
                    this.Text = "单选题";
                    fileName = "data";
                }
                else
                {
                    this.Text = "多选题";
                    fileName = "data1";
                }
                foreach (string line in System.IO.File.ReadLines(@"data\" + fileName, System.Text.Encoding.UTF8))
                {
                    SelectQuestion sq = new SelectQuestion(line, randomAnswer);
                    sqs.Add(sq);
                    count++;
                }
                if (randomQuestion)
                {
                    Random rd = new Random();
                    for (int i = 0; i < sqs.Count(); i++)
                    {
                        int index = rd.Next(sqs.Count());
                        SelectQuestion temp = sqs[i];
                        sqs[i] = sqs[index];
                        sqs[index] = temp;
                    }
                }
                lblresult.Text = "";
                totalQuestion = sqs.Count();
                lblPageSize.Text = totalQuestion.ToString();
                show(sqs[0]);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void show(SelectQuestion sq)
        {
            if (showID)
            {
                lblquestion.Text = sq.id.ToString() + "." + sq.question;
            }
            else
            {
                lblquestion.Text = sq.question;
            }
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = false;
            }
            lblanswer.Text = "";
            lblanswerA.Text = "";
            lblanswerB.Text = "";
            lblanswerC.Text = "";
            lblanswerD.Text = "";
            lblanswerE.Text = "";
            lblanswerF.Text = "";
            lblanswerA.Text = sq.answers[0];
            lblanswerB.Text = sq.answers[1];
            lblanswerC.Text = sq.answers[2];
            if (sq.answers.Length > 3)
            {
                lblanswerD.Text = sq.answers[3];
                lblanswerD.Visible = true;
                btnD.Visible = true;
            }
            else
            {
                lblanswerD.Visible = false;
                btnD.Visible = false;
            }

            if (sq.answers.Length > 4)
            {
                lblanswerE.Text = sq.answers[4];
                lblanswerE.Visible = true;
                btnE.Visible = true;
            }
            else
            {
                lblanswerE.Visible = false;
                btnE.Visible = false;
            }
            if (sq.answers.Length > 5)
            {
                lblanswerF.Text = sq.answers[5];
                lblanswerF.Visible = true;
                btnF.Visible = true;
            }
            else
            {
                lblanswerF.Visible = false;
                btnF.Visible = false;
            }
            lblPageIndex.Text = (currentQuestion + 1).ToString();
            if (review)
            {
                lblanswer.Text = sqs[currentQuestion].getcorrectAnswersString(sqs[currentQuestion].correctAnswers);
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
            show(sqs[currentQuestion]);
        }

        private void button6_Click(object sender, EventArgs e)
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
            show(sqs[currentQuestion]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer[0] == true)
            {
                answer[0] = false;
            }
            else
            {
                answer[0] = true;
            }
            clickButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (answer[1] == true)
            {
                answer[1] = false;
            }
            else
            {
                answer[1] = true;
            }
            clickButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (answer[2] == true)
            {
                answer[2] = false;
            }
            else
            {
                answer[2] = true;
            }
            clickButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (answer[3] == true)
            {
                answer[3] = false;
            }
            else
            {
                answer[3] = true;
            }
            clickButton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (answer[4] == true)
            {
                answer[4] = false;
            }
            else
            {
                answer[4] = true;
            }
            clickButton();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (answer[5] == true)
            {
                answer[5] = false;
            }
            else
            {
                answer[5] = true;
            }
            clickButton();
        }


        string getAnswerString(bool[] answer)
        {
            string result = "";
            if (answer[0] == true) result += "A";
            if (answer[1] == true) result += "B";
            if (answer[2] == true) result += "C";
            if (answer[3] == true) result += "D";
            if (answer[4] == true) result += "E";
            if (answer[5] == true) result += "F";
            return result;
            //return 
        }

        void clickButton()
        {
            string result = getAnswerString(answer);
            if (IsSingle)
            {
                lblresult.Text = sqs[currentQuestion].getResult(result);
                if (lblresult.Text.Contains("答案"))
                {
                    lblresult.ForeColor = Color.Red;
                }
                else
                {
                    lblresult.ForeColor = Color.Green;
                }
                if (IsSingle)
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = false;
                    }
                }
            }
            else
            {
                lblanswer.Text = result;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblresult.Text = sqs[currentQuestion].getResult(lblanswer.Text.ToUpper());
            if (lblresult.Text.Contains("答案"))
            {
                lblresult.ForeColor = Color.Red;
            }
            else
            {
                lblresult.ForeColor = Color.Green;
            }
        }
    }
}
