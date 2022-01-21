// See https://aka.ms/new-console-template for more information
//Javascrip Array method or function == C# List method or function
using System;

namespace Insulter
{
    class Program
    {
        static void Main (string[] args)
        {
            
            List <string> insults = new List<string> () 
            {
                "1, You look like what morning breath smells like.",
                "2, If you tried to give me cpr I would probably throw myself back under water",
                "3,I am not a fan of you",
                "4, You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "5, I'd rather walk than be on the same plane as you",
                "6, If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "7, Do you have to be so...like that?"
            };


            List <int> indexes = new List<int> (){} ;
//Javascrit .Length = C# .Count
            while (indexes.Count < 3){
             int Candidate = new Random().Next (0, insults.Count-1 );
     
               if (!indexes.Any( i => i == Candidate)) {
                 indexes.Add(Candidate);
                };
            };

            for (int i=0; i<indexes.Count; i++){
                int index = indexes[i];
                Console.WriteLine(insults[index]);
            };

            }

         }
}


