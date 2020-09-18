using System;

namespace Abstract_Inheritance_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********** TECHNOLOGY QUIZ ***********\n");
            TechnologyQuiz Quiz = new TechnologyQuiz();
            Quiz.StartQuiz();

            Console.WriteLine("\n*********** WEATHER SURVEY ***********\n");
            WeatherSurvey Survey = new WeatherSurvey();
            Survey.Start();
        }
    }
}
