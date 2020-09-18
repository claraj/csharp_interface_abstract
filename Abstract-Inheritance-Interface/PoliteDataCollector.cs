using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Inheritance_Interface
{
    class PoliteDataCollector : DataCollector
    {
        private ResponseListener Listener;

        public PoliteDataCollector(ResponseListener listener)
        {
            this.Listener = listener;
        }

        public override void CollectData(string question)
        {
            Console.WriteLine("Please provide an answer to the following question. Many thanks in advance!");
            Console.WriteLine(question);
            String response = Console.ReadLine();
            Console.WriteLine("Got it! I will deliver your response promptly. Have a wonderful day!");

            if (response == String.Empty)
            {
                Listener.NoResponseCollected();
            }
            else
            {
                Listener.ResponseCollected(response);
            }
        }
    }
}
