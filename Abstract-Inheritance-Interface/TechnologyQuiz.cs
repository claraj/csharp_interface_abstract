using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Inheritance_Interface
{
    class TechnologyQuiz : ResponseListener
    {
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz! Here's the question...");
            DataCollector Collector = new PoliteDataCollector(this);
            Collector.CollectData("What number system do computers user?");
        }

        public void NoResponseCollected()
        {
            Console.WriteLine("There was no answer collected.");
        }

        public void ResponseCollected(string response)
        {
            if (response.Equals("Binary"))
            {
                Console.WriteLine("Correct! Well done!");
            }
            else
            {
                Console.WriteLine("Sorry, the answer is \"binary\".");
            }
        }
    }
}
