using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace SharpFlashCard.Models
{
    public class GameLogic
    {
        public List<FlashCards> ReadFile()
        {
            List<FlashCards> _FlashCard = new List<FlashCards>();
            using (StreamReader reader = new StreamReader("SharpFlashCard/BootStrapData/Q&A.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string answer = reader.ReadLine();
                    string question = reader.ReadLine();
                    reader.ReadLine(); //read out blank line

                    _FlashCard.Add(new FlashCards(answer, question));
                    
                }
            }
            return _FlashCard;
        }
    }
}