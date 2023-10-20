using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Question
    {

        public Question(string text, string[] options, string answer)
        {
            this.Text = text;
            this.Options = options;
            this.Answer = answer;
        }

        public string Text { get; set; }

        public string[] Options { get; set; }

        public string Answer { get; set; }

        public bool CheckAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
        }

        private Question[] Questions { get; set; }

        public int QuestionIndex { get; set; }

        public Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            System.Console.WriteLine($"{this.QuestionIndex + 1}){question.Text}");

            foreach (var o in question.Options)
            {
                System.Console.WriteLine($"-{o}");
            }
            System.Console.Write("Answer: ");
            var answer = Console.ReadLine();
            this.Guess(answer);
        }

        public void Guess(string answer)
        {
            var question = this.GetQuestion();
            System.Console.WriteLine(question.CheckAnswer(answer));
            System.Console.WriteLine();
            this.QuestionIndex++;
            if (this.Questions.Length == this.QuestionIndex)
            {
                return;
            }
            else
            {
                this.DisplayQuestion();
            }
        }

    }

    public class QuizApp
    {
        static void Main(string[] args)
        {
            var q1 = new Question("What is the best programming language?", new string[] { "C#", "Java", "Python", "C++" }, "C#");
            var q2 = new Question("What is the most popular programming language?", new string[] { "C#", "Java", "Python", "C++" }, "C#");
            var q3 = new Question("What is the most profitable programming language?", new string[] { "C#", "Java", "Python", "C++" }, "C#");

            var questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);

            quiz.DisplayQuestion();



        }
    }
}