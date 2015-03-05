using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using SharpFlashCard.Models;

namespace SharpFlashCard.Models
{
    public class GameLogic
    {
        SharpFlashCard.Models.ApplicationDbContext context = new SharpFlashCard.Models.ApplicationDbContext();
        int id = 0;

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader("Q&A.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string question = reader.ReadLine();
                    string answer = reader.ReadLine();
                    reader.ReadLine(); //read out blank line
                    id++;

                    context.Cards.Add(new FlashCards(id, question, answer));
                }
                context.SaveChanges();
            }
        }
    }
}
