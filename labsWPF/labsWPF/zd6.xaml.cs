using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labsWPF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zd6 : ContentPage
    {
        private int questNum = 0;
        List<Question> randomQuest;
        List<Question> questions;
        Label[] labels;
        public zd6()
        {
            InitializeComponent();
            Random RND = new Random();
            questions = Question.ReadQuestions();
            randomQuest = questions.OrderBy(x => RND.Next()).Take(10).ToList();
            FillQuest();

        }
        public List<Question> RandomQuest{ get => this.randomQuest; }
        private void FillQuest()
        {
            labels = new[] { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };
            infoFrame2.BackgroundColor = Color.White;
            infoFrame.Text = "Ждём ответа...";
            infoFrame.TextColor = Color.Black;
            questBut1.BackgroundColor = Color.White;
            questBut2.BackgroundColor = Color.White;
            questBut3.BackgroundColor = Color.White;
            questBut4.BackgroundColor = Color.White;
            questBut4.IsVisible = true;
            questBut3.IsVisible = true;
            imageFrame.IsVisible = true;
            labels[questNum].BackgroundColor = Color.White;

            questionLabel.Text = randomQuest[questNum].GetQuestion;
            if (randomQuest[questNum].Image != "0")
                imagePdd.Source = randomQuest[questNum].Image;
            else
                imageFrame.IsVisible = false;
            questBut1.Text = randomQuest[questNum].Ans1;
            questBut2.Text = randomQuest[questNum].Ans2;
            if (randomQuest[questNum].Ans3 != "0")
                questBut3.Text = randomQuest[questNum].Ans3;
            else
                questBut3.IsVisible = false;

            if (randomQuest[questNum].Ans4 != "0")
                questBut4.Text = randomQuest[questNum].Ans4;
            else
                questBut4.IsVisible = false;
            if (randomQuest[questNum].IsAnswered)
            {
                infoFrame2.BackgroundColor = Color.Orange;
                infoFrame.Text = "ОТВЕЧЕНО...";
                infoFrame.TextColor = Color.White;
                if (randomQuest[questNum].UserAnswer == 1)
                    questBut1.BackgroundColor = Color.Orange;
                if (randomQuest[questNum].UserAnswer == 2)
                    questBut2.BackgroundColor = Color.Orange;
                if (randomQuest[questNum].UserAnswer == 3)
                    questBut3.BackgroundColor = Color.Orange;
                if (randomQuest[questNum].UserAnswer == 4)
                    questBut4.BackgroundColor = Color.Orange;
                
            }
        }
        private void questBut1_Clicked(object sender, EventArgs e)
        {
            if (!randomQuest[questNum].IsAnswered)
            {
                if (randomQuest[questNum].RightAns == 1)
                {
                    infoFrame2.BackgroundColor = Color.DarkGreen;
                    infoFrame.Text = "ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut1.BackgroundColor = Color.Green;
                }
                else
                {
                    infoFrame2.BackgroundColor = Color.Red;
                    infoFrame.Text = "НЕ ПРАВИЛЬНО!";
                    infoFrame.TextColor= Color.White;
                    questBut1.BackgroundColor = Color.Red;
                }
                randomQuest[questNum].IsAnswered = true;
                randomQuest[questNum].UserAnswer = 1;
            }
        }

        private void questBut2_Clicked(object sender, EventArgs e)
        {
            if (!randomQuest[questNum].IsAnswered)
            {
                if (randomQuest[questNum].RightAns == 2)
                {
                    infoFrame2.BackgroundColor = Color.DarkGreen;
                    infoFrame.Text = "ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut2.BackgroundColor = Color.Green;

                }
                else
                {
                    infoFrame2.BackgroundColor = Color.Red;
                    infoFrame.Text = "НЕ ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut2.BackgroundColor = Color.Red;

                }
                randomQuest[questNum].IsAnswered = true;
                randomQuest[questNum].UserAnswer = 2;
            }
        }

        private void questBut3_Clicked(object sender, EventArgs e)
        {
            if (!randomQuest[questNum].IsAnswered)
            {
                if (randomQuest[questNum].RightAns == 3)
                {
                    infoFrame2.BackgroundColor = Color.DarkGreen;
                    infoFrame.Text = "ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut3.BackgroundColor = Color.Green;

                }
                else
                {
                    infoFrame2.BackgroundColor = Color.Red;
                    infoFrame.Text = "НЕ ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut3.BackgroundColor = Color.Red;
                }
                randomQuest[questNum].IsAnswered = true;
                randomQuest[questNum].UserAnswer = 3;
            }
        }

        private void questBut4_Clicked(object sender, EventArgs e)
        {
            if (!randomQuest[questNum].IsAnswered)
            {
                if (randomQuest[questNum].RightAns == 4)
                {
                    infoFrame2.BackgroundColor = Color.DarkGreen;
                    infoFrame.Text = "ПРАВИЛЬНО!";
                    infoFrame.TextColor = Color.White;
                    questBut4.BackgroundColor = Color.Green;
                }
                else
                {
                    infoFrame2.BackgroundColor = Color.Red;
                    infoFrame.Text = "НЕ ПРАВИЛЬНО!";
                    questBut4.BackgroundColor = Color.Red;
                    infoFrame.TextColor = Color.White;
                }
                randomQuest[questNum].IsAnswered = true;
                randomQuest[questNum].UserAnswer = 4;
            }
        }

        private void prefBut_Clicked(object sender, EventArgs e)
        {
            if (questNum > 0)
            {
                labels[questNum].BackgroundColor = Color.Gray;
                questNum--;
                FillQuest();
            }
        }

        private void nextBut_Clicked(object sender, EventArgs e)
        {
            if (questNum < 9)
            {
                labels[questNum].BackgroundColor = Color.Gray;
                questNum++;
                FillQuest();
            }
        }
    }
}