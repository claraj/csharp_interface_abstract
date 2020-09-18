using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Inheritance_Interface
{
    class RudeDataCollector : DataCollector
    {
        private ResponseListener Listener;

        public RudeDataCollector(ResponseListener listener)
        {
            this.Listener = listener;
        }

        public override void CollectData(string question)
        {
            Console.WriteLine("Answer the question.");
            Console.WriteLine(question);
            String response = Console.ReadLine();
            Console.WriteLine("Time for something else to deal with whatever you typed.");

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
