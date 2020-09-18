using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Inheritance_Interface
{
    class WeatherSurvey : ResponseListener
    {

        public void Start()
        {
            String question = "What is the weather like today?";
            DataCollector dataCollector = new RudeDataCollector(this);
            dataCollector.CollectData(question);
        }

        public void NoResponseCollected()
        {
            Console.WriteLine("There was no response, unknown weather.");
        }

        public void ResponseCollected(string response)
        {
            Console.WriteLine("The current weather is " + response);
        }
    }
}
