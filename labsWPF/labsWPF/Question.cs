using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace labsWPF
{
    
    public class Question
    {
        private int id;
        private string question;
        private string ans1;
        private string ans2;
        private string ans3;
        private string ans4;
        private int rightAns;
        private string img;
        private bool isAnswered;
        private int userAnswer;

        public Question(int id, string question, string ans1, string ans2, string ans3, string ans4, int rightAns,string img,bool isAnswered,int userAnswer)
        {
            this.id = id;
            this.question = question;
            this.ans1 = ans1;
            this.ans2 = ans2;
            this.ans3 = ans3;
            this.ans4 = ans4;
            this.rightAns = rightAns;
            this.img = img;
            this.isAnswered = isAnswered;
            this.userAnswer = userAnswer;
        }
        public int Id { get => this.id; }
        public string GetQuestion { get => this.question;}
        public string Ans1 { get => this.ans1; }
        public string Ans2 { get => this.ans2; }
        public string Ans3 { get => this.ans3; }
        public string Ans4 { get => this.ans4; }
        public int RightAns { get => this.rightAns; }
        public string Image { get => this.img;}
        public bool IsAnswered { get => this.isAnswered; set => this.isAnswered = value; }
        public int UserAnswer { get => this.userAnswer; set => this.userAnswer = value; }


        static public List<Question> ReadQuestions()
        {
            List<Question> quest = new List<Question>();
            try
            {
                string connStr = "server=194.87.210.23;user=Sasha2;database=autoPodbor;password=Qazx1234;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM Questions";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quest.Add(new Question(
                        Convert.ToInt32(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString(),
                        reader[5].ToString(),
                        Convert.ToInt32(reader[6].ToString()),
                        reader[7].ToString(),
                        false,
                        0
                    ));
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            return quest;
        }
    }
}
