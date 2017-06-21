using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace beitimu
{
    public class SelectQuestion
    {
        public int id { get; set; }
        public string question { get; set; }
        public string[] answers { get; set; }
        public bool[] correctAnswers { get; set; }

        public SelectQuestion(string s,bool randomAnswer)
        {
            id = Convert.ToInt32(s.Split('.')[0]);
            question = s.Split('.')[1].Split('@')[0];
            string answer = s.Split('.')[1].Split('@')[1];
            answers = answer.Split('|');
            correctAnswers = new bool[answers.Length];
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].StartsWith("*"))
                {
                    answers[i] = answers[i].Substring(1, answers[i].Length - 1);
                    correctAnswers[i] = true;
                }
                else
                {
                    correctAnswers[i] = false;
                }
            }
            if (randomAnswer)
            {
                Random rd = new Random();
                for (int i = 0; i < answers.Length; i++)
                {
                    int index = rd.Next(answers.Length);
                    string temp = answers[i];
                    answers[i] = answers[index];
                    answers[index] = temp;

                    bool tempb = correctAnswers[i];
                    correctAnswers[i] = correctAnswers[index];
                    correctAnswers[index] = tempb;
                }
            }
        }

        //public string getResult(bool[] choice)
        //{
        //    bool flag = true;
        //    string result = "";
        //    result += "选择了";
        //    for (int i = 0; i < choice.Length; i++)
        //    {
        //        if (choice[i] != correctAnswers[i])
        //        {
        //            flag = false;
        //        }
        //    }
        //    result += getcorrectAnswersString(choice) + ",";
        //    if (flag == true)
        //    {
        //        result += "正确";
        //    }
        //    else
        //    {
        //        result += "正确答案为" + getcorrectAnswersString(correctAnswers);
        //    }

        //    return result;
        //}

        public string getResult(string choice)
        {
            string result = "";
            string correctAnswer = getcorrectAnswersString(correctAnswers);
            result += "选择了" + choice + ",";
            if (choice == correctAnswer)
            {
                result += "正确";
            }
            else
            {
                result += "正确答案为" + correctAnswer;
            }

            return result;
        }

        public string getcorrectAnswersString(bool[] choice)
        {
            string result = "";
            for (int i = 0; i < choice.Length; i++)
            {
                if (choice[i] == true)
                {
                    result += alpha.getChar(i);
                }
            }
            return result;
        }



    }
}
