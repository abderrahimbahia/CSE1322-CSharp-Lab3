//Abderrahim Bahia
//Lab Three
//Last Modified 01/25/2022

using System;

namespace LabThree
{
    class Driver
    {
        static void Main(string[] args)
        {

            Quiz quiz = new Quiz();
            byte choice = 0;

            do
            {
                Console.WriteLine("1. Add a question to the quiz");
                Console.WriteLine("2. Remove a question from the quiz");
                Console.WriteLine("3. Modify a question in the quiz");
                Console.WriteLine("4. Take the quiz");
                Console.WriteLine("5. Quit");

                choice = byte.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    quiz.addQuestion();

                }else if (choice == 2)
                {
                    quiz.removeQuestion();

                }else if (choice == 3)
                { 
                    quiz.modifyQuestion();

                }else if (choice == 4)
                {
                    quiz.giveQuiz();
                }

            } while (choice != 5);
        }
    }
}
