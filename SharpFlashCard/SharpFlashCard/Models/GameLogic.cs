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
        ApplicationDbContext context = new ApplicationDbContext();
 

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader("Q&A.txt"))
            {
                int id = 0;

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
