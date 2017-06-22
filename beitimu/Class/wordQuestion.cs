using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace beitimu
{
    class wordQuestion
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public wordQuestion(string s)
        {
            id = Convert.ToInt32(s.Split('.')[0]);
            question = s.Split('.')[1].Split('@')[0];
            answer = s.Split('.')[1].Split('@')[1];
        }


    }
}
