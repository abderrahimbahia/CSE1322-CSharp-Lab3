//Abderrahim Bahia
//Lab Three
//Last Modified 01/25/2022

using System;

namespace LabThree
{
    public class Question
    {

        private string question;
        private string answer;
        private byte difficulty;


        public Question()
        {
            this.question = "";
        }


        public Question(string question, string answer, byte difficulty)
        {
            this.question = question;
            this.answer = answer;
            this.difficulty = difficulty;

        }

        public string getQuestion()
        {
            return this.question;
        }


        public void setQuestion(string question)
        {
            this.question = question;
        }


        public string getAnswer()
        {
            return this.answer;
        }


        public void setAnswer(string answer)
        {
            this.answer = answer;
        }


        public string getDifficulty()
        {
            return this.question;
        }


        public void setDifficulty(byte difficulty)
        {
            this.difficulty = difficulty;
        }

    }

}
