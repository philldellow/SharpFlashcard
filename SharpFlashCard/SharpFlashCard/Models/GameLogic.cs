using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace SharpFlashCard.Models
{
    public class GameLogic
    {
        
        List<FlashCards> _FlashCard = new List<FlashCards>();

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader("../Q&A.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string question = reader.ReadLine();
                    string answer = reader.ReadLine();
                    _FlashCard.Add(new FlashCards(answer, question));
                }
            }
        }
    }
}