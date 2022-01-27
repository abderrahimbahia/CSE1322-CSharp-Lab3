//Abderrahim Bahia
//Lab Three
//Last Modified 01/25/2022

using System;
using System.Collections.Generic;

namespace LabThree
{
    public class Quiz
    {
        private List<Question> quiz = new List<Question>();


        public void addQuestion()
        {
            Console.WriteLine("Please enter the new question: ");
            string question = Console.ReadLine();

            Console.WriteLine("Please enter the question's answer: ");
            string answer = Console.ReadLine();

            Console.WriteLine("Please enter the question difficulty from 1 to 3: ");
            byte difficulty = byte.Parse(Console.ReadLine());

            Question data = new Question(question, answer, difficulty); 
            quiz.Add(data);

        }

        public void removeQuestion()
        {
            
            for( int i = 0 ; i < quiz.Count; i++)
            {
                Console.WriteLine(i + ". " + quiz[i].getQuestion());
            }

            Console.WriteLine("Please enter the number of the question you want to remove: ");
            int choice = int.Parse(Console.ReadLine());

            quiz.Remove(quiz[choice]);

        }

        public void modifyQuestion()
        {
            for (int i = 0; i < quiz.Count; i++)
            {
                Console.WriteLine(i + ". " + quiz[i].getQuestion());
            }

            Console.WriteLine("Please enter the number of the question you want to modify: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the new text: ");
            string newQuestion = Console.ReadLine();

            Console.WriteLine("Please enter the new Answer: ");
            string newAnswer = Console.ReadLine();

            Console.WriteLine("Please enter the new difficulty form (1-3): ");
            byte newDifficulty = byte.Parse(Console.ReadLine());

            quiz[choice].setQuestion(newQuestion);
            quiz[choice].setAnswer(newAnswer);
            quiz[choice].setDifficulty(newDifficulty);

        }


        public void giveQuiz()
        {
            byte grade = 0;

            foreach (Question question in quiz)
            {
                Console.WriteLine(question.getQuestion());
                Console.WriteLine("Please enter your answer: ");
                string answer = Console.ReadLine();

                if (answer == question.getAnswer())
                {
                    grade++;
                }
            }

            Console.WriteLine("You got " + grade + " Answers Correct");
        }
    }
}
